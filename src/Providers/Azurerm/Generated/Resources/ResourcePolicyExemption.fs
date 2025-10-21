namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId> = { assignments: ResizeArray<azurerm.ResourcePolicyExemption.ResourcePolicyExemptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_exemption">azurerm_resource_policy_exemption</a>.
    /// </summary>
    type ResourcePolicyExemptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourcePolicyExemptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourcePolicyExemptionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ResourcePolicyExemptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourcePolicyExemptionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_exemption#exemption_category-1">ResourcePolicyExemption#exemption_category</a>.
        /// </summary>
        [<CustomOperation "exemption_category">]
        member _.ExemptionCategory(state: ResourcePolicyExemptionState<Missing, 'Name, 'PolicyAssignmentId, 'ResourceId>, value: string) : ResourcePolicyExemptionState<Present, 'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.ExemptionCategory <- value)
            ({ assignments = state.assignments } : ResourcePolicyExemptionState<Present, 'Name, 'PolicyAssignmentId, 'ResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_exemption#name-1">ResourcePolicyExemption#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourcePolicyExemptionState<'ExemptionCategory, Missing, 'PolicyAssignmentId, 'ResourceId>, value: string) : ResourcePolicyExemptionState<'ExemptionCategory, Present, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourcePolicyExemptionState<'ExemptionCategory, Present, 'PolicyAssignmentId, 'ResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_exemption#policy_assignment_id-1">ResourcePolicyExemption#policy_assignment_id</a>.
        /// </summary>
        [<CustomOperation "policy_assignment_id">]
        member _.PolicyAssignmentId(state: ResourcePolicyExemptionState<'ExemptionCategory, 'Name, Missing, 'ResourceId>, value: string) : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, Present, 'ResourceId> =
            state.assignments.Add(fun config -> config.PolicyAssignmentId <- value)
            ({ assignments = state.assignments } : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, Present, 'ResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_exemption#resource_id-1">ResourcePolicyExemption#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, Missing>, value: string) : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, Present> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_exemption#description-1">ResourcePolicyExemption#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>, value: string) : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_exemption#display_name-1">ResourcePolicyExemption#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>, value: string) : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_exemption#expires_on-1">ResourcePolicyExemption#expires_on</a>.
        /// </summary>
        [<CustomOperation "expires_on">]
        member _.ExpiresOn(state: ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>, value: string) : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.ExpiresOn <- value)
            state : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_exemption#id-1">ResourcePolicyExemption#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>, value: string) : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_exemption#metadata-1">ResourcePolicyExemption#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>, value: string) : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_exemption#policy_definition_reference_ids-1">ResourcePolicyExemption#policy_definition_reference_ids</a>.
        /// </summary>
        [<CustomOperation "policy_definition_reference_ids">]
        member _.PolicyDefinitionReferenceIds(state: ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>, value: seq<string>) : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.PolicyDefinitionReferenceIds <- (value |> Seq.toArray))
            state : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_exemption#timeouts-1">ResourcePolicyExemption#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>, value: azurerm.ResourcePolicyExemption.ResourcePolicyExemptionTimeouts) : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourcePolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'ResourceId>

        member _.Run(state: ResourcePolicyExemptionState<Present, Present, Present, Present>) : azurerm.ResourcePolicyExemption.ResourcePolicyExemption =
            let config = azurerm.ResourcePolicyExemption.ResourcePolicyExemptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourcePolicyExemption.ResourcePolicyExemption(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourcePolicyExemption: missing required arguments. Must call: exemption_category, name, policy_assignment_id, resource_id.", 9999, IsError = true)>]
        member _.Run(_: ResourcePolicyExemptionState<_, _, _, _>) : azurerm.ResourcePolicyExemption.ResourcePolicyExemption =
            Unchecked.defaultof<azurerm.ResourcePolicyExemption.ResourcePolicyExemption>
