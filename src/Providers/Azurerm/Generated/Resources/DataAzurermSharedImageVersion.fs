namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSharedImageVersion.DataAzurermSharedImageVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_version">azurerm_shared_image_version</a>.
    /// </summary>
    type DataAzurermSharedImageVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSharedImageVersionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSharedImageVersionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermSharedImageVersionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSharedImageVersionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_version#gallery_name-1">DataAzurermSharedImageVersion#gallery_name</a>.
        /// </summary>
        [<CustomOperation "gallery_name">]
        member _.GalleryName(state: DataAzurermSharedImageVersionState<Missing, 'ImageName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermSharedImageVersionState<Present, 'ImageName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GalleryName <- value)
            ({ assignments = state.assignments } : DataAzurermSharedImageVersionState<Present, 'ImageName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_version#image_name-1">DataAzurermSharedImageVersion#image_name</a>.
        /// </summary>
        [<CustomOperation "image_name">]
        member _.ImageName(state: DataAzurermSharedImageVersionState<'GalleryName, Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermSharedImageVersionState<'GalleryName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ImageName <- value)
            ({ assignments = state.assignments } : DataAzurermSharedImageVersionState<'GalleryName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_version#name-1">DataAzurermSharedImageVersion#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, Missing, 'ResourceGroupName>, value: string) : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_version#resource_group_name-1">DataAzurermSharedImageVersion#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, Missing>, value: string) : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_version#id-1">DataAzurermSharedImageVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_version#sort_versions_by_semver-1">DataAzurermSharedImageVersion#sort_versions_by_semver</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sort_versions_by_semver">]
        member _.SortVersionsBySemver(state: DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName>, value: bool) : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SortVersionsBySemver <- value)
            state : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_version#sort_versions_by_semver-1">DataAzurermSharedImageVersion#sort_versions_by_semver</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sort_versions_by_semver">]
        member _.SortVersionsBySemver(state: DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SortVersionsBySemver <- value)
            state : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_version#tags-1">DataAzurermSharedImageVersion#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_version#timeouts-1">DataAzurermSharedImageVersion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermSharedImageVersion.DataAzurermSharedImageVersionTimeouts) : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSharedImageVersionState<'GalleryName, 'ImageName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermSharedImageVersionState<Present, Present, Present, Present>) : azurerm.DataAzurermSharedImageVersion.DataAzurermSharedImageVersion =
            let config = azurerm.DataAzurermSharedImageVersion.DataAzurermSharedImageVersionConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSharedImageVersion.DataAzurermSharedImageVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSharedImageVersion: missing required arguments. Must call: gallery_name, image_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSharedImageVersionState<_, _, _, _>) : azurerm.DataAzurermSharedImageVersion.DataAzurermSharedImageVersion =
            Unchecked.defaultof<azurerm.DataAzurermSharedImageVersion.DataAzurermSharedImageVersion>
