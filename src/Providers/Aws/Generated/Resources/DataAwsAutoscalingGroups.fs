namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAutoscalingGroupsState = { assignments: ResizeArray<aws.DataAwsAutoscalingGroups.DataAwsAutoscalingGroupsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/autoscaling_groups">aws_autoscaling_groups</a>.
    /// </summary>
    type DataAwsAutoscalingGroupsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAutoscalingGroupsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsAutoscalingGroupsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/autoscaling_groups#filter-1">DataAwsAutoscalingGroups#filter</a> Accepts: aws.IResolvable | aws.DataAwsAutoscalingGroups.DataAwsAutoscalingGroupsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsAutoscalingGroupsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsAutoscalingGroupsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsAutoscalingGroupsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/autoscaling_groups#id-1">DataAwsAutoscalingGroups#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAutoscalingGroupsState, value: string) : DataAwsAutoscalingGroupsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAutoscalingGroupsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/autoscaling_groups#names-1">DataAwsAutoscalingGroups#names</a>.
        /// </summary>
        [<CustomOperation "names">]
        member _.Names(state: DataAwsAutoscalingGroupsState, value: seq<string>) : DataAwsAutoscalingGroupsState =
            state.assignments.Add(fun config -> config.Names <- (value |> Seq.toArray))
            state : DataAwsAutoscalingGroupsState

        member _.Run(state: DataAwsAutoscalingGroupsState) : aws.DataAwsAutoscalingGroups.DataAwsAutoscalingGroups =
            let config = aws.DataAwsAutoscalingGroups.DataAwsAutoscalingGroupsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAutoscalingGroups.DataAwsAutoscalingGroups(StackContext.get (), logicalId, config)
