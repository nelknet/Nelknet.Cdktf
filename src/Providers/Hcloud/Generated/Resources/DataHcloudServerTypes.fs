namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudServerTypesState = { assignments: ResizeArray<hcloud.DataHcloudServerTypes.DataHcloudServerTypesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/server_types">hcloud_server_types</a>.
    /// </summary>
    type DataHcloudServerTypesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudServerTypesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudServerTypesState =
            { assignments = ResizeArray() }



        member _.Run(state: DataHcloudServerTypesState) : hcloud.DataHcloudServerTypes.DataHcloudServerTypes =
            let config = hcloud.DataHcloudServerTypes.DataHcloudServerTypesConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudServerTypes.DataHcloudServerTypes(StackContext.get (), logicalId, config)
