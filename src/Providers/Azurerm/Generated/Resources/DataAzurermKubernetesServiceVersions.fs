namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermKubernetesServiceVersionsState<'Location> = { assignments: ResizeArray<azurerm.DataAzurermKubernetesServiceVersions.DataAzurermKubernetesServiceVersionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_service_versions">azurerm_kubernetes_service_versions</a>.
    /// </summary>
    type DataAzurermKubernetesServiceVersionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermKubernetesServiceVersionsState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKubernetesServiceVersionsState<Missing>)

        member _.Zero(()) : DataAzurermKubernetesServiceVersionsState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermKubernetesServiceVersionsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_service_versions#location-1">DataAzurermKubernetesServiceVersions#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataAzurermKubernetesServiceVersionsState<Missing>, value: string) : DataAzurermKubernetesServiceVersionsState<Present> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataAzurermKubernetesServiceVersionsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_service_versions#id-1">DataAzurermKubernetesServiceVersions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermKubernetesServiceVersionsState<'Location>, value: string) : DataAzurermKubernetesServiceVersionsState<'Location> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermKubernetesServiceVersionsState<'Location>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_service_versions#include_preview-1">DataAzurermKubernetesServiceVersions#include_preview</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "include_preview">]
        member _.IncludePreview(state: DataAzurermKubernetesServiceVersionsState<'Location>, value: bool) : DataAzurermKubernetesServiceVersionsState<'Location> =
            state.assignments.Add(fun config -> config.IncludePreview <- value)
            state : DataAzurermKubernetesServiceVersionsState<'Location>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_service_versions#include_preview-1">DataAzurermKubernetesServiceVersions#include_preview</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "include_preview">]
        member _.IncludePreview(state: DataAzurermKubernetesServiceVersionsState<'Location>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermKubernetesServiceVersionsState<'Location> =
            state.assignments.Add(fun config -> config.IncludePreview <- value)
            state : DataAzurermKubernetesServiceVersionsState<'Location>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_service_versions#timeouts-1">DataAzurermKubernetesServiceVersions#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermKubernetesServiceVersionsState<'Location>, value: azurerm.DataAzurermKubernetesServiceVersions.DataAzurermKubernetesServiceVersionsTimeouts) : DataAzurermKubernetesServiceVersionsState<'Location> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermKubernetesServiceVersionsState<'Location>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_service_versions#version_prefix-1">DataAzurermKubernetesServiceVersions#version_prefix</a>.
        /// </summary>
        [<CustomOperation "version_prefix">]
        member _.VersionPrefix(state: DataAzurermKubernetesServiceVersionsState<'Location>, value: string) : DataAzurermKubernetesServiceVersionsState<'Location> =
            state.assignments.Add(fun config -> config.VersionPrefix <- value)
            state : DataAzurermKubernetesServiceVersionsState<'Location>

        member _.Run(state: DataAzurermKubernetesServiceVersionsState<Present>) : azurerm.DataAzurermKubernetesServiceVersions.DataAzurermKubernetesServiceVersions =
            let config = azurerm.DataAzurermKubernetesServiceVersions.DataAzurermKubernetesServiceVersionsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermKubernetesServiceVersions.DataAzurermKubernetesServiceVersions(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermKubernetesServiceVersions: missing required arguments. Must call: location.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermKubernetesServiceVersionsState<_>) : azurerm.DataAzurermKubernetesServiceVersions.DataAzurermKubernetesServiceVersions =
            Unchecked.defaultof<azurerm.DataAzurermKubernetesServiceVersions.DataAzurermKubernetesServiceVersions>
