namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudVolumeState = { assignments: ResizeArray<hcloud.DataHcloudVolume.DataHcloudVolumeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume">hcloud_volume</a>.
    /// </summary>
    type DataHcloudVolumeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudVolumeState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudVolumeState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#id-1">DataHcloudVolume#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudVolumeState, value: double) : DataHcloudVolumeState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudVolumeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#location-1">DataHcloudVolume#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataHcloudVolumeState, value: string) : DataHcloudVolumeState =
            state.assignments.Add(fun config -> config.Location <- value)
            state : DataHcloudVolumeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#name-1">DataHcloudVolume#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudVolumeState, value: string) : DataHcloudVolumeState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudVolumeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#selector-1">DataHcloudVolume#selector</a>.
        /// </summary>
        [<CustomOperation "selector">]
        member _.Selector(state: DataHcloudVolumeState, value: string) : DataHcloudVolumeState =
            state.assignments.Add(fun config -> config.Selector <- value)
            state : DataHcloudVolumeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#server_id-1">DataHcloudVolume#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: DataHcloudVolumeState, value: double) : DataHcloudVolumeState =
            state.assignments.Add(fun config -> config.ServerId <- value)
            state : DataHcloudVolumeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#with_selector-1">DataHcloudVolume#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudVolumeState, value: string) : DataHcloudVolumeState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudVolumeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/volume#with_status-1">DataHcloudVolume#with_status</a>.
        /// </summary>
        [<CustomOperation "with_status">]
        member _.WithStatus(state: DataHcloudVolumeState, value: seq<string>) : DataHcloudVolumeState =
            state.assignments.Add(fun config -> config.WithStatus <- (value |> Seq.toArray))
            state : DataHcloudVolumeState

        member _.Run(state: DataHcloudVolumeState) : hcloud.DataHcloudVolume.DataHcloudVolume =
            let config = hcloud.DataHcloudVolume.DataHcloudVolumeConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudVolume.DataHcloudVolume(StackContext.get (), logicalId, config)
