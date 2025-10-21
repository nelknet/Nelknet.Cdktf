namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> = { assignments: ResizeArray<azurerm.PostgresqlServer.PostgresqlServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server">azurerm_postgresql_server</a>.
    /// </summary>
    type PostgresqlServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : PostgresqlServerState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlServerState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PostgresqlServerState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PostgresqlServerState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#location-1">PostgresqlServer#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PostgresqlServerState<Missing, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: string) : PostgresqlServerState<Present, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PostgresqlServerState<Present, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#name-1">PostgresqlServer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PostgresqlServerState<'Location, Missing, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: string) : PostgresqlServerState<'Location, Present, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PostgresqlServerState<'Location, Present, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#resource_group_name-1">PostgresqlServer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PostgresqlServerState<'Location, 'Name, Missing, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: string) : PostgresqlServerState<'Location, 'Name, Present, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PostgresqlServerState<'Location, 'Name, Present, 'SkuName, 'SslEnforcementEnabled, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#sku_name-1">PostgresqlServer#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, Missing, 'SslEnforcementEnabled, 'Version>, value: string) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, Present, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, Present, 'SslEnforcementEnabled, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#ssl_enforcement_enabled-1">PostgresqlServer#ssl_enforcement_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ssl_enforcement_enabled">]
        member _.SslEnforcementEnabled(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Missing, 'Version>, value: bool) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Present, 'Version> =
            state.assignments.Add(fun config -> config.SslEnforcementEnabled <- value)
            ({ assignments = state.assignments } : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#ssl_enforcement_enabled-1">PostgresqlServer#ssl_enforcement_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ssl_enforcement_enabled">]
        member _.SslEnforcementEnabled(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Missing, 'Version>, value: HashiCorp.Cdktf.IResolvable) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Present, 'Version> =
            state.assignments.Add(fun config -> config.SslEnforcementEnabled <- value)
            ({ assignments = state.assignments } : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#version-1">PostgresqlServer#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, Missing>, value: string) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#administrator_login-1">PostgresqlServer#administrator_login</a>.
        /// </summary>
        [<CustomOperation "administrator_login">]
        member _.AdministratorLogin(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: string) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.AdministratorLogin <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#administrator_login_password-1">PostgresqlServer#administrator_login_password</a>.
        /// </summary>
        [<CustomOperation "administrator_login_password">]
        member _.AdministratorLoginPassword(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: string) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.AdministratorLoginPassword <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#auto_grow_enabled-1">PostgresqlServer#auto_grow_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_grow_enabled">]
        member _.AutoGrowEnabled(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: bool) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.AutoGrowEnabled <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#auto_grow_enabled-1">PostgresqlServer#auto_grow_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_grow_enabled">]
        member _.AutoGrowEnabled(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: HashiCorp.Cdktf.IResolvable) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.AutoGrowEnabled <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#backup_retention_days-1">PostgresqlServer#backup_retention_days</a>.
        /// </summary>
        [<CustomOperation "backup_retention_days">]
        member _.BackupRetentionDays(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: double) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.BackupRetentionDays <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#create_mode-1">PostgresqlServer#create_mode</a>.
        /// </summary>
        [<CustomOperation "create_mode">]
        member _.CreateMode(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: string) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.CreateMode <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#creation_source_server_id-1">PostgresqlServer#creation_source_server_id</a>.
        /// </summary>
        [<CustomOperation "creation_source_server_id">]
        member _.CreationSourceServerId(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: string) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.CreationSourceServerId <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#geo_redundant_backup_enabled-1">PostgresqlServer#geo_redundant_backup_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "geo_redundant_backup_enabled">]
        member _.GeoRedundantBackupEnabled(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: bool) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.GeoRedundantBackupEnabled <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#geo_redundant_backup_enabled-1">PostgresqlServer#geo_redundant_backup_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "geo_redundant_backup_enabled">]
        member _.GeoRedundantBackupEnabled(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: HashiCorp.Cdktf.IResolvable) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.GeoRedundantBackupEnabled <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#id-1">PostgresqlServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: string) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#identity-1">PostgresqlServer#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: azurerm.PostgresqlServer.PostgresqlServerIdentity) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#infrastructure_encryption_enabled-1">PostgresqlServer#infrastructure_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "infrastructure_encryption_enabled">]
        member _.InfrastructureEncryptionEnabled(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: bool) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.InfrastructureEncryptionEnabled <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#infrastructure_encryption_enabled-1">PostgresqlServer#infrastructure_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "infrastructure_encryption_enabled">]
        member _.InfrastructureEncryptionEnabled(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: HashiCorp.Cdktf.IResolvable) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.InfrastructureEncryptionEnabled <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#public_network_access_enabled-1">PostgresqlServer#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: bool) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#public_network_access_enabled-1">PostgresqlServer#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: HashiCorp.Cdktf.IResolvable) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#restore_point_in_time-1">PostgresqlServer#restore_point_in_time</a>.
        /// </summary>
        [<CustomOperation "restore_point_in_time">]
        member _.RestorePointInTime(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: string) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.RestorePointInTime <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#ssl_minimal_tls_version_enforced-1">PostgresqlServer#ssl_minimal_tls_version_enforced</a>.
        /// </summary>
        [<CustomOperation "ssl_minimal_tls_version_enforced">]
        member _.SslMinimalTlsVersionEnforced(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: string) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.SslMinimalTlsVersionEnforced <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#storage_mb-1">PostgresqlServer#storage_mb</a>.
        /// </summary>
        [<CustomOperation "storage_mb">]
        member _.StorageMb(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: double) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.StorageMb <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#tags-1">PostgresqlServer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: seq<string * string>) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// threat_detection_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#threat_detection_policy-1">PostgresqlServer#threat_detection_policy</a>
        /// </summary>
        [<CustomOperation "threat_detection_policy">]
        member _.ThreatDetectionPolicy(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: azurerm.PostgresqlServer.PostgresqlServerThreatDetectionPolicy) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.ThreatDetectionPolicy <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#timeouts-1">PostgresqlServer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>, value: azurerm.PostgresqlServer.PostgresqlServerTimeouts) : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PostgresqlServerState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SslEnforcementEnabled, 'Version>

        member _.Run(state: PostgresqlServerState<Present, Present, Present, Present, Present, Present>) : azurerm.PostgresqlServer.PostgresqlServer =
            let config = azurerm.PostgresqlServer.PostgresqlServerConfig()
            for setter in state.assignments do
                setter config
            azurerm.PostgresqlServer.PostgresqlServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.postgresqlServer: missing required arguments. Must call: location, name, resource_group_name, sku_name, ssl_enforcement_enabled, version.", 9999, IsError = true)>]
        member _.Run(_: PostgresqlServerState<_, _, _, _, _, _>) : azurerm.PostgresqlServer.PostgresqlServer =
            Unchecked.defaultof<azurerm.PostgresqlServer.PostgresqlServer>
