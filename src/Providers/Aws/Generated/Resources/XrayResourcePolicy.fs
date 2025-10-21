namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type XrayResourcePolicyState<'PolicyDocument, 'PolicyName> = { assignments: ResizeArray<aws.XrayResourcePolicy.XrayResourcePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_resource_policy">aws_xray_resource_policy</a>.
    /// </summary>
    type XrayResourcePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : XrayResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : XrayResourcePolicyState<Missing, Missing>)

        member _.Zero(()) : XrayResourcePolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : XrayResourcePolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_resource_policy#policy_document-1">XrayResourcePolicy#policy_document</a>.
        /// </summary>
        [<CustomOperation "policy_document">]
        member _.PolicyDocument(state: XrayResourcePolicyState<Missing, 'PolicyName>, value: string) : XrayResourcePolicyState<Present, 'PolicyName> =
            state.assignments.Add(fun config -> config.PolicyDocument <- value)
            ({ assignments = state.assignments } : XrayResourcePolicyState<Present, 'PolicyName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_resource_policy#policy_name-1">XrayResourcePolicy#policy_name</a>.
        /// </summary>
        [<CustomOperation "policy_name">]
        member _.PolicyName(state: XrayResourcePolicyState<'PolicyDocument, Missing>, value: string) : XrayResourcePolicyState<'PolicyDocument, Present> =
            state.assignments.Add(fun config -> config.PolicyName <- value)
            ({ assignments = state.assignments } : XrayResourcePolicyState<'PolicyDocument, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_resource_policy#bypass_policy_lockout_check-1">XrayResourcePolicy#bypass_policy_lockout_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_check">]
        member _.BypassPolicyLockoutCheck(state: XrayResourcePolicyState<'PolicyDocument, 'PolicyName>, value: bool) : XrayResourcePolicyState<'PolicyDocument, 'PolicyName> =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutCheck <- value)
            state : XrayResourcePolicyState<'PolicyDocument, 'PolicyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_resource_policy#bypass_policy_lockout_check-1">XrayResourcePolicy#bypass_policy_lockout_check</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bypass_policy_lockout_check">]
        member _.BypassPolicyLockoutCheck(state: XrayResourcePolicyState<'PolicyDocument, 'PolicyName>, value: HashiCorp.Cdktf.IResolvable) : XrayResourcePolicyState<'PolicyDocument, 'PolicyName> =
            state.assignments.Add(fun config -> config.BypassPolicyLockoutCheck <- value)
            state : XrayResourcePolicyState<'PolicyDocument, 'PolicyName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_resource_policy#policy_revision_id-1">XrayResourcePolicy#policy_revision_id</a>.
        /// </summary>
        [<CustomOperation "policy_revision_id">]
        member _.PolicyRevisionId(state: XrayResourcePolicyState<'PolicyDocument, 'PolicyName>, value: string) : XrayResourcePolicyState<'PolicyDocument, 'PolicyName> =
            state.assignments.Add(fun config -> config.PolicyRevisionId <- value)
            state : XrayResourcePolicyState<'PolicyDocument, 'PolicyName>

        member _.Run(state: XrayResourcePolicyState<Present, Present>) : aws.XrayResourcePolicy.XrayResourcePolicy =
            let config = aws.XrayResourcePolicy.XrayResourcePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.XrayResourcePolicy.XrayResourcePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.xrayResourcePolicy: missing required arguments. Must call: policy_document, policy_name.", 9999, IsError = true)>]
        member _.Run(_: XrayResourcePolicyState<_, _>) : aws.XrayResourcePolicy.XrayResourcePolicy =
            Unchecked.defaultof<aws.XrayResourcePolicy.XrayResourcePolicy>
