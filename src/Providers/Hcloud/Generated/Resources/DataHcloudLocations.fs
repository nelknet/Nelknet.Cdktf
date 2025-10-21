namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudLocationsState = { assignments: ResizeArray<hcloud.DataHcloudLocations.DataHcloudLocationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/locations">hcloud_locations</a>.
    /// </summary>
    type DataHcloudLocationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudLocationsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudLocationsState =
            { assignments = ResizeArray() }



        member _.Run(state: DataHcloudLocationsState) : hcloud.DataHcloudLocations.DataHcloudLocations =
            let config = hcloud.DataHcloudLocations.DataHcloudLocationsConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudLocations.DataHcloudLocations(StackContext.get (), logicalId, config)
