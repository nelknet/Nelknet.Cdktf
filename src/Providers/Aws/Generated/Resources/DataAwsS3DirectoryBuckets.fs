namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsS3DirectoryBucketsState = { assignments: ResizeArray<aws.DataAwsS3DirectoryBuckets.DataAwsS3DirectoryBucketsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_directory_buckets">aws_s3_directory_buckets</a>.
    /// </summary>
    type DataAwsS3DirectoryBucketsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsS3DirectoryBucketsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsS3DirectoryBucketsState =
            { assignments = ResizeArray() }



        member _.Run(state: DataAwsS3DirectoryBucketsState) : aws.DataAwsS3DirectoryBuckets.DataAwsS3DirectoryBuckets =
            let config = aws.DataAwsS3DirectoryBuckets.DataAwsS3DirectoryBucketsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsS3DirectoryBuckets.DataAwsS3DirectoryBuckets(StackContext.get (), logicalId, config)
