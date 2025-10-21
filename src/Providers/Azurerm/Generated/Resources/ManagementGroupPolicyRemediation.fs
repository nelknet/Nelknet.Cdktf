namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId> = { assignments: ResizeArray<azurerm.ManagementGroupPolicyRemediation.ManagementGroupPolicyRemediationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation">azurerm_management_group_policy_remediation</a>.
    /// </summary>
    type ManagementGroupPolicyRemediationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagementGroupPolicyRemediationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagementGroupPolicyRemediationState<Missing, Missing, Missing>)

        member _.Zero(()) : ManagementGroupPolicyRemediationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagementGroupPolicyRemediationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#management_group_id-1">ManagementGroupPolicyRemediation#management_group_id</a>.
        /// </summary>
        [<CustomOperation "management_group_id">]
        member _.ManagementGroupId(state: ManagementGroupPolicyRemediationState<Missing, 'Name, 'PolicyAssignmentId>, value: string) : ManagementGroupPolicyRemediationState<Present, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.ManagementGroupId <- value)
            ({ assignments = state.assignments } : ManagementGroupPolicyRemediationState<Present, 'Name, 'PolicyAssignmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#name-1">ManagementGroupPolicyRemediation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ManagementGroupPolicyRemediationState<'ManagementGroupId, Missing, 'PolicyAssignmentId>, value: string) : ManagementGroupPolicyRemediationState<'ManagementGroupId, Present, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ManagementGroupPolicyRemediationState<'ManagementGroupId, Present, 'PolicyAssignmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#policy_assignment_id-1">ManagementGroupPolicyRemediation#policy_assignment_id</a>.
        /// </summary>
        [<CustomOperation "policy_assignment_id">]
        member _.PolicyAssignmentId(state: ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, Missing>, value: string) : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, Present> =
            state.assignments.Add(fun config -> config.PolicyAssignmentId <- value)
            ({ assignments = state.assignments } : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#failure_percentage-1">ManagementGroupPolicyRemediation#failure_percentage</a>.
        /// </summary>
        [<CustomOperation "failure_percentage">]
        member _.FailurePercentage(state: ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: double) : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.FailurePercentage <- value)
            state : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#id-1">ManagementGroupPolicyRemediation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: string) : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#location_filters-1">ManagementGroupPolicyRemediation#location_filters</a>.
        /// </summary>
        [<CustomOperation "location_filters">]
        member _.LocationFilters(state: ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: seq<string>) : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.LocationFilters <- (value |> Seq.toArray))
            state : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#parallel_deployments-1">ManagementGroupPolicyRemediation#parallel_deployments</a>.
        /// </summary>
        [<CustomOperation "parallel_deployments">]
        member _.ParallelDeployments(state: ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: double) : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.ParallelDeployments <- value)
            state : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#policy_definition_reference_id-1">ManagementGroupPolicyRemediation#policy_definition_reference_id</a>.
        /// </summary>
        [<CustomOperation "policy_definition_reference_id">]
        member _.PolicyDefinitionReferenceId(state: ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: string) : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.PolicyDefinitionReferenceId <- value)
            state : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#resource_count-1">ManagementGroupPolicyRemediation#resource_count</a>.
        /// </summary>
        [<CustomOperation "resource_count">]
        member _.ResourceCount(state: ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: double) : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.ResourceCount <- value)
            state : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_remediation#timeouts-1">ManagementGroupPolicyRemediation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>, value: azurerm.ManagementGroupPolicyRemediation.ManagementGroupPolicyRemediationTimeouts) : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ManagementGroupPolicyRemediationState<'ManagementGroupId, 'Name, 'PolicyAssignmentId>

        member _.Run(state: ManagementGroupPolicyRemediationState<Present, Present, Present>) : azurerm.ManagementGroupPolicyRemediation.ManagementGroupPolicyRemediation =
            let config = azurerm.ManagementGroupPolicyRemediation.ManagementGroupPolicyRemediationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ManagementGroupPolicyRemediation.ManagementGroupPolicyRemediation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.managementGroupPolicyRemediation: missing required arguments. Must call: management_group_id, name, policy_assignment_id.", 9999, IsError = true)>]
        member _.Run(_: ManagementGroupPolicyRemediationState<_, _, _>) : azurerm.ManagementGroupPolicyRemediation.ManagementGroupPolicyRemediation =
            Unchecked.defaultof<azurerm.ManagementGroupPolicyRemediation.ManagementGroupPolicyRemediation>
