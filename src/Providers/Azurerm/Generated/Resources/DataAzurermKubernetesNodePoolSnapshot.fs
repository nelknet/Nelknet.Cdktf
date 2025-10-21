namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKubernetesNodePoolSnapshotState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermKubernetesNodePoolSnapshot.DataAzurermKubernetesNodePoolSnapshotConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_node_pool_snapshot">azurerm_kubernetes_node_pool_snapshot</a>.
    /// </summary>
    type DataAzurermKubernetesNodePoolSnapshotBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKubernetesNodePoolSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKubernetesNodePoolSnapshotState<Missing, Missing>)

        member _.Zero(()) : DataAzurermKubernetesNodePoolSnapshotState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKubernetesNodePoolSnapshotState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_node_pool_snapshot#name-1">DataAzurermKubernetesNodePoolSnapshot#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKubernetesNodePoolSnapshotState<Missing, 'ResourceGroupName>, value: string) : DataAzurermKubernetesNodePoolSnapshotState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKubernetesNodePoolSnapshotState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_node_pool_snapshot#resource_group_name-1">DataAzurermKubernetesNodePoolSnapshot#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermKubernetesNodePoolSnapshotState<'Name, Missing>, value: string) : DataAzurermKubernetesNodePoolSnapshotState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermKubernetesNodePoolSnapshotState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_node_pool_snapshot#id-1">DataAzurermKubernetesNodePoolSnapshot#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKubernetesNodePoolSnapshotState<'Name, 'ResourceGroupName>, value: string) : DataAzurermKubernetesNodePoolSnapshotState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKubernetesNodePoolSnapshotState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_node_pool_snapshot#timeouts-1">DataAzurermKubernetesNodePoolSnapshot#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKubernetesNodePoolSnapshotState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermKubernetesNodePoolSnapshot.DataAzurermKubernetesNodePoolSnapshotTimeouts) : DataAzurermKubernetesNodePoolSnapshotState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKubernetesNodePoolSnapshotState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermKubernetesNodePoolSnapshotState<Present, Present>) : azurerm.DataAzurermKubernetesNodePoolSnapshot.DataAzurermKubernetesNodePoolSnapshot =
            let config = azurerm.DataAzurermKubernetesNodePoolSnapshot.DataAzurermKubernetesNodePoolSnapshotConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKubernetesNodePoolSnapshot.DataAzurermKubernetesNodePoolSnapshot(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKubernetesNodePoolSnapshot: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKubernetesNodePoolSnapshotState<_, _>) : azurerm.DataAzurermKubernetesNodePoolSnapshot.DataAzurermKubernetesNodePoolSnapshot =
            Unchecked.defaultof<azurerm.DataAzurermKubernetesNodePoolSnapshot.DataAzurermKubernetesNodePoolSnapshot>
