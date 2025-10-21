namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudImageState = { assignments: ResizeArray<hcloud.DataHcloudImage.DataHcloudImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image">hcloud_image</a>.
    /// </summary>
    type DataHcloudImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudImageState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudImageState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#id-1">DataHcloudImage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudImageState, value: double) : DataHcloudImageState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#include_deprecated-1">DataHcloudImage#include_deprecated</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated(state: DataHcloudImageState, value: bool) : DataHcloudImageState =
            state.assignments.Add(fun config -> config.IncludeDeprecated <- value)
            state : DataHcloudImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#include_deprecated-1">DataHcloudImage#include_deprecated</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated(state: DataHcloudImageState, value: HashiCorp.Cdktf.IResolvable) : DataHcloudImageState =
            state.assignments.Add(fun config -> config.IncludeDeprecated <- value)
            state : DataHcloudImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#most_recent-1">DataHcloudImage#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudImageState, value: bool) : DataHcloudImageState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#most_recent-1">DataHcloudImage#most_recent</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataHcloudImageState, value: HashiCorp.Cdktf.IResolvable) : DataHcloudImageState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataHcloudImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#name-1">DataHcloudImage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudImageState, value: string) : DataHcloudImageState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#selector-1">DataHcloudImage#selector</a>.
        /// </summary>
        [<CustomOperation "selector">]
        member _.Selector(state: DataHcloudImageState, value: string) : DataHcloudImageState =
            state.assignments.Add(fun config -> config.Selector <- value)
            state : DataHcloudImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#with_architecture-1">DataHcloudImage#with_architecture</a>.
        /// </summary>
        [<CustomOperation "with_architecture">]
        member _.WithArchitecture(state: DataHcloudImageState, value: string) : DataHcloudImageState =
            state.assignments.Add(fun config -> config.WithArchitecture <- value)
            state : DataHcloudImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#with_selector-1">DataHcloudImage#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudImageState, value: string) : DataHcloudImageState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/image#with_status-1">DataHcloudImage#with_status</a>.
        /// </summary>
        [<CustomOperation "with_status">]
        member _.WithStatus(state: DataHcloudImageState, value: seq<string>) : DataHcloudImageState =
            state.assignments.Add(fun config -> config.WithStatus <- (value |> Seq.toArray))
            state : DataHcloudImageState

        member _.Run(state: DataHcloudImageState) : hcloud.DataHcloudImage.DataHcloudImage =
            let config = hcloud.DataHcloudImage.DataHcloudImageConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudImage.DataHcloudImage(StackContext.get (), logicalId, config)
