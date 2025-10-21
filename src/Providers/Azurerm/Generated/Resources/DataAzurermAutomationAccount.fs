namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAutomationAccountState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAutomationAccount.DataAzurermAutomationAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_account">azurerm_automation_account</a>.
    /// </summary>
    type DataAzurermAutomationAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAutomationAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationAccountState<Missing, Missing>)

        member _.Zero(()) : DataAzurermAutomationAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAutomationAccountState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_account#name-1">DataAzurermAutomationAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAutomationAccountState<Missing, 'ResourceGroupName>, value: string) : DataAzurermAutomationAccountState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationAccountState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_account#resource_group_name-1">DataAzurermAutomationAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAutomationAccountState<'Name, Missing>, value: string) : DataAzurermAutomationAccountState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAutomationAccountState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_account#id-1">DataAzurermAutomationAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAutomationAccountState<'Name, 'ResourceGroupName>, value: string) : DataAzurermAutomationAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAutomationAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/automation_account#timeouts-1">DataAzurermAutomationAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAutomationAccountState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAutomationAccount.DataAzurermAutomationAccountTimeouts) : DataAzurermAutomationAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAutomationAccountState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAutomationAccountState<Present, Present>) : azurerm.DataAzurermAutomationAccount.DataAzurermAutomationAccount =
            let config = azurerm.DataAzurermAutomationAccount.DataAzurermAutomationAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAutomationAccount.DataAzurermAutomationAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAutomationAccount: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAutomationAccountState<_, _>) : azurerm.DataAzurermAutomationAccount.DataAzurermAutomationAccount =
            Unchecked.defaultof<azurerm.DataAzurermAutomationAccount.DataAzurermAutomationAccount>
