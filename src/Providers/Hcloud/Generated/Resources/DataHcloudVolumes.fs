namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudVolumesState = { assignments: ResizeArray<hcloud.DataHcloudVolumes.DataHcloudVolumesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volumes">hcloud_volumes</a>.
    /// </summary>
    type DataHcloudVolumesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudVolumesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudVolumesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volumes#id-1">DataHcloudVolumes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudVolumesState, value: string) : DataHcloudVolumesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudVolumesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volumes#with_selector-1">DataHcloudVolumes#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudVolumesState, value: string) : DataHcloudVolumesState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudVolumesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volumes#with_status-1">DataHcloudVolumes#with_status</a>.
        /// </summary>
        [<CustomOperation "with_status">]
        member _.WithStatus(state: DataHcloudVolumesState, value: seq<string>) : DataHcloudVolumesState =
            state.assignments.Add(fun config -> config.WithStatus <- (value |> Seq.toArray))
            state : DataHcloudVolumesState

        member _.Run(state: DataHcloudVolumesState) : hcloud.DataHcloudVolumes.DataHcloudVolumes =
            let config = hcloud.DataHcloudVolumes.DataHcloudVolumesConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudVolumes.DataHcloudVolumes(StackContext.get (), logicalId, config)
