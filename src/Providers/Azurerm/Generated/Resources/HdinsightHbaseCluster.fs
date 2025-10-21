namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> = { assignments: ResizeArray<azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster">azurerm_hdinsight_hbase_cluster</a>.
    /// </summary>
    type HdinsightHbaseClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : HdinsightHbaseClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HdinsightHbaseClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HdinsightHbaseClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HdinsightHbaseClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#cluster_version-1">HdinsightHbaseCluster#cluster_version</a>.
        /// </summary>
        [<CustomOperation "cluster_version">]
        member _.ClusterVersion(state: HdinsightHbaseClusterState<Missing, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightHbaseClusterState<Present, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ClusterVersion <- value)
            ({ assignments = state.assignments } : HdinsightHbaseClusterState<Present, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// component_version block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#component_version-1">HdinsightHbaseCluster#component_version</a>
        /// </summary>
        [<CustomOperation "component_version">]
        member _.ComponentVersion(state: HdinsightHbaseClusterState<'ClusterVersion, Missing, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterComponentVersion) : HdinsightHbaseClusterState<'ClusterVersion, Present, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ComponentVersion <- value)
            ({ assignments = state.assignments } : HdinsightHbaseClusterState<'ClusterVersion, Present, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// gateway block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#gateway-1">HdinsightHbaseCluster#gateway</a>
        /// </summary>
        [<CustomOperation "gateway">]
        member _.Gateway(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, Missing, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterGateway) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, Present, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Gateway <- value)
            ({ assignments = state.assignments } : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, Present, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#location-1">HdinsightHbaseCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Missing, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Present, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Present, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#name-1">HdinsightHbaseCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Missing, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Present, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Present, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#resource_group_name-1">HdinsightHbaseCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Missing, 'Roles, 'Tier>, value: string) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Present, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Present, 'Roles, 'Tier>)

        /// <summary>
        /// roles block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#roles-1">HdinsightHbaseCluster#roles</a>
        /// </summary>
        [<CustomOperation "roles">]
        member _.Roles(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Missing, 'Tier>, value: azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterRoles) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Present, 'Tier> =
            state.assignments.Add(fun config -> config.Roles <- value)
            ({ assignments = state.assignments } : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Present, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#tier-1">HdinsightHbaseCluster#tier</a>.
        /// </summary>
        [<CustomOperation "tier">]
        member _.Tier(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Missing>, value: string) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Present> =
            state.assignments.Add(fun config -> config.Tier <- value)
            ({ assignments = state.assignments } : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Present>)

        /// <summary>
        /// compute_isolation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#compute_isolation-1">HdinsightHbaseCluster#compute_isolation</a>
        /// </summary>
        [<CustomOperation "compute_isolation">]
        member _.ComputeIsolation(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterComputeIsolation) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ComputeIsolation <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// disk_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#disk_encryption-1">HdinsightHbaseCluster#disk_encryption</a> Accepts: azurerm.IResolvable | azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterDiskEncryption[]
        /// </summary>
        [<CustomOperation "disk_encryption">]
        member _.DiskEncryption(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.DiskEncryption <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// extension block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#extension-1">HdinsightHbaseCluster#extension</a>
        /// </summary>
        [<CustomOperation "extension">]
        member _.Extension(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterExtension) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Extension <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#id-1">HdinsightHbaseCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// metastores block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#metastores-1">HdinsightHbaseCluster#metastores</a>
        /// </summary>
        [<CustomOperation "metastores">]
        member _.Metastores(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMetastores) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Metastores <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// monitor block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#monitor-1">HdinsightHbaseCluster#monitor</a>
        /// </summary>
        [<CustomOperation "monitor">]
        member _.Monitor(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterMonitor) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Monitor <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// network block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#network-1">HdinsightHbaseCluster#network</a>
        /// </summary>
        [<CustomOperation "network">]
        member _.Network(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterNetwork) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Network <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// private_link_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#private_link_configuration-1">HdinsightHbaseCluster#private_link_configuration</a>
        /// </summary>
        [<CustomOperation "private_link_configuration">]
        member _.PrivateLinkConfiguration(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterPrivateLinkConfiguration) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.PrivateLinkConfiguration <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// security_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#security_profile-1">HdinsightHbaseCluster#security_profile</a>
        /// </summary>
        [<CustomOperation "security_profile">]
        member _.SecurityProfile(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterSecurityProfile) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.SecurityProfile <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#storage_account-1">HdinsightHbaseCluster#storage_account</a> Accepts: azurerm.IResolvable | azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// storage_account_gen2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#storage_account_gen2-1">HdinsightHbaseCluster#storage_account_gen2</a>
        /// </summary>
        [<CustomOperation "storage_account_gen2">]
        member _.StorageAccountGen2(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterStorageAccountGen2) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.StorageAccountGen2 <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#tags-1">HdinsightHbaseCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: seq<string * string>) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#timeouts-1">HdinsightHbaseCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterTimeouts) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hbase_cluster#tls_min_version-1">HdinsightHbaseCluster#tls_min_version</a>.
        /// </summary>
        [<CustomOperation "tls_min_version">]
        member _.TlsMinVersion(state: HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.TlsMinVersion <- value)
            state : HdinsightHbaseClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        member _.Run(state: HdinsightHbaseClusterState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.HdinsightHbaseCluster.HdinsightHbaseCluster =
            let config = azurerm.HdinsightHbaseCluster.HdinsightHbaseClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.HdinsightHbaseCluster.HdinsightHbaseCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.hdinsightHbaseCluster: missing required arguments. Must call: cluster_version, component_version, gateway, location, name, resource_group_name, roles, tier.", 9999, IsError = true)>]
        member _.Run(_: HdinsightHbaseClusterState<_, _, _, _, _, _, _, _>) : azurerm.HdinsightHbaseCluster.HdinsightHbaseCluster =
            Unchecked.defaultof<azurerm.HdinsightHbaseCluster.HdinsightHbaseCluster>
