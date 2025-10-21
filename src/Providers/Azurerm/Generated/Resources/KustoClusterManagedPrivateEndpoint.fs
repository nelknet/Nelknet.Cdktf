namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.KustoClusterManagedPrivateEndpoint.KustoClusterManagedPrivateEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_managed_private_endpoint">azurerm_kusto_cluster_managed_private_endpoint</a>.
    /// </summary>
    type KustoClusterManagedPrivateEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : KustoClusterManagedPrivateEndpointState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoClusterManagedPrivateEndpointState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KustoClusterManagedPrivateEndpointState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoClusterManagedPrivateEndpointState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_managed_private_endpoint#cluster_name-1">KustoClusterManagedPrivateEndpoint#cluster_name</a>.
        /// </summary>
        [<CustomOperation "cluster_name">]
        member _.ClusterName(state: KustoClusterManagedPrivateEndpointState<Missing, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName>, value: string) : KustoClusterManagedPrivateEndpointState<Present, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ClusterName <- value)
            ({ assignments = state.assignments } : KustoClusterManagedPrivateEndpointState<Present, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_managed_private_endpoint#group_id-1">KustoClusterManagedPrivateEndpoint#group_id</a>.
        /// </summary>
        [<CustomOperation "group_id">]
        member _.GroupId(state: KustoClusterManagedPrivateEndpointState<'ClusterName, Missing, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName>, value: string) : KustoClusterManagedPrivateEndpointState<'ClusterName, Present, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GroupId <- value)
            ({ assignments = state.assignments } : KustoClusterManagedPrivateEndpointState<'ClusterName, Present, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_managed_private_endpoint#name-1">KustoClusterManagedPrivateEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, Missing, 'PrivateLinkResourceId, 'ResourceGroupName>, value: string) : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, Present, 'PrivateLinkResourceId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, Present, 'PrivateLinkResourceId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_managed_private_endpoint#private_link_resource_id-1">KustoClusterManagedPrivateEndpoint#private_link_resource_id</a>.
        /// </summary>
        [<CustomOperation "private_link_resource_id">]
        member _.PrivateLinkResourceId(state: KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, Missing, 'ResourceGroupName>, value: string) : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivateLinkResourceId <- value)
            ({ assignments = state.assignments } : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_managed_private_endpoint#resource_group_name-1">KustoClusterManagedPrivateEndpoint#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, Missing>, value: string) : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_managed_private_endpoint#id-1">KustoClusterManagedPrivateEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName>, value: string) : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_managed_private_endpoint#private_link_resource_region-1">KustoClusterManagedPrivateEndpoint#private_link_resource_region</a>.
        /// </summary>
        [<CustomOperation "private_link_resource_region">]
        member _.PrivateLinkResourceRegion(state: KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName>, value: string) : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PrivateLinkResourceRegion <- value)
            state : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_managed_private_endpoint#request_message-1">KustoClusterManagedPrivateEndpoint#request_message</a>.
        /// </summary>
        [<CustomOperation "request_message">]
        member _.RequestMessage(state: KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName>, value: string) : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RequestMessage <- value)
            state : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster_managed_private_endpoint#timeouts-1">KustoClusterManagedPrivateEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName>, value: azurerm.KustoClusterManagedPrivateEndpoint.KustoClusterManagedPrivateEndpointTimeouts) : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KustoClusterManagedPrivateEndpointState<'ClusterName, 'GroupId, 'Name, 'PrivateLinkResourceId, 'ResourceGroupName>

        member _.Run(state: KustoClusterManagedPrivateEndpointState<Present, Present, Present, Present, Present>) : azurerm.KustoClusterManagedPrivateEndpoint.KustoClusterManagedPrivateEndpoint =
            let config = azurerm.KustoClusterManagedPrivateEndpoint.KustoClusterManagedPrivateEndpointConfig()
            for setter in state.assignments do
                setter config
            azurerm.KustoClusterManagedPrivateEndpoint.KustoClusterManagedPrivateEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kustoClusterManagedPrivateEndpoint: missing required arguments. Must call: cluster_name, group_id, name, private_link_resource_id, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: KustoClusterManagedPrivateEndpointState<_, _, _, _, _>) : azurerm.KustoClusterManagedPrivateEndpoint.KustoClusterManagedPrivateEndpoint =
            Unchecked.defaultof<azurerm.KustoClusterManagedPrivateEndpoint.KustoClusterManagedPrivateEndpoint>
