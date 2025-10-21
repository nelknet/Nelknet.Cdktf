namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ShieldDrtAccessRoleArnAssociationState<'RoleArn> = { assignments: ResizeArray<aws.ShieldDrtAccessRoleArnAssociation.ShieldDrtAccessRoleArnAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_drt_access_role_arn_association">aws_shield_drt_access_role_arn_association</a>.
    /// </summary>
    type ShieldDrtAccessRoleArnAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ShieldDrtAccessRoleArnAssociationState<Missing> =
            ({ assignments = ResizeArray() } : ShieldDrtAccessRoleArnAssociationState<Missing>)

        member _.Zero(()) : ShieldDrtAccessRoleArnAssociationState<Missing> =
            ({ assignments = ResizeArray() } : ShieldDrtAccessRoleArnAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_drt_access_role_arn_association#role_arn-1">ShieldDrtAccessRoleArnAssociation#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: ShieldDrtAccessRoleArnAssociationState<Missing>, value: string) : ShieldDrtAccessRoleArnAssociationState<Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : ShieldDrtAccessRoleArnAssociationState<Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_drt_access_role_arn_association#timeouts-1">ShieldDrtAccessRoleArnAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ShieldDrtAccessRoleArnAssociationState<'RoleArn>, value: aws.ShieldDrtAccessRoleArnAssociation.ShieldDrtAccessRoleArnAssociationTimeouts) : ShieldDrtAccessRoleArnAssociationState<'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ShieldDrtAccessRoleArnAssociationState<'RoleArn>

        member _.Run(state: ShieldDrtAccessRoleArnAssociationState<Present>) : aws.ShieldDrtAccessRoleArnAssociation.ShieldDrtAccessRoleArnAssociation =
            let config = aws.ShieldDrtAccessRoleArnAssociation.ShieldDrtAccessRoleArnAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ShieldDrtAccessRoleArnAssociation.ShieldDrtAccessRoleArnAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.shieldDrtAccessRoleArnAssociation: missing required arguments. Must call: role_arn.", 9999, IsError = true)>]
        member _.Run(_: ShieldDrtAccessRoleArnAssociationState<_>) : aws.ShieldDrtAccessRoleArnAssociation.ShieldDrtAccessRoleArnAssociation =
            Unchecked.defaultof<aws.ShieldDrtAccessRoleArnAssociation.ShieldDrtAccessRoleArnAssociation>
