namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogResourcePolicyState<'PolicyDocument, 'PolicyName> = { assignments: ResizeArray<aws.CloudwatchLogResourcePolicy.CloudwatchLogResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_resource_policy">aws_cloudwatch_log_resource_policy</a>.
    /// </summary>
    type CloudwatchLogResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogResourcePolicyState<Missing, Missing>)

        member _.Zero(()) : CloudwatchLogResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogResourcePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_resource_policy#policy_document-1">CloudwatchLogResourcePolicy#policy_document</a>.
        /// </summary>
        [<CustomOperation "policy_document">]
        member _.PolicyDocument(state: CloudwatchLogResourcePolicyState<Missing, 'PolicyName>, value: string) : CloudwatchLogResourcePolicyState<Present, 'PolicyName> =
            state.assignments.Add(fun config -> config.PolicyDocument <- value)
            ({ assignments = state.assignments } : CloudwatchLogResourcePolicyState<Present, 'PolicyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_resource_policy#policy_name-1">CloudwatchLogResourcePolicy#policy_name</a>.
        /// </summary>
        [<CustomOperation "policy_name">]
        member _.PolicyName(state: CloudwatchLogResourcePolicyState<'PolicyDocument, Missing>, value: string) : CloudwatchLogResourcePolicyState<'PolicyDocument, Present> =
            state.assignments.Add(fun config -> config.PolicyName <- value)
            ({ assignments = state.assignments } : CloudwatchLogResourcePolicyState<'PolicyDocument, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_resource_policy#id-1">CloudwatchLogResourcePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchLogResourcePolicyState<'PolicyDocument, 'PolicyName>, value: string) : CloudwatchLogResourcePolicyState<'PolicyDocument, 'PolicyName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchLogResourcePolicyState<'PolicyDocument, 'PolicyName>

        member _.Run(state: CloudwatchLogResourcePolicyState<Present, Present>) : aws.CloudwatchLogResourcePolicy.CloudwatchLogResourcePolicy =
            let config = aws.CloudwatchLogResourcePolicy.CloudwatchLogResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogResourcePolicy.CloudwatchLogResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogResourcePolicy: missing required arguments. Must call: policy_document, policy_name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogResourcePolicyState<_, _>) : aws.CloudwatchLogResourcePolicy.CloudwatchLogResourcePolicy =
            Unchecked.defaultof<aws.CloudwatchLogResourcePolicy.CloudwatchLogResourcePolicy>
