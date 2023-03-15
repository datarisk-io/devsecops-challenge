namespace DevSecOps.Monitoring.Router

open System
open Saturn
open Giraffe
open Microsoft.AspNetCore.Http

open DevSecOps.Monitoring.Endpoint

module Config =

    let apiRouter =
        router {
            not_found_handler (setStatusCode 404 >=> json "Not found!")

            // Endpoints --------------------------------------------------------------------------
            get "/endpoint/get/hello" (Handler.hello)

            post "/endpoint/post/message" (Handler.post)

            put "/endpoint/put/message" (Handler.put)

            delete "/endpoint/delete/nothing" (Handler.delete)
        }
