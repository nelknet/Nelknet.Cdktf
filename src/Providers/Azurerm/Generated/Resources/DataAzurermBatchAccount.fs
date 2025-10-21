namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermBatchAccountState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermBatchAccount.DataAzurermBatchAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_account">azurerm_batch_account</a>.
    /// </summary>
    type DataAzurermBatchAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermBatchAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBatchAccountState<Missing, Missing>)

        member _.Zero(()) : DataAzurermBatchAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBatchAccountState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_account#name-1">DataAzurermBatchAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermBatchAccountState<Missing, 'ResourceGroupName>, value: string) : DataAzurermBatchAccountState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermBatchAccountState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_account#resource_group_name-1">DataAzurermBatchAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermBatchAccountState<'Name, Missing>, value: string) : DataAzurermBatchAccountState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermBatchAccountState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_account#id-1">DataAzurermBatchAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermBatchAccountState<'Name, 'ResourceGroupName>, value: string) : DataAzurermBatchAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermBatchAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_account#timeouts-1">DataAzurermBatchAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermBatchAccountState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermBatchAccount.DataAzurermBatchAccountTimeouts) : DataAzurermBatchAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermBatchAccountState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermBatchAccountState<Present, Present>) : azurerm.DataAzurermBatchAccount.DataAzurermBatchAccount =
            let config = azurerm.DataAzurermBatchAccount.DataAzurermBatchAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermBatchAccount.DataAzurermBatchAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermBatchAccount: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermBatchAccountState<_, _>) : azurerm.DataAzurermBatchAccount.DataAzurermBatchAccount =
            Unchecked.defaultof<azurerm.DataAzurermBatchAccount.DataAzurermBatchAccount>
