set -ex

dotnet tool restore
dotnet paket install
dotnet paket restore
