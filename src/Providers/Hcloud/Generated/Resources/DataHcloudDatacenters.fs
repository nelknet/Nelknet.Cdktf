namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudDatacentersState = { assignments: ResizeArray<hcloud.DataHcloudDatacenters.DataHcloudDatacentersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/datacenters">hcloud_datacenters</a>.
    /// </summary>
    type DataHcloudDatacentersBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudDatacentersState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudDatacentersState =
            { assignments = ResizeArray() }



        member _.Run(state: DataHcloudDatacentersState) : hcloud.DataHcloudDatacenters.DataHcloudDatacenters =
            let config = hcloud.DataHcloudDatacenters.DataHcloudDatacentersConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudDatacenters.DataHcloudDatacenters(StackContext.get (), logicalId, config)
