namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LogicAppIntegrationAccountMap.LogicAppIntegrationAccountMapConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_map">azurerm_logic_app_integration_account_map</a>.
    /// </summary>
    type LogicAppIntegrationAccountMapBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppIntegrationAccountMapState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountMapState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppIntegrationAccountMapState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountMapState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_map#content-1">LogicAppIntegrationAccountMap#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: LogicAppIntegrationAccountMapState<Missing, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountMapState<Present, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Content <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountMapState<Present, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_map#integration_account_name-1">LogicAppIntegrationAccountMap#integration_account_name</a>.
        /// </summary>
        [<CustomOperation "integration_account_name">]
        member _.IntegrationAccountName(state: LogicAppIntegrationAccountMapState<'Content, Missing, 'MapType, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountMapState<'Content, Present, 'MapType, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IntegrationAccountName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountMapState<'Content, Present, 'MapType, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_map#map_type-1">LogicAppIntegrationAccountMap#map_type</a>.
        /// </summary>
        [<CustomOperation "map_type">]
        member _.MapType(state: LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, Missing, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MapType <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_map#name-1">LogicAppIntegrationAccountMap#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, Missing, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_map#resource_group_name-1">LogicAppIntegrationAccountMap#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, Missing>, value: string) : LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_map#id-1">LogicAppIntegrationAccountMap#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_map#metadata-1">LogicAppIntegrationAccountMap#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName>, value: seq<string * string>) : LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_map#timeouts-1">LogicAppIntegrationAccountMap#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppIntegrationAccountMap.LogicAppIntegrationAccountMapTimeouts) : LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppIntegrationAccountMapState<'Content, 'IntegrationAccountName, 'MapType, 'Name, 'ResourceGroupName>

        member _.Run(state: LogicAppIntegrationAccountMapState<Present, Present, Present, Present, Present>) : azurerm.LogicAppIntegrationAccountMap.LogicAppIntegrationAccountMap =
            let config = azurerm.LogicAppIntegrationAccountMap.LogicAppIntegrationAccountMapConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppIntegrationAccountMap.LogicAppIntegrationAccountMap(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppIntegrationAccountMap: missing required arguments. Must call: content, integration_account_name, map_type, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppIntegrationAccountMapState<_, _, _, _, _>) : azurerm.LogicAppIntegrationAccountMap.LogicAppIntegrationAccountMap =
            Unchecked.defaultof<azurerm.LogicAppIntegrationAccountMap.LogicAppIntegrationAccountMap>
