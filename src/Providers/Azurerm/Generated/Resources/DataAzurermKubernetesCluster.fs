namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKubernetesClusterState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster">azurerm_kubernetes_cluster</a>.
    /// </summary>
    type DataAzurermKubernetesClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKubernetesClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKubernetesClusterState<Missing, Missing>)

        member _.Zero(()) : DataAzurermKubernetesClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKubernetesClusterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster#name-1">DataAzurermKubernetesCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKubernetesClusterState<Missing, 'ResourceGroupName>, value: string) : DataAzurermKubernetesClusterState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKubernetesClusterState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster#resource_group_name-1">DataAzurermKubernetesCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermKubernetesClusterState<'Name, Missing>, value: string) : DataAzurermKubernetesClusterState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermKubernetesClusterState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster#id-1">DataAzurermKubernetesCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKubernetesClusterState<'Name, 'ResourceGroupName>, value: string) : DataAzurermKubernetesClusterState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKubernetesClusterState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster#timeouts-1">DataAzurermKubernetesCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKubernetesClusterState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterTimeouts) : DataAzurermKubernetesClusterState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKubernetesClusterState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermKubernetesClusterState<Present, Present>) : azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesCluster =
            let config = azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKubernetesCluster: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKubernetesClusterState<_, _>) : azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesCluster =
            Unchecked.defaultof<azurerm.DataAzurermKubernetesCluster.DataAzurermKubernetesCluster>
