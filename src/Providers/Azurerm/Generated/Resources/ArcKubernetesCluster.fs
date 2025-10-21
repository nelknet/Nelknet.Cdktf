namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ArcKubernetesCluster.ArcKubernetesClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster">azurerm_arc_kubernetes_cluster</a>.
    /// </summary>
    type ArcKubernetesClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : ArcKubernetesClusterState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ArcKubernetesClusterState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ArcKubernetesClusterState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ArcKubernetesClusterState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster#agent_public_key_certificate-1">ArcKubernetesCluster#agent_public_key_certificate</a>.
        /// </summary>
        [<CustomOperation "agent_public_key_certificate">]
        member _.AgentPublicKeyCertificate(state: ArcKubernetesClusterState<Missing, 'Identity, 'Location, 'Name, 'ResourceGroupName>, value: string) : ArcKubernetesClusterState<Present, 'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AgentPublicKeyCertificate <- value)
            ({ assignments = state.assignments } : ArcKubernetesClusterState<Present, 'Identity, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster#identity-1">ArcKubernetesCluster#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ArcKubernetesClusterState<'AgentPublicKeyCertificate, Missing, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.ArcKubernetesCluster.ArcKubernetesClusterIdentity) : ArcKubernetesClusterState<'AgentPublicKeyCertificate, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : ArcKubernetesClusterState<'AgentPublicKeyCertificate, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster#location-1">ArcKubernetesCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, Missing, 'Name, 'ResourceGroupName>, value: string) : ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster#name-1">ArcKubernetesCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, Missing, 'ResourceGroupName>, value: string) : ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster#resource_group_name-1">ArcKubernetesCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, Missing>, value: string) : ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster#id-1">ArcKubernetesCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, 'ResourceGroupName>, value: string) : ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster#tags-1">ArcKubernetesCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster#timeouts-1">ArcKubernetesCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.ArcKubernetesCluster.ArcKubernetesClusterTimeouts) : ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ArcKubernetesClusterState<'AgentPublicKeyCertificate, 'Identity, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ArcKubernetesClusterState<Present, Present, Present, Present, Present>) : azurerm.ArcKubernetesCluster.ArcKubernetesCluster =
            let config = azurerm.ArcKubernetesCluster.ArcKubernetesClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.ArcKubernetesCluster.ArcKubernetesCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.arcKubernetesCluster: missing required arguments. Must call: agent_public_key_certificate, identity, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ArcKubernetesClusterState<_, _, _, _, _>) : azurerm.ArcKubernetesCluster.ArcKubernetesCluster =
            Unchecked.defaultof<azurerm.ArcKubernetesCluster.ArcKubernetesCluster>
