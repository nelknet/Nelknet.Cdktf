namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name> = { assignments: ResizeArray<azurerm.CosmosdbCassandraDatacenter.CosmosdbCassandraDatacenterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter">azurerm_cosmosdb_cassandra_datacenter</a>.
    /// </summary>
    type CosmosdbCassandraDatacenterBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbCassandraDatacenterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbCassandraDatacenterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbCassandraDatacenterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbCassandraDatacenterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#cassandra_cluster_id-1">CosmosdbCassandraDatacenter#cassandra_cluster_id</a>.
        /// </summary>
        [<CustomOperation "cassandra_cluster_id">]
        member _.CassandraClusterId(state: CosmosdbCassandraDatacenterState<Missing, 'DelegatedManagementSubnetId, 'Location, 'Name>, value: string) : CosmosdbCassandraDatacenterState<Present, 'DelegatedManagementSubnetId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.CassandraClusterId <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraDatacenterState<Present, 'DelegatedManagementSubnetId, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#delegated_management_subnet_id-1">CosmosdbCassandraDatacenter#delegated_management_subnet_id</a>.
        /// </summary>
        [<CustomOperation "delegated_management_subnet_id">]
        member _.DelegatedManagementSubnetId(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, Missing, 'Location, 'Name>, value: string) : CosmosdbCassandraDatacenterState<'CassandraClusterId, Present, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.DelegatedManagementSubnetId <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraDatacenterState<'CassandraClusterId, Present, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#location-1">CosmosdbCassandraDatacenter#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, Missing, 'Name>, value: string) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#name-1">CosmosdbCassandraDatacenter#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, Missing>, value: string) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#availability_zones_enabled-1">CosmosdbCassandraDatacenter#availability_zones_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "availability_zones_enabled">]
        member _.AvailabilityZonesEnabled(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>, value: bool) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.AvailabilityZonesEnabled <- value)
            state : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#availability_zones_enabled-1">CosmosdbCassandraDatacenter#availability_zones_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "availability_zones_enabled">]
        member _.AvailabilityZonesEnabled(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.AvailabilityZonesEnabled <- value)
            state : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#backup_storage_customer_key_uri-1">CosmosdbCassandraDatacenter#backup_storage_customer_key_uri</a>.
        /// </summary>
        [<CustomOperation "backup_storage_customer_key_uri">]
        member _.BackupStorageCustomerKeyUri(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>, value: string) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.BackupStorageCustomerKeyUri <- value)
            state : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#base64_encoded_yaml_fragment-1">CosmosdbCassandraDatacenter#base64_encoded_yaml_fragment</a>.
        /// </summary>
        [<CustomOperation "base64_encoded_yaml_fragment">]
        member _.Base64EncodedYamlFragment(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>, value: string) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Base64EncodedYamlFragment <- value)
            state : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#disk_count-1">CosmosdbCassandraDatacenter#disk_count</a>.
        /// </summary>
        [<CustomOperation "disk_count">]
        member _.DiskCount(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>, value: double) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.DiskCount <- value)
            state : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#disk_sku-1">CosmosdbCassandraDatacenter#disk_sku</a>.
        /// </summary>
        [<CustomOperation "disk_sku">]
        member _.DiskSku(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>, value: string) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.DiskSku <- value)
            state : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#id-1">CosmosdbCassandraDatacenter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>, value: string) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#managed_disk_customer_key_uri-1">CosmosdbCassandraDatacenter#managed_disk_customer_key_uri</a>.
        /// </summary>
        [<CustomOperation "managed_disk_customer_key_uri">]
        member _.ManagedDiskCustomerKeyUri(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>, value: string) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.ManagedDiskCustomerKeyUri <- value)
            state : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#node_count-1">CosmosdbCassandraDatacenter#node_count</a>.
        /// </summary>
        [<CustomOperation "node_count">]
        member _.NodeCount(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>, value: double) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.NodeCount <- value)
            state : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#sku_name-1">CosmosdbCassandraDatacenter#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>, value: string) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            state : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_datacenter#timeouts-1">CosmosdbCassandraDatacenter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>, value: azurerm.CosmosdbCassandraDatacenter.CosmosdbCassandraDatacenterTimeouts) : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbCassandraDatacenterState<'CassandraClusterId, 'DelegatedManagementSubnetId, 'Location, 'Name>

        member _.Run(state: CosmosdbCassandraDatacenterState<Present, Present, Present, Present>) : azurerm.CosmosdbCassandraDatacenter.CosmosdbCassandraDatacenter =
            let config = azurerm.CosmosdbCassandraDatacenter.CosmosdbCassandraDatacenterConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbCassandraDatacenter.CosmosdbCassandraDatacenter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbCassandraDatacenter: missing required arguments. Must call: cassandra_cluster_id, delegated_management_subnet_id, location, name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbCassandraDatacenterState<_, _, _, _>) : azurerm.CosmosdbCassandraDatacenter.CosmosdbCassandraDatacenter =
            Unchecked.defaultof<azurerm.CosmosdbCassandraDatacenter.CosmosdbCassandraDatacenter>
