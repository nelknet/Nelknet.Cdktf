namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId> = { assignments: ResizeArray<azurerm.ManagementGroupPolicyExemption.ManagementGroupPolicyExemptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_exemption">azurerm_management_group_policy_exemption</a>.
    /// </summary>
    type ManagementGroupPolicyExemptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagementGroupPolicyExemptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagementGroupPolicyExemptionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ManagementGroupPolicyExemptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagementGroupPolicyExemptionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_exemption#exemption_category-1">ManagementGroupPolicyExemption#exemption_category</a>.
        /// </summary>
        [<CustomOperation "exemption_category">]
        member _.ExemptionCategory(state: ManagementGroupPolicyExemptionState<Missing, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: string) : ManagementGroupPolicyExemptionState<Present, 'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.ExemptionCategory <- value)
            ({ assignments = state.assignments } : ManagementGroupPolicyExemptionState<Present, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_exemption#management_group_id-1">ManagementGroupPolicyExemption#management_group_id</a>.
        /// </summary>
        [<CustomOperation "management_group_id">]
        member _.ManagementGroupId(state: ManagementGroupPolicyExemptionState<'ExemptionCategory, Missing, 'Name, 'PolicyAssignmentId>, value: string) : ManagementGroupPolicyExemptionState<'ExemptionCategory, Present, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.ManagementGroupId <- value)
            ({ assignments = state.assignments } : ManagementGroupPolicyExemptionState<'ExemptionCategory, Present, 'Name, 'PolicyAssignmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_exemption#name-1">ManagementGroupPolicyExemption#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, Missing, 'PolicyAssignmentId>, value: string) : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, Present, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, Present, 'PolicyAssignmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_exemption#policy_assignment_id-1">ManagementGroupPolicyExemption#policy_assignment_id</a>.
        /// </summary>
        [<CustomOperation "policy_assignment_id">]
        member _.PolicyAssignmentId(state: ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, Missing>, value: string) : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, Present> =
            state.assignments.Add(fun config -> config.PolicyAssignmentId <- value)
            ({ assignments = state.assignments } : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_exemption#description-1">ManagementGroupPolicyExemption#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: string) : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_exemption#display_name-1">ManagementGroupPolicyExemption#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: string) : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_exemption#expires_on-1">ManagementGroupPolicyExemption#expires_on</a>.
        /// </summary>
        [<CustomOperation "expires_on">]
        member _.ExpiresOn(state: ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: string) : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.ExpiresOn <- value)
            state : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_exemption#id-1">ManagementGroupPolicyExemption#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: string) : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_exemption#metadata-1">ManagementGroupPolicyExemption#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: string) : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_exemption#policy_definition_reference_ids-1">ManagementGroupPolicyExemption#policy_definition_reference_ids</a>.
        /// </summary>
        [<CustomOperation "policy_definition_reference_ids">]
        member _.PolicyDefinitionReferenceIds(state: ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: seq<string>) : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.PolicyDefinitionReferenceIds <- (value |> Seq.toArray))
            state : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_exemption#timeouts-1">ManagementGroupPolicyExemption#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: azurerm.ManagementGroupPolicyExemption.ManagementGroupPolicyExemptionTimeouts) : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ManagementGroupPolicyExemptionState<'ExemptionCategory, 'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        member _.Run(state: ManagementGroupPolicyExemptionState<Present, Present, Present, Present>) : azurerm.ManagementGroupPolicyExemption.ManagementGroupPolicyExemption =
            let config = azurerm.ManagementGroupPolicyExemption.ManagementGroupPolicyExemptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ManagementGroupPolicyExemption.ManagementGroupPolicyExemption(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.managementGroupPolicyExemption: missing required arguments. Must call: exemption_category, management_group_id, name, policy_assignment_id.", 9999, IsError = true)>]
        member _.Run(_: ManagementGroupPolicyExemptionState<_, _, _, _>) : azurerm.ManagementGroupPolicyExemption.ManagementGroupPolicyExemption =
            Unchecked.defaultof<azurerm.ManagementGroupPolicyExemption.ManagementGroupPolicyExemption>
