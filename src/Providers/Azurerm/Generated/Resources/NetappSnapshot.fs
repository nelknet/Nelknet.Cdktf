namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName> = { assignments: ResizeArray<azurerm.NetappSnapshot.NetappSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot">azurerm_netapp_snapshot</a>.
    /// </summary>
    type NetappSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetappSnapshotState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappSnapshotState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetappSnapshotState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappSnapshotState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot#account_name-1">NetappSnapshot#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: NetappSnapshotState<Missing, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>, value: string) : NetappSnapshotState<Present, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : NetappSnapshotState<Present, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot#location-1">NetappSnapshot#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetappSnapshotState<'AccountName, Missing, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>, value: string) : NetappSnapshotState<'AccountName, Present, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetappSnapshotState<'AccountName, Present, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot#name-1">NetappSnapshot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetappSnapshotState<'AccountName, 'Location, Missing, 'PoolName, 'ResourceGroupName, 'VolumeName>, value: string) : NetappSnapshotState<'AccountName, 'Location, Present, 'PoolName, 'ResourceGroupName, 'VolumeName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetappSnapshotState<'AccountName, 'Location, Present, 'PoolName, 'ResourceGroupName, 'VolumeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot#pool_name-1">NetappSnapshot#pool_name</a>.
        /// </summary>
        [<CustomOperation "pool_name">]
        member _.PoolName(state: NetappSnapshotState<'AccountName, 'Location, 'Name, Missing, 'ResourceGroupName, 'VolumeName>, value: string) : NetappSnapshotState<'AccountName, 'Location, 'Name, Present, 'ResourceGroupName, 'VolumeName> =
            state.assignments.Add(fun config -> config.PoolName <- value)
            ({ assignments = state.assignments } : NetappSnapshotState<'AccountName, 'Location, 'Name, Present, 'ResourceGroupName, 'VolumeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot#resource_group_name-1">NetappSnapshot#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, Missing, 'VolumeName>, value: string) : NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, Present, 'VolumeName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, Present, 'VolumeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot#volume_name-1">NetappSnapshot#volume_name</a>.
        /// </summary>
        [<CustomOperation "volume_name">]
        member _.VolumeName(state: NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, Missing>, value: string) : NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.VolumeName <- value)
            ({ assignments = state.assignments } : NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot#id-1">NetappSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>, value: string) : NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot#timeouts-1">NetappSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>, value: azurerm.NetappSnapshot.NetappSnapshotTimeouts) : NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetappSnapshotState<'AccountName, 'Location, 'Name, 'PoolName, 'ResourceGroupName, 'VolumeName>

        member _.Run(state: NetappSnapshotState<Present, Present, Present, Present, Present, Present>) : azurerm.NetappSnapshot.NetappSnapshot =
            let config = azurerm.NetappSnapshot.NetappSnapshotConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetappSnapshot.NetappSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.netappSnapshot: missing required arguments. Must call: account_name, location, name, pool_name, resource_group_name, volume_name.", 9999, IsError = true)>]
        member _.Run(_: NetappSnapshotState<_, _, _, _, _, _>) : azurerm.NetappSnapshot.NetappSnapshot =
            Unchecked.defaultof<azurerm.NetappSnapshot.NetappSnapshot>
