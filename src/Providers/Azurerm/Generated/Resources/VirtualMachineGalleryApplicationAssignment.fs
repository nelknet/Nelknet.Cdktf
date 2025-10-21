namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId> = { assignments: ResizeArray<azurerm.VirtualMachineGalleryApplicationAssignment.VirtualMachineGalleryApplicationAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_gallery_application_assignment">azurerm_virtual_machine_gallery_application_assignment</a>.
    /// </summary>
    type VirtualMachineGalleryApplicationAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : VirtualMachineGalleryApplicationAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineGalleryApplicationAssignmentState<Missing, Missing>)

        member _.Zero(()) : VirtualMachineGalleryApplicationAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VirtualMachineGalleryApplicationAssignmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_gallery_application_assignment#gallery_application_version_id-1">VirtualMachineGalleryApplicationAssignment#gallery_application_version_id</a>.
        /// </summary>
        [<CustomOperation "gallery_application_version_id">]
        member _.GalleryApplicationVersionId(state: VirtualMachineGalleryApplicationAssignmentState<Missing, 'VirtualMachineId>, value: string) : VirtualMachineGalleryApplicationAssignmentState<Present, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.GalleryApplicationVersionId <- value)
            ({ assignments = state.assignments } : VirtualMachineGalleryApplicationAssignmentState<Present, 'VirtualMachineId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_gallery_application_assignment#virtual_machine_id-1">VirtualMachineGalleryApplicationAssignment#virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_id">]
        member _.VirtualMachineId(state: VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, Missing>, value: string) : VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, Present> =
            state.assignments.Add(fun config -> config.VirtualMachineId <- value)
            ({ assignments = state.assignments } : VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_gallery_application_assignment#configuration_blob_uri-1">VirtualMachineGalleryApplicationAssignment#configuration_blob_uri</a>.
        /// </summary>
        [<CustomOperation "configuration_blob_uri">]
        member _.ConfigurationBlobUri(state: VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId>, value: string) : VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.ConfigurationBlobUri <- value)
            state : VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_gallery_application_assignment#id-1">VirtualMachineGalleryApplicationAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId>, value: string) : VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_gallery_application_assignment#order-1">VirtualMachineGalleryApplicationAssignment#order</a>.
        /// </summary>
        [<CustomOperation "order">]
        member _.Order(state: VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId>, value: double) : VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Order <- value)
            state : VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_gallery_application_assignment#tag-1">VirtualMachineGalleryApplicationAssignment#tag</a>.
        /// </summary>
        [<CustomOperation "tag">]
        member _.Tag(state: VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId>, value: string) : VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Tag <- value)
            state : VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_gallery_application_assignment#timeouts-1">VirtualMachineGalleryApplicationAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId>, value: azurerm.VirtualMachineGalleryApplicationAssignment.VirtualMachineGalleryApplicationAssignmentTimeouts) : VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VirtualMachineGalleryApplicationAssignmentState<'GalleryApplicationVersionId, 'VirtualMachineId>

        member _.Run(state: VirtualMachineGalleryApplicationAssignmentState<Present, Present>) : azurerm.VirtualMachineGalleryApplicationAssignment.VirtualMachineGalleryApplicationAssignment =
            let config = azurerm.VirtualMachineGalleryApplicationAssignment.VirtualMachineGalleryApplicationAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.VirtualMachineGalleryApplicationAssignment.VirtualMachineGalleryApplicationAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.virtualMachineGalleryApplicationAssignment: missing required arguments. Must call: gallery_application_version_id, virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: VirtualMachineGalleryApplicationAssignmentState<_, _>) : azurerm.VirtualMachineGalleryApplicationAssignment.VirtualMachineGalleryApplicationAssignment =
            Unchecked.defaultof<azurerm.VirtualMachineGalleryApplicationAssignment.VirtualMachineGalleryApplicationAssignment>
