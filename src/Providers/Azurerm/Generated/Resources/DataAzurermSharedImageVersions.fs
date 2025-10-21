namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSharedImageVersions.DataAzurermSharedImageVersionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_versions">azurerm_shared_image_versions</a>.
    /// </summary>
    type DataAzurermSharedImageVersionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSharedImageVersionsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSharedImageVersionsState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermSharedImageVersionsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSharedImageVersionsState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_versions#gallery_name-1">DataAzurermSharedImageVersions#gallery_name</a>.
        /// </summary>
        [<CustomOperation "gallery_name">]
        member _.GalleryName(state: DataAzurermSharedImageVersionsState<Missing, 'ImageName, 'ResourceGroupName>, value: string) : DataAzurermSharedImageVersionsState<Present, 'ImageName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GalleryName <- value)
            ({ assignments = state.assignments } : DataAzurermSharedImageVersionsState<Present, 'ImageName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_versions#image_name-1">DataAzurermSharedImageVersions#image_name</a>.
        /// </summary>
        [<CustomOperation "image_name">]
        member _.ImageName(state: DataAzurermSharedImageVersionsState<'GalleryName, Missing, 'ResourceGroupName>, value: string) : DataAzurermSharedImageVersionsState<'GalleryName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ImageName <- value)
            ({ assignments = state.assignments } : DataAzurermSharedImageVersionsState<'GalleryName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_versions#resource_group_name-1">DataAzurermSharedImageVersions#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, Missing>, value: string) : DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_versions#id-1">DataAzurermSharedImageVersions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, 'ResourceGroupName>, value: string) : DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_versions#tags_filter-1">DataAzurermSharedImageVersions#tags_filter</a>.
        /// </summary>
        [<CustomOperation "tags_filter">]
        member _.TagsFilter(state: DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TagsFilter <- dict value)
            state : DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_versions#timeouts-1">DataAzurermSharedImageVersions#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, 'ResourceGroupName>, value: azurerm.DataAzurermSharedImageVersions.DataAzurermSharedImageVersionsTimeouts) : DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSharedImageVersionsState<'GalleryName, 'ImageName, 'ResourceGroupName>

        member _.Run(state: DataAzurermSharedImageVersionsState<Present, Present, Present>) : azurerm.DataAzurermSharedImageVersions.DataAzurermSharedImageVersions =
            let config = azurerm.DataAzurermSharedImageVersions.DataAzurermSharedImageVersionsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSharedImageVersions.DataAzurermSharedImageVersions(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSharedImageVersions: missing required arguments. Must call: gallery_name, image_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSharedImageVersionsState<_, _, _>) : azurerm.DataAzurermSharedImageVersions.DataAzurermSharedImageVersions =
            Unchecked.defaultof<azurerm.DataAzurermSharedImageVersions.DataAzurermSharedImageVersions>
