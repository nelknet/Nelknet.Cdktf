namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbPostgresqlCluster.CosmosdbPostgresqlClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster">azurerm_cosmosdb_postgresql_cluster</a>.
    /// </summary>
    type CosmosdbPostgresqlClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbPostgresqlClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbPostgresqlClusterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbPostgresqlClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbPostgresqlClusterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#location-1">CosmosdbPostgresqlCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: CosmosdbPostgresqlClusterState<Missing, 'Name, 'NodeCount, 'ResourceGroupName>, value: string) : CosmosdbPostgresqlClusterState<Present, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlClusterState<Present, 'Name, 'NodeCount, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#name-1">CosmosdbPostgresqlCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbPostgresqlClusterState<'Location, Missing, 'NodeCount, 'ResourceGroupName>, value: string) : CosmosdbPostgresqlClusterState<'Location, Present, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlClusterState<'Location, Present, 'NodeCount, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#node_count-1">CosmosdbPostgresqlCluster#node_count</a>.
        /// </summary>
        [<CustomOperation "node_count">]
        member _.NodeCount(state: CosmosdbPostgresqlClusterState<'Location, 'Name, Missing, 'ResourceGroupName>, value: double) : CosmosdbPostgresqlClusterState<'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NodeCount <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlClusterState<'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#resource_group_name-1">CosmosdbPostgresqlCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, Missing>, value: string) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#administrator_login_password-1">CosmosdbPostgresqlCluster#administrator_login_password</a>.
        /// </summary>
        [<CustomOperation "administrator_login_password">]
        member _.AdministratorLoginPassword(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: string) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AdministratorLoginPassword <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#citus_version-1">CosmosdbPostgresqlCluster#citus_version</a>.
        /// </summary>
        [<CustomOperation "citus_version">]
        member _.CitusVersion(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: string) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CitusVersion <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_public_ip_access_enabled-1">CosmosdbPostgresqlCluster#coordinator_public_ip_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "coordinator_public_ip_access_enabled">]
        member _.CoordinatorPublicIpAccessEnabled(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: bool) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CoordinatorPublicIpAccessEnabled <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_public_ip_access_enabled-1">CosmosdbPostgresqlCluster#coordinator_public_ip_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "coordinator_public_ip_access_enabled">]
        member _.CoordinatorPublicIpAccessEnabled(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CoordinatorPublicIpAccessEnabled <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_server_edition-1">CosmosdbPostgresqlCluster#coordinator_server_edition</a>.
        /// </summary>
        [<CustomOperation "coordinator_server_edition">]
        member _.CoordinatorServerEdition(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: string) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CoordinatorServerEdition <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_storage_quota_in_mb-1">CosmosdbPostgresqlCluster#coordinator_storage_quota_in_mb</a>.
        /// </summary>
        [<CustomOperation "coordinator_storage_quota_in_mb">]
        member _.CoordinatorStorageQuotaInMb(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: double) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CoordinatorStorageQuotaInMb <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#coordinator_vcore_count-1">CosmosdbPostgresqlCluster#coordinator_vcore_count</a>.
        /// </summary>
        [<CustomOperation "coordinator_vcore_count">]
        member _.CoordinatorVcoreCount(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: double) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CoordinatorVcoreCount <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#ha_enabled-1">CosmosdbPostgresqlCluster#ha_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ha_enabled">]
        member _.HaEnabled(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: bool) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HaEnabled <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#ha_enabled-1">CosmosdbPostgresqlCluster#ha_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "ha_enabled">]
        member _.HaEnabled(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HaEnabled <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#id-1">CosmosdbPostgresqlCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: string) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// maintenance_window block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#maintenance_window-1">CosmosdbPostgresqlCluster#maintenance_window</a>
        /// </summary>
        [<CustomOperation "maintenance_window">]
        member _.MaintenanceWindow(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: azurerm.CosmosdbPostgresqlCluster.CosmosdbPostgresqlClusterMaintenanceWindow) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MaintenanceWindow <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#node_public_ip_access_enabled-1">CosmosdbPostgresqlCluster#node_public_ip_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "node_public_ip_access_enabled">]
        member _.NodePublicIpAccessEnabled(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: bool) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NodePublicIpAccessEnabled <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#node_public_ip_access_enabled-1">CosmosdbPostgresqlCluster#node_public_ip_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "node_public_ip_access_enabled">]
        member _.NodePublicIpAccessEnabled(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NodePublicIpAccessEnabled <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#node_server_edition-1">CosmosdbPostgresqlCluster#node_server_edition</a>.
        /// </summary>
        [<CustomOperation "node_server_edition">]
        member _.NodeServerEdition(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: string) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NodeServerEdition <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#node_storage_quota_in_mb-1">CosmosdbPostgresqlCluster#node_storage_quota_in_mb</a>.
        /// </summary>
        [<CustomOperation "node_storage_quota_in_mb">]
        member _.NodeStorageQuotaInMb(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: double) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NodeStorageQuotaInMb <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#node_vcores-1">CosmosdbPostgresqlCluster#node_vcores</a>.
        /// </summary>
        [<CustomOperation "node_vcores">]
        member _.NodeVcores(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: double) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NodeVcores <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#point_in_time_in_utc-1">CosmosdbPostgresqlCluster#point_in_time_in_utc</a>.
        /// </summary>
        [<CustomOperation "point_in_time_in_utc">]
        member _.PointInTimeInUtc(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: string) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PointInTimeInUtc <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#preferred_primary_zone-1">CosmosdbPostgresqlCluster#preferred_primary_zone</a>.
        /// </summary>
        [<CustomOperation "preferred_primary_zone">]
        member _.PreferredPrimaryZone(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: string) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PreferredPrimaryZone <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#shards_on_coordinator_enabled-1">CosmosdbPostgresqlCluster#shards_on_coordinator_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "shards_on_coordinator_enabled">]
        member _.ShardsOnCoordinatorEnabled(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: bool) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ShardsOnCoordinatorEnabled <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#shards_on_coordinator_enabled-1">CosmosdbPostgresqlCluster#shards_on_coordinator_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "shards_on_coordinator_enabled">]
        member _.ShardsOnCoordinatorEnabled(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ShardsOnCoordinatorEnabled <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#source_location-1">CosmosdbPostgresqlCluster#source_location</a>.
        /// </summary>
        [<CustomOperation "source_location">]
        member _.SourceLocation(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: string) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceLocation <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#source_resource_id-1">CosmosdbPostgresqlCluster#source_resource_id</a>.
        /// </summary>
        [<CustomOperation "source_resource_id">]
        member _.SourceResourceId(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: string) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SourceResourceId <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#sql_version-1">CosmosdbPostgresqlCluster#sql_version</a>.
        /// </summary>
        [<CustomOperation "sql_version">]
        member _.SqlVersion(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: string) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SqlVersion <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#tags-1">CosmosdbPostgresqlCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: seq<string * string>) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#timeouts-1">CosmosdbPostgresqlCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>, value: azurerm.CosmosdbPostgresqlCluster.CosmosdbPostgresqlClusterTimeouts) : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbPostgresqlClusterState<'Location, 'Name, 'NodeCount, 'ResourceGroupName>

        member _.Run(state: CosmosdbPostgresqlClusterState<Present, Present, Present, Present>) : azurerm.CosmosdbPostgresqlCluster.CosmosdbPostgresqlCluster =
            let config = azurerm.CosmosdbPostgresqlCluster.CosmosdbPostgresqlClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbPostgresqlCluster.CosmosdbPostgresqlCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbPostgresqlCluster: missing required arguments. Must call: location, name, node_count, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbPostgresqlClusterState<_, _, _, _>) : azurerm.CosmosdbPostgresqlCluster.CosmosdbPostgresqlCluster =
            Unchecked.defaultof<azurerm.CosmosdbPostgresqlCluster.CosmosdbPostgresqlCluster>
