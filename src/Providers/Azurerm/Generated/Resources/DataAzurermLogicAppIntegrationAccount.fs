namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermLogicAppIntegrationAccountState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermLogicAppIntegrationAccount.DataAzurermLogicAppIntegrationAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_integration_account">azurerm_logic_app_integration_account</a>.
    /// </summary>
    type DataAzurermLogicAppIntegrationAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermLogicAppIntegrationAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLogicAppIntegrationAccountState<Missing, Missing>)

        member _.Zero(()) : DataAzurermLogicAppIntegrationAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermLogicAppIntegrationAccountState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_integration_account#name-1">DataAzurermLogicAppIntegrationAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermLogicAppIntegrationAccountState<Missing, 'ResourceGroupName>, value: string) : DataAzurermLogicAppIntegrationAccountState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermLogicAppIntegrationAccountState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_integration_account#resource_group_name-1">DataAzurermLogicAppIntegrationAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermLogicAppIntegrationAccountState<'Name, Missing>, value: string) : DataAzurermLogicAppIntegrationAccountState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermLogicAppIntegrationAccountState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_integration_account#id-1">DataAzurermLogicAppIntegrationAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermLogicAppIntegrationAccountState<'Name, 'ResourceGroupName>, value: string) : DataAzurermLogicAppIntegrationAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermLogicAppIntegrationAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/logic_app_integration_account#timeouts-1">DataAzurermLogicAppIntegrationAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermLogicAppIntegrationAccountState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermLogicAppIntegrationAccount.DataAzurermLogicAppIntegrationAccountTimeouts) : DataAzurermLogicAppIntegrationAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermLogicAppIntegrationAccountState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermLogicAppIntegrationAccountState<Present, Present>) : azurerm.DataAzurermLogicAppIntegrationAccount.DataAzurermLogicAppIntegrationAccount =
            let config = azurerm.DataAzurermLogicAppIntegrationAccount.DataAzurermLogicAppIntegrationAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermLogicAppIntegrationAccount.DataAzurermLogicAppIntegrationAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermLogicAppIntegrationAccount: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermLogicAppIntegrationAccountState<_, _>) : azurerm.DataAzurermLogicAppIntegrationAccount.DataAzurermLogicAppIntegrationAccount =
            Unchecked.defaultof<azurerm.DataAzurermLogicAppIntegrationAccount.DataAzurermLogicAppIntegrationAccount>
