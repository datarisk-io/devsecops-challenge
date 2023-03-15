open System
open Saturn
open Giraffe
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder

open DevSecOps.Monitoring.Router.Config


let app =
    application {
        use_router apiRouter
        url "http://0.0.0.0:8085"
    }

[<EntryPoint>]
let main argv =
    run app
    0
