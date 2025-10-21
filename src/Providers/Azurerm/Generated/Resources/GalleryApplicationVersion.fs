namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion> = { assignments: ResizeArray<azurerm.GalleryApplicationVersion.GalleryApplicationVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version">azurerm_gallery_application_version</a>.
    /// </summary>
    type GalleryApplicationVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : GalleryApplicationVersionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GalleryApplicationVersionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GalleryApplicationVersionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GalleryApplicationVersionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#gallery_application_id-1">GalleryApplicationVersion#gallery_application_id</a>.
        /// </summary>
        [<CustomOperation "gallery_application_id">]
        member _.GalleryApplicationId(state: GalleryApplicationVersionState<Missing, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>, value: string) : GalleryApplicationVersionState<Present, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.GalleryApplicationId <- value)
            ({ assignments = state.assignments } : GalleryApplicationVersionState<Present, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#location-1">GalleryApplicationVersion#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: GalleryApplicationVersionState<'GalleryApplicationId, Missing, 'ManageAction, 'Name, 'Source, 'TargetRegion>, value: string) : GalleryApplicationVersionState<'GalleryApplicationId, Present, 'ManageAction, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : GalleryApplicationVersionState<'GalleryApplicationId, Present, 'ManageAction, 'Name, 'Source, 'TargetRegion>)

        /// <summary>
        /// manage_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#manage_action-1">GalleryApplicationVersion#manage_action</a>
        /// </summary>
        [<CustomOperation "manage_action">]
        member _.ManageAction(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, Missing, 'Name, 'Source, 'TargetRegion>, value: azurerm.GalleryApplicationVersion.GalleryApplicationVersionManageAction) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, Present, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.ManageAction <- value)
            ({ assignments = state.assignments } : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, Present, 'Name, 'Source, 'TargetRegion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#name-1">GalleryApplicationVersion#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, Missing, 'Source, 'TargetRegion>, value: string) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, Present, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, Present, 'Source, 'TargetRegion>)

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#source-1">GalleryApplicationVersion#source</a>
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, Missing, 'TargetRegion>, value: azurerm.GalleryApplicationVersion.GalleryApplicationVersionSource) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, Present, 'TargetRegion> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, Present, 'TargetRegion>)

        /// <summary>
        /// target_region block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#target_region-1">GalleryApplicationVersion#target_region</a> Accepts: azurerm.IResolvable | azurerm.GalleryApplicationVersion.GalleryApplicationVersionTargetRegion[]
        /// </summary>
        [<CustomOperation "target_region">]
        member _.TargetRegion(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, Missing>, value: HashiCorp.Cdktf.IResolvable) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, Present> =
            state.assignments.Add(fun config -> config.TargetRegion <- value)
            ({ assignments = state.assignments } : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#config_file-1">GalleryApplicationVersion#config_file</a>.
        /// </summary>
        [<CustomOperation "config_file">]
        member _.ConfigFile(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>, value: string) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.ConfigFile <- value)
            state : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#enable_health_check-1">GalleryApplicationVersion#enable_health_check</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_health_check">]
        member _.EnableHealthCheck(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>, value: bool) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.EnableHealthCheck <- value)
            state : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#enable_health_check-1">GalleryApplicationVersion#enable_health_check</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_health_check">]
        member _.EnableHealthCheck(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>, value: HashiCorp.Cdktf.IResolvable) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.EnableHealthCheck <- value)
            state : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#end_of_life_date-1">GalleryApplicationVersion#end_of_life_date</a>.
        /// </summary>
        [<CustomOperation "end_of_life_date">]
        member _.EndOfLifeDate(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>, value: string) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.EndOfLifeDate <- value)
            state : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#exclude_from_latest-1">GalleryApplicationVersion#exclude_from_latest</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "exclude_from_latest">]
        member _.ExcludeFromLatest(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>, value: bool) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.ExcludeFromLatest <- value)
            state : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#exclude_from_latest-1">GalleryApplicationVersion#exclude_from_latest</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "exclude_from_latest">]
        member _.ExcludeFromLatest(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>, value: HashiCorp.Cdktf.IResolvable) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.ExcludeFromLatest <- value)
            state : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#id-1">GalleryApplicationVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>, value: string) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#package_file-1">GalleryApplicationVersion#package_file</a>.
        /// </summary>
        [<CustomOperation "package_file">]
        member _.PackageFile(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>, value: string) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.PackageFile <- value)
            state : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#tags-1">GalleryApplicationVersion#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>, value: seq<string * string>) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/gallery_application_version#timeouts-1">GalleryApplicationVersion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>, value: azurerm.GalleryApplicationVersion.GalleryApplicationVersionTimeouts) : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GalleryApplicationVersionState<'GalleryApplicationId, 'Location, 'ManageAction, 'Name, 'Source, 'TargetRegion>

        member _.Run(state: GalleryApplicationVersionState<Present, Present, Present, Present, Present, Present>) : azurerm.GalleryApplicationVersion.GalleryApplicationVersion =
            let config = azurerm.GalleryApplicationVersion.GalleryApplicationVersionConfig()
            for setter in state.assignments do
                setter config
            azurerm.GalleryApplicationVersion.GalleryApplicationVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.galleryApplicationVersion: missing required arguments. Must call: gallery_application_id, location, manage_action, name, source, target_region.", 9999, IsError = true)>]
        member _.Run(_: GalleryApplicationVersionState<_, _, _, _, _, _>) : azurerm.GalleryApplicationVersion.GalleryApplicationVersion =
            Unchecked.defaultof<azurerm.GalleryApplicationVersion.GalleryApplicationVersion>
