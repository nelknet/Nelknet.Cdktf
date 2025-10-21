namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name> = { assignments: ResizeArray<azurerm.MachineLearningInferenceCluster.MachineLearningInferenceClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster">azurerm_machine_learning_inference_cluster</a>.
    /// </summary>
    type MachineLearningInferenceClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : MachineLearningInferenceClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningInferenceClusterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MachineLearningInferenceClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningInferenceClusterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster#kubernetes_cluster_id-1">MachineLearningInferenceCluster#kubernetes_cluster_id</a>.
        /// </summary>
        [<CustomOperation "kubernetes_cluster_id">]
        member _.KubernetesClusterId(state: MachineLearningInferenceClusterState<Missing, 'Location, 'MachineLearningWorkspaceId, 'Name>, value: string) : MachineLearningInferenceClusterState<Present, 'Location, 'MachineLearningWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.KubernetesClusterId <- value)
            ({ assignments = state.assignments } : MachineLearningInferenceClusterState<Present, 'Location, 'MachineLearningWorkspaceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster#location-1">MachineLearningInferenceCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MachineLearningInferenceClusterState<'KubernetesClusterId, Missing, 'MachineLearningWorkspaceId, 'Name>, value: string) : MachineLearningInferenceClusterState<'KubernetesClusterId, Present, 'MachineLearningWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MachineLearningInferenceClusterState<'KubernetesClusterId, Present, 'MachineLearningWorkspaceId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster#machine_learning_workspace_id-1">MachineLearningInferenceCluster#machine_learning_workspace_id</a>.
        /// </summary>
        [<CustomOperation "machine_learning_workspace_id">]
        member _.MachineLearningWorkspaceId(state: MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, Missing, 'Name>, value: string) : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, Present, 'Name> =
            state.assignments.Add(fun config -> config.MachineLearningWorkspaceId <- value)
            ({ assignments = state.assignments } : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster#name-1">MachineLearningInferenceCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, Missing>, value: string) : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster#cluster_purpose-1">MachineLearningInferenceCluster#cluster_purpose</a>.
        /// </summary>
        [<CustomOperation "cluster_purpose">]
        member _.ClusterPurpose(state: MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>, value: string) : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.ClusterPurpose <- value)
            state : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster#description-1">MachineLearningInferenceCluster#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>, value: string) : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster#id-1">MachineLearningInferenceCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>, value: string) : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster#identity-1">MachineLearningInferenceCluster#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>, value: azurerm.MachineLearningInferenceCluster.MachineLearningInferenceClusterIdentity) : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>

        /// <summary>
        /// ssl block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster#ssl-1">MachineLearningInferenceCluster#ssl</a>
        /// </summary>
        [<CustomOperation "ssl">]
        member _.Ssl(state: MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>, value: azurerm.MachineLearningInferenceCluster.MachineLearningInferenceClusterSsl) : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Ssl <- value)
            state : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster#tags-1">MachineLearningInferenceCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>, value: seq<string * string>) : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_inference_cluster#timeouts-1">MachineLearningInferenceCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>, value: azurerm.MachineLearningInferenceCluster.MachineLearningInferenceClusterTimeouts) : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MachineLearningInferenceClusterState<'KubernetesClusterId, 'Location, 'MachineLearningWorkspaceId, 'Name>

        member _.Run(state: MachineLearningInferenceClusterState<Present, Present, Present, Present>) : azurerm.MachineLearningInferenceCluster.MachineLearningInferenceCluster =
            let config = azurerm.MachineLearningInferenceCluster.MachineLearningInferenceClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.MachineLearningInferenceCluster.MachineLearningInferenceCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.machineLearningInferenceCluster: missing required arguments. Must call: kubernetes_cluster_id, location, machine_learning_workspace_id, name.", 9999, IsError = true)>]
        member _.Run(_: MachineLearningInferenceClusterState<_, _, _, _>) : azurerm.MachineLearningInferenceCluster.MachineLearningInferenceCluster =
            Unchecked.defaultof<azurerm.MachineLearningInferenceCluster.MachineLearningInferenceCluster>
