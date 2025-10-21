namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> = { assignments: ResizeArray<azurerm.ManagementGroupPolicyAssignment.ManagementGroupPolicyAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment">azurerm_management_group_policy_assignment</a>.
    /// </summary>
    type ManagementGroupPolicyAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagementGroupPolicyAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagementGroupPolicyAssignmentState<Missing, Missing, Missing>)

        member _.Zero(()) : ManagementGroupPolicyAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagementGroupPolicyAssignmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#management_group_id-1">ManagementGroupPolicyAssignment#management_group_id</a>.
        /// </summary>
        [<CustomOperation "management_group_id">]
        member _.ManagementGroupId(state: ManagementGroupPolicyAssignmentState<Missing, 'Name, 'PolicyDefinitionId>, value: string) : ManagementGroupPolicyAssignmentState<Present, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.ManagementGroupId <- value)
            ({ assignments = state.assignments } : ManagementGroupPolicyAssignmentState<Present, 'Name, 'PolicyDefinitionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#name-1">ManagementGroupPolicyAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, Missing, 'PolicyDefinitionId>, value: string) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, Present, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ManagementGroupPolicyAssignmentState<'ManagementGroupId, Present, 'PolicyDefinitionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#policy_definition_id-1">ManagementGroupPolicyAssignment#policy_definition_id</a>.
        /// </summary>
        [<CustomOperation "policy_definition_id">]
        member _.PolicyDefinitionId(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, Missing>, value: string) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, Present> =
            state.assignments.Add(fun config -> config.PolicyDefinitionId <- value)
            ({ assignments = state.assignments } : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#description-1">ManagementGroupPolicyAssignment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: string) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#display_name-1">ManagementGroupPolicyAssignment#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: string) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#enforce-1">ManagementGroupPolicyAssignment#enforce</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enforce">]
        member _.Enforce(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: bool) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.Enforce <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#enforce-1">ManagementGroupPolicyAssignment#enforce</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enforce">]
        member _.Enforce(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: HashiCorp.Cdktf.IResolvable) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.Enforce <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#id-1">ManagementGroupPolicyAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: string) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#identity-1">ManagementGroupPolicyAssignment#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: azurerm.ManagementGroupPolicyAssignment.ManagementGroupPolicyAssignmentIdentity) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#location-1">ManagementGroupPolicyAssignment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: string) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.Location <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#metadata-1">ManagementGroupPolicyAssignment#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: string) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// non_compliance_message block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#non_compliance_message-1">ManagementGroupPolicyAssignment#non_compliance_message</a> Accepts: azurerm.IResolvable | azurerm.ManagementGroupPolicyAssignment.ManagementGroupPolicyAssignmentNonComplianceMessage[]
        /// </summary>
        [<CustomOperation "non_compliance_message">]
        member _.NonComplianceMessage(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: HashiCorp.Cdktf.IResolvable) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.NonComplianceMessage <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#not_scopes-1">ManagementGroupPolicyAssignment#not_scopes</a>.
        /// </summary>
        [<CustomOperation "not_scopes">]
        member _.NotScopes(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: seq<string>) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.NotScopes <- (value |> Seq.toArray))
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// overrides block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#overrides-1">ManagementGroupPolicyAssignment#overrides</a> Accepts: azurerm.IResolvable | azurerm.ManagementGroupPolicyAssignment.ManagementGroupPolicyAssignmentOverrides[]
        /// </summary>
        [<CustomOperation "overrides">]
        member _.Overrides(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: HashiCorp.Cdktf.IResolvable) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.Overrides <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#parameters-1">ManagementGroupPolicyAssignment#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: string) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// resource_selectors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#resource_selectors-1">ManagementGroupPolicyAssignment#resource_selectors</a> Accepts: azurerm.IResolvable | azurerm.ManagementGroupPolicyAssignment.ManagementGroupPolicyAssignmentResourceSelectors[]
        /// </summary>
        [<CustomOperation "resource_selectors">]
        member _.ResourceSelectors(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: HashiCorp.Cdktf.IResolvable) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.ResourceSelectors <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_policy_assignment#timeouts-1">ManagementGroupPolicyAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>, value: azurerm.ManagementGroupPolicyAssignment.ManagementGroupPolicyAssignmentTimeouts) : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ManagementGroupPolicyAssignmentState<'ManagementGroupId, 'Name, 'PolicyDefinitionId>

        member _.Run(state: ManagementGroupPolicyAssignmentState<Present, Present, Present>) : azurerm.ManagementGroupPolicyAssignment.ManagementGroupPolicyAssignment =
            let config = azurerm.ManagementGroupPolicyAssignment.ManagementGroupPolicyAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.ManagementGroupPolicyAssignment.ManagementGroupPolicyAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.managementGroupPolicyAssignment: missing required arguments. Must call: management_group_id, name, policy_definition_id.", 9999, IsError = true)>]
        member _.Run(_: ManagementGroupPolicyAssignmentState<_, _, _>) : azurerm.ManagementGroupPolicyAssignment.ManagementGroupPolicyAssignment =
            Unchecked.defaultof<azurerm.ManagementGroupPolicyAssignment.ManagementGroupPolicyAssignment>
