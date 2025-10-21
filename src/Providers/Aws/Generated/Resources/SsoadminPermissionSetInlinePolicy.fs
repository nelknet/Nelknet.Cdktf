namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsoadminPermissionSetInlinePolicyState<'InlinePolicy, 'InstanceArn, 'PermissionSetArn> = { assignments: ResizeArray<aws.SsoadminPermissionSetInlinePolicy.SsoadminPermissionSetInlinePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set_inline_policy">aws_ssoadmin_permission_set_inline_policy</a>.
    /// </summary>
    type SsoadminPermissionSetInlinePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsoadminPermissionSetInlinePolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminPermissionSetInlinePolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : SsoadminPermissionSetInlinePolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminPermissionSetInlinePolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set_inline_policy#inline_policy-1">SsoadminPermissionSetInlinePolicy#inline_policy</a>.
        /// </summary>
        [<CustomOperation "inline_policy">]
        member _.InlinePolicy(state: SsoadminPermissionSetInlinePolicyState<Missing, 'InstanceArn, 'PermissionSetArn>, value: string) : SsoadminPermissionSetInlinePolicyState<Present, 'InstanceArn, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.InlinePolicy <- value)
            ({ assignments = state.assignments } : SsoadminPermissionSetInlinePolicyState<Present, 'InstanceArn, 'PermissionSetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set_inline_policy#instance_arn-1">SsoadminPermissionSetInlinePolicy#instance_arn</a>.
        /// </summary>
        [<CustomOperation "instance_arn">]
        member _.InstanceArn(state: SsoadminPermissionSetInlinePolicyState<'InlinePolicy, Missing, 'PermissionSetArn>, value: string) : SsoadminPermissionSetInlinePolicyState<'InlinePolicy, Present, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.InstanceArn <- value)
            ({ assignments = state.assignments } : SsoadminPermissionSetInlinePolicyState<'InlinePolicy, Present, 'PermissionSetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set_inline_policy#permission_set_arn-1">SsoadminPermissionSetInlinePolicy#permission_set_arn</a>.
        /// </summary>
        [<CustomOperation "permission_set_arn">]
        member _.PermissionSetArn(state: SsoadminPermissionSetInlinePolicyState<'InlinePolicy, 'InstanceArn, Missing>, value: string) : SsoadminPermissionSetInlinePolicyState<'InlinePolicy, 'InstanceArn, Present> =
            state.assignments.Add(fun config -> config.PermissionSetArn <- value)
            ({ assignments = state.assignments } : SsoadminPermissionSetInlinePolicyState<'InlinePolicy, 'InstanceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set_inline_policy#id-1">SsoadminPermissionSetInlinePolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsoadminPermissionSetInlinePolicyState<'InlinePolicy, 'InstanceArn, 'PermissionSetArn>, value: string) : SsoadminPermissionSetInlinePolicyState<'InlinePolicy, 'InstanceArn, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsoadminPermissionSetInlinePolicyState<'InlinePolicy, 'InstanceArn, 'PermissionSetArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set_inline_policy#timeouts-1">SsoadminPermissionSetInlinePolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SsoadminPermissionSetInlinePolicyState<'InlinePolicy, 'InstanceArn, 'PermissionSetArn>, value: aws.SsoadminPermissionSetInlinePolicy.SsoadminPermissionSetInlinePolicyTimeouts) : SsoadminPermissionSetInlinePolicyState<'InlinePolicy, 'InstanceArn, 'PermissionSetArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SsoadminPermissionSetInlinePolicyState<'InlinePolicy, 'InstanceArn, 'PermissionSetArn>

        member _.Run(state: SsoadminPermissionSetInlinePolicyState<Present, Present, Present>) : aws.SsoadminPermissionSetInlinePolicy.SsoadminPermissionSetInlinePolicy =
            let config = aws.SsoadminPermissionSetInlinePolicy.SsoadminPermissionSetInlinePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.SsoadminPermissionSetInlinePolicy.SsoadminPermissionSetInlinePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssoadminPermissionSetInlinePolicy: missing required arguments. Must call: inline_policy, instance_arn, permission_set_arn.", 9999, IsError = true)>]
        member _.Run(_: SsoadminPermissionSetInlinePolicyState<_, _, _>) : aws.SsoadminPermissionSetInlinePolicy.SsoadminPermissionSetInlinePolicy =
            Unchecked.defaultof<aws.SsoadminPermissionSetInlinePolicy.SsoadminPermissionSetInlinePolicy>
