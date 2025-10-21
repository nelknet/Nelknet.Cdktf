namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubConfigurationPolicyAssociationState<'PolicyId, 'TargetId> = { assignments: ResizeArray<aws.SecurityhubConfigurationPolicyAssociation.SecurityhubConfigurationPolicyAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy_association">aws_securityhub_configuration_policy_association</a>.
    /// </summary>
    type SecurityhubConfigurationPolicyAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubConfigurationPolicyAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubConfigurationPolicyAssociationState<Missing, Missing>)

        member _.Zero(()) : SecurityhubConfigurationPolicyAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubConfigurationPolicyAssociationState<Missing, Missing>)

        /// <summary>
        /// The universally unique identifier (UUID) of the configuration policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy_association#policy_id-1">SecurityhubConfigurationPolicyAssociation#policy_id</a>
        /// </summary>
        [<CustomOperation "policy_id">]
        member _.PolicyId(state: SecurityhubConfigurationPolicyAssociationState<Missing, 'TargetId>, value: string) : SecurityhubConfigurationPolicyAssociationState<Present, 'TargetId> =
            state.assignments.Add(fun config -> config.PolicyId <- value)
            ({ assignments = state.assignments } : SecurityhubConfigurationPolicyAssociationState<Present, 'TargetId>)

        /// <summary>
        /// The identifier of the target account, organizational unit, or the root to associate with the specified configuration. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy_association#target_id-1">SecurityhubConfigurationPolicyAssociation#target_id</a>
        /// </summary>
        [<CustomOperation "target_id">]
        member _.TargetId(state: SecurityhubConfigurationPolicyAssociationState<'PolicyId, Missing>, value: string) : SecurityhubConfigurationPolicyAssociationState<'PolicyId, Present> =
            state.assignments.Add(fun config -> config.TargetId <- value)
            ({ assignments = state.assignments } : SecurityhubConfigurationPolicyAssociationState<'PolicyId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy_association#id-1">SecurityhubConfigurationPolicyAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubConfigurationPolicyAssociationState<'PolicyId, 'TargetId>, value: string) : SecurityhubConfigurationPolicyAssociationState<'PolicyId, 'TargetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubConfigurationPolicyAssociationState<'PolicyId, 'TargetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_configuration_policy_association#timeouts-1">SecurityhubConfigurationPolicyAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityhubConfigurationPolicyAssociationState<'PolicyId, 'TargetId>, value: aws.SecurityhubConfigurationPolicyAssociation.SecurityhubConfigurationPolicyAssociationTimeouts) : SecurityhubConfigurationPolicyAssociationState<'PolicyId, 'TargetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityhubConfigurationPolicyAssociationState<'PolicyId, 'TargetId>

        member _.Run(state: SecurityhubConfigurationPolicyAssociationState<Present, Present>) : aws.SecurityhubConfigurationPolicyAssociation.SecurityhubConfigurationPolicyAssociation =
            let config = aws.SecurityhubConfigurationPolicyAssociation.SecurityhubConfigurationPolicyAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubConfigurationPolicyAssociation.SecurityhubConfigurationPolicyAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubConfigurationPolicyAssociation: missing required arguments. Must call: policy_id, target_id.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubConfigurationPolicyAssociationState<_, _>) : aws.SecurityhubConfigurationPolicyAssociation.SecurityhubConfigurationPolicyAssociation =
            Unchecked.defaultof<aws.SecurityhubConfigurationPolicyAssociation.SecurityhubConfigurationPolicyAssociation>
