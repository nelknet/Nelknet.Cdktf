namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDefaultTagsState = { assignments: ResizeArray<aws.DataAwsDefaultTags.DataAwsDefaultTagsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/default_tags">aws_default_tags</a>.
    /// </summary>
    type DataAwsDefaultTagsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDefaultTagsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsDefaultTagsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/default_tags#id-1">DataAwsDefaultTags#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDefaultTagsState, value: string) : DataAwsDefaultTagsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDefaultTagsState

        member _.Run(state: DataAwsDefaultTagsState) : aws.DataAwsDefaultTags.DataAwsDefaultTags =
            let config = aws.DataAwsDefaultTags.DataAwsDefaultTagsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDefaultTags.DataAwsDefaultTags(StackContext.get (), logicalId, config)
