namespace DevSecOps.Monitoring.Endpoint

open System
open Saturn
open Giraffe
open Microsoft.AspNetCore.Http

module Handler =

    let hello: HttpHandler =
        fun (next: HttpFunc) (ctx: HttpContext) ->
            task {
                try
                    let msg = Map [ ("message", "Successful") ]
                    ctx.SetStatusCode 200
                    return! json msg next ctx
                with
                | _ as err ->
                    printfn "%s" err.Message
                    let msg = Map [ ("message", "error message") ]
                    ctx.SetStatusCode 400
                    return! json msg next ctx
            }

    let post: HttpHandler =
        fun (next: HttpFunc) (ctx: HttpContext) ->
            task {
                try
                    let msg = Map [ ("message", "Successful posted") ]
                    ctx.SetStatusCode 201
                    return! json msg next ctx
                with
                | _ as err ->
                    printfn "%s" err.Message
                    let msg = Map [ ("message", "error posting") ]
                    ctx.SetStatusCode 400
                    return! json msg next ctx
            }

    let put: HttpHandler =
        fun (next: HttpFunc) (ctx: HttpContext) ->
            task {
                try
                    let msg = Map [ ("message", "Successful updated") ]
                    ctx.SetStatusCode 200
                    return! json msg next ctx
                with
                | _ as err ->
                    printfn "%s" err.Message
                    let msg = Map [ ("message", "error updating") ]
                    ctx.SetStatusCode 400
                    return! json msg next ctx
            }

    let delete: HttpHandler =
        fun (next: HttpFunc) (ctx: HttpContext) ->
            task {
                try
                    let msg = Map [ ("message", "Successful deleted") ]
                    ctx.SetStatusCode 200
                    return! json msg next ctx
                with
                | _ as err ->
                    printfn "%s" err.Message
                    let msg = Map [ ("message", "error deleting") ]
                    ctx.SetStatusCode 400
                    return! json msg next ctx
            }
