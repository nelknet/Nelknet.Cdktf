namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId> = { assignments: ResizeArray<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_analysis">aws_ec2_network_insights_analysis</a>.
    /// </summary>
    type Ec2NetworkInsightsAnalysisBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2NetworkInsightsAnalysisState<Missing> =
            ({ assignments = ResizeArray() } : Ec2NetworkInsightsAnalysisState<Missing>)

        member _.Zero(()) : Ec2NetworkInsightsAnalysisState<Missing> =
            ({ assignments = ResizeArray() } : Ec2NetworkInsightsAnalysisState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_analysis#network_insights_path_id-1">Ec2NetworkInsightsAnalysis#network_insights_path_id</a>.
        /// </summary>
        [<CustomOperation "network_insights_path_id">]
        member _.NetworkInsightsPathId(state: Ec2NetworkInsightsAnalysisState<Missing>, value: string) : Ec2NetworkInsightsAnalysisState<Present> =
            state.assignments.Add(fun config -> config.NetworkInsightsPathId <- value)
            ({ assignments = state.assignments } : Ec2NetworkInsightsAnalysisState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_analysis#filter_in_arns-1">Ec2NetworkInsightsAnalysis#filter_in_arns</a>.
        /// </summary>
        [<CustomOperation "filter_in_arns">]
        member _.FilterInArns(state: Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId>, value: seq<string>) : Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId> =
            state.assignments.Add(fun config -> config.FilterInArns <- (value |> Seq.toArray))
            state : Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_analysis#id-1">Ec2NetworkInsightsAnalysis#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId>, value: string) : Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_analysis#tags-1">Ec2NetworkInsightsAnalysis#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId>, value: seq<string * string>) : Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_analysis#tags_all-1">Ec2NetworkInsightsAnalysis#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId>, value: seq<string * string>) : Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_analysis#wait_for_completion-1">Ec2NetworkInsightsAnalysis#wait_for_completion</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_completion">]
        member _.WaitForCompletion(state: Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId>, value: bool) : Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId> =
            state.assignments.Add(fun config -> config.WaitForCompletion <- value)
            state : Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_analysis#wait_for_completion-1">Ec2NetworkInsightsAnalysis#wait_for_completion</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_completion">]
        member _.WaitForCompletion(state: Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId>, value: HashiCorp.Cdktf.IResolvable) : Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId> =
            state.assignments.Add(fun config -> config.WaitForCompletion <- value)
            state : Ec2NetworkInsightsAnalysisState<'NetworkInsightsPathId>

        member _.Run(state: Ec2NetworkInsightsAnalysisState<Present>) : aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysis =
            let config = aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysisConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysis(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2NetworkInsightsAnalysis: missing required arguments. Must call: network_insights_path_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2NetworkInsightsAnalysisState<_>) : aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysis =
            Unchecked.defaultof<aws.Ec2NetworkInsightsAnalysis.Ec2NetworkInsightsAnalysis>
