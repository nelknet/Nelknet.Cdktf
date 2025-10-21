namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStackHciClusterState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermStackHciCluster.DataAzurermStackHciClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stack_hci_cluster">azurerm_stack_hci_cluster</a>.
    /// </summary>
    type DataAzurermStackHciClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStackHciClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStackHciClusterState<Missing, Missing>)

        member _.Zero(()) : DataAzurermStackHciClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStackHciClusterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stack_hci_cluster#name-1">DataAzurermStackHciCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermStackHciClusterState<Missing, 'ResourceGroupName>, value: string) : DataAzurermStackHciClusterState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermStackHciClusterState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stack_hci_cluster#resource_group_name-1">DataAzurermStackHciCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermStackHciClusterState<'Name, Missing>, value: string) : DataAzurermStackHciClusterState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermStackHciClusterState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stack_hci_cluster#id-1">DataAzurermStackHciCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStackHciClusterState<'Name, 'ResourceGroupName>, value: string) : DataAzurermStackHciClusterState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStackHciClusterState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/stack_hci_cluster#timeouts-1">DataAzurermStackHciCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStackHciClusterState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermStackHciCluster.DataAzurermStackHciClusterTimeouts) : DataAzurermStackHciClusterState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStackHciClusterState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermStackHciClusterState<Present, Present>) : azurerm.DataAzurermStackHciCluster.DataAzurermStackHciCluster =
            let config = azurerm.DataAzurermStackHciCluster.DataAzurermStackHciClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStackHciCluster.DataAzurermStackHciCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStackHciCluster: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStackHciClusterState<_, _>) : azurerm.DataAzurermStackHciCluster.DataAzurermStackHciCluster =
            Unchecked.defaultof<azurerm.DataAzurermStackHciCluster.DataAzurermStackHciCluster>
