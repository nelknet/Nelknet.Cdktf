namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudServersState = { assignments: ResizeArray<hcloud.DataHcloudServers.DataHcloudServersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/servers">hcloud_servers</a>.
    /// </summary>
    type DataHcloudServersBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudServersState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudServersState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/servers#id-1">DataHcloudServers#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudServersState, value: string) : DataHcloudServersState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudServersState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/servers#with_selector-1">DataHcloudServers#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudServersState, value: string) : DataHcloudServersState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudServersState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/servers#with_status-1">DataHcloudServers#with_status</a>.
        /// </summary>
        [<CustomOperation "with_status">]
        member _.WithStatus(state: DataHcloudServersState, value: seq<string>) : DataHcloudServersState =
            state.assignments.Add(fun config -> config.WithStatus <- (value |> Seq.toArray))
            state : DataHcloudServersState

        member _.Run(state: DataHcloudServersState) : hcloud.DataHcloudServers.DataHcloudServers =
            let config = hcloud.DataHcloudServers.DataHcloudServersConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudServers.DataHcloudServers(StackContext.get (), logicalId, config)
