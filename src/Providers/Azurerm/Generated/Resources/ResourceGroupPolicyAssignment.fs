namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> = { assignments: ResizeArray<azurerm.ResourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment">azurerm_resource_group_policy_assignment</a>.
    /// </summary>
    type ResourceGroupPolicyAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourceGroupPolicyAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupPolicyAssignmentState<Missing, Missing, Missing>)

        member _.Zero(()) : ResourceGroupPolicyAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourceGroupPolicyAssignmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#name-1">ResourceGroupPolicyAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourceGroupPolicyAssignmentState<Missing, 'PolicyDefinitionId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyAssignmentState<Present, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourceGroupPolicyAssignmentState<Present, 'PolicyDefinitionId, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#policy_definition_id-1">ResourceGroupPolicyAssignment#policy_definition_id</a>.
        /// </summary>
        [<CustomOperation "policy_definition_id">]
        member _.PolicyDefinitionId(state: ResourceGroupPolicyAssignmentState<'Name, Missing, 'ResourceGroupId>, value: string) : ResourceGroupPolicyAssignmentState<'Name, Present, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.PolicyDefinitionId <- value)
            ({ assignments = state.assignments } : ResourceGroupPolicyAssignmentState<'Name, Present, 'ResourceGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#resource_group_id-1">ResourceGroupPolicyAssignment#resource_group_id</a>.
        /// </summary>
        [<CustomOperation "resource_group_id">]
        member _.ResourceGroupId(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, Missing>, value: string) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupId <- value)
            ({ assignments = state.assignments } : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#description-1">ResourceGroupPolicyAssignment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#display_name-1">ResourceGroupPolicyAssignment#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#enforce-1">ResourceGroupPolicyAssignment#enforce</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enforce">]
        member _.Enforce(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: bool) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Enforce <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#enforce-1">ResourceGroupPolicyAssignment#enforce</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enforce">]
        member _.Enforce(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: HashiCorp.Cdktf.IResolvable) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Enforce <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#id-1">ResourceGroupPolicyAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#identity-1">ResourceGroupPolicyAssignment#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: azurerm.ResourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentIdentity) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#location-1">ResourceGroupPolicyAssignment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Location <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#metadata-1">ResourceGroupPolicyAssignment#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// non_compliance_message block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#non_compliance_message-1">ResourceGroupPolicyAssignment#non_compliance_message</a> Accepts: azurerm.IResolvable | azurerm.ResourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentNonComplianceMessage[]
        /// </summary>
        [<CustomOperation "non_compliance_message">]
        member _.NonComplianceMessage(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: HashiCorp.Cdktf.IResolvable) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.NonComplianceMessage <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#not_scopes-1">ResourceGroupPolicyAssignment#not_scopes</a>.
        /// </summary>
        [<CustomOperation "not_scopes">]
        member _.NotScopes(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: seq<string>) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.NotScopes <- (value |> Seq.toArray))
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// overrides block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#overrides-1">ResourceGroupPolicyAssignment#overrides</a> Accepts: azurerm.IResolvable | azurerm.ResourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentOverrides[]
        /// </summary>
        [<CustomOperation "overrides">]
        member _.Overrides(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: HashiCorp.Cdktf.IResolvable) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Overrides <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#parameters-1">ResourceGroupPolicyAssignment#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: string) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// resource_selectors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#resource_selectors-1">ResourceGroupPolicyAssignment#resource_selectors</a> Accepts: azurerm.IResolvable | azurerm.ResourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentResourceSelectors[]
        /// </summary>
        [<CustomOperation "resource_selectors">]
        member _.ResourceSelectors(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: HashiCorp.Cdktf.IResolvable) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.ResourceSelectors <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_group_policy_assignment#timeouts-1">ResourceGroupPolicyAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>, value: azurerm.ResourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentTimeouts) : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourceGroupPolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceGroupId>

        member _.Run(state: ResourceGroupPolicyAssignmentState<Present, Present, Present>) : azurerm.ResourceGroupPolicyAssignment.ResourceGroupPolicyAssignment =
            let config = azurerm.ResourceGroupPolicyAssignment.ResourceGroupPolicyAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourceGroupPolicyAssignment.ResourceGroupPolicyAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourceGroupPolicyAssignment: missing required arguments. Must call: name, policy_definition_id, resource_group_id.", 9999, IsError = true)>]
        member _.Run(_: ResourceGroupPolicyAssignmentState<_, _, _>) : azurerm.ResourceGroupPolicyAssignment.ResourceGroupPolicyAssignment =
            Unchecked.defaultof<azurerm.ResourceGroupPolicyAssignment.ResourceGroupPolicyAssignment>
