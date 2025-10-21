namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LocationGeofenceCollectionState<'CollectionName> = { assignments: ResizeArray<aws.LocationGeofenceCollection.LocationGeofenceCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_geofence_collection">aws_location_geofence_collection</a>.
    /// </summary>
    type LocationGeofenceCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : LocationGeofenceCollectionState<Missing> =
            ({ assignments = ResizeArray() } : LocationGeofenceCollectionState<Missing>)

        member _.Zero(()) : LocationGeofenceCollectionState<Missing> =
            ({ assignments = ResizeArray() } : LocationGeofenceCollectionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_geofence_collection#collection_name-1">LocationGeofenceCollection#collection_name</a>.
        /// </summary>
        [<CustomOperation "collection_name">]
        member _.CollectionName(state: LocationGeofenceCollectionState<Missing>, value: string) : LocationGeofenceCollectionState<Present> =
            state.assignments.Add(fun config -> config.CollectionName <- value)
            ({ assignments = state.assignments } : LocationGeofenceCollectionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_geofence_collection#description-1">LocationGeofenceCollection#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LocationGeofenceCollectionState<'CollectionName>, value: string) : LocationGeofenceCollectionState<'CollectionName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LocationGeofenceCollectionState<'CollectionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_geofence_collection#id-1">LocationGeofenceCollection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LocationGeofenceCollectionState<'CollectionName>, value: string) : LocationGeofenceCollectionState<'CollectionName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LocationGeofenceCollectionState<'CollectionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_geofence_collection#kms_key_id-1">LocationGeofenceCollection#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: LocationGeofenceCollectionState<'CollectionName>, value: string) : LocationGeofenceCollectionState<'CollectionName> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : LocationGeofenceCollectionState<'CollectionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_geofence_collection#tags-1">LocationGeofenceCollection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LocationGeofenceCollectionState<'CollectionName>, value: seq<string * string>) : LocationGeofenceCollectionState<'CollectionName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LocationGeofenceCollectionState<'CollectionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_geofence_collection#tags_all-1">LocationGeofenceCollection#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LocationGeofenceCollectionState<'CollectionName>, value: seq<string * string>) : LocationGeofenceCollectionState<'CollectionName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LocationGeofenceCollectionState<'CollectionName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_geofence_collection#timeouts-1">LocationGeofenceCollection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LocationGeofenceCollectionState<'CollectionName>, value: aws.LocationGeofenceCollection.LocationGeofenceCollectionTimeouts) : LocationGeofenceCollectionState<'CollectionName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LocationGeofenceCollectionState<'CollectionName>

        member _.Run(state: LocationGeofenceCollectionState<Present>) : aws.LocationGeofenceCollection.LocationGeofenceCollection =
            let config = aws.LocationGeofenceCollection.LocationGeofenceCollectionConfig()
            for setter in state.assignments do
                setter config
            aws.LocationGeofenceCollection.LocationGeofenceCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.locationGeofenceCollection: missing required arguments. Must call: collection_name.", 9999, IsError = true)>]
        member _.Run(_: LocationGeofenceCollectionState<_>) : aws.LocationGeofenceCollection.LocationGeofenceCollection =
            Unchecked.defaultof<aws.LocationGeofenceCollection.LocationGeofenceCollection>
