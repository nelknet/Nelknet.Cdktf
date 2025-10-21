namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType> = { assignments: ResizeArray<azurerm.PolicySetDefinition.PolicySetDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition">azurerm_policy_set_definition</a>.
    /// </summary>
    type PolicySetDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : PolicySetDefinitionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PolicySetDefinitionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PolicySetDefinitionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PolicySetDefinitionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#display_name-1">PolicySetDefinition#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: PolicySetDefinitionState<Missing, 'Name, 'PolicyDefinitionReference, 'PolicyType>, value: string) : PolicySetDefinitionState<Present, 'Name, 'PolicyDefinitionReference, 'PolicyType> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : PolicySetDefinitionState<Present, 'Name, 'PolicyDefinitionReference, 'PolicyType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#name-1">PolicySetDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PolicySetDefinitionState<'DisplayName, Missing, 'PolicyDefinitionReference, 'PolicyType>, value: string) : PolicySetDefinitionState<'DisplayName, Present, 'PolicyDefinitionReference, 'PolicyType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PolicySetDefinitionState<'DisplayName, Present, 'PolicyDefinitionReference, 'PolicyType>)

        /// <summary>
        /// policy_definition_reference block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#policy_definition_reference-1">PolicySetDefinition#policy_definition_reference</a> Accepts: azurerm.IResolvable | azurerm.PolicySetDefinition.PolicySetDefinitionPolicyDefinitionReference[]
        /// </summary>
        [<CustomOperation "policy_definition_reference">]
        member _.PolicyDefinitionReference(state: PolicySetDefinitionState<'DisplayName, 'Name, Missing, 'PolicyType>, value: HashiCorp.Cdktf.IResolvable) : PolicySetDefinitionState<'DisplayName, 'Name, Present, 'PolicyType> =
            state.assignments.Add(fun config -> config.PolicyDefinitionReference <- value)
            ({ assignments = state.assignments } : PolicySetDefinitionState<'DisplayName, 'Name, Present, 'PolicyType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#policy_type-1">PolicySetDefinition#policy_type</a>.
        /// </summary>
        [<CustomOperation "policy_type">]
        member _.PolicyType(state: PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, Missing>, value: string) : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, Present> =
            state.assignments.Add(fun config -> config.PolicyType <- value)
            ({ assignments = state.assignments } : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#description-1">PolicySetDefinition#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>, value: string) : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#id-1">PolicySetDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>, value: string) : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#management_group_id-1">PolicySetDefinition#management_group_id</a>.
        /// </summary>
        [<CustomOperation "management_group_id">]
        member _.ManagementGroupId(state: PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>, value: string) : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType> =
            state.assignments.Add(fun config -> config.ManagementGroupId <- value)
            state : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#metadata-1">PolicySetDefinition#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>, value: string) : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#parameters-1">PolicySetDefinition#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>, value: string) : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            state : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>

        /// <summary>
        /// policy_definition_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#policy_definition_group-1">PolicySetDefinition#policy_definition_group</a> Accepts: azurerm.IResolvable | azurerm.PolicySetDefinition.PolicySetDefinitionPolicyDefinitionGroup[]
        /// </summary>
        [<CustomOperation "policy_definition_group">]
        member _.PolicyDefinitionGroup(state: PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>, value: HashiCorp.Cdktf.IResolvable) : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType> =
            state.assignments.Add(fun config -> config.PolicyDefinitionGroup <- value)
            state : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_set_definition#timeouts-1">PolicySetDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>, value: azurerm.PolicySetDefinition.PolicySetDefinitionTimeouts) : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PolicySetDefinitionState<'DisplayName, 'Name, 'PolicyDefinitionReference, 'PolicyType>

        member _.Run(state: PolicySetDefinitionState<Present, Present, Present, Present>) : azurerm.PolicySetDefinition.PolicySetDefinition =
            let config = azurerm.PolicySetDefinition.PolicySetDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.PolicySetDefinition.PolicySetDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.policySetDefinition: missing required arguments. Must call: display_name, name, policy_definition_reference, policy_type.", 9999, IsError = true)>]
        member _.Run(_: PolicySetDefinitionState<_, _, _, _>) : azurerm.PolicySetDefinition.PolicySetDefinition =
            Unchecked.defaultof<azurerm.PolicySetDefinition.PolicySetDefinition>
