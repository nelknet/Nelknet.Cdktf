namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermBatchPoolState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermBatchPool.DataAzurermBatchPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_pool">azurerm_batch_pool</a>.
    /// </summary>
    type DataAzurermBatchPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermBatchPoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBatchPoolState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermBatchPoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBatchPoolState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_pool#account_name-1">DataAzurermBatchPool#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: DataAzurermBatchPoolState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermBatchPoolState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : DataAzurermBatchPoolState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_pool#name-1">DataAzurermBatchPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermBatchPoolState<'AccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermBatchPoolState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermBatchPoolState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_pool#resource_group_name-1">DataAzurermBatchPool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermBatchPoolState<'AccountName, 'Name, Missing>, value: string) : DataAzurermBatchPoolState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermBatchPoolState<'AccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_pool#id-1">DataAzurermBatchPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermBatchPoolState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermBatchPoolState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermBatchPoolState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_pool#timeouts-1">DataAzurermBatchPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermBatchPoolState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermBatchPool.DataAzurermBatchPoolTimeouts) : DataAzurermBatchPoolState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermBatchPoolState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermBatchPoolState<Present, Present, Present>) : azurerm.DataAzurermBatchPool.DataAzurermBatchPool =
            let config = azurerm.DataAzurermBatchPool.DataAzurermBatchPoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermBatchPool.DataAzurermBatchPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermBatchPool: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermBatchPoolState<_, _, _>) : azurerm.DataAzurermBatchPool.DataAzurermBatchPool =
            Unchecked.defaultof<azurerm.DataAzurermBatchPool.DataAzurermBatchPool>
