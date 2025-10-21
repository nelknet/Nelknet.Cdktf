namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.MysqlFlexibleServer.MysqlFlexibleServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server">azurerm_mysql_flexible_server</a>.
    /// </summary>
    type MysqlFlexibleServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : MysqlFlexibleServerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MysqlFlexibleServerState<Missing, Missing, Missing>)

        member _.Zero(()) : MysqlFlexibleServerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MysqlFlexibleServerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#location-1">MysqlFlexibleServer#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MysqlFlexibleServerState<Missing, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#name-1">MysqlFlexibleServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MysqlFlexibleServerState<'Location, Missing, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#resource_group_name-1">MysqlFlexibleServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MysqlFlexibleServerState<'Location, 'Name, Missing>, value: string) : MysqlFlexibleServerState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MysqlFlexibleServerState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#administrator_login-1">MysqlFlexibleServer#administrator_login</a>.
        /// </summary>
        [<CustomOperation "administrator_login">]
        member _.AdministratorLogin(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AdministratorLogin <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#administrator_password-1">MysqlFlexibleServer#administrator_password</a>.
        /// </summary>
        [<CustomOperation "administrator_password">]
        member _.AdministratorPassword(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AdministratorPassword <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#backup_retention_days-1">MysqlFlexibleServer#backup_retention_days</a>.
        /// </summary>
        [<CustomOperation "backup_retention_days">]
        member _.BackupRetentionDays(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: double) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BackupRetentionDays <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#create_mode-1">MysqlFlexibleServer#create_mode</a>.
        /// </summary>
        [<CustomOperation "create_mode">]
        member _.CreateMode(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CreateMode <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// customer_managed_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#customer_managed_key-1">MysqlFlexibleServer#customer_managed_key</a>
        /// </summary>
        [<CustomOperation "customer_managed_key">]
        member _.CustomerManagedKey(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.MysqlFlexibleServer.MysqlFlexibleServerCustomerManagedKey) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomerManagedKey <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#delegated_subnet_id-1">MysqlFlexibleServer#delegated_subnet_id</a>.
        /// </summary>
        [<CustomOperation "delegated_subnet_id">]
        member _.DelegatedSubnetId(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DelegatedSubnetId <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#geo_redundant_backup_enabled-1">MysqlFlexibleServer#geo_redundant_backup_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "geo_redundant_backup_enabled">]
        member _.GeoRedundantBackupEnabled(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: bool) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GeoRedundantBackupEnabled <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#geo_redundant_backup_enabled-1">MysqlFlexibleServer#geo_redundant_backup_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "geo_redundant_backup_enabled">]
        member _.GeoRedundantBackupEnabled(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GeoRedundantBackupEnabled <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// high_availability block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#high_availability-1">MysqlFlexibleServer#high_availability</a>
        /// </summary>
        [<CustomOperation "high_availability">]
        member _.HighAvailability(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.MysqlFlexibleServer.MysqlFlexibleServerHighAvailability) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HighAvailability <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#id-1">MysqlFlexibleServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#identity-1">MysqlFlexibleServer#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.MysqlFlexibleServer.MysqlFlexibleServerIdentity) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// maintenance_window block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#maintenance_window-1">MysqlFlexibleServer#maintenance_window</a>
        /// </summary>
        [<CustomOperation "maintenance_window">]
        member _.MaintenanceWindow(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.MysqlFlexibleServer.MysqlFlexibleServerMaintenanceWindow) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MaintenanceWindow <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#point_in_time_restore_time_in_utc-1">MysqlFlexibleServer#point_in_time_restore_time_in_utc</a>.
        /// </summary>
        [<CustomOperation "point_in_time_restore_time_in_utc">]
        member _.PointInTimeRestoreTimeInUtc(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PointInTimeRestoreTimeInUtc <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#private_dns_zone_id-1">MysqlFlexibleServer#private_dns_zone_id</a>.
        /// </summary>
        [<CustomOperation "private_dns_zone_id">]
        member _.PrivateDnsZoneId(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivateDnsZoneId <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#replication_role-1">MysqlFlexibleServer#replication_role</a>.
        /// </summary>
        [<CustomOperation "replication_role">]
        member _.ReplicationRole(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ReplicationRole <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#sku_name-1">MysqlFlexibleServer#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#source_server_id-1">MysqlFlexibleServer#source_server_id</a>.
        /// </summary>
        [<CustomOperation "source_server_id">]
        member _.SourceServerId(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceServerId <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// storage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#storage-1">MysqlFlexibleServer#storage</a>
        /// </summary>
        [<CustomOperation "storage">]
        member _.Storage(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.MysqlFlexibleServer.MysqlFlexibleServerStorage) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Storage <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#tags-1">MysqlFlexibleServer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#timeouts-1">MysqlFlexibleServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.MysqlFlexibleServer.MysqlFlexibleServerTimeouts) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#version-1">MysqlFlexibleServer#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#zone-1">MysqlFlexibleServer#zone</a>.
        /// </summary>
        [<CustomOperation "zone">]
        member _.Zone(state: MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>, value: string) : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Zone <- value)
            state : MysqlFlexibleServerState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: MysqlFlexibleServerState<Present, Present, Present>) : azurerm.MysqlFlexibleServer.MysqlFlexibleServer =
            let config = azurerm.MysqlFlexibleServer.MysqlFlexibleServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.MysqlFlexibleServer.MysqlFlexibleServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mysqlFlexibleServer: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: MysqlFlexibleServerState<_, _, _>) : azurerm.MysqlFlexibleServer.MysqlFlexibleServer =
            Unchecked.defaultof<azurerm.MysqlFlexibleServer.MysqlFlexibleServer>
