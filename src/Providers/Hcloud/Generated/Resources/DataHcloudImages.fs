namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudImagesState = { assignments: ResizeArray<hcloud.DataHcloudImages.DataHcloudImagesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images">hcloud_images</a>.
    /// </summary>
    type DataHcloudImagesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudImagesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudImagesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#id-1">DataHcloudImages#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudImagesState, value: string) : DataHcloudImagesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudImagesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#include_deprecated-1">DataHcloudImages#include_deprecated</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated(state: DataHcloudImagesState, value: bool) : DataHcloudImagesState =
            state.assignments.Add(fun config -> config.IncludeDeprecated <- value)
            state : DataHcloudImagesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#include_deprecated-1">DataHcloudImages#include_deprecated</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated(state: DataHcloudImagesState, value: HashiCorp.Cdktf.IResolvable) : DataHcloudImagesState =
            state.assignments.Add(fun config -> config.IncludeDeprecated <- value)
            state : DataHcloudImagesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#most_recent-1">DataHcloudImages#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudImagesState, value: bool) : DataHcloudImagesState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudImagesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#most_recent-1">DataHcloudImages#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudImagesState, value: HashiCorp.Cdktf.IResolvable) : DataHcloudImagesState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudImagesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#with_architecture-1">DataHcloudImages#with_architecture</a>.
        /// </summary>
        [<CustomOperation "with_architecture">]
        member _.WithArchitecture(state: DataHcloudImagesState, value: seq<string>) : DataHcloudImagesState =
            state.assignments.Add(fun config -> config.WithArchitecture <- (value |> Seq.toArray))
            state : DataHcloudImagesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#with_selector-1">DataHcloudImages#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudImagesState, value: string) : DataHcloudImagesState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudImagesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/images#with_status-1">DataHcloudImages#with_status</a>.
        /// </summary>
        [<CustomOperation "with_status">]
        member _.WithStatus(state: DataHcloudImagesState, value: seq<string>) : DataHcloudImagesState =
            state.assignments.Add(fun config -> config.WithStatus <- (value |> Seq.toArray))
            state : DataHcloudImagesState

        member _.Run(state: DataHcloudImagesState) : hcloud.DataHcloudImages.DataHcloudImages =
            let config = hcloud.DataHcloudImages.DataHcloudImagesConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudImages.DataHcloudImages(StackContext.get (), logicalId, config)
