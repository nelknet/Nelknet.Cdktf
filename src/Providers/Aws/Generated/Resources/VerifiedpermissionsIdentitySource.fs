namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VerifiedpermissionsIdentitySourceState<'PolicyStoreId> = { assignments: ResizeArray<aws.VerifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source">aws_verifiedpermissions_identity_source</a>.
    /// </summary>
    type VerifiedpermissionsIdentitySourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : VerifiedpermissionsIdentitySourceState<Missing> =
            ({ assignments = ResizeArray() } : VerifiedpermissionsIdentitySourceState<Missing>)

        member _.Zero(()) : VerifiedpermissionsIdentitySourceState<Missing> =
            ({ assignments = ResizeArray() } : VerifiedpermissionsIdentitySourceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#policy_store_id-1">VerifiedpermissionsIdentitySource#policy_store_id</a>.
        /// </summary>
        [<CustomOperation "policy_store_id">]
        member _.PolicyStoreId(state: VerifiedpermissionsIdentitySourceState<Missing>, value: string) : VerifiedpermissionsIdentitySourceState<Present> =
            state.assignments.Add(fun config -> config.PolicyStoreId <- value)
            ({ assignments = state.assignments } : VerifiedpermissionsIdentitySourceState<Present>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#configuration-1">VerifiedpermissionsIdentitySource#configuration</a> Accepts: aws.IResolvable | aws.VerifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfiguration[]
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: VerifiedpermissionsIdentitySourceState<'PolicyStoreId>, value: HashiCorp.Cdktf.IResolvable) : VerifiedpermissionsIdentitySourceState<'PolicyStoreId> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : VerifiedpermissionsIdentitySourceState<'PolicyStoreId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_identity_source#principal_entity_type-1">VerifiedpermissionsIdentitySource#principal_entity_type</a>.
        /// </summary>
        [<CustomOperation "principal_entity_type">]
        member _.PrincipalEntityType(state: VerifiedpermissionsIdentitySourceState<'PolicyStoreId>, value: string) : VerifiedpermissionsIdentitySourceState<'PolicyStoreId> =
            state.assignments.Add(fun config -> config.PrincipalEntityType <- value)
            state : VerifiedpermissionsIdentitySourceState<'PolicyStoreId>

        member _.Run(state: VerifiedpermissionsIdentitySourceState<Present>) : aws.VerifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySource =
            let config = aws.VerifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySourceConfig()
            for setter in state.assignments do
                setter config
            aws.VerifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.verifiedpermissionsIdentitySource: missing required arguments. Must call: policy_store_id.", 9999, IsError = true)>]
        member _.Run(_: VerifiedpermissionsIdentitySourceState<_>) : aws.VerifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySource =
            Unchecked.defaultof<aws.VerifiedpermissionsIdentitySource.VerifiedpermissionsIdentitySource>
