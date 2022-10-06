<#
  .SYNOPSIS
  Fetch the package list from javadoc jar and checkin to docs/metadata

  .DESCRIPTION
  The scripts is used for docs.ms to fetch namespace list for particular artifact.

  .PARAMETER DotnetNupkgLocation
  Specifies the fo jar location.

  .PARAMETER DocRepoLocation
  Specifies Location of the root of the docs.microsoft.com reference doc location. 

  .PARAMETER ArtifactName
  The artifact name. E.g. azure-sdk-template
#>
[CmdletBinding()]
param (
  [string] $DotnetNupkgLocation = "",
  [string] $DocRepoLocation = "",
  [string] $ArtifactName = ""
)
Set-StrictMode -Version 3
. (Join-Path $PSScriptRoot ../common/scripts/common.ps1)

Write-Host "DotnetNupkgLocation: $DotnetNupkgLocation"
Write-Host "DocRepoLocation: $DocRepoLocation"
Write-Host "ArtifactName: $ArtifactName"

$nupkgFiles = Get-ChildItem $DotnetNupkgLocation -Filter "*.nupkg" -Recurse
if (!$nupkgFiles -or !(Test-Path $nupkgFiles[0].FullName)) {
  LogWarning "$ArtifactName not found."
  return
}
$nupkgFile = $nupkgFiles[0]
Write-Host "Nupkg file name: $($nupkgFile.Name)"
$version = $nupkgFile.Name -replace "$ArtifactName.(.*\d).nupkg", '$1'
Write-Host "The full version: $version"
$originalVersion = [AzureEngSemanticVersion]::ParseVersionString($version)
Write-Host "The origin version: $originalVersion"
$metadataMoniker = 'latest'
if ($originalVersion -and $originalVersion.IsPrerelease) {
  $metadataMoniker = 'preview'
}
$packageNameLocation = "$DocRepoLocation/metadata/$metadataMoniker"
New-Item -ItemType Directory -Path $packageNameLocation -Force
Write-Host "The moniker $packageNameLocation"

Fetch-Namespaces-From-Dotnet-Nupkg $nupkgFile.FullName "$packageNameLocation/$ArtifactName.txt"
