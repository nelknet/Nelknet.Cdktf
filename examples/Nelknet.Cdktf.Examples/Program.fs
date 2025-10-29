module Nelknet.Cdktf.Examples

open System
open System.Collections.Generic
open Nelknet.Cdktf
open Nelknet.Cdktf.Providers
open Nelknet.Cdktf.Terraform

module private Env =
    let require name =
        match Environment.GetEnvironmentVariable(name) with
        | null
        | "" -> failwithf "Expected the environment variable '%s' to be set." name
        | value -> value

type HcloudServer = hcloud.Server.Server

let serverIndices = [ 1 .. 3 ]

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

            let created = ResizeArray<HcloudServer>()

            for index in serverIndices do
                let logicalId = sprintf "sample-server-%d" index

                let server =
                    Hcloud.server logicalId {
                        name (sprintf "fsharp-sample-%d" index)
                        server_type "cpx11"
                        image "ubuntu-22.04"
                        labels [ "module", "nelknet" ]
                    }

                Terraform.output (sprintf "%s-name" logicalId) {
                    value server.Name
                    description (sprintf "Expose the created Hetzner server name for %s." logicalId)
                }
                |> ignore

                created.Add(server)

            return List.ofSeq created
        }

    app.Synth()

    let serverNames = app.Result |> List.map (fun server -> server.Name)
    printfn "The Hetzner example stack synthesized with servers: %A" serverNames

    0
