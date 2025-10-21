namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudLocationState = { assignments: ResizeArray<hcloud.DataHcloudLocation.DataHcloudLocationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/location">hcloud_location</a>.
    /// </summary>
    type DataHcloudLocationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudLocationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudLocationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// ID of the Location. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/location#id-1">DataHcloudLocation#id</a> Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudLocationState, value: double) : DataHcloudLocationState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudLocationState

        /// <summary>
        /// Name of the Location. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/location#name-1">DataHcloudLocation#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudLocationState, value: string) : DataHcloudLocationState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudLocationState

        member _.Run(state: DataHcloudLocationState) : hcloud.DataHcloudLocation.DataHcloudLocation =
            let config = hcloud.DataHcloudLocation.DataHcloudLocationConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudLocation.DataHcloudLocation(StackContext.get (), logicalId, config)
