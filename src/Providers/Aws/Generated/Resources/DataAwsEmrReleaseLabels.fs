namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEmrReleaseLabelsState = { assignments: ResizeArray<aws.DataAwsEmrReleaseLabels.DataAwsEmrReleaseLabelsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emr_release_labels">aws_emr_release_labels</a>.
    /// </summary>
    type DataAwsEmrReleaseLabelsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEmrReleaseLabelsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEmrReleaseLabelsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emr_release_labels#filters-1">DataAwsEmrReleaseLabels#filters</a>
        /// </summary>
        [<CustomOperation "filters">]
        member _.Filters(state: DataAwsEmrReleaseLabelsState, value: aws.DataAwsEmrReleaseLabels.DataAwsEmrReleaseLabelsFilters) : DataAwsEmrReleaseLabelsState =
            state.assignments.Add(fun config -> config.Filters <- value)
            state : DataAwsEmrReleaseLabelsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/emr_release_labels#id-1">DataAwsEmrReleaseLabels#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEmrReleaseLabelsState, value: string) : DataAwsEmrReleaseLabelsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEmrReleaseLabelsState

        member _.Run(state: DataAwsEmrReleaseLabelsState) : aws.DataAwsEmrReleaseLabels.DataAwsEmrReleaseLabels =
            let config = aws.DataAwsEmrReleaseLabels.DataAwsEmrReleaseLabelsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEmrReleaseLabels.DataAwsEmrReleaseLabels(StackContext.get (), logicalId, config)
