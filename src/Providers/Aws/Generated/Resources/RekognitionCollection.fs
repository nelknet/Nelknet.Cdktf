namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RekognitionCollectionState<'CollectionId> = { assignments: ResizeArray<aws.RekognitionCollection.RekognitionCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_collection">aws_rekognition_collection</a>.
    /// </summary>
    type RekognitionCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : RekognitionCollectionState<Missing> =
            ({ assignments = ResizeArray() } : RekognitionCollectionState<Missing>)

        member _.Zero(()) : RekognitionCollectionState<Missing> =
            ({ assignments = ResizeArray() } : RekognitionCollectionState<Missing>)

        /// <summary>
        /// The name of the Rekognition collection. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_collection#collection_id-1">RekognitionCollection#collection_id</a>
        /// </summary>
        [<CustomOperation "collection_id">]
        member _.CollectionId(state: RekognitionCollectionState<Missing>, value: string) : RekognitionCollectionState<Present> =
            state.assignments.Add(fun config -> config.CollectionId <- value)
            ({ assignments = state.assignments } : RekognitionCollectionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_collection#tags-1">RekognitionCollection#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RekognitionCollectionState<'CollectionId>, value: seq<string * string>) : RekognitionCollectionState<'CollectionId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RekognitionCollectionState<'CollectionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rekognition_collection#timeouts-1">RekognitionCollection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RekognitionCollectionState<'CollectionId>, value: aws.RekognitionCollection.RekognitionCollectionTimeouts) : RekognitionCollectionState<'CollectionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RekognitionCollectionState<'CollectionId>

        member _.Run(state: RekognitionCollectionState<Present>) : aws.RekognitionCollection.RekognitionCollection =
            let config = aws.RekognitionCollection.RekognitionCollectionConfig()
            for setter in state.assignments do
                setter config
            aws.RekognitionCollection.RekognitionCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rekognitionCollection: missing required arguments. Must call: collection_id.", 9999, IsError = true)>]
        member _.Run(_: RekognitionCollectionState<_>) : aws.RekognitionCollection.RekognitionCollection =
            Unchecked.defaultof<aws.RekognitionCollection.RekognitionCollection>
