namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones> = { assignments: ResizeArray<azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system">azurerm_managed_lustre_file_system</a>.
    /// </summary>
    type ManagedLustreFileSystemBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagedLustreFileSystemState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagedLustreFileSystemState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ManagedLustreFileSystemState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagedLustreFileSystemState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#location-1">ManagedLustreFileSystem#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ManagedLustreFileSystemState<Missing, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>, value: string) : ManagedLustreFileSystemState<Present, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ManagedLustreFileSystemState<Present, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>)

        /// <summary>
        /// maintenance_window block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#maintenance_window-1">ManagedLustreFileSystem#maintenance_window</a>
        /// </summary>
        [<CustomOperation "maintenance_window">]
        member _.MaintenanceWindow(state: ManagedLustreFileSystemState<'Location, Missing, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>, value: azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemMaintenanceWindow) : ManagedLustreFileSystemState<'Location, Present, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones> =
            state.assignments.Add(fun config -> config.MaintenanceWindow <- value)
            ({ assignments = state.assignments } : ManagedLustreFileSystemState<'Location, Present, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#name-1">ManagedLustreFileSystem#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, Missing, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>, value: string) : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, Present, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, Present, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#resource_group_name-1">ManagedLustreFileSystem#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, Missing, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>, value: string) : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, Present, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, Present, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#sku_name-1">ManagedLustreFileSystem#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, Missing, 'StorageCapacityInTb, 'SubnetId, 'Zones>, value: string) : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, Present, 'StorageCapacityInTb, 'SubnetId, 'Zones> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, Present, 'StorageCapacityInTb, 'SubnetId, 'Zones>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#storage_capacity_in_tb-1">ManagedLustreFileSystem#storage_capacity_in_tb</a>.
        /// </summary>
        [<CustomOperation "storage_capacity_in_tb">]
        member _.StorageCapacityInTb(state: ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, Missing, 'SubnetId, 'Zones>, value: double) : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, Present, 'SubnetId, 'Zones> =
            state.assignments.Add(fun config -> config.StorageCapacityInTb <- value)
            ({ assignments = state.assignments } : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, Present, 'SubnetId, 'Zones>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#subnet_id-1">ManagedLustreFileSystem#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, Missing, 'Zones>, value: string) : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, Present, 'Zones> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, Present, 'Zones>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#zones-1">ManagedLustreFileSystem#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, Missing>, value: seq<string>) : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, Present> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, Present>)

        /// <summary>
        /// encryption_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#encryption_key-1">ManagedLustreFileSystem#encryption_key</a>
        /// </summary>
        [<CustomOperation "encryption_key">]
        member _.EncryptionKey(state: ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>, value: azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemEncryptionKey) : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones> =
            state.assignments.Add(fun config -> config.EncryptionKey <- value)
            state : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>

        /// <summary>
        /// hsm_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#hsm_setting-1">ManagedLustreFileSystem#hsm_setting</a>
        /// </summary>
        [<CustomOperation "hsm_setting">]
        member _.HsmSetting(state: ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>, value: azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemHsmSetting) : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones> =
            state.assignments.Add(fun config -> config.HsmSetting <- value)
            state : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#id-1">ManagedLustreFileSystem#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>, value: string) : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#identity-1">ManagedLustreFileSystem#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>, value: azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemIdentity) : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#tags-1">ManagedLustreFileSystem#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>, value: seq<string * string>) : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#timeouts-1">ManagedLustreFileSystem#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>, value: azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemTimeouts) : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ManagedLustreFileSystemState<'Location, 'MaintenanceWindow, 'Name, 'ResourceGroupName, 'SkuName, 'StorageCapacityInTb, 'SubnetId, 'Zones>

        member _.Run(state: ManagedLustreFileSystemState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.ManagedLustreFileSystem.ManagedLustreFileSystem =
            let config = azurerm.ManagedLustreFileSystem.ManagedLustreFileSystemConfig()
            for setter in state.assignments do
                setter config
            azurerm.ManagedLustreFileSystem.ManagedLustreFileSystem(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.managedLustreFileSystem: missing required arguments. Must call: location, maintenance_window, name, resource_group_name, sku_name, storage_capacity_in_tb, subnet_id, zones.", 9999, IsError = true)>]
        member _.Run(_: ManagedLustreFileSystemState<_, _, _, _, _, _, _, _>) : azurerm.ManagedLustreFileSystem.ManagedLustreFileSystem =
            Unchecked.defaultof<azurerm.ManagedLustreFileSystem.ManagedLustreFileSystem>
