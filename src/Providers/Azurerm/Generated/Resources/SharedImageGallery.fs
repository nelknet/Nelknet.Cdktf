namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.SharedImageGallery.SharedImageGalleryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery">azurerm_shared_image_gallery</a>.
    /// </summary>
    type SharedImageGalleryBuilder(logicalId: string) =
        member _.Yield(_: unit) : SharedImageGalleryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SharedImageGalleryState<Missing, Missing, Missing>)

        member _.Zero(()) : SharedImageGalleryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SharedImageGalleryState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#location-1">SharedImageGallery#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SharedImageGalleryState<Missing, 'Name, 'ResourceGroupName>, value: string) : SharedImageGalleryState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SharedImageGalleryState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#name-1">SharedImageGallery#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SharedImageGalleryState<'Location, Missing, 'ResourceGroupName>, value: string) : SharedImageGalleryState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SharedImageGalleryState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#resource_group_name-1">SharedImageGallery#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SharedImageGalleryState<'Location, 'Name, Missing>, value: string) : SharedImageGalleryState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SharedImageGalleryState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#description-1">SharedImageGallery#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName>, value: string) : SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#id-1">SharedImageGallery#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName>, value: string) : SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// sharing block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#sharing-1">SharedImageGallery#sharing</a>
        /// </summary>
        [<CustomOperation "sharing">]
        member _.Sharing(state: SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.SharedImageGallery.SharedImageGallerySharing) : SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Sharing <- value)
            state : SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#tags-1">SharedImageGallery#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_gallery#timeouts-1">SharedImageGallery#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.SharedImageGallery.SharedImageGalleryTimeouts) : SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SharedImageGalleryState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: SharedImageGalleryState<Present, Present, Present>) : azurerm.SharedImageGallery.SharedImageGallery =
            let config = azurerm.SharedImageGallery.SharedImageGalleryConfig()
            for setter in state.assignments do
                setter config
            azurerm.SharedImageGallery.SharedImageGallery(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sharedImageGallery: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: SharedImageGalleryState<_, _, _>) : azurerm.SharedImageGallery.SharedImageGallery =
            Unchecked.defaultof<azurerm.SharedImageGallery.SharedImageGallery>
