namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName> = { assignments: ResizeArray<azurerm.DataAzurermNetappSnapshot.DataAzurermNetappSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot">azurerm_netapp_snapshot</a>.
    /// </summary>
    type DataAzurermNetappSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetappSnapshotState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappSnapshotState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermNetappSnapshotState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappSnapshotState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot#account_name-1">DataAzurermNetappSnapshot#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: DataAzurermNetappSnapshotState<Missing, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>, value: string) : DataAzurermNetappSnapshotState<Present, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappSnapshotState<Present, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot#name-1">DataAzurermNetappSnapshot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetappSnapshotState<'AccountName, Missing, 'PoolName, 'ResourceGroupName, 'VolumeName>, value: string) : DataAzurermNetappSnapshotState<'AccountName, Present, 'PoolName, 'ResourceGroupName, 'VolumeName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetappSnapshotState<'AccountName, Present, 'PoolName, 'ResourceGroupName, 'VolumeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot#pool_name-1">DataAzurermNetappSnapshot#pool_name</a>.
        /// </summary>
        [<CustomOperation "pool_name">]
        member _.PoolName(state: DataAzurermNetappSnapshotState<'AccountName, 'Name, Missing, 'ResourceGroupName, 'VolumeName>, value: string) : DataAzurermNetappSnapshotState<'AccountName, 'Name, Present, 'ResourceGroupName, 'VolumeName> =
            state.assignments.Add(fun config -> config.PoolName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappSnapshotState<'AccountName, 'Name, Present, 'ResourceGroupName, 'VolumeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot#resource_group_name-1">DataAzurermNetappSnapshot#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, Missing, 'VolumeName>, value: string) : DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, Present, 'VolumeName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, Present, 'VolumeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot#volume_name-1">DataAzurermNetappSnapshot#volume_name</a>.
        /// </summary>
        [<CustomOperation "volume_name">]
        member _.VolumeName(state: DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName, Missing>, value: string) : DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VolumeName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot#id-1">DataAzurermNetappSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>, value: string) : DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_snapshot#timeouts-1">DataAzurermNetappSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>, value: azurerm.DataAzurermNetappSnapshot.DataAzurermNetappSnapshotTimeouts) : DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetappSnapshotState<'AccountName, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>

        member _.Run(state: DataAzurermNetappSnapshotState<Present, Present, Present, Present, Present>) : azurerm.DataAzurermNetappSnapshot.DataAzurermNetappSnapshot =
            let config = azurerm.DataAzurermNetappSnapshot.DataAzurermNetappSnapshotConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetappSnapshot.DataAzurermNetappSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetappSnapshot: missing required arguments. Must call: account_name, name, pool_name, resource_group_name, volume_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetappSnapshotState<_, _, _, _, _>) : azurerm.DataAzurermNetappSnapshot.DataAzurermNetappSnapshot =
            Unchecked.defaultof<azurerm.DataAzurermNetappSnapshot.DataAzurermNetappSnapshot>
