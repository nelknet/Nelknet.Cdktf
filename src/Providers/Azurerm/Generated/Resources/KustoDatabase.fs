namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.KustoDatabase.KustoDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database">azurerm_kusto_database</a>.
    /// </summary>
    type KustoDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : KustoDatabaseState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoDatabaseState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KustoDatabaseState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoDatabaseState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database#cluster_name-1">KustoDatabase#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: KustoDatabaseState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoDatabaseState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : KustoDatabaseState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database#location-1">KustoDatabase#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: KustoDatabaseState<'ClusterName, Missing, 'Name, 'ResourceGroupName>, value: string) : KustoDatabaseState<'ClusterName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : KustoDatabaseState<'ClusterName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database#name-1">KustoDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KustoDatabaseState<'ClusterName, 'Location, Missing, 'ResourceGroupName>, value: string) : KustoDatabaseState<'ClusterName, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KustoDatabaseState<'ClusterName, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database#resource_group_name-1">KustoDatabase#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KustoDatabaseState<'ClusterName, 'Location, 'Name, Missing>, value: string) : KustoDatabaseState<'ClusterName, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KustoDatabaseState<'ClusterName, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database#hot_cache_period-1">KustoDatabase#hot_cache_period</a>.
        /// </summary>
        [<CustomOperation "hot_cache_period">]
        member _.HotCachePeriod(state: KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HotCachePeriod <- value)
            state : KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database#id-1">KustoDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database#soft_delete_period-1">KustoDatabase#soft_delete_period</a>.
        /// </summary>
        [<CustomOperation "soft_delete_period">]
        member _.SoftDeletePeriod(state: KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SoftDeletePeriod <- value)
            state : KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_database#timeouts-1">KustoDatabase#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KustoDatabase.KustoDatabaseTimeouts) : KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KustoDatabaseState<'ClusterName, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: KustoDatabaseState<Present, Present, Present, Present>) : azurerm.KustoDatabase.KustoDatabase =
            let config = azurerm.KustoDatabase.KustoDatabaseConfig()
            for setter in state.assignments do
                setter config
            azurerm.KustoDatabase.KustoDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kustoDatabase: missing required arguments. Must call: cluster_name, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: KustoDatabaseState<_, _, _, _>) : azurerm.KustoDatabase.KustoDatabase =
            Unchecked.defaultof<azurerm.KustoDatabase.KustoDatabase>
