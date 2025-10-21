namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId> = { assignments: ResizeArray<azurerm.SubscriptionPolicyExemption.SubscriptionPolicyExemptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_exemption">azurerm_subscription_policy_exemption</a>.
    /// </summary>
    type SubscriptionPolicyExemptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubscriptionPolicyExemptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubscriptionPolicyExemptionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SubscriptionPolicyExemptionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubscriptionPolicyExemptionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_exemption#exemption_category-1">SubscriptionPolicyExemption#exemption_category</a>.
        /// </summary>
        [<CustomOperation "exemption_category">]
        member _.ExemptionCategory(state: SubscriptionPolicyExemptionState<Missing, 'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: string) : SubscriptionPolicyExemptionState<Present, 'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.ExemptionCategory <- value)
            ({ assignments = state.assignments } : SubscriptionPolicyExemptionState<Present, 'Name, 'PolicyAssignmentId, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_exemption#name-1">SubscriptionPolicyExemption#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SubscriptionPolicyExemptionState<'ExemptionCategory, Missing, 'PolicyAssignmentId, 'SubscriptionId>, value: string) : SubscriptionPolicyExemptionState<'ExemptionCategory, Present, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SubscriptionPolicyExemptionState<'ExemptionCategory, Present, 'PolicyAssignmentId, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_exemption#policy_assignment_id-1">SubscriptionPolicyExemption#policy_assignment_id</a>.
        /// </summary>
        [<CustomOperation "policy_assignment_id">]
        member _.PolicyAssignmentId(state: SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, Missing, 'SubscriptionId>, value: string) : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, Present, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.PolicyAssignmentId <- value)
            ({ assignments = state.assignments } : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, Present, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_exemption#subscription_id-1">SubscriptionPolicyExemption#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, Missing>, value: string) : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, Present> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_exemption#description-1">SubscriptionPolicyExemption#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: string) : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_exemption#display_name-1">SubscriptionPolicyExemption#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: string) : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_exemption#expires_on-1">SubscriptionPolicyExemption#expires_on</a>.
        /// </summary>
        [<CustomOperation "expires_on">]
        member _.ExpiresOn(state: SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: string) : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.ExpiresOn <- value)
            state : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_exemption#id-1">SubscriptionPolicyExemption#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: string) : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_exemption#metadata-1">SubscriptionPolicyExemption#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: string) : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_exemption#policy_definition_reference_ids-1">SubscriptionPolicyExemption#policy_definition_reference_ids</a>.
        /// </summary>
        [<CustomOperation "policy_definition_reference_ids">]
        member _.PolicyDefinitionReferenceIds(state: SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: seq<string>) : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.PolicyDefinitionReferenceIds <- (value |> Seq.toArray))
            state : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_exemption#timeouts-1">SubscriptionPolicyExemption#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: azurerm.SubscriptionPolicyExemption.SubscriptionPolicyExemptionTimeouts) : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubscriptionPolicyExemptionState<'ExemptionCategory, 'Name, 'PolicyAssignmentId, 'SubscriptionId>

        member _.Run(state: SubscriptionPolicyExemptionState<Present, Present, Present, Present>) : azurerm.SubscriptionPolicyExemption.SubscriptionPolicyExemption =
            let config = azurerm.SubscriptionPolicyExemption.SubscriptionPolicyExemptionConfig()
            for setter in state.assignments do
                setter config
            azurerm.SubscriptionPolicyExemption.SubscriptionPolicyExemption(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.subscriptionPolicyExemption: missing required arguments. Must call: exemption_category, name, policy_assignment_id, subscription_id.", 9999, IsError = true)>]
        member _.Run(_: SubscriptionPolicyExemptionState<_, _, _, _>) : azurerm.SubscriptionPolicyExemption.SubscriptionPolicyExemption =
            Unchecked.defaultof<azurerm.SubscriptionPolicyExemption.SubscriptionPolicyExemption>
