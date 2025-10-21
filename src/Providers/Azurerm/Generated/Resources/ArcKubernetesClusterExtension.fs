namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name> = { assignments: ResizeArray<azurerm.ArcKubernetesClusterExtension.ArcKubernetesClusterExtensionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension">azurerm_arc_kubernetes_cluster_extension</a>.
    /// </summary>
    type ArcKubernetesClusterExtensionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ArcKubernetesClusterExtensionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ArcKubernetesClusterExtensionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ArcKubernetesClusterExtensionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ArcKubernetesClusterExtensionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#cluster_id-1">ArcKubernetesClusterExtension#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: ArcKubernetesClusterExtensionState<Missing, 'ExtensionType, 'Identity, 'Name>, value: string) : ArcKubernetesClusterExtensionState<Present, 'ExtensionType, 'Identity, 'Name> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : ArcKubernetesClusterExtensionState<Present, 'ExtensionType, 'Identity, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#extension_type-1">ArcKubernetesClusterExtension#extension_type</a>.
        /// </summary>
        [<CustomOperation "extension_type">]
        member _.ExtensionType(state: ArcKubernetesClusterExtensionState<'ClusterId, Missing, 'Identity, 'Name>, value: string) : ArcKubernetesClusterExtensionState<'ClusterId, Present, 'Identity, 'Name> =
            state.assignments.Add(fun config -> config.ExtensionType <- value)
            ({ assignments = state.assignments } : ArcKubernetesClusterExtensionState<'ClusterId, Present, 'Identity, 'Name>)

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#identity-1">ArcKubernetesClusterExtension#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, Missing, 'Name>, value: azurerm.ArcKubernetesClusterExtension.ArcKubernetesClusterExtensionIdentity) : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, Present, 'Name> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#name-1">ArcKubernetesClusterExtension#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, Missing>, value: string) : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#configuration_protected_settings-1">ArcKubernetesClusterExtension#configuration_protected_settings</a>.
        /// </summary>
        [<CustomOperation "configuration_protected_settings">]
        member _.ConfigurationProtectedSettings(state: ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>, value: seq<string * string>) : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name> =
            state.assignments.Add(fun config -> config.ConfigurationProtectedSettings <- dict value)
            state : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#configuration_settings-1">ArcKubernetesClusterExtension#configuration_settings</a>.
        /// </summary>
        [<CustomOperation "configuration_settings">]
        member _.ConfigurationSettings(state: ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>, value: seq<string * string>) : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name> =
            state.assignments.Add(fun config -> config.ConfigurationSettings <- dict value)
            state : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#id-1">ArcKubernetesClusterExtension#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>, value: string) : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#release_namespace-1">ArcKubernetesClusterExtension#release_namespace</a>.
        /// </summary>
        [<CustomOperation "release_namespace">]
        member _.ReleaseNamespace(state: ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>, value: string) : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name> =
            state.assignments.Add(fun config -> config.ReleaseNamespace <- value)
            state : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#release_train-1">ArcKubernetesClusterExtension#release_train</a>.
        /// </summary>
        [<CustomOperation "release_train">]
        member _.ReleaseTrain(state: ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>, value: string) : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name> =
            state.assignments.Add(fun config -> config.ReleaseTrain <- value)
            state : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#target_namespace-1">ArcKubernetesClusterExtension#target_namespace</a>.
        /// </summary>
        [<CustomOperation "target_namespace">]
        member _.TargetNamespace(state: ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>, value: string) : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name> =
            state.assignments.Add(fun config -> config.TargetNamespace <- value)
            state : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#timeouts-1">ArcKubernetesClusterExtension#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>, value: azurerm.ArcKubernetesClusterExtension.ArcKubernetesClusterExtensionTimeouts) : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#version-1">ArcKubernetesClusterExtension#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>, value: string) : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : ArcKubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Identity, 'Name>

        member _.Run(state: ArcKubernetesClusterExtensionState<Present, Present, Present, Present>) : azurerm.ArcKubernetesClusterExtension.ArcKubernetesClusterExtension =
            let config = azurerm.ArcKubernetesClusterExtension.ArcKubernetesClusterExtensionConfig()
            for setter in state.assignments do
                setter config
            azurerm.ArcKubernetesClusterExtension.ArcKubernetesClusterExtension(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.arcKubernetesClusterExtension: missing required arguments. Must call: cluster_id, extension_type, identity, name.", 9999, IsError = true)>]
        member _.Run(_: ArcKubernetesClusterExtensionState<_, _, _, _>) : azurerm.ArcKubernetesClusterExtension.ArcKubernetesClusterExtension =
            Unchecked.defaultof<azurerm.ArcKubernetesClusterExtension.ArcKubernetesClusterExtension>
