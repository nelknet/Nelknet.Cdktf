namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId> = { assignments: ResizeArray<azurerm.SubscriptionPolicyRemediation.SubscriptionPolicyRemediationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_remediation">azurerm_subscription_policy_remediation</a>.
    /// </summary>
    type SubscriptionPolicyRemediationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SubscriptionPolicyRemediationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubscriptionPolicyRemediationState<Missing, Missing, Missing>)

        member _.Zero(()) : SubscriptionPolicyRemediationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SubscriptionPolicyRemediationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_remediation#name-1">SubscriptionPolicyRemediation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SubscriptionPolicyRemediationState<Missing, 'PolicyAssignmentId, 'SubscriptionId>, value: string) : SubscriptionPolicyRemediationState<Present, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SubscriptionPolicyRemediationState<Present, 'PolicyAssignmentId, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_remediation#policy_assignment_id-1">SubscriptionPolicyRemediation#policy_assignment_id</a>.
        /// </summary>
        [<CustomOperation "policy_assignment_id">]
        member _.PolicyAssignmentId(state: SubscriptionPolicyRemediationState<'Name, Missing, 'SubscriptionId>, value: string) : SubscriptionPolicyRemediationState<'Name, Present, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.PolicyAssignmentId <- value)
            ({ assignments = state.assignments } : SubscriptionPolicyRemediationState<'Name, Present, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_remediation#subscription_id-1">SubscriptionPolicyRemediation#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, Missing>, value: string) : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, Present> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_remediation#failure_percentage-1">SubscriptionPolicyRemediation#failure_percentage</a>.
        /// </summary>
        [<CustomOperation "failure_percentage">]
        member _.FailurePercentage(state: SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: double) : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.FailurePercentage <- value)
            state : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_remediation#id-1">SubscriptionPolicyRemediation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: string) : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_remediation#location_filters-1">SubscriptionPolicyRemediation#location_filters</a>.
        /// </summary>
        [<CustomOperation "location_filters">]
        member _.LocationFilters(state: SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: seq<string>) : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.LocationFilters <- (value |> Seq.toArray))
            state : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_remediation#parallel_deployments-1">SubscriptionPolicyRemediation#parallel_deployments</a>.
        /// </summary>
        [<CustomOperation "parallel_deployments">]
        member _.ParallelDeployments(state: SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: double) : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.ParallelDeployments <- value)
            state : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_remediation#policy_definition_reference_id-1">SubscriptionPolicyRemediation#policy_definition_reference_id</a>.
        /// </summary>
        [<CustomOperation "policy_definition_reference_id">]
        member _.PolicyDefinitionReferenceId(state: SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: string) : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.PolicyDefinitionReferenceId <- value)
            state : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_remediation#resource_count-1">SubscriptionPolicyRemediation#resource_count</a>.
        /// </summary>
        [<CustomOperation "resource_count">]
        member _.ResourceCount(state: SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: double) : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.ResourceCount <- value)
            state : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_remediation#resource_discovery_mode-1">SubscriptionPolicyRemediation#resource_discovery_mode</a>.
        /// </summary>
        [<CustomOperation "resource_discovery_mode">]
        member _.ResourceDiscoveryMode(state: SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: string) : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.ResourceDiscoveryMode <- value)
            state : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/subscription_policy_remediation#timeouts-1">SubscriptionPolicyRemediation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>, value: azurerm.SubscriptionPolicyRemediation.SubscriptionPolicyRemediationTimeouts) : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SubscriptionPolicyRemediationState<'Name, 'PolicyAssignmentId, 'SubscriptionId>

        member _.Run(state: SubscriptionPolicyRemediationState<Present, Present, Present>) : azurerm.SubscriptionPolicyRemediation.SubscriptionPolicyRemediation =
            let config = azurerm.SubscriptionPolicyRemediation.SubscriptionPolicyRemediationConfig()
            for setter in state.assignments do
                setter config
            azurerm.SubscriptionPolicyRemediation.SubscriptionPolicyRemediation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.subscriptionPolicyRemediation: missing required arguments. Must call: name, policy_assignment_id, subscription_id.", 9999, IsError = true)>]
        member _.Run(_: SubscriptionPolicyRemediationState<_, _, _>) : azurerm.SubscriptionPolicyRemediation.SubscriptionPolicyRemediation =
            Unchecked.defaultof<azurerm.SubscriptionPolicyRemediation.SubscriptionPolicyRemediation>
