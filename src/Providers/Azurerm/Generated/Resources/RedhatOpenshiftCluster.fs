namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile> = { assignments: ResizeArray<azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster">azurerm_redhat_openshift_cluster</a>.
    /// </summary>
    type RedhatOpenshiftClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedhatOpenshiftClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedhatOpenshiftClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RedhatOpenshiftClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedhatOpenshiftClusterState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// api_server_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#api_server_profile-1">RedhatOpenshiftCluster#api_server_profile</a>
        /// </summary>
        [<CustomOperation "api_server_profile">]
        member _.ApiServerProfile(state: RedhatOpenshiftClusterState<Missing, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>, value: azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterApiServerProfile) : RedhatOpenshiftClusterState<Present, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile> =
            state.assignments.Add(fun config -> config.ApiServerProfile <- value)
            ({ assignments = state.assignments } : RedhatOpenshiftClusterState<Present, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>)

        /// <summary>
        /// cluster_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#cluster_profile-1">RedhatOpenshiftCluster#cluster_profile</a>
        /// </summary>
        [<CustomOperation "cluster_profile">]
        member _.ClusterProfile(state: RedhatOpenshiftClusterState<'ApiServerProfile, Missing, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>, value: azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterClusterProfile) : RedhatOpenshiftClusterState<'ApiServerProfile, Present, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile> =
            state.assignments.Add(fun config -> config.ClusterProfile <- value)
            ({ assignments = state.assignments } : RedhatOpenshiftClusterState<'ApiServerProfile, Present, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>)

        /// <summary>
        /// ingress_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#ingress_profile-1">RedhatOpenshiftCluster#ingress_profile</a>
        /// </summary>
        [<CustomOperation "ingress_profile">]
        member _.IngressProfile(state: RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, Missing, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>, value: azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterIngressProfile) : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, Present, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile> =
            state.assignments.Add(fun config -> config.IngressProfile <- value)
            ({ assignments = state.assignments } : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, Present, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#location-1">RedhatOpenshiftCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, Missing, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>, value: string) : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, Present, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, Present, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>)

        /// <summary>
        /// main_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#main_profile-1">RedhatOpenshiftCluster#main_profile</a>
        /// </summary>
        [<CustomOperation "main_profile">]
        member _.MainProfile(state: RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, Missing, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>, value: azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterMainProfile) : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, Present, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile> =
            state.assignments.Add(fun config -> config.MainProfile <- value)
            ({ assignments = state.assignments } : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, Present, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#name-1">RedhatOpenshiftCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, Missing, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>, value: string) : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, Present, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, Present, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>)

        /// <summary>
        /// network_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#network_profile-1">RedhatOpenshiftCluster#network_profile</a>
        /// </summary>
        [<CustomOperation "network_profile">]
        member _.NetworkProfile(state: RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, Missing, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>, value: azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterNetworkProfile) : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, Present, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile> =
            state.assignments.Add(fun config -> config.NetworkProfile <- value)
            ({ assignments = state.assignments } : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, Present, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#resource_group_name-1">RedhatOpenshiftCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, Missing, 'ServicePrincipal, 'WorkerProfile>, value: string) : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, Present, 'ServicePrincipal, 'WorkerProfile> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, Present, 'ServicePrincipal, 'WorkerProfile>)

        /// <summary>
        /// service_principal block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#service_principal-1">RedhatOpenshiftCluster#service_principal</a>
        /// </summary>
        [<CustomOperation "service_principal">]
        member _.ServicePrincipal(state: RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, Missing, 'WorkerProfile>, value: azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterServicePrincipal) : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, Present, 'WorkerProfile> =
            state.assignments.Add(fun config -> config.ServicePrincipal <- value)
            ({ assignments = state.assignments } : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, Present, 'WorkerProfile>)

        /// <summary>
        /// worker_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#worker_profile-1">RedhatOpenshiftCluster#worker_profile</a>
        /// </summary>
        [<CustomOperation "worker_profile">]
        member _.WorkerProfile(state: RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, Missing>, value: azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterWorkerProfile) : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, Present> =
            state.assignments.Add(fun config -> config.WorkerProfile <- value)
            ({ assignments = state.assignments } : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#id-1">RedhatOpenshiftCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>, value: string) : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#tags-1">RedhatOpenshiftCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>, value: seq<string * string>) : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redhat_openshift_cluster#timeouts-1">RedhatOpenshiftCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>, value: azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterTimeouts) : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedhatOpenshiftClusterState<'ApiServerProfile, 'ClusterProfile, 'IngressProfile, 'Location, 'MainProfile, 'Name, 'NetworkProfile, 'ResourceGroupName, 'ServicePrincipal, 'WorkerProfile>

        member _.Run(state: RedhatOpenshiftClusterState<Present, Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.RedhatOpenshiftCluster.RedhatOpenshiftCluster =
            let config = azurerm.RedhatOpenshiftCluster.RedhatOpenshiftClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.RedhatOpenshiftCluster.RedhatOpenshiftCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.redhatOpenshiftCluster: missing required arguments. Must call: api_server_profile, cluster_profile, ingress_profile, location, main_profile, name, network_profile, resource_group_name, service_principal, worker_profile.", 9999, IsError = true)>]
        member _.Run(_: RedhatOpenshiftClusterState<_, _, _, _, _, _, _, _, _, _>) : azurerm.RedhatOpenshiftCluster.RedhatOpenshiftCluster =
            Unchecked.defaultof<azurerm.RedhatOpenshiftCluster.RedhatOpenshiftCluster>
