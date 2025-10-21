namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.KustoAttachedDatabaseConfiguration.KustoAttachedDatabaseConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_attached_database_configuration">azurerm_kusto_attached_database_configuration</a>.
    /// </summary>
    type KustoAttachedDatabaseConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : KustoAttachedDatabaseConfigurationState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoAttachedDatabaseConfigurationState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KustoAttachedDatabaseConfigurationState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoAttachedDatabaseConfigurationState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_attached_database_configuration#cluster_name-1">KustoAttachedDatabaseConfiguration#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: KustoAttachedDatabaseConfigurationState<Missing, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoAttachedDatabaseConfigurationState<Present, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : KustoAttachedDatabaseConfigurationState<Present, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_attached_database_configuration#cluster_resource_id-1">KustoAttachedDatabaseConfiguration#cluster_resource_id</a>.
        /// </summary>
        [<CustomOperation "cluster_resource_id">]
        member _.ClusterResourceId(state: KustoAttachedDatabaseConfigurationState<'ClusterName, Missing, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoAttachedDatabaseConfigurationState<'ClusterName, Present, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClusterResourceId <- value)
            ({ assignments = state.assignments } : KustoAttachedDatabaseConfigurationState<'ClusterName, Present, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_attached_database_configuration#database_name-1">KustoAttachedDatabaseConfiguration#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_attached_database_configuration#location-1">KustoAttachedDatabaseConfiguration#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, Missing, 'Name, 'ResourceGroupName>, value: string) : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_attached_database_configuration#name-1">KustoAttachedDatabaseConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, Missing, 'ResourceGroupName>, value: string) : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_attached_database_configuration#resource_group_name-1">KustoAttachedDatabaseConfiguration#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, Missing>, value: string) : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_attached_database_configuration#default_principal_modification_kind-1">KustoAttachedDatabaseConfiguration#default_principal_modification_kind</a>.
        /// </summary>
        [<CustomOperation "default_principal_modification_kind">]
        member _.DefaultPrincipalModificationKind(state: KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefaultPrincipalModificationKind <- value)
            state : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_attached_database_configuration#id-1">KustoAttachedDatabaseConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName>, value: string) : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// sharing block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_attached_database_configuration#sharing-1">KustoAttachedDatabaseConfiguration#sharing</a>
        /// </summary>
        [<CustomOperation "sharing">]
        member _.Sharing(state: KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KustoAttachedDatabaseConfiguration.KustoAttachedDatabaseConfigurationSharing) : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sharing <- value)
            state : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_attached_database_configuration#timeouts-1">KustoAttachedDatabaseConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.KustoAttachedDatabaseConfiguration.KustoAttachedDatabaseConfigurationTimeouts) : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KustoAttachedDatabaseConfigurationState<'ClusterName, 'ClusterResourceId, 'DatabaseName, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: KustoAttachedDatabaseConfigurationState<Present, Present, Present, Present, Present, Present>) : azurerm.KustoAttachedDatabaseConfiguration.KustoAttachedDatabaseConfiguration =
            let config = azurerm.KustoAttachedDatabaseConfiguration.KustoAttachedDatabaseConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.KustoAttachedDatabaseConfiguration.KustoAttachedDatabaseConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kustoAttachedDatabaseConfiguration: missing required arguments. Must call: cluster_name, cluster_resource_id, database_name, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: KustoAttachedDatabaseConfigurationState<_, _, _, _, _, _>) : azurerm.KustoAttachedDatabaseConfiguration.KustoAttachedDatabaseConfiguration =
            Unchecked.defaultof<azurerm.KustoAttachedDatabaseConfiguration.KustoAttachedDatabaseConfiguration>
