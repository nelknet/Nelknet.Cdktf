namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevCenterGalleryState<'DevCenterId, 'Name, 'SharedGalleryId> = { assignments: ResizeArray<azurerm.DevCenterGallery.DevCenterGalleryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_gallery">azurerm_dev_center_gallery</a>.
    /// </summary>
    type DevCenterGalleryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevCenterGalleryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterGalleryState<Missing, Missing, Missing>)

        member _.Zero(()) : DevCenterGalleryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterGalleryState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_gallery#dev_center_id-1">DevCenterGallery#dev_center_id</a>.
        /// </summary>
        [<CustomOperation "dev_center_id">]
        member _.DevCenterId(state: DevCenterGalleryState<Missing, 'Name, 'SharedGalleryId>, value: string) : DevCenterGalleryState<Present, 'Name, 'SharedGalleryId> =
            state.assignments.Add(fun config -> config.DevCenterId <- value)
            ({ assignments = state.assignments } : DevCenterGalleryState<Present, 'Name, 'SharedGalleryId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_gallery#name-1">DevCenterGallery#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevCenterGalleryState<'DevCenterId, Missing, 'SharedGalleryId>, value: string) : DevCenterGalleryState<'DevCenterId, Present, 'SharedGalleryId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevCenterGalleryState<'DevCenterId, Present, 'SharedGalleryId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_gallery#shared_gallery_id-1">DevCenterGallery#shared_gallery_id</a>.
        /// </summary>
        [<CustomOperation "shared_gallery_id">]
        member _.SharedGalleryId(state: DevCenterGalleryState<'DevCenterId, 'Name, Missing>, value: string) : DevCenterGalleryState<'DevCenterId, 'Name, Present> =
            state.assignments.Add(fun config -> config.SharedGalleryId <- value)
            ({ assignments = state.assignments } : DevCenterGalleryState<'DevCenterId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_gallery#id-1">DevCenterGallery#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevCenterGalleryState<'DevCenterId, 'Name, 'SharedGalleryId>, value: string) : DevCenterGalleryState<'DevCenterId, 'Name, 'SharedGalleryId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevCenterGalleryState<'DevCenterId, 'Name, 'SharedGalleryId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_gallery#timeouts-1">DevCenterGallery#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevCenterGalleryState<'DevCenterId, 'Name, 'SharedGalleryId>, value: azurerm.DevCenterGallery.DevCenterGalleryTimeouts) : DevCenterGalleryState<'DevCenterId, 'Name, 'SharedGalleryId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevCenterGalleryState<'DevCenterId, 'Name, 'SharedGalleryId>

        member _.Run(state: DevCenterGalleryState<Present, Present, Present>) : azurerm.DevCenterGallery.DevCenterGallery =
            let config = azurerm.DevCenterGallery.DevCenterGalleryConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevCenterGallery.DevCenterGallery(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devCenterGallery: missing required arguments. Must call: dev_center_id, name, shared_gallery_id.", 9999, IsError = true)>]
        member _.Run(_: DevCenterGalleryState<_, _, _>) : azurerm.DevCenterGallery.DevCenterGallery =
            Unchecked.defaultof<azurerm.DevCenterGallery.DevCenterGallery>
