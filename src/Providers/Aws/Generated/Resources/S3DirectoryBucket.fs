namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3DirectoryBucketState<'Bucket> = { assignments: ResizeArray<aws.S3DirectoryBucket.S3DirectoryBucketConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_directory_bucket">aws_s3_directory_bucket</a>.
    /// </summary>
    type S3DirectoryBucketBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3DirectoryBucketState<Missing> =
            ({ assignments = ResizeArray() } : S3DirectoryBucketState<Missing>)

        member _.Zero(()) : S3DirectoryBucketState<Missing> =
            ({ assignments = ResizeArray() } : S3DirectoryBucketState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_directory_bucket#bucket-1">S3DirectoryBucket#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3DirectoryBucketState<Missing>, value: string) : S3DirectoryBucketState<Present> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3DirectoryBucketState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_directory_bucket#data_redundancy-1">S3DirectoryBucket#data_redundancy</a>.
        /// </summary>
        [<CustomOperation "data_redundancy">]
        member _.DataRedundancy(state: S3DirectoryBucketState<'Bucket>, value: string) : S3DirectoryBucketState<'Bucket> =
            state.assignments.Add(fun config -> config.DataRedundancy <- value)
            state : S3DirectoryBucketState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_directory_bucket#force_destroy-1">S3DirectoryBucket#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: S3DirectoryBucketState<'Bucket>, value: bool) : S3DirectoryBucketState<'Bucket> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : S3DirectoryBucketState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_directory_bucket#force_destroy-1">S3DirectoryBucket#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: S3DirectoryBucketState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : S3DirectoryBucketState<'Bucket> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : S3DirectoryBucketState<'Bucket>

        /// <summary>
        /// location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_directory_bucket#location-1">S3DirectoryBucket#location</a> Accepts: aws.IResolvable | aws.S3DirectoryBucket.S3DirectoryBucketLocation[]
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: S3DirectoryBucketState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : S3DirectoryBucketState<'Bucket> =
            state.assignments.Add(fun config -> config.Location <- value)
            state : S3DirectoryBucketState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_directory_bucket#type-1">S3DirectoryBucket#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: S3DirectoryBucketState<'Bucket>, value: string) : S3DirectoryBucketState<'Bucket> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : S3DirectoryBucketState<'Bucket>

        member _.Run(state: S3DirectoryBucketState<Present>) : aws.S3DirectoryBucket.S3DirectoryBucket =
            let config = aws.S3DirectoryBucket.S3DirectoryBucketConfig()
            for setter in state.assignments do
                setter config
            aws.S3DirectoryBucket.S3DirectoryBucket(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3DirectoryBucket: missing required arguments. Must call: bucket.", 9999, IsError = true)>]
        member _.Run(_: S3DirectoryBucketState<_>) : aws.S3DirectoryBucket.S3DirectoryBucket =
            Unchecked.defaultof<aws.S3DirectoryBucket.S3DirectoryBucket>
