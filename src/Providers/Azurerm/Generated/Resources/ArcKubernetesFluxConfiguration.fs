namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> = { assignments: ResizeArray<azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration">azurerm_arc_kubernetes_flux_configuration</a>.
    /// </summary>
    type ArcKubernetesFluxConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ArcKubernetesFluxConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ArcKubernetesFluxConfigurationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ArcKubernetesFluxConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ArcKubernetesFluxConfigurationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#cluster_id-1">ArcKubernetesFluxConfiguration#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: ArcKubernetesFluxConfigurationState<Missing, 'Kustomizations, 'Name, 'Namespace>, value: string) : ArcKubernetesFluxConfigurationState<Present, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : ArcKubernetesFluxConfigurationState<Present, 'Kustomizations, 'Name, 'Namespace>)

        /// <summary>
        /// kustomizations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#kustomizations-1">ArcKubernetesFluxConfiguration#kustomizations</a> Accepts: azurerm.IResolvable | azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationKustomizations[]
        /// </summary>
        [<CustomOperation "kustomizations">]
        member _.Kustomizations(state: ArcKubernetesFluxConfigurationState<'ClusterId, Missing, 'Name, 'Namespace>, value: HashiCorp.Cdktf.IResolvable) : ArcKubernetesFluxConfigurationState<'ClusterId, Present, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.Kustomizations <- value)
            ({ assignments = state.assignments } : ArcKubernetesFluxConfigurationState<'ClusterId, Present, 'Name, 'Namespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#name-1">ArcKubernetesFluxConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, Missing, 'Namespace>, value: string) : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, Present, 'Namespace> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, Present, 'Namespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#namespace-1">ArcKubernetesFluxConfiguration#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, Missing>, value: string) : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, Present> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            ({ assignments = state.assignments } : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, Present>)

        /// <summary>
        /// blob_storage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#blob_storage-1">ArcKubernetesFluxConfiguration#blob_storage</a>
        /// </summary>
        [<CustomOperation "blob_storage">]
        member _.BlobStorage(state: ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationBlobStorage) : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.BlobStorage <- value)
            state : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// bucket block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#bucket-1">ArcKubernetesFluxConfiguration#bucket</a>
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationBucket) : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            state : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#continuous_reconciliation_enabled-1">ArcKubernetesFluxConfiguration#continuous_reconciliation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "continuous_reconciliation_enabled">]
        member _.ContinuousReconciliationEnabled(state: ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: bool) : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.ContinuousReconciliationEnabled <- value)
            state : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#continuous_reconciliation_enabled-1">ArcKubernetesFluxConfiguration#continuous_reconciliation_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "continuous_reconciliation_enabled">]
        member _.ContinuousReconciliationEnabled(state: ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: HashiCorp.Cdktf.IResolvable) : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.ContinuousReconciliationEnabled <- value)
            state : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// git_repository block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#git_repository-1">ArcKubernetesFluxConfiguration#git_repository</a>
        /// </summary>
        [<CustomOperation "git_repository">]
        member _.GitRepository(state: ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationGitRepository) : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.GitRepository <- value)
            state : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#id-1">ArcKubernetesFluxConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: string) : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#scope-1">ArcKubernetesFluxConfiguration#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: string) : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.Scope <- value)
            state : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_flux_configuration#timeouts-1">ArcKubernetesFluxConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>, value: azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationTimeouts) : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ArcKubernetesFluxConfigurationState<'ClusterId, 'Kustomizations, 'Name, 'Namespace>

        member _.Run(state: ArcKubernetesFluxConfigurationState<Present, Present, Present, Present>) : azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfiguration =
            let config = azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.arcKubernetesFluxConfiguration: missing required arguments. Must call: cluster_id, kustomizations, name, namespace.", 9999, IsError = true)>]
        member _.Run(_: ArcKubernetesFluxConfigurationState<_, _, _, _>) : azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfiguration =
            Unchecked.defaultof<azurerm.ArcKubernetesFluxConfiguration.ArcKubernetesFluxConfiguration>
