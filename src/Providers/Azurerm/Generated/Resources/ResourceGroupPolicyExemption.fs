namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId> = { assignments: ResizeArray<azurerm.ResourceGroupPolicyExemption.ResourceGroupPolicyExemptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_exemption">azurerm_resource_group_policy_exemption</a>.
    /// </summary>
    type ResourceGroupPolicyExemptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourceGroupPolicyExemptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupPolicyExemptionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ResourceGroupPolicyExemptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupPolicyExemptionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_exemption#exemption_category-1">ResourceGroupPolicyExemption#exemption_category</a>.
        /// </summary>
        [<CustomOperation "exemption_category">]
        member _.ExemptionCategory(state: ResourceGroupPolicyExemptionState<Missing, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyExemptionState<Present, 'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.ExemptionCategory <- value)
            ({ assignments = state.assignments } : ResourceGroupPolicyExemptionState<Present, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_exemption#name-1">ResourceGroupPolicyExemption#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourceGroupPolicyExemptionState<'ExemptionCategory, Missing, 'PolicyAssignmentId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyExemptionState<'ExemptionCategory, Present, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourceGroupPolicyExemptionState<'ExemptionCategory, Present, 'PolicyAssignmentId, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_exemption#policy_assignment_id-1">ResourceGroupPolicyExemption#policy_assignment_id</a>.
        /// </summary>
        [<CustomOperation "policy_assignment_id">]
        member _.PolicyAssignmentId(state: ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, Missing, 'ResourceGroupId>, value: string) : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, Present, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.PolicyAssignmentId <- value)
            ({ assignments = state.assignments } : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, Present, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_exemption#resource_group_id-1">ResourceGroupPolicyExemption#resource_group_id</a>.
        /// </summary>
        [<CustomOperation "resource_group_id">]
        member _.ResourceGroupId(state: ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, Missing>, value: string) : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupId <- value)
            ({ assignments = state.assignments } : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_exemption#description-1">ResourceGroupPolicyExemption#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_exemption#display_name-1">ResourceGroupPolicyExemption#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_exemption#expires_on-1">ResourceGroupPolicyExemption#expires_on</a>.
        /// </summary>
        [<CustomOperation "expires_on">]
        member _.ExpiresOn(state: ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.ExpiresOn <- value)
            state : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_exemption#id-1">ResourceGroupPolicyExemption#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_exemption#metadata-1">ResourceGroupPolicyExemption#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_exemption#policy_definition_reference_ids-1">ResourceGroupPolicyExemption#policy_definition_reference_ids</a>.
        /// </summary>
        [<CustomOperation "policy_definition_reference_ids">]
        member _.PolicyDefinitionReferenceIds(state: ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: seq<string>) : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.PolicyDefinitionReferenceIds <- (value |> Seq.toArray))
            state : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_exemption#timeouts-1">ResourceGroupPolicyExemption#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: azurerm.ResourceGroupPolicyExemption.ResourceGroupPolicyExemptionTimeouts) : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourceGroupPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        member _.Run(state: ResourceGroupPolicyExemptionState<Present, Present, Present, Present>) : azurerm.ResourceGroupPolicyExemption.ResourceGroupPolicyExemption =
            let config = azurerm.ResourceGroupPolicyExemption.ResourceGroupPolicyExemptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourceGroupPolicyExemption.ResourceGroupPolicyExemption(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourceGroupPolicyExemption: missing required arguments. Must call: exemption_category, name, policy_assignment_id, resource_group_id.", 9999, IsError = true)>]
        member _.Run(_: ResourceGroupPolicyExemptionState<_, _, _, _>) : azurerm.ResourceGroupPolicyExemption.ResourceGroupPolicyExemption =
            Unchecked.defaultof<azurerm.ResourceGroupPolicyExemption.ResourceGroupPolicyExemption>
