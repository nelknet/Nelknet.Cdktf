namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLocationGeofenceCollectionState<'CollectionName> = { assignments: ResizeArray<aws.DataAwsLocationGeofenceCollection.DataAwsLocationGeofenceCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_geofence_collection">aws_location_geofence_collection</a>.
    /// </summary>
    type DataAwsLocationGeofenceCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLocationGeofenceCollectionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationGeofenceCollectionState<Missing>)

        member _.Zero(()) : DataAwsLocationGeofenceCollectionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationGeofenceCollectionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_geofence_collection#collection_name-1">DataAwsLocationGeofenceCollection#collection_name</a>.
        /// </summary>
        [<CustomOperation "collection_name">]
        member _.CollectionName(state: DataAwsLocationGeofenceCollectionState<Missing>, value: string) : DataAwsLocationGeofenceCollectionState<Present> =
            state.assignments.Add(fun config -> config.CollectionName <- value)
            ({ assignments = state.assignments } : DataAwsLocationGeofenceCollectionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_geofence_collection#id-1">DataAwsLocationGeofenceCollection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLocationGeofenceCollectionState<'CollectionName>, value: string) : DataAwsLocationGeofenceCollectionState<'CollectionName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLocationGeofenceCollectionState<'CollectionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_geofence_collection#kms_key_id-1">DataAwsLocationGeofenceCollection#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: DataAwsLocationGeofenceCollectionState<'CollectionName>, value: string) : DataAwsLocationGeofenceCollectionState<'CollectionName> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : DataAwsLocationGeofenceCollectionState<'CollectionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_geofence_collection#tags-1">DataAwsLocationGeofenceCollection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsLocationGeofenceCollectionState<'CollectionName>, value: seq<string * string>) : DataAwsLocationGeofenceCollectionState<'CollectionName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsLocationGeofenceCollectionState<'CollectionName>

        member _.Run(state: DataAwsLocationGeofenceCollectionState<Present>) : aws.DataAwsLocationGeofenceCollection.DataAwsLocationGeofenceCollection =
            let config = aws.DataAwsLocationGeofenceCollection.DataAwsLocationGeofenceCollectionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLocationGeofenceCollection.DataAwsLocationGeofenceCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLocationGeofenceCollection: missing required arguments. Must call: collection_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLocationGeofenceCollectionState<_>) : aws.DataAwsLocationGeofenceCollection.DataAwsLocationGeofenceCollection =
            Unchecked.defaultof<aws.DataAwsLocationGeofenceCollection.DataAwsLocationGeofenceCollection>
