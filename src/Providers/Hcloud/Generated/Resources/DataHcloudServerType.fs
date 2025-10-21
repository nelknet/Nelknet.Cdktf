namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudServerTypeState = { assignments: ResizeArray<hcloud.DataHcloudServerType.DataHcloudServerTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server_type">hcloud_server_type</a>.
    /// </summary>
    type DataHcloudServerTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudServerTypeState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudServerTypeState =
            { assignments = ResizeArray() }

        /// <summary>
        /// ID of the Server Type. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server_type#id-1">DataHcloudServerType#id</a> Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudServerTypeState, value: double) : DataHcloudServerTypeState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudServerTypeState

        /// <summary>
        /// Name of the Server Type. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server_type#name-1">DataHcloudServerType#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudServerTypeState, value: string) : DataHcloudServerTypeState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudServerTypeState

        member _.Run(state: DataHcloudServerTypeState) : hcloud.DataHcloudServerType.DataHcloudServerType =
            let config = hcloud.DataHcloudServerType.DataHcloudServerTypeConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudServerType.DataHcloudServerType(StackContext.get (), logicalId, config)
