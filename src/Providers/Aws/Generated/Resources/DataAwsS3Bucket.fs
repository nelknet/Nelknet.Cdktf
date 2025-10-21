namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsS3BucketState<'Bucket> = { assignments: ResizeArray<aws.DataAwsS3Bucket.DataAwsS3BucketConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket">aws_s3_bucket</a>.
    /// </summary>
    type DataAwsS3BucketBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsS3BucketState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsS3BucketState<Missing>)

        member _.Zero(()) : DataAwsS3BucketState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsS3BucketState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket#bucket-1">DataAwsS3Bucket#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: DataAwsS3BucketState<Missing>, value: string) : DataAwsS3BucketState<Present> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : DataAwsS3BucketState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket#id-1">DataAwsS3Bucket#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsS3BucketState<'Bucket>, value: string) : DataAwsS3BucketState<'Bucket> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsS3BucketState<'Bucket>

        member _.Run(state: DataAwsS3BucketState<Present>) : aws.DataAwsS3Bucket.DataAwsS3Bucket =
            let config = aws.DataAwsS3Bucket.DataAwsS3BucketConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsS3Bucket.DataAwsS3Bucket(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsS3Bucket: missing required arguments. Must call: bucket.", 9999, IsError = true)>]
        member _.Run(_: DataAwsS3BucketState<_>) : aws.DataAwsS3Bucket.DataAwsS3Bucket =
            Unchecked.defaultof<aws.DataAwsS3Bucket.DataAwsS3Bucket>
