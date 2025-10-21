namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageSyncState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.StorageSync.StorageSyncConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync">azurerm_storage_sync</a>.
    /// </summary>
    type StorageSyncBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageSyncState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageSyncState<Missing, Missing, Missing>)

        member _.Zero(()) : StorageSyncState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageSyncState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync#location-1">StorageSync#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: StorageSyncState<Missing, 'Name, 'ResourceGroupName>, value: string) : StorageSyncState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : StorageSyncState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync#name-1">StorageSync#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageSyncState<'Location, Missing, 'ResourceGroupName>, value: string) : StorageSyncState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageSyncState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync#resource_group_name-1">StorageSync#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StorageSyncState<'Location, 'Name, Missing>, value: string) : StorageSyncState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StorageSyncState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync#id-1">StorageSync#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageSyncState<'Location, 'Name, 'ResourceGroupName>, value: string) : StorageSyncState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageSyncState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync#incoming_traffic_policy-1">StorageSync#incoming_traffic_policy</a>.
        /// </summary>
        [<CustomOperation "incoming_traffic_policy">]
        member _.IncomingTrafficPolicy(state: StorageSyncState<'Location, 'Name, 'ResourceGroupName>, value: string) : StorageSyncState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IncomingTrafficPolicy <- value)
            state : StorageSyncState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync#tags-1">StorageSync#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StorageSyncState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : StorageSyncState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StorageSyncState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_sync#timeouts-1">StorageSync#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageSyncState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageSync.StorageSyncTimeouts) : StorageSyncState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageSyncState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: StorageSyncState<Present, Present, Present>) : azurerm.StorageSync.StorageSync =
            let config = azurerm.StorageSync.StorageSyncConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageSync.StorageSync(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageSync: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: StorageSyncState<_, _, _>) : azurerm.StorageSync.StorageSync =
            Unchecked.defaultof<azurerm.StorageSync.StorageSync>
