namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VmwareClusterState<'ClusterNodeCount, 'Name, 'SkuName, 'VmwareCloudId> = { assignments: ResizeArray<azurerm.VmwareCluster.VmwareClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_cluster">azurerm_vmware_cluster</a>.
    /// </summary>
    type VmwareClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : VmwareClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VmwareClusterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : VmwareClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VmwareClusterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_cluster#cluster_node_count-1">VmwareCluster#cluster_node_count</a>.
        /// </summary>
        [<CustomOperation "cluster_node_count">]
        member _.ClusterNodeCount(state: VmwareClusterState<Missing, 'Name, 'SkuName, 'VmwareCloudId>, value: double) : VmwareClusterState<Present, 'Name, 'SkuName, 'VmwareCloudId> =
            state.assignments.Add(fun config -> config.ClusterNodeCount <- value)
            ({ assignments = state.assignments } : VmwareClusterState<Present, 'Name, 'SkuName, 'VmwareCloudId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_cluster#name-1">VmwareCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: VmwareClusterState<'ClusterNodeCount, Missing, 'SkuName, 'VmwareCloudId>, value: string) : VmwareClusterState<'ClusterNodeCount, Present, 'SkuName, 'VmwareCloudId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : VmwareClusterState<'ClusterNodeCount, Present, 'SkuName, 'VmwareCloudId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_cluster#sku_name-1">VmwareCluster#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: VmwareClusterState<'ClusterNodeCount, 'Name, Missing, 'VmwareCloudId>, value: string) : VmwareClusterState<'ClusterNodeCount, 'Name, Present, 'VmwareCloudId> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : VmwareClusterState<'ClusterNodeCount, 'Name, Present, 'VmwareCloudId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_cluster#vmware_cloud_id-1">VmwareCluster#vmware_cloud_id</a>.
        /// </summary>
        [<CustomOperation "vmware_cloud_id">]
        member _.VmwareCloudId(state: VmwareClusterState<'ClusterNodeCount, 'Name, 'SkuName, Missing>, value: string) : VmwareClusterState<'ClusterNodeCount, 'Name, 'SkuName, Present> =
            state.assignments.Add(fun config -> config.VmwareCloudId <- value)
            ({ assignments = state.assignments } : VmwareClusterState<'ClusterNodeCount, 'Name, 'SkuName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_cluster#id-1">VmwareCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VmwareClusterState<'ClusterNodeCount, 'Name, 'SkuName, 'VmwareCloudId>, value: string) : VmwareClusterState<'ClusterNodeCount, 'Name, 'SkuName, 'VmwareCloudId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VmwareClusterState<'ClusterNodeCount, 'Name, 'SkuName, 'VmwareCloudId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_cluster#timeouts-1">VmwareCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VmwareClusterState<'ClusterNodeCount, 'Name, 'SkuName, 'VmwareCloudId>, value: azurerm.VmwareCluster.VmwareClusterTimeouts) : VmwareClusterState<'ClusterNodeCount, 'Name, 'SkuName, 'VmwareCloudId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VmwareClusterState<'ClusterNodeCount, 'Name, 'SkuName, 'VmwareCloudId>

        member _.Run(state: VmwareClusterState<Present, Present, Present, Present>) : azurerm.VmwareCluster.VmwareCluster =
            let config = azurerm.VmwareCluster.VmwareClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.VmwareCluster.VmwareCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.vmwareCluster: missing required arguments. Must call: cluster_node_count, name, sku_name, vmware_cloud_id.", 9999, IsError = true)>]
        member _.Run(_: VmwareClusterState<_, _, _, _>) : azurerm.VmwareCluster.VmwareCluster =
            Unchecked.defaultof<azurerm.VmwareCluster.VmwareCluster>
