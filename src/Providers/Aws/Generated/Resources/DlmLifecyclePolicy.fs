namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails> = { assignments: ResizeArray<aws.DlmLifecyclePolicy.DlmLifecyclePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy">aws_dlm_lifecycle_policy</a>.
    /// </summary>
    type DlmLifecyclePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DlmLifecyclePolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DlmLifecyclePolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : DlmLifecyclePolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DlmLifecyclePolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#description-1">DlmLifecyclePolicy#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DlmLifecyclePolicyState<Missing, 'ExecutionRoleArn, 'PolicyDetails>, value: string) : DlmLifecyclePolicyState<Present, 'ExecutionRoleArn, 'PolicyDetails> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : DlmLifecyclePolicyState<Present, 'ExecutionRoleArn, 'PolicyDetails>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#execution_role_arn-1">DlmLifecyclePolicy#execution_role_arn</a>.
        /// </summary>
        [<CustomOperation "execution_role_arn">]
        member _.ExecutionRoleArn(state: DlmLifecyclePolicyState<'Description, Missing, 'PolicyDetails>, value: string) : DlmLifecyclePolicyState<'Description, Present, 'PolicyDetails> =
            state.assignments.Add(fun config -> config.ExecutionRoleArn <- value)
            ({ assignments = state.assignments } : DlmLifecyclePolicyState<'Description, Present, 'PolicyDetails>)

        /// <summary>
        /// policy_details block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#policy_details-1">DlmLifecyclePolicy#policy_details</a>
        /// </summary>
        [<CustomOperation "policy_details">]
        member _.PolicyDetails(state: DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, Missing>, value: aws.DlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetails) : DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, Present> =
            state.assignments.Add(fun config -> config.PolicyDetails <- value)
            ({ assignments = state.assignments } : DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#id-1">DlmLifecyclePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails>, value: string) : DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#state-1">DlmLifecyclePolicy#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails>, value: string) : DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails> =
            state.assignments.Add(fun config -> config.State <- value)
            state : DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#tags-1">DlmLifecyclePolicy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails>, value: seq<string * string>) : DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dlm_lifecycle_policy#tags_all-1">DlmLifecyclePolicy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails>, value: seq<string * string>) : DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DlmLifecyclePolicyState<'Description, 'ExecutionRoleArn, 'PolicyDetails>

        member _.Run(state: DlmLifecyclePolicyState<Present, Present, Present>) : aws.DlmLifecyclePolicy.DlmLifecyclePolicy =
            let config = aws.DlmLifecyclePolicy.DlmLifecyclePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DlmLifecyclePolicy.DlmLifecyclePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dlmLifecyclePolicy: missing required arguments. Must call: description, execution_role_arn, policy_details.", 9999, IsError = true)>]
        member _.Run(_: DlmLifecyclePolicyState<_, _, _>) : aws.DlmLifecyclePolicy.DlmLifecyclePolicy =
            Unchecked.defaultof<aws.DlmLifecyclePolicy.DlmLifecyclePolicy>
