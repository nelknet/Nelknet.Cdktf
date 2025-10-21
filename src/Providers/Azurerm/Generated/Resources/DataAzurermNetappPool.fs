namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetappPoolState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNetappPool.DataAzurermNetappPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_pool">azurerm_netapp_pool</a>.
    /// </summary>
    type DataAzurermNetappPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetappPoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappPoolState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermNetappPoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappPoolState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_pool#account_name-1">DataAzurermNetappPool#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: DataAzurermNetappPoolState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermNetappPoolState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappPoolState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_pool#name-1">DataAzurermNetappPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetappPoolState<'AccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermNetappPoolState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetappPoolState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_pool#resource_group_name-1">DataAzurermNetappPool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNetappPoolState<'AccountName, 'Name, Missing>, value: string) : DataAzurermNetappPoolState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappPoolState<'AccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_pool#id-1">DataAzurermNetappPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetappPoolState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermNetappPoolState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetappPoolState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_pool#timeouts-1">DataAzurermNetappPool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetappPoolState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermNetappPool.DataAzurermNetappPoolTimeouts) : DataAzurermNetappPoolState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetappPoolState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermNetappPoolState<Present, Present, Present>) : azurerm.DataAzurermNetappPool.DataAzurermNetappPool =
            let config = azurerm.DataAzurermNetappPool.DataAzurermNetappPoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetappPool.DataAzurermNetappPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetappPool: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetappPoolState<_, _, _>) : azurerm.DataAzurermNetappPool.DataAzurermNetappPool =
            Unchecked.defaultof<azurerm.DataAzurermNetappPool.DataAzurermNetappPool>
