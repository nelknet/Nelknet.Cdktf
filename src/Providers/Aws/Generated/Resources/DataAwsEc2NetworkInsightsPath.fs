namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2NetworkInsightsPathState = { assignments: ResizeArray<aws.DataAwsEc2NetworkInsightsPath.DataAwsEc2NetworkInsightsPathConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_network_insights_path">aws_ec2_network_insights_path</a>.
    /// </summary>
    type DataAwsEc2NetworkInsightsPathBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2NetworkInsightsPathState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2NetworkInsightsPathState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_network_insights_path#filter-1">DataAwsEc2NetworkInsightsPath#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2NetworkInsightsPath.DataAwsEc2NetworkInsightsPathFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2NetworkInsightsPathState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2NetworkInsightsPathState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2NetworkInsightsPathState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_network_insights_path#id-1">DataAwsEc2NetworkInsightsPath#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2NetworkInsightsPathState, value: string) : DataAwsEc2NetworkInsightsPathState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2NetworkInsightsPathState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_network_insights_path#network_insights_path_id-1">DataAwsEc2NetworkInsightsPath#network_insights_path_id</a>.
        /// </summary>
        [<CustomOperation "network_insights_path_id">]
        member _.NetworkInsightsPathId(state: DataAwsEc2NetworkInsightsPathState, value: string) : DataAwsEc2NetworkInsightsPathState =
            state.assignments.Add(fun config -> config.NetworkInsightsPathId <- value)
            state : DataAwsEc2NetworkInsightsPathState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_network_insights_path#tags-1">DataAwsEc2NetworkInsightsPath#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2NetworkInsightsPathState, value: seq<string * string>) : DataAwsEc2NetworkInsightsPathState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2NetworkInsightsPathState

        member _.Run(state: DataAwsEc2NetworkInsightsPathState) : aws.DataAwsEc2NetworkInsightsPath.DataAwsEc2NetworkInsightsPath =
            let config = aws.DataAwsEc2NetworkInsightsPath.DataAwsEc2NetworkInsightsPathConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2NetworkInsightsPath.DataAwsEc2NetworkInsightsPath(StackContext.get (), logicalId, config)
