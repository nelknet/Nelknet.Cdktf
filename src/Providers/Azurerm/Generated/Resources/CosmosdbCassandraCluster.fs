namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbCassandraCluster.CosmosdbCassandraClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster">azurerm_cosmosdb_cassandra_cluster</a>.
    /// </summary>
    type CosmosdbCassandraClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbCassandraClusterState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbCassandraClusterState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbCassandraClusterState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbCassandraClusterState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#default_admin_password-1">CosmosdbCassandraCluster#default_admin_password</a>.
        /// </summary>
        [<CustomOperation "default_admin_password">]
        member _.DefaultAdminPassword(state: CosmosdbCassandraClusterState<Missing, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: string) : CosmosdbCassandraClusterState<Present, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefaultAdminPassword <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraClusterState<Present, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#delegated_management_subnet_id-1">CosmosdbCassandraCluster#delegated_management_subnet_id</a>.
        /// </summary>
        [<CustomOperation "delegated_management_subnet_id">]
        member _.DelegatedManagementSubnetId(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : CosmosdbCassandraClusterState<'DefaultAdminPassword, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DelegatedManagementSubnetId <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraClusterState<'DefaultAdminPassword, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#location-1">CosmosdbCassandraCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, Missing, 'Name, 'ResourceGroupName>, value: string) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#name-1">CosmosdbCassandraCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, Missing, 'ResourceGroupName>, value: string) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#resource_group_name-1">CosmosdbCassandraCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, Missing>, value: string) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#authentication_method-1">CosmosdbCassandraCluster#authentication_method</a>.
        /// </summary>
        [<CustomOperation "authentication_method">]
        member _.AuthenticationMethod(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: string) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuthenticationMethod <- value)
            state : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#client_certificate_pems-1">CosmosdbCassandraCluster#client_certificate_pems</a>.
        /// </summary>
        [<CustomOperation "client_certificate_pems">]
        member _.ClientCertificatePems(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClientCertificatePems <- (value |> Seq.toArray))
            state : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#external_gossip_certificate_pems-1">CosmosdbCassandraCluster#external_gossip_certificate_pems</a>.
        /// </summary>
        [<CustomOperation "external_gossip_certificate_pems">]
        member _.ExternalGossipCertificatePems(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExternalGossipCertificatePems <- (value |> Seq.toArray))
            state : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#external_seed_node_ip_addresses-1">CosmosdbCassandraCluster#external_seed_node_ip_addresses</a>.
        /// </summary>
        [<CustomOperation "external_seed_node_ip_addresses">]
        member _.ExternalSeedNodeIpAddresses(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ExternalSeedNodeIpAddresses <- (value |> Seq.toArray))
            state : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#hours_between_backups-1">CosmosdbCassandraCluster#hours_between_backups</a>.
        /// </summary>
        [<CustomOperation "hours_between_backups">]
        member _.HoursBetweenBackups(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: double) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HoursBetweenBackups <- value)
            state : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#id-1">CosmosdbCassandraCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: string) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#identity-1">CosmosdbCassandraCluster#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbCassandraCluster.CosmosdbCassandraClusterIdentity) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#repair_enabled-1">CosmosdbCassandraCluster#repair_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "repair_enabled">]
        member _.RepairEnabled(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: bool) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RepairEnabled <- value)
            state : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#repair_enabled-1">CosmosdbCassandraCluster#repair_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "repair_enabled">]
        member _.RepairEnabled(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RepairEnabled <- value)
            state : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#tags-1">CosmosdbCassandraCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#timeouts-1">CosmosdbCassandraCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.CosmosdbCassandraCluster.CosmosdbCassandraClusterTimeouts) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_cassandra_cluster#version-1">CosmosdbCassandraCluster#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>, value: string) : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : CosmosdbCassandraClusterState<'DefaultAdminPassword, 'DelegatedManagementSubnetId, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: CosmosdbCassandraClusterState<Present, Present, Present, Present, Present>) : azurerm.CosmosdbCassandraCluster.CosmosdbCassandraCluster =
            let config = azurerm.CosmosdbCassandraCluster.CosmosdbCassandraClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbCassandraCluster.CosmosdbCassandraCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbCassandraCluster: missing required arguments. Must call: default_admin_password, delegated_management_subnet_id, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbCassandraClusterState<_, _, _, _, _>) : azurerm.CosmosdbCassandraCluster.CosmosdbCassandraCluster =
            Unchecked.defaultof<azurerm.CosmosdbCassandraCluster.CosmosdbCassandraCluster>
