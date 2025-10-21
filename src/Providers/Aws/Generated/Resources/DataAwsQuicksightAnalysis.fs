namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsQuicksightAnalysisState<'AnalysisId> = { assignments: ResizeArray<aws.DataAwsQuicksightAnalysis.DataAwsQuicksightAnalysisConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_analysis">aws_quicksight_analysis</a>.
    /// </summary>
    type DataAwsQuicksightAnalysisBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsQuicksightAnalysisState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsQuicksightAnalysisState<Missing>)

        member _.Zero(()) : DataAwsQuicksightAnalysisState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsQuicksightAnalysisState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_analysis#analysis_id-1">DataAwsQuicksightAnalysis#analysis_id</a>.
        /// </summary>
        [<CustomOperation "analysis_id">]
        member _.AnalysisId(state: DataAwsQuicksightAnalysisState<Missing>, value: string) : DataAwsQuicksightAnalysisState<Present> =
            state.assignments.Add(fun config -> config.AnalysisId <- value)
            ({ assignments = state.assignments } : DataAwsQuicksightAnalysisState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_analysis#aws_account_id-1">DataAwsQuicksightAnalysis#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: DataAwsQuicksightAnalysisState<'AnalysisId>, value: string) : DataAwsQuicksightAnalysisState<'AnalysisId> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : DataAwsQuicksightAnalysisState<'AnalysisId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_analysis#id-1">DataAwsQuicksightAnalysis#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsQuicksightAnalysisState<'AnalysisId>, value: string) : DataAwsQuicksightAnalysisState<'AnalysisId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsQuicksightAnalysisState<'AnalysisId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_analysis#tags-1">DataAwsQuicksightAnalysis#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsQuicksightAnalysisState<'AnalysisId>, value: seq<string * string>) : DataAwsQuicksightAnalysisState<'AnalysisId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsQuicksightAnalysisState<'AnalysisId>

        member _.Run(state: DataAwsQuicksightAnalysisState<Present>) : aws.DataAwsQuicksightAnalysis.DataAwsQuicksightAnalysis =
            let config = aws.DataAwsQuicksightAnalysis.DataAwsQuicksightAnalysisConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsQuicksightAnalysis.DataAwsQuicksightAnalysis(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsQuicksightAnalysis: missing required arguments. Must call: analysis_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsQuicksightAnalysisState<_>) : aws.DataAwsQuicksightAnalysis.DataAwsQuicksightAnalysis =
            Unchecked.defaultof<aws.DataAwsQuicksightAnalysis.DataAwsQuicksightAnalysis>
