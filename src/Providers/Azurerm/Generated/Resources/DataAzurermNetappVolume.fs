namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNetappVolume.DataAzurermNetappVolumeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume">azurerm_netapp_volume</a>.
    /// </summary>
    type DataAzurermNetappVolumeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetappVolumeState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappVolumeState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermNetappVolumeState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappVolumeState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume#account_name-1">DataAzurermNetappVolume#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: DataAzurermNetappVolumeState<Missing, 'Name, 'PoolName, 'ResourceGroupName>, value: string) : DataAzurermNetappVolumeState<Present, 'Name, 'PoolName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappVolumeState<Present, 'Name, 'PoolName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume#name-1">DataAzurermNetappVolume#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetappVolumeState<'AccountName, Missing, 'PoolName, 'ResourceGroupName>, value: string) : DataAzurermNetappVolumeState<'AccountName, Present, 'PoolName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetappVolumeState<'AccountName, Present, 'PoolName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume#pool_name-1">DataAzurermNetappVolume#pool_name</a>.
        /// </summary>
        [<CustomOperation "pool_name">]
        member _.PoolName(state: DataAzurermNetappVolumeState<'AccountName, 'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermNetappVolumeState<'AccountName, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PoolName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappVolumeState<'AccountName, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume#resource_group_name-1">DataAzurermNetappVolume#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, Missing>, value: string) : DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume#id-1">DataAzurermNetappVolume#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName>, value: string) : DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume#security_style-1">DataAzurermNetappVolume#security_style</a>.
        /// </summary>
        [<CustomOperation "security_style">]
        member _.SecurityStyle(state: DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName>, value: string) : DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SecurityStyle <- value)
            state : DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_volume#timeouts-1">DataAzurermNetappVolume#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName>, value: azurerm.DataAzurermNetappVolume.DataAzurermNetappVolumeTimeouts) : DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetappVolumeState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName>

        member _.Run(state: DataAzurermNetappVolumeState<Present, Present, Present, Present>) : azurerm.DataAzurermNetappVolume.DataAzurermNetappVolume =
            let config = azurerm.DataAzurermNetappVolume.DataAzurermNetappVolumeConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetappVolume.DataAzurermNetappVolume(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetappVolume: missing required arguments. Must call: account_name, name, pool_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetappVolumeState<_, _, _, _>) : azurerm.DataAzurermNetappVolume.DataAzurermNetappVolume =
            Unchecked.defaultof<azurerm.DataAzurermNetappVolume.DataAzurermNetappVolume>
