﻿$solution = "..\Src\ShogunLib.sln"
$shogunLib = "..\Src\ShogunLib\ShogunLib.csproj"
$nuget = ".\nuget.exe"
$msb = "C:\Program Files (x86)\MSBuild\12.0\Bin\MSBuild.exe"

function Download-Nuget
{
    $url = "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
        
    Invoke-WebRequest -Uri $url -OutFile $nuget
}

function Restore-Packages
{
    param($solution)
    & $nuget restore $solution
}

function Build-Solution
{
    param($path, $configuration, $platform)
    

    & $msb $path /nologo /m /t:Rebuild /p:Configuration=$configuration /property:Platform=$platform
}

function Build-Package
{
    param($project)
        
    if (-not(Test-Path -Path "bin")) 
    {
        New-Item "bin" -ItemType Directory
    }

    & $nuget pack $project  -properties Configuration=Release -OutputDirectory "bin"
}

Download-Nuget

Restore-Packages -Solution $solution

Build-Solution -Path $solution -Configuration Release -Platform "Any CPU"

Build-Package -Project $shogunLib