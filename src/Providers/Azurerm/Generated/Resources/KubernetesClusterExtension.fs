namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name> = { assignments: ResizeArray<azurerm.KubernetesClusterExtension.KubernetesClusterExtensionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension">azurerm_kubernetes_cluster_extension</a>.
    /// </summary>
    type KubernetesClusterExtensionBuilder(logicalId: string) =
        member _.Yield(_: unit) : KubernetesClusterExtensionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesClusterExtensionState<Missing, Missing, Missing>)

        member _.Zero(()) : KubernetesClusterExtensionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesClusterExtensionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension#cluster_id-1">KubernetesClusterExtension#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: KubernetesClusterExtensionState<Missing, 'ExtensionType, 'Name>, value: string) : KubernetesClusterExtensionState<Present, 'ExtensionType, 'Name> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : KubernetesClusterExtensionState<Present, 'ExtensionType, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension#extension_type-1">KubernetesClusterExtension#extension_type</a>.
        /// </summary>
        [<CustomOperation "extension_type">]
        member _.ExtensionType(state: KubernetesClusterExtensionState<'ClusterId, Missing, 'Name>, value: string) : KubernetesClusterExtensionState<'ClusterId, Present, 'Name> =
            state.assignments.Add(fun config -> config.ExtensionType <- value)
            ({ assignments = state.assignments } : KubernetesClusterExtensionState<'ClusterId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension#name-1">KubernetesClusterExtension#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, Missing>, value: string) : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension#configuration_protected_settings-1">KubernetesClusterExtension#configuration_protected_settings</a>.
        /// </summary>
        [<CustomOperation "configuration_protected_settings">]
        member _.ConfigurationProtectedSettings(state: KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>, value: seq<string * string>) : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name> =
            state.assignments.Add(fun config -> config.ConfigurationProtectedSettings <- dict value)
            state : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension#configuration_settings-1">KubernetesClusterExtension#configuration_settings</a>.
        /// </summary>
        [<CustomOperation "configuration_settings">]
        member _.ConfigurationSettings(state: KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>, value: seq<string * string>) : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name> =
            state.assignments.Add(fun config -> config.ConfigurationSettings <- dict value)
            state : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension#id-1">KubernetesClusterExtension#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>, value: string) : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>

        /// <summary>
        /// plan block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension#plan-1">KubernetesClusterExtension#plan</a>
        /// </summary>
        [<CustomOperation "plan">]
        member _.Plan(state: KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>, value: azurerm.KubernetesClusterExtension.KubernetesClusterExtensionPlan) : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name> =
            state.assignments.Add(fun config -> config.Plan <- value)
            state : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension#release_namespace-1">KubernetesClusterExtension#release_namespace</a>.
        /// </summary>
        [<CustomOperation "release_namespace">]
        member _.ReleaseNamespace(state: KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>, value: string) : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name> =
            state.assignments.Add(fun config -> config.ReleaseNamespace <- value)
            state : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension#release_train-1">KubernetesClusterExtension#release_train</a>.
        /// </summary>
        [<CustomOperation "release_train">]
        member _.ReleaseTrain(state: KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>, value: string) : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name> =
            state.assignments.Add(fun config -> config.ReleaseTrain <- value)
            state : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension#target_namespace-1">KubernetesClusterExtension#target_namespace</a>.
        /// </summary>
        [<CustomOperation "target_namespace">]
        member _.TargetNamespace(state: KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>, value: string) : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name> =
            state.assignments.Add(fun config -> config.TargetNamespace <- value)
            state : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension#timeouts-1">KubernetesClusterExtension#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>, value: azurerm.KubernetesClusterExtension.KubernetesClusterExtensionTimeouts) : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_extension#version-1">KubernetesClusterExtension#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>, value: string) : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : KubernetesClusterExtensionState<'ClusterId, 'ExtensionType, 'Name>

        member _.Run(state: KubernetesClusterExtensionState<Present, Present, Present>) : azurerm.KubernetesClusterExtension.KubernetesClusterExtension =
            let config = azurerm.KubernetesClusterExtension.KubernetesClusterExtensionConfig()
            for setter in state.assignments do
                setter config
            azurerm.KubernetesClusterExtension.KubernetesClusterExtension(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kubernetesClusterExtension: missing required arguments. Must call: cluster_id, extension_type, name.", 9999, IsError = true)>]
        member _.Run(_: KubernetesClusterExtensionState<_, _, _>) : azurerm.KubernetesClusterExtension.KubernetesClusterExtension =
            Unchecked.defaultof<azurerm.KubernetesClusterExtension.KubernetesClusterExtension>
