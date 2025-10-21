namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKustoClusterState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermKustoCluster.DataAzurermKustoClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_cluster">azurerm_kusto_cluster</a>.
    /// </summary>
    type DataAzurermKustoClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKustoClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKustoClusterState<Missing, Missing>)

        member _.Zero(()) : DataAzurermKustoClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKustoClusterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_cluster#name-1">DataAzurermKustoCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKustoClusterState<Missing, 'ResourceGroupName>, value: string) : DataAzurermKustoClusterState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKustoClusterState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_cluster#resource_group_name-1">DataAzurermKustoCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermKustoClusterState<'Name, Missing>, value: string) : DataAzurermKustoClusterState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermKustoClusterState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_cluster#id-1">DataAzurermKustoCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKustoClusterState<'Name, 'ResourceGroupName>, value: string) : DataAzurermKustoClusterState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKustoClusterState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_cluster#timeouts-1">DataAzurermKustoCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKustoClusterState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermKustoCluster.DataAzurermKustoClusterTimeouts) : DataAzurermKustoClusterState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKustoClusterState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermKustoClusterState<Present, Present>) : azurerm.DataAzurermKustoCluster.DataAzurermKustoCluster =
            let config = azurerm.DataAzurermKustoCluster.DataAzurermKustoClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKustoCluster.DataAzurermKustoCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKustoCluster: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKustoClusterState<_, _>) : azurerm.DataAzurermKustoCluster.DataAzurermKustoCluster =
            Unchecked.defaultof<azurerm.DataAzurermKustoCluster.DataAzurermKustoCluster>
