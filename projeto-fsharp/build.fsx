#r "paket: groupref Build //"

open Fake.Core
open Fake.IO
open Fake.DotNet

let serverPath = Path.getFullName "src/Server"

let dotnet cmd workingDir =
    let result = DotNet.exec (DotNet.Options.withWorkingDirectory workingDir) cmd ""

    if result.ExitCode <> 0 then
        failwithf "'dotnet %s' failed in %s" cmd workingDir


Target.create "Run" (fun _ -> dotnet "watch run" serverPath)

Target.create "Format" (fun _ -> dotnet "fantomas . -r" "src")

Target.create "Build" (fun _ -> dotnet "publish -c Release -o out" "src/Server")

open Fake.Core.TargetOperators

[<EntryPoint>]
Target.runOrDefault "Run"