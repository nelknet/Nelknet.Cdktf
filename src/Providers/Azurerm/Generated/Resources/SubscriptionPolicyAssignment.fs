namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> = { assignments: ResizeArray<azurerm.SubscriptionPolicyAssignment.SubscriptionPolicyAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment">azurerm_subscription_policy_assignment</a>.
    /// </summary>
    type SubscriptionPolicyAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubscriptionPolicyAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubscriptionPolicyAssignmentState<Missing, Missing, Missing>)

        member _.Zero(()) : SubscriptionPolicyAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubscriptionPolicyAssignmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#name-1">SubscriptionPolicyAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SubscriptionPolicyAssignmentState<Missing, 'PolicyDefinitionId, 'SubscriptionId>, value: string) : SubscriptionPolicyAssignmentState<Present, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SubscriptionPolicyAssignmentState<Present, 'PolicyDefinitionId, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#policy_definition_id-1">SubscriptionPolicyAssignment#policy_definition_id</a>.
        /// </summary>
        [<CustomOperation "policy_definition_id">]
        member _.PolicyDefinitionId(state: SubscriptionPolicyAssignmentState<'Name, Missing, 'SubscriptionId>, value: string) : SubscriptionPolicyAssignmentState<'Name, Present, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.PolicyDefinitionId <- value)
            ({ assignments = state.assignments } : SubscriptionPolicyAssignmentState<'Name, Present, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#subscription_id-1">SubscriptionPolicyAssignment#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, Missing>, value: string) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, Present> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#description-1">SubscriptionPolicyAssignment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: string) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#display_name-1">SubscriptionPolicyAssignment#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: string) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#enforce-1">SubscriptionPolicyAssignment#enforce</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enforce">]
        member _.Enforce(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: bool) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Enforce <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#enforce-1">SubscriptionPolicyAssignment#enforce</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enforce">]
        member _.Enforce(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: HashiCorp.Cdktf.IResolvable) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Enforce <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#id-1">SubscriptionPolicyAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: string) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#identity-1">SubscriptionPolicyAssignment#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: azurerm.SubscriptionPolicyAssignment.SubscriptionPolicyAssignmentIdentity) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#location-1">SubscriptionPolicyAssignment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: string) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Location <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#metadata-1">SubscriptionPolicyAssignment#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: string) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// non_compliance_message block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#non_compliance_message-1">SubscriptionPolicyAssignment#non_compliance_message</a> Accepts: azurerm.IResolvable | azurerm.SubscriptionPolicyAssignment.SubscriptionPolicyAssignmentNonComplianceMessage[]
        /// </summary>
        [<CustomOperation "non_compliance_message">]
        member _.NonComplianceMessage(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: HashiCorp.Cdktf.IResolvable) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.NonComplianceMessage <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#not_scopes-1">SubscriptionPolicyAssignment#not_scopes</a>.
        /// </summary>
        [<CustomOperation "not_scopes">]
        member _.NotScopes(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: seq<string>) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.NotScopes <- (value |> Seq.toArray))
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// overrides block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#overrides-1">SubscriptionPolicyAssignment#overrides</a> Accepts: azurerm.IResolvable | azurerm.SubscriptionPolicyAssignment.SubscriptionPolicyAssignmentOverrides[]
        /// </summary>
        [<CustomOperation "overrides">]
        member _.Overrides(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: HashiCorp.Cdktf.IResolvable) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Overrides <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#parameters-1">SubscriptionPolicyAssignment#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: string) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// resource_selectors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#resource_selectors-1">SubscriptionPolicyAssignment#resource_selectors</a> Accepts: azurerm.IResolvable | azurerm.SubscriptionPolicyAssignment.SubscriptionPolicyAssignmentResourceSelectors[]
        /// </summary>
        [<CustomOperation "resource_selectors">]
        member _.ResourceSelectors(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: HashiCorp.Cdktf.IResolvable) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.ResourceSelectors <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_assignment#timeouts-1">SubscriptionPolicyAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>, value: azurerm.SubscriptionPolicyAssignment.SubscriptionPolicyAssignmentTimeouts) : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubscriptionPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'SubscriptionId>

        member _.Run(state: SubscriptionPolicyAssignmentState<Present, Present, Present>) : azurerm.SubscriptionPolicyAssignment.SubscriptionPolicyAssignment =
            let config = azurerm.SubscriptionPolicyAssignment.SubscriptionPolicyAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.SubscriptionPolicyAssignment.SubscriptionPolicyAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.subscriptionPolicyAssignment: missing required arguments. Must call: name, policy_definition_id, subscription_id.", 9999, IsError = true)>]
        member _.Run(_: SubscriptionPolicyAssignmentState<_, _, _>) : azurerm.SubscriptionPolicyAssignment.SubscriptionPolicyAssignment =
            Unchecked.defaultof<azurerm.SubscriptionPolicyAssignment.SubscriptionPolicyAssignment>
