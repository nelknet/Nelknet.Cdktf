namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudServerState = { assignments: ResizeArray<hcloud.DataHcloudServer.DataHcloudServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server">hcloud_server</a>.
    /// </summary>
    type DataHcloudServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudServerState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudServerState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#id-1">DataHcloudServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudServerState, value: double) : DataHcloudServerState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#name-1">DataHcloudServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudServerState, value: string) : DataHcloudServerState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudServerState

        /// <summary>
        /// network block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#network-1">DataHcloudServer#network</a> Accepts: hcloud.IResolvable | hcloud.DataHcloudServer.DataHcloudServerNetwork[]
        /// </summary>
        [<CustomOperation "network">]
        member _.Network(state: DataHcloudServerState, value: HashiCorp.Cdktf.IResolvable) : DataHcloudServerState =
            state.assignments.Add(fun config -> config.Network <- value)
            state : DataHcloudServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#placement_group_id-1">DataHcloudServer#placement_group_id</a>.
        /// </summary>
        [<CustomOperation "placement_group_id">]
        member _.PlacementGroupId(state: DataHcloudServerState, value: double) : DataHcloudServerState =
            state.assignments.Add(fun config -> config.PlacementGroupId <- value)
            state : DataHcloudServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#selector-1">DataHcloudServer#selector</a>.
        /// </summary>
        [<CustomOperation "selector">]
        member _.Selector(state: DataHcloudServerState, value: string) : DataHcloudServerState =
            state.assignments.Add(fun config -> config.Selector <- value)
            state : DataHcloudServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#with_selector-1">DataHcloudServer#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudServerState, value: string) : DataHcloudServerState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudServerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server#with_status-1">DataHcloudServer#with_status</a>.
        /// </summary>
        [<CustomOperation "with_status">]
        member _.WithStatus(state: DataHcloudServerState, value: seq<string>) : DataHcloudServerState =
            state.assignments.Add(fun config -> config.WithStatus <- (value |> Seq.toArray))
            state : DataHcloudServerState

        member _.Run(state: DataHcloudServerState) : hcloud.DataHcloudServer.DataHcloudServer =
            let config = hcloud.DataHcloudServer.DataHcloudServerConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudServer.DataHcloudServer(StackContext.get (), logicalId, config)
