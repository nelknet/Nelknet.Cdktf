namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermBatchApplicationState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermBatchApplication.DataAzurermBatchApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_application">azurerm_batch_application</a>.
    /// </summary>
    type DataAzurermBatchApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermBatchApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBatchApplicationState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermBatchApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBatchApplicationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_application#account_name-1">DataAzurermBatchApplication#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: DataAzurermBatchApplicationState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermBatchApplicationState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : DataAzurermBatchApplicationState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_application#name-1">DataAzurermBatchApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermBatchApplicationState<'AccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermBatchApplicationState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermBatchApplicationState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_application#resource_group_name-1">DataAzurermBatchApplication#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermBatchApplicationState<'AccountName, 'Name, Missing>, value: string) : DataAzurermBatchApplicationState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermBatchApplicationState<'AccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_application#id-1">DataAzurermBatchApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermBatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermBatchApplicationState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermBatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_application#timeouts-1">DataAzurermBatchApplication#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermBatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermBatchApplication.DataAzurermBatchApplicationTimeouts) : DataAzurermBatchApplicationState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermBatchApplicationState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermBatchApplicationState<Present, Present, Present>) : azurerm.DataAzurermBatchApplication.DataAzurermBatchApplication =
            let config = azurerm.DataAzurermBatchApplication.DataAzurermBatchApplicationConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermBatchApplication.DataAzurermBatchApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermBatchApplication: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermBatchApplicationState<_, _, _>) : azurerm.DataAzurermBatchApplication.DataAzurermBatchApplication =
            Unchecked.defaultof<azurerm.DataAzurermBatchApplication.DataAzurermBatchApplication>
