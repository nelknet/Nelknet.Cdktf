namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogIndexPolicyState<'LogGroupName, 'PolicyDocument> = { assignments: ResizeArray<aws.CloudwatchLogIndexPolicy.CloudwatchLogIndexPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_index_policy">aws_cloudwatch_log_index_policy</a>.
    /// </summary>
    type CloudwatchLogIndexPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogIndexPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogIndexPolicyState<Missing, Missing>)

        member _.Zero(()) : CloudwatchLogIndexPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogIndexPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_index_policy#log_group_name-1">CloudwatchLogIndexPolicy#log_group_name</a>.
        /// </summary>
        [<CustomOperation "log_group_name">]
        member _.LogGroupName(state: CloudwatchLogIndexPolicyState<Missing, 'PolicyDocument>, value: string) : CloudwatchLogIndexPolicyState<Present, 'PolicyDocument> =
            state.assignments.Add(fun config -> config.LogGroupName <- value)
            ({ assignments = state.assignments } : CloudwatchLogIndexPolicyState<Present, 'PolicyDocument>)

        /// <summary>
        /// Field index filter policy, in JSON. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_index_policy#policy_document-1">CloudwatchLogIndexPolicy#policy_document</a>
        /// </summary>
        [<CustomOperation "policy_document">]
        member _.PolicyDocument(state: CloudwatchLogIndexPolicyState<'LogGroupName, Missing>, value: string) : CloudwatchLogIndexPolicyState<'LogGroupName, Present> =
            state.assignments.Add(fun config -> config.PolicyDocument <- value)
            ({ assignments = state.assignments } : CloudwatchLogIndexPolicyState<'LogGroupName, Present>)

        member _.Run(state: CloudwatchLogIndexPolicyState<Present, Present>) : aws.CloudwatchLogIndexPolicy.CloudwatchLogIndexPolicy =
            let config = aws.CloudwatchLogIndexPolicy.CloudwatchLogIndexPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogIndexPolicy.CloudwatchLogIndexPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogIndexPolicy: missing required arguments. Must call: log_group_name, policy_document.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogIndexPolicyState<_, _>) : aws.CloudwatchLogIndexPolicy.CloudwatchLogIndexPolicy =
            Unchecked.defaultof<aws.CloudwatchLogIndexPolicy.CloudwatchLogIndexPolicy>
