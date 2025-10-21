namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlBucketState<'Bucket, 'OutpostId> = { assignments: ResizeArray<aws.S3ControlBucket.S3ControlBucketConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket">aws_s3control_bucket</a>.
    /// </summary>
    type S3ControlBucketBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlBucketState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlBucketState<Missing, Missing>)

        member _.Zero(()) : S3ControlBucketState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlBucketState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket#bucket-1">S3ControlBucket#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3ControlBucketState<Missing, 'OutpostId>, value: string) : S3ControlBucketState<Present, 'OutpostId> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3ControlBucketState<Present, 'OutpostId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket#outpost_id-1">S3ControlBucket#outpost_id</a>.
        /// </summary>
        [<CustomOperation "outpost_id">]
        member _.OutpostId(state: S3ControlBucketState<'Bucket, Missing>, value: string) : S3ControlBucketState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.OutpostId <- value)
            ({ assignments = state.assignments } : S3ControlBucketState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket#id-1">S3ControlBucket#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3ControlBucketState<'Bucket, 'OutpostId>, value: string) : S3ControlBucketState<'Bucket, 'OutpostId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3ControlBucketState<'Bucket, 'OutpostId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket#tags-1">S3ControlBucket#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: S3ControlBucketState<'Bucket, 'OutpostId>, value: seq<string * string>) : S3ControlBucketState<'Bucket, 'OutpostId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : S3ControlBucketState<'Bucket, 'OutpostId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket#tags_all-1">S3ControlBucket#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: S3ControlBucketState<'Bucket, 'OutpostId>, value: seq<string * string>) : S3ControlBucketState<'Bucket, 'OutpostId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : S3ControlBucketState<'Bucket, 'OutpostId>

        member _.Run(state: S3ControlBucketState<Present, Present>) : aws.S3ControlBucket.S3ControlBucket =
            let config = aws.S3ControlBucket.S3ControlBucketConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlBucket.S3ControlBucket(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlBucket: missing required arguments. Must call: bucket, outpost_id.", 9999, IsError = true)>]
        member _.Run(_: S3ControlBucketState<_, _>) : aws.S3ControlBucket.S3ControlBucket =
            Unchecked.defaultof<aws.S3ControlBucket.S3ControlBucket>
