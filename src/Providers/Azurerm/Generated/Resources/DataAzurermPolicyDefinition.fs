namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPolicyDefinitionState = { assignments: ResizeArray<azurerm.DataAzurermPolicyDefinition.DataAzurermPolicyDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition">azurerm_policy_definition</a>.
    /// </summary>
    type DataAzurermPolicyDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPolicyDefinitionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAzurermPolicyDefinitionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition#display_name-1">DataAzurermPolicyDefinition#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: DataAzurermPolicyDefinitionState, value: string) : DataAzurermPolicyDefinitionState =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : DataAzurermPolicyDefinitionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition#id-1">DataAzurermPolicyDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPolicyDefinitionState, value: string) : DataAzurermPolicyDefinitionState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPolicyDefinitionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition#management_group_name-1">DataAzurermPolicyDefinition#management_group_name</a>.
        /// </summary>
        [<CustomOperation "management_group_name">]
        member _.ManagementGroupName(state: DataAzurermPolicyDefinitionState, value: string) : DataAzurermPolicyDefinitionState =
            state.assignments.Add(fun config -> config.ManagementGroupName <- value)
            state : DataAzurermPolicyDefinitionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition#name-1">DataAzurermPolicyDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPolicyDefinitionState, value: string) : DataAzurermPolicyDefinitionState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermPolicyDefinitionState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition#timeouts-1">DataAzurermPolicyDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPolicyDefinitionState, value: azurerm.DataAzurermPolicyDefinition.DataAzurermPolicyDefinitionTimeouts) : DataAzurermPolicyDefinitionState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPolicyDefinitionState

        member _.Run(state: DataAzurermPolicyDefinitionState) : azurerm.DataAzurermPolicyDefinition.DataAzurermPolicyDefinition =
            let config = azurerm.DataAzurermPolicyDefinition.DataAzurermPolicyDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPolicyDefinition.DataAzurermPolicyDefinition(StackContext.get (), logicalId, config)
