namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule> = { assignments: ResizeArray<aws.S3BucketInventory.S3BucketInventoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory">aws_s3_bucket_inventory</a>.
    /// </summary>
    type S3BucketInventoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketInventoryState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketInventoryState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : S3BucketInventoryState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketInventoryState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#bucket-1">S3BucketInventory#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketInventoryState<Missing, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule>, value: string) : S3BucketInventoryState<Present, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketInventoryState<Present, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule>)

        /// <summary>
        /// destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#destination-1">S3BucketInventory#destination</a>
        /// </summary>
        [<CustomOperation "destination">]
        member _.Destination(state: S3BucketInventoryState<'Bucket, Missing, 'IncludedObjectVersions, 'Name, 'Schedule>, value: aws.S3BucketInventory.S3BucketInventoryDestination) : S3BucketInventoryState<'Bucket, Present, 'IncludedObjectVersions, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Destination <- value)
            ({ assignments = state.assignments } : S3BucketInventoryState<'Bucket, Present, 'IncludedObjectVersions, 'Name, 'Schedule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#included_object_versions-1">S3BucketInventory#included_object_versions</a>.
        /// </summary>
        [<CustomOperation "included_object_versions">]
        member _.IncludedObjectVersions(state: S3BucketInventoryState<'Bucket, 'Destination, Missing, 'Name, 'Schedule>, value: string) : S3BucketInventoryState<'Bucket, 'Destination, Present, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.IncludedObjectVersions <- value)
            ({ assignments = state.assignments } : S3BucketInventoryState<'Bucket, 'Destination, Present, 'Name, 'Schedule>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#name-1">S3BucketInventory#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, Missing, 'Schedule>, value: string) : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, Present, 'Schedule> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, Present, 'Schedule>)

        /// <summary>
        /// schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#schedule-1">S3BucketInventory#schedule</a>
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, Missing>, value: aws.S3BucketInventory.S3BucketInventorySchedule) : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, Present> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            ({ assignments = state.assignments } : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#enabled-1">S3BucketInventory#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule>, value: bool) : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#enabled-1">S3BucketInventory#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule>, value: HashiCorp.Cdktf.IResolvable) : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule>

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#filter-1">S3BucketInventory#filter</a>
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule>, value: aws.S3BucketInventory.S3BucketInventoryFilter) : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#id-1">S3BucketInventory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule>, value: string) : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_inventory#optional_fields-1">S3BucketInventory#optional_fields</a>.
        /// </summary>
        [<CustomOperation "optional_fields">]
        member _.OptionalFields(state: S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule>, value: seq<string>) : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule> =
            state.assignments.Add(fun config -> config.OptionalFields <- (value |> Seq.toArray))
            state : S3BucketInventoryState<'Bucket, 'Destination, 'IncludedObjectVersions, 'Name, 'Schedule>

        member _.Run(state: S3BucketInventoryState<Present, Present, Present, Present, Present>) : aws.S3BucketInventory.S3BucketInventory =
            let config = aws.S3BucketInventory.S3BucketInventoryConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketInventory.S3BucketInventory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketInventory: missing required arguments. Must call: bucket, destination, included_object_versions, name, schedule.", 9999, IsError = true)>]
        member _.Run(_: S3BucketInventoryState<_, _, _, _, _>) : aws.S3BucketInventory.S3BucketInventory =
            Unchecked.defaultof<aws.S3BucketInventory.S3BucketInventory>
