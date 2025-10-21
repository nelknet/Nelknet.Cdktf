namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSharedImageGalleryState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermSharedImageGallery.DataAzurermSharedImageGalleryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_gallery">azurerm_shared_image_gallery</a>.
    /// </summary>
    type DataAzurermSharedImageGalleryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSharedImageGalleryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSharedImageGalleryState<Missing, Missing>)

        member _.Zero(()) : DataAzurermSharedImageGalleryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSharedImageGalleryState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_gallery#name-1">DataAzurermSharedImageGallery#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermSharedImageGalleryState<Missing, 'ResourceGroupName>, value: string) : DataAzurermSharedImageGalleryState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermSharedImageGalleryState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_gallery#resource_group_name-1">DataAzurermSharedImageGallery#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermSharedImageGalleryState<'Name, Missing>, value: string) : DataAzurermSharedImageGalleryState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermSharedImageGalleryState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_gallery#id-1">DataAzurermSharedImageGallery#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSharedImageGalleryState<'Name, 'ResourceGroupName>, value: string) : DataAzurermSharedImageGalleryState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSharedImageGalleryState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/shared_image_gallery#timeouts-1">DataAzurermSharedImageGallery#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSharedImageGalleryState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermSharedImageGallery.DataAzurermSharedImageGalleryTimeouts) : DataAzurermSharedImageGalleryState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSharedImageGalleryState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermSharedImageGalleryState<Present, Present>) : azurerm.DataAzurermSharedImageGallery.DataAzurermSharedImageGallery =
            let config = azurerm.DataAzurermSharedImageGallery.DataAzurermSharedImageGalleryConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSharedImageGallery.DataAzurermSharedImageGallery(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSharedImageGallery: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSharedImageGalleryState<_, _>) : azurerm.DataAzurermSharedImageGallery.DataAzurermSharedImageGallery =
            Unchecked.defaultof<azurerm.DataAzurermSharedImageGallery.DataAzurermSharedImageGallery>
