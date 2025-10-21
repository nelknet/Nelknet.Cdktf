namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId> = { assignments: ResizeArray<azurerm.ResourceGroupPolicyRemediation.ResourceGroupPolicyRemediationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_remediation">azurerm_resource_group_policy_remediation</a>.
    /// </summary>
    type ResourceGroupPolicyRemediationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourceGroupPolicyRemediationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupPolicyRemediationState<Missing, Missing, Missing>)

        member _.Zero(()) : ResourceGroupPolicyRemediationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupPolicyRemediationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_remediation#name-1">ResourceGroupPolicyRemediation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourceGroupPolicyRemediationState<Missing, 'PolicyAssignmentId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyRemediationState<Present, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourceGroupPolicyRemediationState<Present, 'PolicyAssignmentId, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_remediation#policy_assignment_id-1">ResourceGroupPolicyRemediation#policy_assignment_id</a>.
        /// </summary>
        [<CustomOperation "policy_assignment_id">]
        member _.PolicyAssignmentId(state: ResourceGroupPolicyRemediationState<'Name, Missing, 'ResourceGroupId>, value: string) : ResourceGroupPolicyRemediationState<'Name, Present, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.PolicyAssignmentId <- value)
            ({ assignments = state.assignments } : ResourceGroupPolicyRemediationState<'Name, Present, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_remediation#resource_group_id-1">ResourceGroupPolicyRemediation#resource_group_id</a>.
        /// </summary>
        [<CustomOperation "resource_group_id">]
        member _.ResourceGroupId(state: ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, Missing>, value: string) : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupId <- value)
            ({ assignments = state.assignments } : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_remediation#failure_percentage-1">ResourceGroupPolicyRemediation#failure_percentage</a>.
        /// </summary>
        [<CustomOperation "failure_percentage">]
        member _.FailurePercentage(state: ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: double) : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.FailurePercentage <- value)
            state : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_remediation#id-1">ResourceGroupPolicyRemediation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_remediation#location_filters-1">ResourceGroupPolicyRemediation#location_filters</a>.
        /// </summary>
        [<CustomOperation "location_filters">]
        member _.LocationFilters(state: ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: seq<string>) : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.LocationFilters <- (value |> Seq.toArray))
            state : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_remediation#parallel_deployments-1">ResourceGroupPolicyRemediation#parallel_deployments</a>.
        /// </summary>
        [<CustomOperation "parallel_deployments">]
        member _.ParallelDeployments(state: ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: double) : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.ParallelDeployments <- value)
            state : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_remediation#policy_definition_reference_id-1">ResourceGroupPolicyRemediation#policy_definition_reference_id</a>.
        /// </summary>
        [<CustomOperation "policy_definition_reference_id">]
        member _.PolicyDefinitionReferenceId(state: ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.PolicyDefinitionReferenceId <- value)
            state : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_remediation#resource_count-1">ResourceGroupPolicyRemediation#resource_count</a>.
        /// </summary>
        [<CustomOperation "resource_count">]
        member _.ResourceCount(state: ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: double) : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.ResourceCount <- value)
            state : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_remediation#resource_discovery_mode-1">ResourceGroupPolicyRemediation#resource_discovery_mode</a>.
        /// </summary>
        [<CustomOperation "resource_discovery_mode">]
        member _.ResourceDiscoveryMode(state: ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.ResourceDiscoveryMode <- value)
            state : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_remediation#timeouts-1">ResourceGroupPolicyRemediation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>, value: azurerm.ResourceGroupPolicyRemediation.ResourceGroupPolicyRemediationTimeouts) : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourceGroupPolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceGroupId>

        member _.Run(state: ResourceGroupPolicyRemediationState<Present, Present, Present>) : azurerm.ResourceGroupPolicyRemediation.ResourceGroupPolicyRemediation =
            let config = azurerm.ResourceGroupPolicyRemediation.ResourceGroupPolicyRemediationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourceGroupPolicyRemediation.ResourceGroupPolicyRemediation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourceGroupPolicyRemediation: missing required arguments. Must call: name, policy_assignment_id, resource_group_id.", 9999, IsError = true)>]
        member _.Run(_: ResourceGroupPolicyRemediationState<_, _, _>) : azurerm.ResourceGroupPolicyRemediation.ResourceGroupPolicyRemediation =
            Unchecked.defaultof<azurerm.ResourceGroupPolicyRemediation.ResourceGroupPolicyRemediation>
