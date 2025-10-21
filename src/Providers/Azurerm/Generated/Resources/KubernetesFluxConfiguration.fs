namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> = { assignments: ResizeArray<azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration">azurerm_kubernetes_flux_configuration</a>.
    /// </summary>
    type KubernetesFluxConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : KubernetesFluxConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesFluxConfigurationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KubernetesFluxConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KubernetesFluxConfigurationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#cluster_id-1">KubernetesFluxConfiguration#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: KubernetesFluxConfigurationState<Missing, 'Kustomizations, 'Name, 'Namespace>, value: string) : KubernetesFluxConfigurationState<Present, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : KubernetesFluxConfigurationState<Present, 'Kustomizations, 'Name, 'Namespace>)

        /// <summary>
        /// kustomizations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#kustomizations-1">KubernetesFluxConfiguration#kustomizations</a> Accepts: azurerm.IResolvable | azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizations[]
        /// </summary>
        [<CustomOperation "kustomizations">]
        member _.Kustomizations(state: KubernetesFluxConfigurationState<'ClusterId, Missing, 'Name, 'Namespace>, value: HashiCorp.Cdktf.IResolvable) : KubernetesFluxConfigurationState<'ClusterId, Present, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.Kustomizations <- value)
            ({ assignments = state.assignments } : KubernetesFluxConfigurationState<'ClusterId, Present, 'Name, 'Namespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#name-1">KubernetesFluxConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, Missing, 'Namespace>, value: string) : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, Present, 'Namespace> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, Present, 'Namespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#namespace-1">KubernetesFluxConfiguration#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, Missing>, value: string) : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, Present> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            ({ assignments = state.assignments } : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, Present>)

        /// <summary>
        /// blob_storage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#blob_storage-1">KubernetesFluxConfiguration#blob_storage</a>
        /// </summary>
        [<CustomOperation "blob_storage">]
        member _.BlobStorage(state: KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationBlobStorage) : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.BlobStorage <- value)
            state : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// bucket block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#bucket-1">KubernetesFluxConfiguration#bucket</a>
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationBucket) : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            state : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#continuous_reconciliation_enabled-1">KubernetesFluxConfiguration#continuous_reconciliation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "continuous_reconciliation_enabled">]
        member _.ContinuousReconciliationEnabled(state: KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: bool) : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.ContinuousReconciliationEnabled <- value)
            state : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#continuous_reconciliation_enabled-1">KubernetesFluxConfiguration#continuous_reconciliation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "continuous_reconciliation_enabled">]
        member _.ContinuousReconciliationEnabled(state: KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: HashiCorp.Cdktf.IResolvable) : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.ContinuousReconciliationEnabled <- value)
            state : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// git_repository block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#git_repository-1">KubernetesFluxConfiguration#git_repository</a>
        /// </summary>
        [<CustomOperation "git_repository">]
        member _.GitRepository(state: KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationGitRepository) : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.GitRepository <- value)
            state : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#id-1">KubernetesFluxConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: string) : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#scope-1">KubernetesFluxConfiguration#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: string) : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.Scope <- value)
            state : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_flux_configuration#timeouts-1">KubernetesFluxConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationTimeouts) : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        member _.Run(state: KubernetesFluxConfigurationState<Present, Present, Present, Present>) : azurerm.KubernetesFluxConfiguration.KubernetesFluxConfiguration =
            let config = azurerm.KubernetesFluxConfiguration.KubernetesFluxConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.KubernetesFluxConfiguration.KubernetesFluxConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kubernetesFluxConfiguration: missing required arguments. Must call: cluster_id, kustomizations, name, namespace.", 9999, IsError = true)>]
        member _.Run(_: KubernetesFluxConfigurationState<_, _, _, _>) : azurerm.KubernetesFluxConfiguration.KubernetesFluxConfiguration =
            Unchecked.defaultof<azurerm.KubernetesFluxConfiguration.KubernetesFluxConfiguration>
