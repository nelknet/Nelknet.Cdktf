namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> = { assignments: ResizeArray<azurerm.ResourcePolicyAssignment.ResourcePolicyAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment">azurerm_resource_policy_assignment</a>.
    /// </summary>
    type ResourcePolicyAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ResourcePolicyAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourcePolicyAssignmentState<Missing, Missing, Missing>)

        member _.Zero(()) : ResourcePolicyAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ResourcePolicyAssignmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#name-1">ResourcePolicyAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ResourcePolicyAssignmentState<Missing, 'PolicyDefinitionId, 'ResourceId>, value: string) : ResourcePolicyAssignmentState<Present, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ResourcePolicyAssignmentState<Present, 'PolicyDefinitionId, 'ResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#policy_definition_id-1">ResourcePolicyAssignment#policy_definition_id</a>.
        /// </summary>
        [<CustomOperation "policy_definition_id">]
        member _.PolicyDefinitionId(state: ResourcePolicyAssignmentState<'Name, Missing, 'ResourceId>, value: string) : ResourcePolicyAssignmentState<'Name, Present, 'ResourceId> =
            state.assignments.Add(fun config -> config.PolicyDefinitionId <- value)
            ({ assignments = state.assignments } : ResourcePolicyAssignmentState<'Name, Present, 'ResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#resource_id-1">ResourcePolicyAssignment#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, Missing>, value: string) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, Present> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#description-1">ResourcePolicyAssignment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: string) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#display_name-1">ResourcePolicyAssignment#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: string) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#enforce-1">ResourcePolicyAssignment#enforce</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enforce">]
        member _.Enforce(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: bool) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Enforce <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#enforce-1">ResourcePolicyAssignment#enforce</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enforce">]
        member _.Enforce(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: HashiCorp.Cdktf.IResolvable) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Enforce <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#id-1">ResourcePolicyAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: string) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#identity-1">ResourcePolicyAssignment#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: azurerm.ResourcePolicyAssignment.ResourcePolicyAssignmentIdentity) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#location-1">ResourcePolicyAssignment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: string) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Location <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#metadata-1">ResourcePolicyAssignment#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: string) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// non_compliance_message block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#non_compliance_message-1">ResourcePolicyAssignment#non_compliance_message</a> Accepts: azurerm.IResolvable | azurerm.ResourcePolicyAssignment.ResourcePolicyAssignmentNonComplianceMessage[]
        /// </summary>
        [<CustomOperation "non_compliance_message">]
        member _.NonComplianceMessage(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: HashiCorp.Cdktf.IResolvable) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.NonComplianceMessage <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#not_scopes-1">ResourcePolicyAssignment#not_scopes</a>.
        /// </summary>
        [<CustomOperation "not_scopes">]
        member _.NotScopes(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: seq<string>) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.NotScopes <- (value |> Seq.toArray))
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// overrides block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#overrides-1">ResourcePolicyAssignment#overrides</a> Accepts: azurerm.IResolvable | azurerm.ResourcePolicyAssignment.ResourcePolicyAssignmentOverrides[]
        /// </summary>
        [<CustomOperation "overrides">]
        member _.Overrides(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: HashiCorp.Cdktf.IResolvable) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Overrides <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#parameters-1">ResourcePolicyAssignment#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: string) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// resource_selectors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#resource_selectors-1">ResourcePolicyAssignment#resource_selectors</a> Accepts: azurerm.IResolvable | azurerm.ResourcePolicyAssignment.ResourcePolicyAssignmentResourceSelectors[]
        /// </summary>
        [<CustomOperation "resource_selectors">]
        member _.ResourceSelectors(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: HashiCorp.Cdktf.IResolvable) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.ResourceSelectors <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/resource_policy_assignment#timeouts-1">ResourcePolicyAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>, value: azurerm.ResourcePolicyAssignment.ResourcePolicyAssignmentTimeouts) : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ResourcePolicyAssignmentState<'Name, 'PolicyDefinitionId, 'ResourceId>

        member _.Run(state: ResourcePolicyAssignmentState<Present, Present, Present>) : azurerm.ResourcePolicyAssignment.ResourcePolicyAssignment =
            let config = azurerm.ResourcePolicyAssignment.ResourcePolicyAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.ResourcePolicyAssignment.ResourcePolicyAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.resourcePolicyAssignment: missing required arguments. Must call: name, policy_definition_id, resource_id.", 9999, IsError = true)>]
        member _.Run(_: ResourcePolicyAssignmentState<_, _, _>) : azurerm.ResourcePolicyAssignment.ResourcePolicyAssignment =
            Unchecked.defaultof<azurerm.ResourcePolicyAssignment.ResourcePolicyAssignment>
