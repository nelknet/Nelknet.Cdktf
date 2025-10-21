namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType> = { assignments: ResizeArray<azurerm.GalleryApplication.GalleryApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application">azurerm_gallery_application</a>.
    /// </summary>
    type GalleryApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : GalleryApplicationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GalleryApplicationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GalleryApplicationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GalleryApplicationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application#gallery_id-1">GalleryApplication#gallery_id</a>.
        /// </summary>
        [<CustomOperation "gallery_id">]
        member _.GalleryId(state: GalleryApplicationState<Missing, 'Location, 'Name, 'SupportedOsType>, value: string) : GalleryApplicationState<Present, 'Location, 'Name, 'SupportedOsType> =
            state.assignments.Add(fun config -> config.GalleryId <- value)
            ({ assignments = state.assignments } : GalleryApplicationState<Present, 'Location, 'Name, 'SupportedOsType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application#location-1">GalleryApplication#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: GalleryApplicationState<'GalleryId, Missing, 'Name, 'SupportedOsType>, value: string) : GalleryApplicationState<'GalleryId, Present, 'Name, 'SupportedOsType> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : GalleryApplicationState<'GalleryId, Present, 'Name, 'SupportedOsType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application#name-1">GalleryApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GalleryApplicationState<'GalleryId, 'Location, Missing, 'SupportedOsType>, value: string) : GalleryApplicationState<'GalleryId, 'Location, Present, 'SupportedOsType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GalleryApplicationState<'GalleryId, 'Location, Present, 'SupportedOsType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application#supported_os_type-1">GalleryApplication#supported_os_type</a>.
        /// </summary>
        [<CustomOperation "supported_os_type">]
        member _.SupportedOsType(state: GalleryApplicationState<'GalleryId, 'Location, 'Name, Missing>, value: string) : GalleryApplicationState<'GalleryId, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.SupportedOsType <- value)
            ({ assignments = state.assignments } : GalleryApplicationState<'GalleryId, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application#description-1">GalleryApplication#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>, value: string) : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application#end_of_life_date-1">GalleryApplication#end_of_life_date</a>.
        /// </summary>
        [<CustomOperation "end_of_life_date">]
        member _.EndOfLifeDate(state: GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>, value: string) : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType> =
            state.assignments.Add(fun config -> config.EndOfLifeDate <- value)
            state : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application#eula-1">GalleryApplication#eula</a>.
        /// </summary>
        [<CustomOperation "eula">]
        member _.Eula(state: GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>, value: string) : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType> =
            state.assignments.Add(fun config -> config.Eula <- value)
            state : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application#id-1">GalleryApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>, value: string) : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application#privacy_statement_uri-1">GalleryApplication#privacy_statement_uri</a>.
        /// </summary>
        [<CustomOperation "privacy_statement_uri">]
        member _.PrivacyStatementUri(state: GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>, value: string) : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType> =
            state.assignments.Add(fun config -> config.PrivacyStatementUri <- value)
            state : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application#release_note_uri-1">GalleryApplication#release_note_uri</a>.
        /// </summary>
        [<CustomOperation "release_note_uri">]
        member _.ReleaseNoteUri(state: GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>, value: string) : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType> =
            state.assignments.Add(fun config -> config.ReleaseNoteUri <- value)
            state : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application#tags-1">GalleryApplication#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>, value: seq<string * string>) : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application#timeouts-1">GalleryApplication#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>, value: azurerm.GalleryApplication.GalleryApplicationTimeouts) : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GalleryApplicationState<'GalleryId, 'Location, 'Name, 'SupportedOsType>

        member _.Run(state: GalleryApplicationState<Present, Present, Present, Present>) : azurerm.GalleryApplication.GalleryApplication =
            let config = azurerm.GalleryApplication.GalleryApplicationConfig()
            for setter in state.assignments do
                setter config
            azurerm.GalleryApplication.GalleryApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.galleryApplication: missing required arguments. Must call: gallery_id, location, name, supported_os_type.", 9999, IsError = true)>]
        member _.Run(_: GalleryApplicationState<_, _, _, _>) : azurerm.GalleryApplication.GalleryApplication =
            Unchecked.defaultof<azurerm.GalleryApplication.GalleryApplication>
