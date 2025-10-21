namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VerifiedpermissionsPolicyState<'PolicyStoreId> = { assignments: ResizeArray<aws.VerifiedpermissionsPolicy.VerifiedpermissionsPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy">aws_verifiedpermissions_policy</a>.
    /// </summary>
    type VerifiedpermissionsPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : VerifiedpermissionsPolicyState<Missing> =
            ({ assignments = ResizeArray() } : VerifiedpermissionsPolicyState<Missing>)

        member _.Zero(()) : VerifiedpermissionsPolicyState<Missing> =
            ({ assignments = ResizeArray() } : VerifiedpermissionsPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#policy_store_id-1">VerifiedpermissionsPolicy#policy_store_id</a>.
        /// </summary>
        [<CustomOperation "policy_store_id">]
        member _.PolicyStoreId(state: VerifiedpermissionsPolicyState<Missing>, value: string) : VerifiedpermissionsPolicyState<Present> =
            state.assignments.Add(fun config -> config.PolicyStoreId <- value)
            ({ assignments = state.assignments } : VerifiedpermissionsPolicyState<Present>)

        /// <summary>
        /// definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#definition-1">VerifiedpermissionsPolicy#definition</a> Accepts: aws.IResolvable | aws.VerifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinition[]
        /// </summary>
        [<CustomOperation "definition">]
        member _.Definition(state: VerifiedpermissionsPolicyState<'PolicyStoreId>, value: HashiCorp.Cdktf.IResolvable) : VerifiedpermissionsPolicyState<'PolicyStoreId> =
            state.assignments.Add(fun config -> config.Definition <- value)
            state : VerifiedpermissionsPolicyState<'PolicyStoreId>

        member _.Run(state: VerifiedpermissionsPolicyState<Present>) : aws.VerifiedpermissionsPolicy.VerifiedpermissionsPolicy =
            let config = aws.VerifiedpermissionsPolicy.VerifiedpermissionsPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.VerifiedpermissionsPolicy.VerifiedpermissionsPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.verifiedpermissionsPolicy: missing required arguments. Must call: policy_store_id.", 9999, IsError = true)>]
        member _.Run(_: VerifiedpermissionsPolicyState<_>) : aws.VerifiedpermissionsPolicy.VerifiedpermissionsPolicy =
            Unchecked.defaultof<aws.VerifiedpermissionsPolicy.VerifiedpermissionsPolicy>
