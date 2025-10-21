namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServerNetworkAState<'ServerId> = { assignments: ResizeArray<hcloud.ServerNetwork.ServerNetworkAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network">hcloud_server_network</a>.
    /// </summary>
    type ServerNetworkABuilder(logicalId: string) =
        member _.Yield(_: unit) : ServerNetworkAState<Missing> =
            ({ assignments = ResizeArray() } : ServerNetworkAState<Missing>)

        member _.Zero(()) : ServerNetworkAState<Missing> =
            ({ assignments = ResizeArray() } : ServerNetworkAState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network#server_id-1">ServerNetworkA#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: ServerNetworkAState<Missing>, value: double) : ServerNetworkAState<Present> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            ({ assignments = state.assignments } : ServerNetworkAState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network#alias_ips-1">ServerNetworkA#alias_ips</a>.
        /// </summary>
        [<CustomOperation "alias_ips">]
        member _.AliasIps(state: ServerNetworkAState<'ServerId>, value: seq<string>) : ServerNetworkAState<'ServerId> =
            state.assignments.Add(fun config -> config.AliasIps <- (value |> Seq.toArray))
            state : ServerNetworkAState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network#id-1">ServerNetworkA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServerNetworkAState<'ServerId>, value: string) : ServerNetworkAState<'ServerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServerNetworkAState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network#ip-1">ServerNetworkA#ip</a>.
        /// </summary>
        [<CustomOperation "ip">]
        member _.Ip(state: ServerNetworkAState<'ServerId>, value: string) : ServerNetworkAState<'ServerId> =
            state.assignments.Add(fun config -> config.Ip <- value)
            state : ServerNetworkAState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network#network_id-1">ServerNetworkA#network_id</a>.
        /// </summary>
        [<CustomOperation "network_id">]
        member _.NetworkId(state: ServerNetworkAState<'ServerId>, value: double) : ServerNetworkAState<'ServerId> =
            state.assignments.Add(fun config -> config.NetworkId <- value)
            state : ServerNetworkAState<'ServerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/server_network#subnet_id-1">ServerNetworkA#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: ServerNetworkAState<'ServerId>, value: string) : ServerNetworkAState<'ServerId> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : ServerNetworkAState<'ServerId>

        member _.Run(state: ServerNetworkAState<Present>) : hcloud.ServerNetwork.ServerNetworkA =
            let config = hcloud.ServerNetwork.ServerNetworkAConfig()
            for setter in state.assignments do
                setter config
            hcloud.ServerNetwork.ServerNetworkA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.serverNetworkA: missing required arguments. Must call: server_id.", 9999, IsError = true)>]
        member _.Run(_: ServerNetworkAState<_>) : hcloud.ServerNetwork.ServerNetworkA =
            Unchecked.defaultof<hcloud.ServerNetwork.ServerNetworkA>
