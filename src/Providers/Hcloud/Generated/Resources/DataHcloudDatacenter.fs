namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudDatacenterState = { assignments: ResizeArray<hcloud.DataHcloudDatacenter.DataHcloudDatacenterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/datacenter">hcloud_datacenter</a>.
    /// </summary>
    type DataHcloudDatacenterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudDatacenterState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudDatacenterState =
            { assignments = ResizeArray() }

        /// <summary>
        /// ID of the Datacenter. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/datacenter#id-1">DataHcloudDatacenter#id</a> Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudDatacenterState, value: double) : DataHcloudDatacenterState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudDatacenterState

        /// <summary>
        /// Name of the Datacenter. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/datacenter#name-1">DataHcloudDatacenter#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudDatacenterState, value: string) : DataHcloudDatacenterState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudDatacenterState

        member _.Run(state: DataHcloudDatacenterState) : hcloud.DataHcloudDatacenter.DataHcloudDatacenter =
            let config = hcloud.DataHcloudDatacenter.DataHcloudDatacenterConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudDatacenter.DataHcloudDatacenter(StackContext.get (), logicalId, config)
