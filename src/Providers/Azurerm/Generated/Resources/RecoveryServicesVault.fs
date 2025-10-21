namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.RecoveryServicesVault.RecoveryServicesVaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault">azurerm_recovery_services_vault</a>.
    /// </summary>
    type RecoveryServicesVaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : RecoveryServicesVaultState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RecoveryServicesVaultState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RecoveryServicesVaultState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RecoveryServicesVaultState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#location-1">RecoveryServicesVault#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: RecoveryServicesVaultState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : RecoveryServicesVaultState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : RecoveryServicesVaultState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#name-1">RecoveryServicesVault#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RecoveryServicesVaultState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : RecoveryServicesVaultState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RecoveryServicesVaultState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#resource_group_name-1">RecoveryServicesVault#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RecoveryServicesVaultState<'Location, 'Name, Missing, 'Sku>, value: string) : RecoveryServicesVaultState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RecoveryServicesVaultState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#sku-1">RecoveryServicesVault#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#classic_vmware_replication_enabled-1">RecoveryServicesVault#classic_vmware_replication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "classic_vmware_replication_enabled">]
        member _.ClassicVmwareReplicationEnabled(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ClassicVmwareReplicationEnabled <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#classic_vmware_replication_enabled-1">RecoveryServicesVault#classic_vmware_replication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "classic_vmware_replication_enabled">]
        member _.ClassicVmwareReplicationEnabled(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ClassicVmwareReplicationEnabled <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#cross_region_restore_enabled-1">RecoveryServicesVault#cross_region_restore_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "cross_region_restore_enabled">]
        member _.CrossRegionRestoreEnabled(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CrossRegionRestoreEnabled <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#cross_region_restore_enabled-1">RecoveryServicesVault#cross_region_restore_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "cross_region_restore_enabled">]
        member _.CrossRegionRestoreEnabled(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CrossRegionRestoreEnabled <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#encryption-1">RecoveryServicesVault#encryption</a>
        /// </summary>
        [<CustomOperation "encryption">]
        member _.Encryption(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.RecoveryServicesVault.RecoveryServicesVaultEncryption) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Encryption <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#id-1">RecoveryServicesVault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#identity-1">RecoveryServicesVault#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.RecoveryServicesVault.RecoveryServicesVaultIdentity) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#immutability-1">RecoveryServicesVault#immutability</a>.
        /// </summary>
        [<CustomOperation "immutability">]
        member _.Immutability(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Immutability <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// monitoring block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#monitoring-1">RecoveryServicesVault#monitoring</a>
        /// </summary>
        [<CustomOperation "monitoring">]
        member _.Monitoring(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.RecoveryServicesVault.RecoveryServicesVaultMonitoring) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Monitoring <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#public_network_access_enabled-1">RecoveryServicesVault#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#public_network_access_enabled-1">RecoveryServicesVault#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#soft_delete_enabled-1">RecoveryServicesVault#soft_delete_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "soft_delete_enabled">]
        member _.SoftDeleteEnabled(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SoftDeleteEnabled <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#soft_delete_enabled-1">RecoveryServicesVault#soft_delete_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "soft_delete_enabled">]
        member _.SoftDeleteEnabled(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.SoftDeleteEnabled <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#storage_mode_type-1">RecoveryServicesVault#storage_mode_type</a>.
        /// </summary>
        [<CustomOperation "storage_mode_type">]
        member _.StorageModeType(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.StorageModeType <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#tags-1">RecoveryServicesVault#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/recovery_services_vault#timeouts-1">RecoveryServicesVault#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.RecoveryServicesVault.RecoveryServicesVaultTimeouts) : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RecoveryServicesVaultState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: RecoveryServicesVaultState<Present, Present, Present, Present>) : azurerm.RecoveryServicesVault.RecoveryServicesVault =
            let config = azurerm.RecoveryServicesVault.RecoveryServicesVaultConfig()
            for setter in state.assignments do
                setter config
            azurerm.RecoveryServicesVault.RecoveryServicesVault(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.recoveryServicesVault: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: RecoveryServicesVaultState<_, _, _, _>) : azurerm.RecoveryServicesVault.RecoveryServicesVault =
            Unchecked.defaultof<azurerm.RecoveryServicesVault.RecoveryServicesVault>
