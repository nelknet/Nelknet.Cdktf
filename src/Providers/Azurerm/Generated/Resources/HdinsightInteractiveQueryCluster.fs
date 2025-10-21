namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> = { assignments: ResizeArray<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster">azurerm_hdinsight_interactive_query_cluster</a>.
    /// </summary>
    type HdinsightInteractiveQueryClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : HdinsightInteractiveQueryClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HdinsightInteractiveQueryClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HdinsightInteractiveQueryClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HdinsightInteractiveQueryClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#cluster_version-1">HdinsightInteractiveQueryCluster#cluster_version</a>.
        /// </summary>
        [<CustomOperation "cluster_version">]
        member _.ClusterVersion(state: HdinsightInteractiveQueryClusterState<Missing, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightInteractiveQueryClusterState<Present, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ClusterVersion <- value)
            ({ assignments = state.assignments } : HdinsightInteractiveQueryClusterState<Present, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// component_version block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#component_version-1">HdinsightInteractiveQueryCluster#component_version</a>
        /// </summary>
        [<CustomOperation "component_version">]
        member _.ComponentVersion(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, Missing, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComponentVersion) : HdinsightInteractiveQueryClusterState<'ClusterVersion, Present, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ComponentVersion <- value)
            ({ assignments = state.assignments } : HdinsightInteractiveQueryClusterState<'ClusterVersion, Present, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// gateway block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#gateway-1">HdinsightInteractiveQueryCluster#gateway</a>
        /// </summary>
        [<CustomOperation "gateway">]
        member _.Gateway(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, Missing, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterGateway) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, Present, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Gateway <- value)
            ({ assignments = state.assignments } : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, Present, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#location-1">HdinsightInteractiveQueryCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Missing, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Present, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, Present, 'Name, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#name-1">HdinsightInteractiveQueryCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Missing, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Present, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, Present, 'ResourceGroupName, 'Roles, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#resource_group_name-1">HdinsightInteractiveQueryCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Missing, 'Roles, 'Tier>, value: string) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Present, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, Present, 'Roles, 'Tier>)

        /// <summary>
        /// roles block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#roles-1">HdinsightInteractiveQueryCluster#roles</a>
        /// </summary>
        [<CustomOperation "roles">]
        member _.Roles(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Missing, 'Tier>, value: azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterRoles) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Present, 'Tier> =
            state.assignments.Add(fun config -> config.Roles <- value)
            ({ assignments = state.assignments } : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, Present, 'Tier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#tier-1">HdinsightInteractiveQueryCluster#tier</a>.
        /// </summary>
        [<CustomOperation "tier">]
        member _.Tier(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Missing>, value: string) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Present> =
            state.assignments.Add(fun config -> config.Tier <- value)
            ({ assignments = state.assignments } : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, Present>)

        /// <summary>
        /// compute_isolation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#compute_isolation-1">HdinsightInteractiveQueryCluster#compute_isolation</a>
        /// </summary>
        [<CustomOperation "compute_isolation">]
        member _.ComputeIsolation(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComputeIsolation) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.ComputeIsolation <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// disk_encryption block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#disk_encryption-1">HdinsightInteractiveQueryCluster#disk_encryption</a> Accepts: azurerm.IResolvable | azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterDiskEncryption[]
        /// </summary>
        [<CustomOperation "disk_encryption">]
        member _.DiskEncryption(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.DiskEncryption <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#encryption_in_transit_enabled-1">HdinsightInteractiveQueryCluster#encryption_in_transit_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_in_transit_enabled">]
        member _.EncryptionInTransitEnabled(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: bool) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.EncryptionInTransitEnabled <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#encryption_in_transit_enabled-1">HdinsightInteractiveQueryCluster#encryption_in_transit_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "encryption_in_transit_enabled">]
        member _.EncryptionInTransitEnabled(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.EncryptionInTransitEnabled <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// extension block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#extension-1">HdinsightInteractiveQueryCluster#extension</a>
        /// </summary>
        [<CustomOperation "extension">]
        member _.Extension(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterExtension) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Extension <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#id-1">HdinsightInteractiveQueryCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// metastores block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#metastores-1">HdinsightInteractiveQueryCluster#metastores</a>
        /// </summary>
        [<CustomOperation "metastores">]
        member _.Metastores(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMetastores) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Metastores <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// monitor block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#monitor-1">HdinsightInteractiveQueryCluster#monitor</a>
        /// </summary>
        [<CustomOperation "monitor">]
        member _.Monitor(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterMonitor) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Monitor <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// network block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#network-1">HdinsightInteractiveQueryCluster#network</a>
        /// </summary>
        [<CustomOperation "network">]
        member _.Network(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterNetwork) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Network <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// private_link_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#private_link_configuration-1">HdinsightInteractiveQueryCluster#private_link_configuration</a>
        /// </summary>
        [<CustomOperation "private_link_configuration">]
        member _.PrivateLinkConfiguration(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterPrivateLinkConfiguration) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.PrivateLinkConfiguration <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// security_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#security_profile-1">HdinsightInteractiveQueryCluster#security_profile</a>
        /// </summary>
        [<CustomOperation "security_profile">]
        member _.SecurityProfile(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterSecurityProfile) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.SecurityProfile <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#storage_account-1">HdinsightInteractiveQueryCluster#storage_account</a> Accepts: azurerm.IResolvable | azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccount[]
        /// </summary>
        [<CustomOperation "storage_account">]
        member _.StorageAccount(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: HashiCorp.Cdktf.IResolvable) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.StorageAccount <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// storage_account_gen2 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#storage_account_gen2-1">HdinsightInteractiveQueryCluster#storage_account_gen2</a>
        /// </summary>
        [<CustomOperation "storage_account_gen2">]
        member _.StorageAccountGen2(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterStorageAccountGen2) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.StorageAccountGen2 <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#tags-1">HdinsightInteractiveQueryCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: seq<string * string>) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#timeouts-1">HdinsightInteractiveQueryCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterTimeouts) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#tls_min_version-1">HdinsightInteractiveQueryCluster#tls_min_version</a>.
        /// </summary>
        [<CustomOperation "tls_min_version">]
        member _.TlsMinVersion(state: HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>, value: string) : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier> =
            state.assignments.Add(fun config -> config.TlsMinVersion <- value)
            state : HdinsightInteractiveQueryClusterState<'ClusterVersion, 'ComponentVersion, 'Gateway, 'Location, 'Name, 'ResourceGroupName, 'Roles, 'Tier>

        member _.Run(state: HdinsightInteractiveQueryClusterState<Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryCluster =
            let config = azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.hdinsightInteractiveQueryCluster: missing required arguments. Must call: cluster_version, component_version, gateway, location, name, resource_group_name, roles, tier.", 9999, IsError = true)>]
        member _.Run(_: HdinsightInteractiveQueryClusterState<_, _, _, _, _, _, _, _>) : azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryCluster =
            Unchecked.defaultof<azurerm.HdinsightInteractiveQueryCluster.HdinsightInteractiveQueryCluster>
