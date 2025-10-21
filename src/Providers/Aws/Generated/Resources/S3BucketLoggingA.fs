namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix> = { assignments: ResizeArray<aws.S3BucketLogging.S3BucketLoggingAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging">aws_s3_bucket_logging</a>.
    /// </summary>
    type S3BucketLoggingABuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketLoggingAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketLoggingAState<Missing, Missing, Missing>)

        member _.Zero(()) : S3BucketLoggingAState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketLoggingAState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#bucket-1">S3BucketLoggingA#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketLoggingAState<Missing, 'TargetBucket, 'TargetPrefix>, value: string) : S3BucketLoggingAState<Present, 'TargetBucket, 'TargetPrefix> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketLoggingAState<Present, 'TargetBucket, 'TargetPrefix>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#target_bucket-1">S3BucketLoggingA#target_bucket</a>.
        /// </summary>
        [<CustomOperation "target_bucket">]
        member _.TargetBucket(state: S3BucketLoggingAState<'Bucket, Missing, 'TargetPrefix>, value: string) : S3BucketLoggingAState<'Bucket, Present, 'TargetPrefix> =
            state.assignments.Add(fun config -> config.TargetBucket <- value)
            ({ assignments = state.assignments } : S3BucketLoggingAState<'Bucket, Present, 'TargetPrefix>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#target_prefix-1">S3BucketLoggingA#target_prefix</a>.
        /// </summary>
        [<CustomOperation "target_prefix">]
        member _.TargetPrefix(state: S3BucketLoggingAState<'Bucket, 'TargetBucket, Missing>, value: string) : S3BucketLoggingAState<'Bucket, 'TargetBucket, Present> =
            state.assignments.Add(fun config -> config.TargetPrefix <- value)
            ({ assignments = state.assignments } : S3BucketLoggingAState<'Bucket, 'TargetBucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#expected_bucket_owner-1">S3BucketLoggingA#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix>, value: string) : S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#id-1">S3BucketLoggingA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix>, value: string) : S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix>

        /// <summary>
        /// target_grant block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#target_grant-1">S3BucketLoggingA#target_grant</a> Accepts: aws.IResolvable | aws.S3BucketLogging.S3BucketLoggingTargetGrant[]
        /// </summary>
        [<CustomOperation "target_grant">]
        member _.TargetGrant(state: S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix>, value: HashiCorp.Cdktf.IResolvable) : S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix> =
            state.assignments.Add(fun config -> config.TargetGrant <- value)
            state : S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix>

        /// <summary>
        /// target_object_key_format block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_logging#target_object_key_format-1">S3BucketLoggingA#target_object_key_format</a>
        /// </summary>
        [<CustomOperation "target_object_key_format">]
        member _.TargetObjectKeyFormat(state: S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix>, value: aws.S3BucketLogging.S3BucketLoggingTargetObjectKeyFormat) : S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix> =
            state.assignments.Add(fun config -> config.TargetObjectKeyFormat <- value)
            state : S3BucketLoggingAState<'Bucket, 'TargetBucket, 'TargetPrefix>

        member _.Run(state: S3BucketLoggingAState<Present, Present, Present>) : aws.S3BucketLogging.S3BucketLoggingA =
            let config = aws.S3BucketLogging.S3BucketLoggingAConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketLogging.S3BucketLoggingA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketLoggingA: missing required arguments. Must call: bucket, target_bucket, target_prefix.", 9999, IsError = true)>]
        member _.Run(_: S3BucketLoggingAState<_, _, _>) : aws.S3BucketLogging.S3BucketLoggingA =
            Unchecked.defaultof<aws.S3BucketLogging.S3BucketLoggingA>
