namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPolicySetDefinitionState = { assignments: ResizeArray<azurerm.DataAzurermPolicySetDefinition.DataAzurermPolicySetDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_set_definition">azurerm_policy_set_definition</a>.
    /// </summary>
    type DataAzurermPolicySetDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPolicySetDefinitionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAzurermPolicySetDefinitionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_set_definition#display_name-1">DataAzurermPolicySetDefinition#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: DataAzurermPolicySetDefinitionState, value: string) : DataAzurermPolicySetDefinitionState =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : DataAzurermPolicySetDefinitionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_set_definition#id-1">DataAzurermPolicySetDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPolicySetDefinitionState, value: string) : DataAzurermPolicySetDefinitionState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPolicySetDefinitionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_set_definition#management_group_name-1">DataAzurermPolicySetDefinition#management_group_name</a>.
        /// </summary>
        [<CustomOperation "management_group_name">]
        member _.ManagementGroupName(state: DataAzurermPolicySetDefinitionState, value: string) : DataAzurermPolicySetDefinitionState =
            state.assignments.Add(fun config -> config.ManagementGroupName <- value)
            state : DataAzurermPolicySetDefinitionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_set_definition#name-1">DataAzurermPolicySetDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPolicySetDefinitionState, value: string) : DataAzurermPolicySetDefinitionState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermPolicySetDefinitionState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_set_definition#timeouts-1">DataAzurermPolicySetDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPolicySetDefinitionState, value: azurerm.DataAzurermPolicySetDefinition.DataAzurermPolicySetDefinitionTimeouts) : DataAzurermPolicySetDefinitionState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPolicySetDefinitionState

        member _.Run(state: DataAzurermPolicySetDefinitionState) : azurerm.DataAzurermPolicySetDefinition.DataAzurermPolicySetDefinition =
            let config = azurerm.DataAzurermPolicySetDefinition.DataAzurermPolicySetDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPolicySetDefinition.DataAzurermPolicySetDefinition(StackContext.get (), logicalId, config)
