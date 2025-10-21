namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, 'PolicyType> = { assignments: ResizeArray<aws.CloudwatchLogAccountPolicy.CloudwatchLogAccountPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_account_policy">aws_cloudwatch_log_account_policy</a>.
    /// </summary>
    type CloudwatchLogAccountPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogAccountPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogAccountPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : CloudwatchLogAccountPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogAccountPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_account_policy#policy_document-1">CloudwatchLogAccountPolicy#policy_document</a>.
        /// </summary>
        [<CustomOperation "policy_document">]
        member _.PolicyDocument(state: CloudwatchLogAccountPolicyState<Missing, 'PolicyName, 'PolicyType>, value: string) : CloudwatchLogAccountPolicyState<Present, 'PolicyName, 'PolicyType> =
            state.assignments.Add(fun config -> config.PolicyDocument <- value)
            ({ assignments = state.assignments } : CloudwatchLogAccountPolicyState<Present, 'PolicyName, 'PolicyType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_account_policy#policy_name-1">CloudwatchLogAccountPolicy#policy_name</a>.
        /// </summary>
        [<CustomOperation "policy_name">]
        member _.PolicyName(state: CloudwatchLogAccountPolicyState<'PolicyDocument, Missing, 'PolicyType>, value: string) : CloudwatchLogAccountPolicyState<'PolicyDocument, Present, 'PolicyType> =
            state.assignments.Add(fun config -> config.PolicyName <- value)
            ({ assignments = state.assignments } : CloudwatchLogAccountPolicyState<'PolicyDocument, Present, 'PolicyType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_account_policy#policy_type-1">CloudwatchLogAccountPolicy#policy_type</a>.
        /// </summary>
        [<CustomOperation "policy_type">]
        member _.PolicyType(state: CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, Missing>, value: string) : CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, Present> =
            state.assignments.Add(fun config -> config.PolicyType <- value)
            ({ assignments = state.assignments } : CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_account_policy#id-1">CloudwatchLogAccountPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, 'PolicyType>, value: string) : CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, 'PolicyType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, 'PolicyType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_account_policy#scope-1">CloudwatchLogAccountPolicy#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, 'PolicyType>, value: string) : CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, 'PolicyType> =
            state.assignments.Add(fun config -> config.Scope <- value)
            state : CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, 'PolicyType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_account_policy#selection_criteria-1">CloudwatchLogAccountPolicy#selection_criteria</a>.
        /// </summary>
        [<CustomOperation "selection_criteria">]
        member _.SelectionCriteria(state: CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, 'PolicyType>, value: string) : CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, 'PolicyType> =
            state.assignments.Add(fun config -> config.SelectionCriteria <- value)
            state : CloudwatchLogAccountPolicyState<'PolicyDocument, 'PolicyName, 'PolicyType>

        member _.Run(state: CloudwatchLogAccountPolicyState<Present, Present, Present>) : aws.CloudwatchLogAccountPolicy.CloudwatchLogAccountPolicy =
            let config = aws.CloudwatchLogAccountPolicy.CloudwatchLogAccountPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogAccountPolicy.CloudwatchLogAccountPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogAccountPolicy: missing required arguments. Must call: policy_document, policy_name, policy_type.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogAccountPolicyState<_, _, _>) : aws.CloudwatchLogAccountPolicy.CloudwatchLogAccountPolicy =
            Unchecked.defaultof<aws.CloudwatchLogAccountPolicy.CloudwatchLogAccountPolicy>
