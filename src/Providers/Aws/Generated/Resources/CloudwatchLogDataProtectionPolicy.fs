namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogDataProtectionPolicyState<'LogGroupName, 'PolicyDocument> = { assignments: ResizeArray<aws.CloudwatchLogDataProtectionPolicy.CloudwatchLogDataProtectionPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_data_protection_policy">aws_cloudwatch_log_data_protection_policy</a>.
    /// </summary>
    type CloudwatchLogDataProtectionPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogDataProtectionPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDataProtectionPolicyState<Missing, Missing>)

        member _.Zero(()) : CloudwatchLogDataProtectionPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDataProtectionPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_data_protection_policy#log_group_name-1">CloudwatchLogDataProtectionPolicy#log_group_name</a>.
        /// </summary>
        [<CustomOperation "log_group_name">]
        member _.LogGroupName(state: CloudwatchLogDataProtectionPolicyState<Missing, 'PolicyDocument>, value: string) : CloudwatchLogDataProtectionPolicyState<Present, 'PolicyDocument> =
            state.assignments.Add(fun config -> config.LogGroupName <- value)
            ({ assignments = state.assignments } : CloudwatchLogDataProtectionPolicyState<Present, 'PolicyDocument>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_data_protection_policy#policy_document-1">CloudwatchLogDataProtectionPolicy#policy_document</a>.
        /// </summary>
        [<CustomOperation "policy_document">]
        member _.PolicyDocument(state: CloudwatchLogDataProtectionPolicyState<'LogGroupName, Missing>, value: string) : CloudwatchLogDataProtectionPolicyState<'LogGroupName, Present> =
            state.assignments.Add(fun config -> config.PolicyDocument <- value)
            ({ assignments = state.assignments } : CloudwatchLogDataProtectionPolicyState<'LogGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_data_protection_policy#id-1">CloudwatchLogDataProtectionPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchLogDataProtectionPolicyState<'LogGroupName, 'PolicyDocument>, value: string) : CloudwatchLogDataProtectionPolicyState<'LogGroupName, 'PolicyDocument> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchLogDataProtectionPolicyState<'LogGroupName, 'PolicyDocument>

        member _.Run(state: CloudwatchLogDataProtectionPolicyState<Present, Present>) : aws.CloudwatchLogDataProtectionPolicy.CloudwatchLogDataProtectionPolicy =
            let config = aws.CloudwatchLogDataProtectionPolicy.CloudwatchLogDataProtectionPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogDataProtectionPolicy.CloudwatchLogDataProtectionPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogDataProtectionPolicy: missing required arguments. Must call: log_group_name, policy_document.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogDataProtectionPolicyState<_, _>) : aws.CloudwatchLogDataProtectionPolicy.CloudwatchLogDataProtectionPolicy =
            Unchecked.defaultof<aws.CloudwatchLogDataProtectionPolicy.CloudwatchLogDataProtectionPolicy>
