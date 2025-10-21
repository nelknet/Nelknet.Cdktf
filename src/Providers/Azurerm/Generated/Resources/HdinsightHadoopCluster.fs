namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> = { assignments: ResizeArray<azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster">azurerm_hdinsight_hadoop_cluster</a>.
    /// </summary>
    type HdinsightHadoopClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : HdinsightHadoopClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HdinsightHadoopClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HdinsightHadoopClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HdinsightHadoopClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#cluster_version-1">HdinsightHadoopCluster#cluster_version</a>.
        /// </summary>
        [<CustomOperation "cluster_version">]
        member _.ClusterVersion(state: HdinsightHadoopClusterState<Missing, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightHadoopClusterState<Present, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ClusterVersion <- value)
            ({ assignments = state.assignments } : HdinsightHadoopClusterState<Present, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// component_version block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#component_version-1">HdinsightHadoopCluster#component_version</a>
        /// </summary>
        [<CustomOperation "component_version">]
        member _.ComponentVersion(state: HdinsightHadoopClusterState<'ClusterVersion, Missing, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterComponentVersion) : HdinsightHadoopClusterState<'ClusterVersion, Present, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ComponentVersion <- value)
            ({ assignments = state.assignments } : HdinsightHadoopClusterState<'ClusterVersion, Present, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// gateway block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#gateway-1">HdinsightHadoopCluster#gateway</a>
        /// </summary>
        [<CustomOperation "gateway">]
        member _.Gateway(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, Missing, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterGateway) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, Present, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Gateway <- value)
            ({ assignments = state.assignments } : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, Present, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#location-1">HdinsightHadoopCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Missing, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Present, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Present, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#name-1">HdinsightHadoopCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Missing, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Present, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Present, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#resource_group_name-1">HdinsightHadoopCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Missing, 'Roles, 'Tier>, value: string) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Present, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Present, 'Roles, 'Tier>)

        /// <summary>
        /// roles block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#roles-1">HdinsightHadoopCluster#roles</a>
        /// </summary>
        [<CustomOperation "roles">]
        member _.Roles(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Missing, 'Tier>, value: azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterRoles) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Present, 'Tier> =
            state.assignments.Add(fun config -> config.Roles <- value)
            ({ assignments = state.assignments } : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Present, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#tier-1">HdinsightHadoopCluster#tier</a>.
        /// </summary>
        [<CustomOperation "tier">]
        member _.Tier(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Missing>, value: string) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Present> =
            state.assignments.Add(fun config -> config.Tier <- value)
            ({ assignments = state.assignments } : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Present>)

        /// <summary>
        /// compute_isolation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#compute_isolation-1">HdinsightHadoopCluster#compute_isolation</a>
        /// </summary>
        [<CustomOperation "compute_isolation">]
        member _.ComputeIsolation(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterComputeIsolation) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ComputeIsolation <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// disk_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#disk_encryption-1">HdinsightHadoopCluster#disk_encryption</a> Accepts: azurerm.IResolvable | azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterDiskEncryption[]
        /// </summary>
        [<CustomOperation "disk_encryption">]
        member _.DiskEncryption(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.DiskEncryption <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// extension block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#extension-1">HdinsightHadoopCluster#extension</a>
        /// </summary>
        [<CustomOperation "extension">]
        member _.Extension(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterExtension) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Extension <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#id-1">HdinsightHadoopCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// metastores block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#metastores-1">HdinsightHadoopCluster#metastores</a>
        /// </summary>
        [<CustomOperation "metastores">]
        member _.Metastores(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterMetastores) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Metastores <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// monitor block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#monitor-1">HdinsightHadoopCluster#monitor</a>
        /// </summary>
        [<CustomOperation "monitor">]
        member _.Monitor(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterMonitor) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Monitor <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// network block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#network-1">HdinsightHadoopCluster#network</a>
        /// </summary>
        [<CustomOperation "network">]
        member _.Network(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterNetwork) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Network <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// private_link_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#private_link_configuration-1">HdinsightHadoopCluster#private_link_configuration</a>
        /// </summary>
        [<CustomOperation "private_link_configuration">]
        member _.PrivateLinkConfiguration(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterPrivateLinkConfiguration) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.PrivateLinkConfiguration <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// security_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#security_profile-1">HdinsightHadoopCluster#security_profile</a>
        /// </summary>
        [<CustomOperation "security_profile">]
        member _.SecurityProfile(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterSecurityProfile) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.SecurityProfile <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#storage_account-1">HdinsightHadoopCluster#storage_account</a> Accepts: azurerm.IResolvable | azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// storage_account_gen2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#storage_account_gen2-1">HdinsightHadoopCluster#storage_account_gen2</a>
        /// </summary>
        [<CustomOperation "storage_account_gen2">]
        member _.StorageAccountGen2(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterStorageAccountGen2) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.StorageAccountGen2 <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#tags-1">HdinsightHadoopCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: seq<string * string>) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#timeouts-1">HdinsightHadoopCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterTimeouts) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#tls_min_version-1">HdinsightHadoopCluster#tls_min_version</a>.
        /// </summary>
        [<CustomOperation "tls_min_version">]
        member _.TlsMinVersion(state: HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.TlsMinVersion <- value)
            state : HdinsightHadoopClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        member _.Run(state: HdinsightHadoopClusterState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.HdinsightHadoopCluster.HdinsightHadoopCluster =
            let config = azurerm.HdinsightHadoopCluster.HdinsightHadoopClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.HdinsightHadoopCluster.HdinsightHadoopCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.hdinsightHadoopCluster: missing required arguments. Must call: cluster_version, component_version, gateway, location, name, resource_group_name, roles, tier.", 9999, IsError = true)>]
        member _.Run(_: HdinsightHadoopClusterState<_, _, _, _, _, _, _, _>) : azurerm.HdinsightHadoopCluster.HdinsightHadoopCluster =
            Unchecked.defaultof<azurerm.HdinsightHadoopCluster.HdinsightHadoopCluster>
