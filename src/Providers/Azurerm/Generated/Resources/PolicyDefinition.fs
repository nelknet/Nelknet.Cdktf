namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType> = { assignments: ResizeArray<azurerm.PolicyDefinition.PolicyDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_definition">azurerm_policy_definition</a>.
    /// </summary>
    type PolicyDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : PolicyDefinitionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PolicyDefinitionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PolicyDefinitionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PolicyDefinitionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_definition#display_name-1">PolicyDefinition#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: PolicyDefinitionState<Missing, 'Mode, 'Name, 'PolicyType>, value: string) : PolicyDefinitionState<Present, 'Mode, 'Name, 'PolicyType> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : PolicyDefinitionState<Present, 'Mode, 'Name, 'PolicyType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_definition#mode-1">PolicyDefinition#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: PolicyDefinitionState<'DisplayName, Missing, 'Name, 'PolicyType>, value: string) : PolicyDefinitionState<'DisplayName, Present, 'Name, 'PolicyType> =
            state.assignments.Add(fun config -> config.Mode <- value)
            ({ assignments = state.assignments } : PolicyDefinitionState<'DisplayName, Present, 'Name, 'PolicyType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_definition#name-1">PolicyDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PolicyDefinitionState<'DisplayName, 'Mode, Missing, 'PolicyType>, value: string) : PolicyDefinitionState<'DisplayName, 'Mode, Present, 'PolicyType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PolicyDefinitionState<'DisplayName, 'Mode, Present, 'PolicyType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_definition#policy_type-1">PolicyDefinition#policy_type</a>.
        /// </summary>
        [<CustomOperation "policy_type">]
        member _.PolicyType(state: PolicyDefinitionState<'DisplayName, 'Mode, 'Name, Missing>, value: string) : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, Present> =
            state.assignments.Add(fun config -> config.PolicyType <- value)
            ({ assignments = state.assignments } : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_definition#description-1">PolicyDefinition#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>, value: string) : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_definition#id-1">PolicyDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>, value: string) : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_definition#management_group_id-1">PolicyDefinition#management_group_id</a>.
        /// </summary>
        [<CustomOperation "management_group_id">]
        member _.ManagementGroupId(state: PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>, value: string) : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType> =
            state.assignments.Add(fun config -> config.ManagementGroupId <- value)
            state : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_definition#metadata-1">PolicyDefinition#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>, value: string) : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_definition#parameters-1">PolicyDefinition#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>, value: string) : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            state : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_definition#policy_rule-1">PolicyDefinition#policy_rule</a>.
        /// </summary>
        [<CustomOperation "policy_rule">]
        member _.PolicyRule(state: PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>, value: string) : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType> =
            state.assignments.Add(fun config -> config.PolicyRule <- value)
            state : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/policy_definition#timeouts-1">PolicyDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>, value: azurerm.PolicyDefinition.PolicyDefinitionTimeouts) : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PolicyDefinitionState<'DisplayName, 'Mode, 'Name, 'PolicyType>

        member _.Run(state: PolicyDefinitionState<Present, Present, Present, Present>) : azurerm.PolicyDefinition.PolicyDefinition =
            let config = azurerm.PolicyDefinition.PolicyDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.PolicyDefinition.PolicyDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.policyDefinition: missing required arguments. Must call: display_name, mode, name, policy_type.", 9999, IsError = true)>]
        member _.Run(_: PolicyDefinitionState<_, _, _, _>) : azurerm.PolicyDefinition.PolicyDefinition =
            Unchecked.defaultof<azurerm.PolicyDefinition.PolicyDefinition>
