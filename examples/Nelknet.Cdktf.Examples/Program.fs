module Nelknet.Cdktf.Examples

open System
open Nelknet.Cdktf
open Nelknet.Cdktf.Providers

module private Env =
    let require name =
        match Environment.GetEnvironmentVariable(name) with
        | null
        | "" -> failwithf "Expected the environment variable '%s' to be set." name
        | value -> value

[<EntryPoint>]
let main _ =
    let apiToken = Env.require "HCLOUD_TOKEN"

    let app =
        stack "hcloud-example" {
            let _provider = 
                Hcloud.provider "hcloud" {
                    token apiToken
                    poll_interval "750ms"
                }

            let server =
                Hcloud.server "sample-server" {
                    name "fsharp-sample"
                    server_type "cpx11"
                    image "ubuntu-22.04"
                    labels [ "module", "nelknet" ]
                }

            do
                Terraform.output "server-name" {
                    value server.Name
                    description "Exposes the created Hetzner server name."
                }
                |> ignore
        }

    app.Synth()
    
    printfn "The Hetzner example stack synthesized successfully."

    0
