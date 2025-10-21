namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPolicyDefinitionBuiltInState = { assignments: ResizeArray<azurerm.DataAzurermPolicyDefinitionBuiltIn.DataAzurermPolicyDefinitionBuiltInConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition_built_in">azurerm_policy_definition_built_in</a>.
    /// </summary>
    type DataAzurermPolicyDefinitionBuiltInBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPolicyDefinitionBuiltInState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAzurermPolicyDefinitionBuiltInState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition_built_in#display_name-1">DataAzurermPolicyDefinitionBuiltIn#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: DataAzurermPolicyDefinitionBuiltInState, value: string) : DataAzurermPolicyDefinitionBuiltInState =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : DataAzurermPolicyDefinitionBuiltInState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition_built_in#id-1">DataAzurermPolicyDefinitionBuiltIn#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPolicyDefinitionBuiltInState, value: string) : DataAzurermPolicyDefinitionBuiltInState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPolicyDefinitionBuiltInState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition_built_in#management_group_name-1">DataAzurermPolicyDefinitionBuiltIn#management_group_name</a>.
        /// </summary>
        [<CustomOperation "management_group_name">]
        member _.ManagementGroupName(state: DataAzurermPolicyDefinitionBuiltInState, value: string) : DataAzurermPolicyDefinitionBuiltInState =
            state.assignments.Add(fun config -> config.ManagementGroupName <- value)
            state : DataAzurermPolicyDefinitionBuiltInState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition_built_in#name-1">DataAzurermPolicyDefinitionBuiltIn#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPolicyDefinitionBuiltInState, value: string) : DataAzurermPolicyDefinitionBuiltInState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAzurermPolicyDefinitionBuiltInState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/policy_definition_built_in#timeouts-1">DataAzurermPolicyDefinitionBuiltIn#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPolicyDefinitionBuiltInState, value: azurerm.DataAzurermPolicyDefinitionBuiltIn.DataAzurermPolicyDefinitionBuiltInTimeouts) : DataAzurermPolicyDefinitionBuiltInState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPolicyDefinitionBuiltInState

        member _.Run(state: DataAzurermPolicyDefinitionBuiltInState) : azurerm.DataAzurermPolicyDefinitionBuiltIn.DataAzurermPolicyDefinitionBuiltIn =
            let config = azurerm.DataAzurermPolicyDefinitionBuiltIn.DataAzurermPolicyDefinitionBuiltInConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPolicyDefinitionBuiltIn.DataAzurermPolicyDefinitionBuiltIn(StackContext.get (), logicalId, config)
