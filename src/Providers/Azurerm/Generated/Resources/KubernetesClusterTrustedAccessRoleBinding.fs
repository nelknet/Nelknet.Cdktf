namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, 'Roles, 'SourceResourceId> = { assignments: ResizeArray<azurerm.KubernetesClusterTrustedAccessRoleBinding.KubernetesClusterTrustedAccessRoleBindingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_trusted_access_role_binding">azurerm_kubernetes_cluster_trusted_access_role_binding</a>.
    /// </summary>
    type KubernetesClusterTrustedAccessRoleBindingBuilder(logicalId: string) =
        member _.Yield(_: unit) : KubernetesClusterTrustedAccessRoleBindingState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesClusterTrustedAccessRoleBindingState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KubernetesClusterTrustedAccessRoleBindingState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesClusterTrustedAccessRoleBindingState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_trusted_access_role_binding#kubernetes_cluster_id-1">KubernetesClusterTrustedAccessRoleBinding#kubernetes_cluster_id</a>.
        /// </summary>
        [<CustomOperation "kubernetes_cluster_id">]
        member _.KubernetesClusterId(state: KubernetesClusterTrustedAccessRoleBindingState<Missing, 'Name, 'Roles, 'SourceResourceId>, value: string) : KubernetesClusterTrustedAccessRoleBindingState<Present, 'Name, 'Roles, 'SourceResourceId> =
            state.assignments.Add(fun config -> config.KubernetesClusterId <- value)
            ({ assignments = state.assignments } : KubernetesClusterTrustedAccessRoleBindingState<Present, 'Name, 'Roles, 'SourceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_trusted_access_role_binding#name-1">KubernetesClusterTrustedAccessRoleBinding#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, Missing, 'Roles, 'SourceResourceId>, value: string) : KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, Present, 'Roles, 'SourceResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, Present, 'Roles, 'SourceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_trusted_access_role_binding#roles-1">KubernetesClusterTrustedAccessRoleBinding#roles</a>.
        /// </summary>
        [<CustomOperation "roles">]
        member _.Roles(state: KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, Missing, 'SourceResourceId>, value: seq<string>) : KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, Present, 'SourceResourceId> =
            state.assignments.Add(fun config -> config.Roles <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, Present, 'SourceResourceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_trusted_access_role_binding#source_resource_id-1">KubernetesClusterTrustedAccessRoleBinding#source_resource_id</a>.
        /// </summary>
        [<CustomOperation "source_resource_id">]
        member _.SourceResourceId(state: KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, 'Roles, Missing>, value: string) : KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, 'Roles, Present> =
            state.assignments.Add(fun config -> config.SourceResourceId <- value)
            ({ assignments = state.assignments } : KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, 'Roles, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_trusted_access_role_binding#id-1">KubernetesClusterTrustedAccessRoleBinding#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, 'Roles, 'SourceResourceId>, value: string) : KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, 'Roles, 'SourceResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, 'Roles, 'SourceResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster_trusted_access_role_binding#timeouts-1">KubernetesClusterTrustedAccessRoleBinding#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, 'Roles, 'SourceResourceId>, value: azurerm.KubernetesClusterTrustedAccessRoleBinding.KubernetesClusterTrustedAccessRoleBindingTimeouts) : KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, 'Roles, 'SourceResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KubernetesClusterTrustedAccessRoleBindingState<'KubernetesClusterId, 'Name, 'Roles, 'SourceResourceId>

        member _.Run(state: KubernetesClusterTrustedAccessRoleBindingState<Present, Present, Present, Present>) : azurerm.KubernetesClusterTrustedAccessRoleBinding.KubernetesClusterTrustedAccessRoleBinding =
            let config = azurerm.KubernetesClusterTrustedAccessRoleBinding.KubernetesClusterTrustedAccessRoleBindingConfig()
            for setter in state.assignments do
                setter config
            azurerm.KubernetesClusterTrustedAccessRoleBinding.KubernetesClusterTrustedAccessRoleBinding(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kubernetesClusterTrustedAccessRoleBinding: missing required arguments. Must call: kubernetes_cluster_id, name, roles, source_resource_id.", 9999, IsError = true)>]
        member _.Run(_: KubernetesClusterTrustedAccessRoleBindingState<_, _, _, _>) : azurerm.KubernetesClusterTrustedAccessRoleBinding.KubernetesClusterTrustedAccessRoleBinding =
            Unchecked.defaultof<azurerm.KubernetesClusterTrustedAccessRoleBinding.KubernetesClusterTrustedAccessRoleBinding>
