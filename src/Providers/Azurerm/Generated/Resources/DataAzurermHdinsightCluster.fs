namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermHdinsightClusterState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermHdinsightCluster.DataAzurermHdinsightClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/hdinsight_cluster">azurerm_hdinsight_cluster</a>.
    /// </summary>
    type DataAzurermHdinsightClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermHdinsightClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermHdinsightClusterState<Missing, Missing>)

        member _.Zero(()) : DataAzurermHdinsightClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermHdinsightClusterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/hdinsight_cluster#name-1">DataAzurermHdinsightCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermHdinsightClusterState<Missing, 'ResourceGroupName>, value: string) : DataAzurermHdinsightClusterState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermHdinsightClusterState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/hdinsight_cluster#resource_group_name-1">DataAzurermHdinsightCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermHdinsightClusterState<'Name, Missing>, value: string) : DataAzurermHdinsightClusterState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermHdinsightClusterState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/hdinsight_cluster#id-1">DataAzurermHdinsightCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermHdinsightClusterState<'Name, 'ResourceGroupName>, value: string) : DataAzurermHdinsightClusterState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermHdinsightClusterState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/hdinsight_cluster#timeouts-1">DataAzurermHdinsightCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermHdinsightClusterState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermHdinsightCluster.DataAzurermHdinsightClusterTimeouts) : DataAzurermHdinsightClusterState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermHdinsightClusterState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermHdinsightClusterState<Present, Present>) : azurerm.DataAzurermHdinsightCluster.DataAzurermHdinsightCluster =
            let config = azurerm.DataAzurermHdinsightCluster.DataAzurermHdinsightClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermHdinsightCluster.DataAzurermHdinsightCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermHdinsightCluster: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermHdinsightClusterState<_, _>) : azurerm.DataAzurermHdinsightCluster.DataAzurermHdinsightCluster =
            Unchecked.defaultof<azurerm.DataAzurermHdinsightCluster.DataAzurermHdinsightCluster>
