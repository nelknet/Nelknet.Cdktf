namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2NetworkInsightsAnalysisState = { assignments: ResizeArray<aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_network_insights_analysis">aws_ec2_network_insights_analysis</a>.
    /// </summary>
    type DataAwsEc2NetworkInsightsAnalysisBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2NetworkInsightsAnalysisState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2NetworkInsightsAnalysisState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_network_insights_analysis#filter-1">DataAwsEc2NetworkInsightsAnalysis#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2NetworkInsightsAnalysisState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2NetworkInsightsAnalysisState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2NetworkInsightsAnalysisState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_network_insights_analysis#id-1">DataAwsEc2NetworkInsightsAnalysis#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2NetworkInsightsAnalysisState, value: string) : DataAwsEc2NetworkInsightsAnalysisState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2NetworkInsightsAnalysisState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_network_insights_analysis#network_insights_analysis_id-1">DataAwsEc2NetworkInsightsAnalysis#network_insights_analysis_id</a>.
        /// </summary>
        [<CustomOperation "network_insights_analysis_id">]
        member _.NetworkInsightsAnalysisId(state: DataAwsEc2NetworkInsightsAnalysisState, value: string) : DataAwsEc2NetworkInsightsAnalysisState =
            state.assignments.Add(fun config -> config.NetworkInsightsAnalysisId <- value)
            state : DataAwsEc2NetworkInsightsAnalysisState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_network_insights_analysis#tags-1">DataAwsEc2NetworkInsightsAnalysis#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2NetworkInsightsAnalysisState, value: seq<string * string>) : DataAwsEc2NetworkInsightsAnalysisState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2NetworkInsightsAnalysisState

        member _.Run(state: DataAwsEc2NetworkInsightsAnalysisState) : aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysis =
            let config = aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysis(StackContext.get (), logicalId, config)
