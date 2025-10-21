namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server">azurerm_postgresql_flexible_server</a>.
    /// </summary>
    type PostgresqlFlexibleServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : PostgresqlFlexibleServerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlFlexibleServerState<Missing, Missing, Missing>)

        member _.Zero(()) : PostgresqlFlexibleServerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlFlexibleServerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#location-1">PostgresqlFlexibleServer#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PostgresqlFlexibleServerState<Missing, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#name-1">PostgresqlFlexibleServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PostgresqlFlexibleServerState<'Location, Missing, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#resource_group_name-1">PostgresqlFlexibleServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PostgresqlFlexibleServerState<'Location, 'Name, Missing>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PostgresqlFlexibleServerState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#administrator_login-1">PostgresqlFlexibleServer#administrator_login</a>.
        /// </summary>
        [<CustomOperation "administrator_login">]
        member _.AdministratorLogin(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AdministratorLogin <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#administrator_password-1">PostgresqlFlexibleServer#administrator_password</a>.
        /// </summary>
        [<CustomOperation "administrator_password">]
        member _.AdministratorPassword(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AdministratorPassword <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#authentication-1">PostgresqlFlexibleServer#authentication</a>
        /// </summary>
        [<CustomOperation "authentication">]
        member _.Authentication(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServerAuthentication) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Authentication <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#auto_grow_enabled-1">PostgresqlFlexibleServer#auto_grow_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_grow_enabled">]
        member _.AutoGrowEnabled(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: bool) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoGrowEnabled <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#auto_grow_enabled-1">PostgresqlFlexibleServer#auto_grow_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_grow_enabled">]
        member _.AutoGrowEnabled(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutoGrowEnabled <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#backup_retention_days-1">PostgresqlFlexibleServer#backup_retention_days</a>.
        /// </summary>
        [<CustomOperation "backup_retention_days">]
        member _.BackupRetentionDays(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: double) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BackupRetentionDays <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#create_mode-1">PostgresqlFlexibleServer#create_mode</a>.
        /// </summary>
        [<CustomOperation "create_mode">]
        member _.CreateMode(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CreateMode <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// customer_managed_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#customer_managed_key-1">PostgresqlFlexibleServer#customer_managed_key</a>
        /// </summary>
        [<CustomOperation "customer_managed_key">]
        member _.CustomerManagedKey(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServerCustomerManagedKey) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomerManagedKey <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#delegated_subnet_id-1">PostgresqlFlexibleServer#delegated_subnet_id</a>.
        /// </summary>
        [<CustomOperation "delegated_subnet_id">]
        member _.DelegatedSubnetId(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DelegatedSubnetId <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#geo_redundant_backup_enabled-1">PostgresqlFlexibleServer#geo_redundant_backup_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "geo_redundant_backup_enabled">]
        member _.GeoRedundantBackupEnabled(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: bool) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GeoRedundantBackupEnabled <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#geo_redundant_backup_enabled-1">PostgresqlFlexibleServer#geo_redundant_backup_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "geo_redundant_backup_enabled">]
        member _.GeoRedundantBackupEnabled(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GeoRedundantBackupEnabled <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// high_availability block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#high_availability-1">PostgresqlFlexibleServer#high_availability</a>
        /// </summary>
        [<CustomOperation "high_availability">]
        member _.HighAvailability(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServerHighAvailability) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HighAvailability <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#id-1">PostgresqlFlexibleServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#identity-1">PostgresqlFlexibleServer#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServerIdentity) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// maintenance_window block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#maintenance_window-1">PostgresqlFlexibleServer#maintenance_window</a>
        /// </summary>
        [<CustomOperation "maintenance_window">]
        member _.MaintenanceWindow(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServerMaintenanceWindow) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MaintenanceWindow <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#point_in_time_restore_time_in_utc-1">PostgresqlFlexibleServer#point_in_time_restore_time_in_utc</a>.
        /// </summary>
        [<CustomOperation "point_in_time_restore_time_in_utc">]
        member _.PointInTimeRestoreTimeInUtc(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PointInTimeRestoreTimeInUtc <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#private_dns_zone_id-1">PostgresqlFlexibleServer#private_dns_zone_id</a>.
        /// </summary>
        [<CustomOperation "private_dns_zone_id">]
        member _.PrivateDnsZoneId(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivateDnsZoneId <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#public_network_access_enabled-1">PostgresqlFlexibleServer#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: bool) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#public_network_access_enabled-1">PostgresqlFlexibleServer#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#replication_role-1">PostgresqlFlexibleServer#replication_role</a>.
        /// </summary>
        [<CustomOperation "replication_role">]
        member _.ReplicationRole(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ReplicationRole <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#sku_name-1">PostgresqlFlexibleServer#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#source_server_id-1">PostgresqlFlexibleServer#source_server_id</a>.
        /// </summary>
        [<CustomOperation "source_server_id">]
        member _.SourceServerId(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceServerId <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#storage_mb-1">PostgresqlFlexibleServer#storage_mb</a>.
        /// </summary>
        [<CustomOperation "storage_mb">]
        member _.StorageMb(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: double) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageMb <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#storage_tier-1">PostgresqlFlexibleServer#storage_tier</a>.
        /// </summary>
        [<CustomOperation "storage_tier">]
        member _.StorageTier(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StorageTier <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#tags-1">PostgresqlFlexibleServer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#timeouts-1">PostgresqlFlexibleServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServerTimeouts) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#version-1">PostgresqlFlexibleServer#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#zone-1">PostgresqlFlexibleServer#zone</a>.
        /// </summary>
        [<CustomOperation "zone">]
        member _.Zone(state: PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Zone <- value)
            state : PostgresqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: PostgresqlFlexibleServerState<Present, Present, Present>) : azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServer =
            let config = azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.postgresqlFlexibleServer: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: PostgresqlFlexibleServerState<_, _, _>) : azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServer =
            Unchecked.defaultof<azurerm.PostgresqlFlexibleServer.PostgresqlFlexibleServer>
