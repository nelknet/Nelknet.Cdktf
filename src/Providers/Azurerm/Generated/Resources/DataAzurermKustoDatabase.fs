namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKustoDatabaseState<'ClusterName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermKustoDatabase.DataAzurermKustoDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_database">azurerm_kusto_database</a>.
    /// </summary>
    type DataAzurermKustoDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKustoDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKustoDatabaseState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermKustoDatabaseState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKustoDatabaseState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_database#cluster_name-1">DataAzurermKustoDatabase#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: DataAzurermKustoDatabaseState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermKustoDatabaseState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : DataAzurermKustoDatabaseState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_database#name-1">DataAzurermKustoDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermKustoDatabaseState<'ClusterName, Missing, 'ResourceGroupName>, value: string) : DataAzurermKustoDatabaseState<'ClusterName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermKustoDatabaseState<'ClusterName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_database#resource_group_name-1">DataAzurermKustoDatabase#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermKustoDatabaseState<'ClusterName, 'Name, Missing>, value: string) : DataAzurermKustoDatabaseState<'ClusterName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermKustoDatabaseState<'ClusterName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_database#id-1">DataAzurermKustoDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKustoDatabaseState<'ClusterName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermKustoDatabaseState<'ClusterName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKustoDatabaseState<'ClusterName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_database#timeouts-1">DataAzurermKustoDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKustoDatabaseState<'ClusterName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermKustoDatabase.DataAzurermKustoDatabaseTimeouts) : DataAzurermKustoDatabaseState<'ClusterName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKustoDatabaseState<'ClusterName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermKustoDatabaseState<Present, Present, Present>) : azurerm.DataAzurermKustoDatabase.DataAzurermKustoDatabase =
            let config = azurerm.DataAzurermKustoDatabase.DataAzurermKustoDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKustoDatabase.DataAzurermKustoDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKustoDatabase: missing required arguments. Must call: cluster_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKustoDatabaseState<_, _, _>) : azurerm.DataAzurermKustoDatabase.DataAzurermKustoDatabase =
            Unchecked.defaultof<azurerm.DataAzurermKustoDatabase.DataAzurermKustoDatabase>
