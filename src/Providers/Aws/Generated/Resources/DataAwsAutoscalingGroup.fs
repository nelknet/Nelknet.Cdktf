namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAutoscalingGroupState<'Name> = { assignments: ResizeArray<aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/autoscaling_group">aws_autoscaling_group</a>.
    /// </summary>
    type DataAwsAutoscalingGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAutoscalingGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsAutoscalingGroupState<Missing>)

        member _.Zero(()) : DataAwsAutoscalingGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsAutoscalingGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/autoscaling_group#name-1">DataAwsAutoscalingGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsAutoscalingGroupState<Missing>, value: string) : DataAwsAutoscalingGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsAutoscalingGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/autoscaling_group#id-1">DataAwsAutoscalingGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAutoscalingGroupState<'Name>, value: string) : DataAwsAutoscalingGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAutoscalingGroupState<'Name>

        member _.Run(state: DataAwsAutoscalingGroupState<Present>) : aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroup =
            let config = aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAutoscalingGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAutoscalingGroupState<_>) : aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroup =
            Unchecked.defaultof<aws.DataAwsAutoscalingGroup.DataAwsAutoscalingGroup>
