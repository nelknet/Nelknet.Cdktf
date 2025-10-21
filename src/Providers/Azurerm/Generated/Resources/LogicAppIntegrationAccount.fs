namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.LogicAppIntegrationAccount.LogicAppIntegrationAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account">azurerm_logic_app_integration_account</a>.
    /// </summary>
    type LogicAppIntegrationAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppIntegrationAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppIntegrationAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account#location-1">LogicAppIntegrationAccount#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LogicAppIntegrationAccountState<Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : LogicAppIntegrationAccountState<Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountState<Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account#name-1">LogicAppIntegrationAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppIntegrationAccountState<'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : LogicAppIntegrationAccountState<'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountState<'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account#resource_group_name-1">LogicAppIntegrationAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogicAppIntegrationAccountState<'Location, 'Name, Missing, 'SkuName>, value: string) : LogicAppIntegrationAccountState<'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountState<'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account#sku_name-1">LogicAppIntegrationAccount#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account#id-1">LogicAppIntegrationAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account#integration_service_environment_id-1">LogicAppIntegrationAccount#integration_service_environment_id</a>.
        /// </summary>
        [<CustomOperation "integration_service_environment_id">]
        member _.IntegrationServiceEnvironmentId(state: LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.IntegrationServiceEnvironmentId <- value)
            state : LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account#tags-1">LogicAppIntegrationAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account#timeouts-1">LogicAppIntegrationAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.LogicAppIntegrationAccount.LogicAppIntegrationAccountTimeouts) : LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppIntegrationAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: LogicAppIntegrationAccountState<Present, Present, Present, Present>) : azurerm.LogicAppIntegrationAccount.LogicAppIntegrationAccount =
            let config = azurerm.LogicAppIntegrationAccount.LogicAppIntegrationAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppIntegrationAccount.LogicAppIntegrationAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppIntegrationAccount: missing required arguments. Must call: location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppIntegrationAccountState<_, _, _, _>) : azurerm.LogicAppIntegrationAccount.LogicAppIntegrationAccount =
            Unchecked.defaultof<azurerm.LogicAppIntegrationAccount.LogicAppIntegrationAccount>
