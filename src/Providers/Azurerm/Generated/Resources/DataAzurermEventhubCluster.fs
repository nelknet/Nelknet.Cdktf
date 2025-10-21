namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermEventhubClusterState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermEventhubCluster.DataAzurermEventhubClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_cluster">azurerm_eventhub_cluster</a>.
    /// </summary>
    type DataAzurermEventhubClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermEventhubClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventhubClusterState<Missing, Missing>)

        member _.Zero(()) : DataAzurermEventhubClusterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventhubClusterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_cluster#name-1">DataAzurermEventhubCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermEventhubClusterState<Missing, 'ResourceGroupName>, value: string) : DataAzurermEventhubClusterState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubClusterState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_cluster#resource_group_name-1">DataAzurermEventhubCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermEventhubClusterState<'Name, Missing>, value: string) : DataAzurermEventhubClusterState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubClusterState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_cluster#id-1">DataAzurermEventhubCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermEventhubClusterState<'Name, 'ResourceGroupName>, value: string) : DataAzurermEventhubClusterState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermEventhubClusterState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_cluster#timeouts-1">DataAzurermEventhubCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermEventhubClusterState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermEventhubCluster.DataAzurermEventhubClusterTimeouts) : DataAzurermEventhubClusterState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermEventhubClusterState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermEventhubClusterState<Present, Present>) : azurerm.DataAzurermEventhubCluster.DataAzurermEventhubCluster =
            let config = azurerm.DataAzurermEventhubCluster.DataAzurermEventhubClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermEventhubCluster.DataAzurermEventhubCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermEventhubCluster: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermEventhubClusterState<_, _>) : azurerm.DataAzurermEventhubCluster.DataAzurermEventhubCluster =
            Unchecked.defaultof<azurerm.DataAzurermEventhubCluster.DataAzurermEventhubCluster>
