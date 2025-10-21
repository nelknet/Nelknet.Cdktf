namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> = { assignments: ResizeArray<azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster">azurerm_hdinsight_kafka_cluster</a>.
    /// </summary>
    type HdinsightKafkaClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : HdinsightKafkaClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HdinsightKafkaClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HdinsightKafkaClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HdinsightKafkaClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#cluster_version-1">HdinsightKafkaCluster#cluster_version</a>.
        /// </summary>
        [<CustomOperation "cluster_version">]
        member _.ClusterVersion(state: HdinsightKafkaClusterState<Missing, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightKafkaClusterState<Present, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ClusterVersion <- value)
            ({ assignments = state.assignments } : HdinsightKafkaClusterState<Present, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// component_version block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#component_version-1">HdinsightKafkaCluster#component_version</a>
        /// </summary>
        [<CustomOperation "component_version">]
        member _.ComponentVersion(state: HdinsightKafkaClusterState<'ClusterVersion, Missing, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterComponentVersion) : HdinsightKafkaClusterState<'ClusterVersion, Present, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ComponentVersion <- value)
            ({ assignments = state.assignments } : HdinsightKafkaClusterState<'ClusterVersion, Present, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// gateway block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#gateway-1">HdinsightKafkaCluster#gateway</a>
        /// </summary>
        [<CustomOperation "gateway">]
        member _.Gateway(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, Missing, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterGateway) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, Present, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Gateway <- value)
            ({ assignments = state.assignments } : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, Present, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#location-1">HdinsightKafkaCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Missing, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Present, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Present, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#name-1">HdinsightKafkaCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Missing, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Present, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Present, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#resource_group_name-1">HdinsightKafkaCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Missing, 'Roles, 'Tier>, value: string) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Present, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Present, 'Roles, 'Tier>)

        /// <summary>
        /// roles block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#roles-1">HdinsightKafkaCluster#roles</a>
        /// </summary>
        [<CustomOperation "roles">]
        member _.Roles(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Missing, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRoles) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Present, 'Tier> =
            state.assignments.Add(fun config -> config.Roles <- value)
            ({ assignments = state.assignments } : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Present, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#tier-1">HdinsightKafkaCluster#tier</a>.
        /// </summary>
        [<CustomOperation "tier">]
        member _.Tier(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Missing>, value: string) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Present> =
            state.assignments.Add(fun config -> config.Tier <- value)
            ({ assignments = state.assignments } : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Present>)

        /// <summary>
        /// compute_isolation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#compute_isolation-1">HdinsightKafkaCluster#compute_isolation</a>
        /// </summary>
        [<CustomOperation "compute_isolation">]
        member _.ComputeIsolation(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterComputeIsolation) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ComputeIsolation <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// disk_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#disk_encryption-1">HdinsightKafkaCluster#disk_encryption</a> Accepts: azurerm.IResolvable | azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterDiskEncryption[]
        /// </summary>
        [<CustomOperation "disk_encryption">]
        member _.DiskEncryption(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.DiskEncryption <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#encryption_in_transit_enabled-1">HdinsightKafkaCluster#encryption_in_transit_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_in_transit_enabled">]
        member _.EncryptionInTransitEnabled(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: bool) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.EncryptionInTransitEnabled <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#encryption_in_transit_enabled-1">HdinsightKafkaCluster#encryption_in_transit_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_in_transit_enabled">]
        member _.EncryptionInTransitEnabled(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.EncryptionInTransitEnabled <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// extension block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#extension-1">HdinsightKafkaCluster#extension</a>
        /// </summary>
        [<CustomOperation "extension">]
        member _.Extension(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterExtension) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Extension <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#id-1">HdinsightKafkaCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// metastores block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#metastores-1">HdinsightKafkaCluster#metastores</a>
        /// </summary>
        [<CustomOperation "metastores">]
        member _.Metastores(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMetastores) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Metastores <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// monitor block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#monitor-1">HdinsightKafkaCluster#monitor</a>
        /// </summary>
        [<CustomOperation "monitor">]
        member _.Monitor(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterMonitor) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Monitor <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// network block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#network-1">HdinsightKafkaCluster#network</a>
        /// </summary>
        [<CustomOperation "network">]
        member _.Network(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterNetwork) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Network <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// private_link_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#private_link_configuration-1">HdinsightKafkaCluster#private_link_configuration</a>
        /// </summary>
        [<CustomOperation "private_link_configuration">]
        member _.PrivateLinkConfiguration(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterPrivateLinkConfiguration) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.PrivateLinkConfiguration <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// rest_proxy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#rest_proxy-1">HdinsightKafkaCluster#rest_proxy</a>
        /// </summary>
        [<CustomOperation "rest_proxy">]
        member _.RestProxy(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterRestProxy) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.RestProxy <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// security_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#security_profile-1">HdinsightKafkaCluster#security_profile</a>
        /// </summary>
        [<CustomOperation "security_profile">]
        member _.SecurityProfile(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterSecurityProfile) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.SecurityProfile <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#storage_account-1">HdinsightKafkaCluster#storage_account</a> Accepts: azurerm.IResolvable | azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// storage_account_gen2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#storage_account_gen2-1">HdinsightKafkaCluster#storage_account_gen2</a>
        /// </summary>
        [<CustomOperation "storage_account_gen2">]
        member _.StorageAccountGen2(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterStorageAccountGen2) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.StorageAccountGen2 <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#tags-1">HdinsightKafkaCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: seq<string * string>) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#timeouts-1">HdinsightKafkaCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterTimeouts) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_kafka_cluster#tls_min_version-1">HdinsightKafkaCluster#tls_min_version</a>.
        /// </summary>
        [<CustomOperation "tls_min_version">]
        member _.TlsMinVersion(state: HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.TlsMinVersion <- value)
            state : HdinsightKafkaClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        member _.Run(state: HdinsightKafkaClusterState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.HdinsightKafkaCluster.HdinsightKafkaCluster =
            let config = azurerm.HdinsightKafkaCluster.HdinsightKafkaClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.HdinsightKafkaCluster.HdinsightKafkaCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.hdinsightKafkaCluster: missing required arguments. Must call: cluster_version, component_version, gateway, location, name, resource_group_name, roles, tier.", 9999, IsError = true)>]
        member _.Run(_: HdinsightKafkaClusterState<_, _, _, _, _, _, _, _>) : azurerm.HdinsightKafkaCluster.HdinsightKafkaCluster =
            Unchecked.defaultof<azurerm.HdinsightKafkaCluster.HdinsightKafkaCluster>
