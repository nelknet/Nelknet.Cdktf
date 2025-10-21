namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> = { assignments: ResizeArray<azurerm.SharedImageVersion.SharedImageVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version">azurerm_shared_image_version</a>.
    /// </summary>
    type SharedImageVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SharedImageVersionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SharedImageVersionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SharedImageVersionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SharedImageVersionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#gallery_name-1">SharedImageVersion#gallery_name</a>.
        /// </summary>
        [<CustomOperation "gallery_name">]
        member _.GalleryName(state: SharedImageVersionState<Missing, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: string) : SharedImageVersionState<Present, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.GalleryName <- value)
            ({ assignments = state.assignments } : SharedImageVersionState<Present, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#image_name-1">SharedImageVersion#image_name</a>.
        /// </summary>
        [<CustomOperation "image_name">]
        member _.ImageName(state: SharedImageVersionState<'GalleryName, Missing, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: string) : SharedImageVersionState<'GalleryName, Present, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.ImageName <- value)
            ({ assignments = state.assignments } : SharedImageVersionState<'GalleryName, Present, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#location-1">SharedImageVersion#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SharedImageVersionState<'GalleryName, 'ImageName, Missing, 'Name, 'ResourceGroupName, 'TargetRegion>, value: string) : SharedImageVersionState<'GalleryName, 'ImageName, Present, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SharedImageVersionState<'GalleryName, 'ImageName, Present, 'Name, 'ResourceGroupName, 'TargetRegion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#name-1">SharedImageVersion#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, Missing, 'ResourceGroupName, 'TargetRegion>, value: string) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, Present, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, Present, 'ResourceGroupName, 'TargetRegion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#resource_group_name-1">SharedImageVersion#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, Missing, 'TargetRegion>, value: string) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, Present, 'TargetRegion> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, Present, 'TargetRegion>)

        /// <summary>
        /// target_region block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#target_region-1">SharedImageVersion#target_region</a> Accepts: azurerm.IResolvable | azurerm.SharedImageVersion.SharedImageVersionTargetRegion[]
        /// </summary>
        [<CustomOperation "target_region">]
        member _.TargetRegion(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, Missing>, value: HashiCorp.Cdktf.IResolvable) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.TargetRegion <- value)
            ({ assignments = state.assignments } : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#blob_uri-1">SharedImageVersion#blob_uri</a>.
        /// </summary>
        [<CustomOperation "blob_uri">]
        member _.BlobUri(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: string) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.BlobUri <- value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#deletion_of_replicated_locations_enabled-1">SharedImageVersion#deletion_of_replicated_locations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "deletion_of_replicated_locations_enabled">]
        member _.DeletionOfReplicatedLocationsEnabled(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: bool) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.DeletionOfReplicatedLocationsEnabled <- value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#deletion_of_replicated_locations_enabled-1">SharedImageVersion#deletion_of_replicated_locations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "deletion_of_replicated_locations_enabled">]
        member _.DeletionOfReplicatedLocationsEnabled(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: HashiCorp.Cdktf.IResolvable) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.DeletionOfReplicatedLocationsEnabled <- value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#end_of_life_date-1">SharedImageVersion#end_of_life_date</a>.
        /// </summary>
        [<CustomOperation "end_of_life_date">]
        member _.EndOfLifeDate(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: string) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.EndOfLifeDate <- value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#exclude_from_latest-1">SharedImageVersion#exclude_from_latest</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "exclude_from_latest">]
        member _.ExcludeFromLatest(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: bool) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.ExcludeFromLatest <- value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#exclude_from_latest-1">SharedImageVersion#exclude_from_latest</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "exclude_from_latest">]
        member _.ExcludeFromLatest(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: HashiCorp.Cdktf.IResolvable) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.ExcludeFromLatest <- value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#id-1">SharedImageVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: string) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#managed_image_id-1">SharedImageVersion#managed_image_id</a>.
        /// </summary>
        [<CustomOperation "managed_image_id">]
        member _.ManagedImageId(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: string) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.ManagedImageId <- value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#os_disk_snapshot_id-1">SharedImageVersion#os_disk_snapshot_id</a>.
        /// </summary>
        [<CustomOperation "os_disk_snapshot_id">]
        member _.OsDiskSnapshotId(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: string) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.OsDiskSnapshotId <- value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#replication_mode-1">SharedImageVersion#replication_mode</a>.
        /// </summary>
        [<CustomOperation "replication_mode">]
        member _.ReplicationMode(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: string) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.ReplicationMode <- value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#storage_account_id-1">SharedImageVersion#storage_account_id</a>.
        /// </summary>
        [<CustomOperation "storage_account_id">]
        member _.StorageAccountId(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: string) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.StorageAccountId <- value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#tags-1">SharedImageVersion#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: seq<string * string>) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/shared_image_version#timeouts-1">SharedImageVersion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>, value: azurerm.SharedImageVersion.SharedImageVersionTimeouts) : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SharedImageVersionState<'GalleryName, 'ImageName, 'Location, 'Name, 'ResourceGroupName, 'TargetRegion>

        member _.Run(state: SharedImageVersionState<Present, Present, Present, Present, Present, Present>) : azurerm.SharedImageVersion.SharedImageVersion =
            let config = azurerm.SharedImageVersion.SharedImageVersionConfig()
            for setter in state.assignments do
                setter config
            azurerm.SharedImageVersion.SharedImageVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sharedImageVersion: missing required arguments. Must call: gallery_name, image_name, location, name, resource_group_name, target_region.", 9999, IsError = true)>]
        member _.Run(_: SharedImageVersionState<_, _, _, _, _, _>) : azurerm.SharedImageVersion.SharedImageVersion =
            Unchecked.defaultof<azurerm.SharedImageVersion.SharedImageVersion>
