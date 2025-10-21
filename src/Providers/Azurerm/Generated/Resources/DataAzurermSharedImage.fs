namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSharedImageState<'GalleryName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSharedImage.DataAzurermSharedImageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image">azurerm_shared_image</a>.
    /// </summary>
    type DataAzurermSharedImageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSharedImageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSharedImageState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermSharedImageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSharedImageState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image#gallery_name-1">DataAzurermSharedImage#gallery_name</a>.
        /// </summary>
        [<CustomOperation "gallery_name">]
        member _.GalleryName(state: DataAzurermSharedImageState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermSharedImageState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GalleryName <- value)
            ({ assignments = state.assignments } : DataAzurermSharedImageState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image#name-1">DataAzurermSharedImage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSharedImageState<'GalleryName, Missing, 'ResourceGroupName>, value: string) : DataAzurermSharedImageState<'GalleryName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSharedImageState<'GalleryName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image#resource_group_name-1">DataAzurermSharedImage#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSharedImageState<'GalleryName, 'Name, Missing>, value: string) : DataAzurermSharedImageState<'GalleryName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSharedImageState<'GalleryName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image#id-1">DataAzurermSharedImage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSharedImageState<'GalleryName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermSharedImageState<'GalleryName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSharedImageState<'GalleryName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image#timeouts-1">DataAzurermSharedImage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSharedImageState<'GalleryName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermSharedImage.DataAzurermSharedImageTimeouts) : DataAzurermSharedImageState<'GalleryName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSharedImageState<'GalleryName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermSharedImageState<Present, Present, Present>) : azurerm.DataAzurermSharedImage.DataAzurermSharedImage =
            let config = azurerm.DataAzurermSharedImage.DataAzurermSharedImageConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSharedImage.DataAzurermSharedImage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSharedImage: missing required arguments. Must call: gallery_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSharedImageState<_, _, _>) : azurerm.DataAzurermSharedImage.DataAzurermSharedImage =
            Unchecked.defaultof<azurerm.DataAzurermSharedImage.DataAzurermSharedImage>
