namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ShieldProtectionHealthCheckAssociationState<'HealthCheckArn, 'ShieldProtectionId> = { assignments: ResizeArray<aws.ShieldProtectionHealthCheckAssociation.ShieldProtectionHealthCheckAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_health_check_association">aws_shield_protection_health_check_association</a>.
    /// </summary>
    type ShieldProtectionHealthCheckAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ShieldProtectionHealthCheckAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ShieldProtectionHealthCheckAssociationState<Missing, Missing>)

        member _.Zero(()) : ShieldProtectionHealthCheckAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ShieldProtectionHealthCheckAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_health_check_association#health_check_arn-1">ShieldProtectionHealthCheckAssociation#health_check_arn</a>.
        /// </summary>
        [<CustomOperation "health_check_arn">]
        member _.HealthCheckArn(state: ShieldProtectionHealthCheckAssociationState<Missing, 'ShieldProtectionId>, value: string) : ShieldProtectionHealthCheckAssociationState<Present, 'ShieldProtectionId> =
            state.assignments.Add(fun config -> config.HealthCheckArn <- value)
            ({ assignments = state.assignments } : ShieldProtectionHealthCheckAssociationState<Present, 'ShieldProtectionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_health_check_association#shield_protection_id-1">ShieldProtectionHealthCheckAssociation#shield_protection_id</a>.
        /// </summary>
        [<CustomOperation "shield_protection_id">]
        member _.ShieldProtectionId(state: ShieldProtectionHealthCheckAssociationState<'HealthCheckArn, Missing>, value: string) : ShieldProtectionHealthCheckAssociationState<'HealthCheckArn, Present> =
            state.assignments.Add(fun config -> config.ShieldProtectionId <- value)
            ({ assignments = state.assignments } : ShieldProtectionHealthCheckAssociationState<'HealthCheckArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_protection_health_check_association#id-1">ShieldProtectionHealthCheckAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ShieldProtectionHealthCheckAssociationState<'HealthCheckArn, 'ShieldProtectionId>, value: string) : ShieldProtectionHealthCheckAssociationState<'HealthCheckArn, 'ShieldProtectionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ShieldProtectionHealthCheckAssociationState<'HealthCheckArn, 'ShieldProtectionId>

        member _.Run(state: ShieldProtectionHealthCheckAssociationState<Present, Present>) : aws.ShieldProtectionHealthCheckAssociation.ShieldProtectionHealthCheckAssociation =
            let config = aws.ShieldProtectionHealthCheckAssociation.ShieldProtectionHealthCheckAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ShieldProtectionHealthCheckAssociation.ShieldProtectionHealthCheckAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.shieldProtectionHealthCheckAssociation: missing required arguments. Must call: health_check_arn, shield_protection_id.", 9999, IsError = true)>]
        member _.Run(_: ShieldProtectionHealthCheckAssociationState<_, _>) : aws.ShieldProtectionHealthCheckAssociation.ShieldProtectionHealthCheckAssociation =
            Unchecked.defaultof<aws.ShieldProtectionHealthCheckAssociation.ShieldProtectionHealthCheckAssociation>
