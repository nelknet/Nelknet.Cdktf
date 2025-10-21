namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId> = { assignments: ResizeArray<azurerm.ResourcePolicyRemediation.ResourcePolicyRemediationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_remediation">azurerm_resource_policy_remediation</a>.
    /// </summary>
    type ResourcePolicyRemediationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourcePolicyRemediationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourcePolicyRemediationState<Missing, Missing, Missing>)

        member _.Zero(()) : ResourcePolicyRemediationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourcePolicyRemediationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_remediation#name-1">ResourcePolicyRemediation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourcePolicyRemediationState<Missing, 'PolicyAssignmentId, 'ResourceId>, value: string) : ResourcePolicyRemediationState<Present, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourcePolicyRemediationState<Present, 'PolicyAssignmentId, 'ResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_remediation#policy_assignment_id-1">ResourcePolicyRemediation#policy_assignment_id</a>.
        /// </summary>
        [<CustomOperation "policy_assignment_id">]
        member _.PolicyAssignmentId(state: ResourcePolicyRemediationState<'Name, Missing, 'ResourceId>, value: string) : ResourcePolicyRemediationState<'Name, Present, 'ResourceId> =
            state.assignments.Add(fun config -> config.PolicyAssignmentId <- value)
            ({ assignments = state.assignments } : ResourcePolicyRemediationState<'Name, Present, 'ResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_remediation#resource_id-1">ResourcePolicyRemediation#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, Missing>, value: string) : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, Present> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_remediation#failure_percentage-1">ResourcePolicyRemediation#failure_percentage</a>.
        /// </summary>
        [<CustomOperation "failure_percentage">]
        member _.FailurePercentage(state: ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>, value: double) : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.FailurePercentage <- value)
            state : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_remediation#id-1">ResourcePolicyRemediation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>, value: string) : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_remediation#location_filters-1">ResourcePolicyRemediation#location_filters</a>.
        /// </summary>
        [<CustomOperation "location_filters">]
        member _.LocationFilters(state: ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>, value: seq<string>) : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.LocationFilters <- (value |> Seq.toArray))
            state : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_remediation#parallel_deployments-1">ResourcePolicyRemediation#parallel_deployments</a>.
        /// </summary>
        [<CustomOperation "parallel_deployments">]
        member _.ParallelDeployments(state: ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>, value: double) : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.ParallelDeployments <- value)
            state : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_remediation#policy_definition_reference_id-1">ResourcePolicyRemediation#policy_definition_reference_id</a>.
        /// </summary>
        [<CustomOperation "policy_definition_reference_id">]
        member _.PolicyDefinitionReferenceId(state: ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>, value: string) : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.PolicyDefinitionReferenceId <- value)
            state : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_remediation#resource_count-1">ResourcePolicyRemediation#resource_count</a>.
        /// </summary>
        [<CustomOperation "resource_count">]
        member _.ResourceCount(state: ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>, value: double) : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.ResourceCount <- value)
            state : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_remediation#resource_discovery_mode-1">ResourcePolicyRemediation#resource_discovery_mode</a>.
        /// </summary>
        [<CustomOperation "resource_discovery_mode">]
        member _.ResourceDiscoveryMode(state: ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>, value: string) : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.ResourceDiscoveryMode <- value)
            state : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_remediation#timeouts-1">ResourcePolicyRemediation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>, value: azurerm.ResourcePolicyRemediation.ResourcePolicyRemediationTimeouts) : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourcePolicyRemediationState<'Name, 'PolicyAssignmentId, 'ResourceId>

        member _.Run(state: ResourcePolicyRemediationState<Present, Present, Present>) : azurerm.ResourcePolicyRemediation.ResourcePolicyRemediation =
            let config = azurerm.ResourcePolicyRemediation.ResourcePolicyRemediationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourcePolicyRemediation.ResourcePolicyRemediation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourcePolicyRemediation: missing required arguments. Must call: name, policy_assignment_id, resource_id.", 9999, IsError = true)>]
        member _.Run(_: ResourcePolicyRemediationState<_, _, _>) : azurerm.ResourcePolicyRemediation.ResourcePolicyRemediation =
            Unchecked.defaultof<azurerm.ResourcePolicyRemediation.ResourcePolicyRemediation>
