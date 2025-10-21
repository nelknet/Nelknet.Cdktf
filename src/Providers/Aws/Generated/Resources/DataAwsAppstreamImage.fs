namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAppstreamImageState = { assignments: ResizeArray<aws.DataAwsAppstreamImage.DataAwsAppstreamImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appstream_image">aws_appstream_image</a>.
    /// </summary>
    type DataAwsAppstreamImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAppstreamImageState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsAppstreamImageState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appstream_image#arn-1">DataAwsAppstreamImage#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsAppstreamImageState, value: string) : DataAwsAppstreamImageState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsAppstreamImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appstream_image#most_recent-1">DataAwsAppstreamImage#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsAppstreamImageState, value: bool) : DataAwsAppstreamImageState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsAppstreamImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appstream_image#most_recent-1">DataAwsAppstreamImage#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsAppstreamImageState, value: HashiCorp.Cdktf.IResolvable) : DataAwsAppstreamImageState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsAppstreamImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appstream_image#name-1">DataAwsAppstreamImage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAppstreamImageState, value: string) : DataAwsAppstreamImageState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsAppstreamImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appstream_image#name_regex-1">DataAwsAppstreamImage#name_regex</a>.
        /// </summary>
        [<CustomOperation "name_regex">]
        member _.NameRegex(state: DataAwsAppstreamImageState, value: string) : DataAwsAppstreamImageState =
            state.assignments.Add(fun config -> config.NameRegex <- value)
            state : DataAwsAppstreamImageState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appstream_image#type-1">DataAwsAppstreamImage#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataAwsAppstreamImageState, value: string) : DataAwsAppstreamImageState =
            state.assignments.Add(fun config -> config.Type <- value)
            state : DataAwsAppstreamImageState

        member _.Run(state: DataAwsAppstreamImageState) : aws.DataAwsAppstreamImage.DataAwsAppstreamImage =
            let config = aws.DataAwsAppstreamImage.DataAwsAppstreamImageConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAppstreamImage.DataAwsAppstreamImage(StackContext.get (), logicalId, config)
