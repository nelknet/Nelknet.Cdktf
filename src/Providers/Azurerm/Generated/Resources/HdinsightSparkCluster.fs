namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> = { assignments: ResizeArray<azurerm.HdinsightSparkCluster.HdinsightSparkClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster">azurerm_hdinsight_spark_cluster</a>.
    /// </summary>
    type HdinsightSparkClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : HdinsightSparkClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HdinsightSparkClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HdinsightSparkClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HdinsightSparkClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#cluster_version-1">HdinsightSparkCluster#cluster_version</a>.
        /// </summary>
        [<CustomOperation "cluster_version">]
        member _.ClusterVersion(state: HdinsightSparkClusterState<Missing, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightSparkClusterState<Present, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ClusterVersion <- value)
            ({ assignments = state.assignments } : HdinsightSparkClusterState<Present, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// component_version block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#component_version-1">HdinsightSparkCluster#component_version</a>
        /// </summary>
        [<CustomOperation "component_version">]
        member _.ComponentVersion(state: HdinsightSparkClusterState<'ClusterVersion, Missing, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightSparkCluster.HdinsightSparkClusterComponentVersion) : HdinsightSparkClusterState<'ClusterVersion, Present, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ComponentVersion <- value)
            ({ assignments = state.assignments } : HdinsightSparkClusterState<'ClusterVersion, Present, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// gateway block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#gateway-1">HdinsightSparkCluster#gateway</a>
        /// </summary>
        [<CustomOperation "gateway">]
        member _.Gateway(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, Missing, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightSparkCluster.HdinsightSparkClusterGateway) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, Present, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Gateway <- value)
            ({ assignments = state.assignments } : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, Present, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#location-1">HdinsightSparkCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Missing, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Present, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Present, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#name-1">HdinsightSparkCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Missing, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Present, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Present, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#resource_group_name-1">HdinsightSparkCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Missing, 'Roles, 'Tier>, value: string) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Present, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Present, 'Roles, 'Tier>)

        /// <summary>
        /// roles block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#roles-1">HdinsightSparkCluster#roles</a>
        /// </summary>
        [<CustomOperation "roles">]
        member _.Roles(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Missing, 'Tier>, value: azurerm.HdinsightSparkCluster.HdinsightSparkClusterRoles) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Present, 'Tier> =
            state.assignments.Add(fun config -> config.Roles <- value)
            ({ assignments = state.assignments } : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Present, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#tier-1">HdinsightSparkCluster#tier</a>.
        /// </summary>
        [<CustomOperation "tier">]
        member _.Tier(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Missing>, value: string) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Present> =
            state.assignments.Add(fun config -> config.Tier <- value)
            ({ assignments = state.assignments } : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Present>)

        /// <summary>
        /// compute_isolation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#compute_isolation-1">HdinsightSparkCluster#compute_isolation</a>
        /// </summary>
        [<CustomOperation "compute_isolation">]
        member _.ComputeIsolation(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightSparkCluster.HdinsightSparkClusterComputeIsolation) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ComputeIsolation <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// disk_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#disk_encryption-1">HdinsightSparkCluster#disk_encryption</a> Accepts: azurerm.IResolvable | azurerm.HdinsightSparkCluster.HdinsightSparkClusterDiskEncryption[]
        /// </summary>
        [<CustomOperation "disk_encryption">]
        member _.DiskEncryption(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.DiskEncryption <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#encryption_in_transit_enabled-1">HdinsightSparkCluster#encryption_in_transit_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_in_transit_enabled">]
        member _.EncryptionInTransitEnabled(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: bool) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.EncryptionInTransitEnabled <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#encryption_in_transit_enabled-1">HdinsightSparkCluster#encryption_in_transit_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_in_transit_enabled">]
        member _.EncryptionInTransitEnabled(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.EncryptionInTransitEnabled <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// extension block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#extension-1">HdinsightSparkCluster#extension</a>
        /// </summary>
        [<CustomOperation "extension">]
        member _.Extension(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightSparkCluster.HdinsightSparkClusterExtension) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Extension <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#id-1">HdinsightSparkCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// metastores block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#metastores-1">HdinsightSparkCluster#metastores</a>
        /// </summary>
        [<CustomOperation "metastores">]
        member _.Metastores(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightSparkCluster.HdinsightSparkClusterMetastores) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Metastores <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// monitor block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#monitor-1">HdinsightSparkCluster#monitor</a>
        /// </summary>
        [<CustomOperation "monitor">]
        member _.Monitor(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightSparkCluster.HdinsightSparkClusterMonitor) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Monitor <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// network block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#network-1">HdinsightSparkCluster#network</a>
        /// </summary>
        [<CustomOperation "network">]
        member _.Network(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightSparkCluster.HdinsightSparkClusterNetwork) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Network <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// private_link_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#private_link_configuration-1">HdinsightSparkCluster#private_link_configuration</a>
        /// </summary>
        [<CustomOperation "private_link_configuration">]
        member _.PrivateLinkConfiguration(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightSparkCluster.HdinsightSparkClusterPrivateLinkConfiguration) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.PrivateLinkConfiguration <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// security_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#security_profile-1">HdinsightSparkCluster#security_profile</a>
        /// </summary>
        [<CustomOperation "security_profile">]
        member _.SecurityProfile(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightSparkCluster.HdinsightSparkClusterSecurityProfile) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.SecurityProfile <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#storage_account-1">HdinsightSparkCluster#storage_account</a> Accepts: azurerm.IResolvable | azurerm.HdinsightSparkCluster.HdinsightSparkClusterStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// storage_account_gen2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#storage_account_gen2-1">HdinsightSparkCluster#storage_account_gen2</a>
        /// </summary>
        [<CustomOperation "storage_account_gen2">]
        member _.StorageAccountGen2(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightSparkCluster.HdinsightSparkClusterStorageAccountGen2) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.StorageAccountGen2 <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#tags-1">HdinsightSparkCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: seq<string * string>) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#timeouts-1">HdinsightSparkCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightSparkCluster.HdinsightSparkClusterTimeouts) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#tls_min_version-1">HdinsightSparkCluster#tls_min_version</a>.
        /// </summary>
        [<CustomOperation "tls_min_version">]
        member _.TlsMinVersion(state: HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.TlsMinVersion <- value)
            state : HdinsightSparkClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        member _.Run(state: HdinsightSparkClusterState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.HdinsightSparkCluster.HdinsightSparkCluster =
            let config = azurerm.HdinsightSparkCluster.HdinsightSparkClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.HdinsightSparkCluster.HdinsightSparkCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.hdinsightSparkCluster: missing required arguments. Must call: cluster_version, component_version, gateway, location, name, resource_group_name, roles, tier.", 9999, IsError = true)>]
        member _.Run(_: HdinsightSparkClusterState<_, _, _, _, _, _, _, _>) : azurerm.HdinsightSparkCluster.HdinsightSparkCluster =
            Unchecked.defaultof<azurerm.HdinsightSparkCluster.HdinsightSparkCluster>
