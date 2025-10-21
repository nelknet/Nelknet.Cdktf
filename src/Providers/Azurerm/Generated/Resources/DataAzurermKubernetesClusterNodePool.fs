namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermKubernetesClusterNodePool.DataAzurermKubernetesClusterNodePoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster_node_pool">azurerm_kubernetes_cluster_node_pool</a>.
    /// </summary>
    type DataAzurermKubernetesClusterNodePoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKubernetesClusterNodePoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKubernetesClusterNodePoolState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermKubernetesClusterNodePoolState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKubernetesClusterNodePoolState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster_node_pool#kubernetes_cluster_name-1">DataAzurermKubernetesClusterNodePool#kubernetes_cluster_name</a>.
        /// </summary>
        [<CustomOperation "kubernetes_cluster_name">]
        member _.KubernetesClusterName(state: DataAzurermKubernetesClusterNodePoolState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermKubernetesClusterNodePoolState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KubernetesClusterName <- value)
            ({ assignments = state.assignments } : DataAzurermKubernetesClusterNodePoolState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster_node_pool#name-1">DataAzurermKubernetesClusterNodePool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, Missing, 'ResourceGroupName>, value: string) : DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster_node_pool#resource_group_name-1">DataAzurermKubernetesClusterNodePool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, 'Name, Missing>, value: string) : DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster_node_pool#id-1">DataAzurermKubernetesClusterNodePool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster_node_pool#timeouts-1">DataAzurermKubernetesClusterNodePool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermKubernetesClusterNodePool.DataAzurermKubernetesClusterNodePoolTimeouts) : DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKubernetesClusterNodePoolState<'KubernetesClusterName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermKubernetesClusterNodePoolState<Present, Present, Present>) : azurerm.DataAzurermKubernetesClusterNodePool.DataAzurermKubernetesClusterNodePool =
            let config = azurerm.DataAzurermKubernetesClusterNodePool.DataAzurermKubernetesClusterNodePoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKubernetesClusterNodePool.DataAzurermKubernetesClusterNodePool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKubernetesClusterNodePool: missing required arguments. Must call: kubernetes_cluster_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKubernetesClusterNodePoolState<_, _, _>) : azurerm.DataAzurermKubernetesClusterNodePool.DataAzurermKubernetesClusterNodePool =
            Unchecked.defaultof<azurerm.DataAzurermKubernetesClusterNodePool.DataAzurermKubernetesClusterNodePool>
