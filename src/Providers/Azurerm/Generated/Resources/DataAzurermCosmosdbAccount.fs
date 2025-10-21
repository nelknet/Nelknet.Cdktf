namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCosmosdbAccountState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_account">azurerm_cosmosdb_account</a>.
    /// </summary>
    type DataAzurermCosmosdbAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCosmosdbAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCosmosdbAccountState<Missing, Missing>)

        member _.Zero(()) : DataAzurermCosmosdbAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCosmosdbAccountState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_account#name-1">DataAzurermCosmosdbAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCosmosdbAccountState<Missing, 'ResourceGroupName>, value: string) : DataAzurermCosmosdbAccountState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbAccountState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_account#resource_group_name-1">DataAzurermCosmosdbAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCosmosdbAccountState<'Name, Missing>, value: string) : DataAzurermCosmosdbAccountState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCosmosdbAccountState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_account#id-1">DataAzurermCosmosdbAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCosmosdbAccountState<'Name, 'ResourceGroupName>, value: string) : DataAzurermCosmosdbAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCosmosdbAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cosmosdb_account#timeouts-1">DataAzurermCosmosdbAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCosmosdbAccountState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountTimeouts) : DataAzurermCosmosdbAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCosmosdbAccountState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermCosmosdbAccountState<Present, Present>) : azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccount =
            let config = azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCosmosdbAccount: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCosmosdbAccountState<_, _>) : azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccount =
            Unchecked.defaultof<azurerm.DataAzurermCosmosdbAccount.DataAzurermCosmosdbAccount>
