$binPath = "c:\Users\USER\source\repos\Sistem-Data-Penduduk-Desa\Sistem-Data-Penduduk-Desa\bin\Debug\net10.0-windows"
$settingPath = "$binPath\setting.txt"

if (!(Test-Path $settingPath)) {
    Write-Error "setting.txt not found!"
    exit 1
}

$settings = Get-Content $settingPath
$server = $settings[0]
$database = $settings[1]
$username = $settings[2]
$password = $settings[3]
$port = $settings[4]

$connString = "$server;$database;$username;$password;$port"
Write-Host "Connection string: $connString"

# Load MySql.Data.dll
$assemblyPath = "$binPath\MySql.Data.dll"
if (Test-Path $assemblyPath) {
    [System.Reflection.Assembly]::LoadFrom($assemblyPath) | Out-Null
} else {
    Write-Error "MySql.Data.dll not found at $assemblyPath"
    exit 1
}

$conn = New-Object MySql.Data.MySqlClient.MySqlConnection($connString)
try {
    $conn.Open()
    Write-Host "Successfully connected to database."
    
    $tablesCmd = New-Object MySql.Data.MySqlClient.MySqlCommand("SHOW TABLES", $conn)
    $reader = $tablesCmd.ExecuteReader()
    $tables = @()
    while ($reader.Read()) {
        $tables += $reader.GetValue(0)
    }
    $reader.Close()
    
    foreach ($table in $tables) {
        Write-Host "`n--- TABLE: $table ---"
        $descCmd = New-Object MySql.Data.MySqlClient.MySqlCommand("DESCRIBE $table", $conn)
        $descReader = $descCmd.ExecuteReader()
        while ($descReader.Read()) {
            $field = $descReader.GetValue(0)
            $type = $descReader.GetValue(1)
            $nullVal = $descReader.GetValue(2)
            $key = $descReader.GetValue(3)
            $defaultVal = $descReader.GetValue(4)
            $extra = $descReader.GetValue(5)
            Write-Host "$field - $type (Null: $nullVal, Key: $key, Default: $defaultVal, Extra: $extra)"
        }
        $descReader.Close()
    }
} catch {
    Write-Error $_.Exception.Message
} finally {
    if ($conn.State -eq [System.Data.ConnectionState]::Open) {
        $conn.Close()
    }
}
