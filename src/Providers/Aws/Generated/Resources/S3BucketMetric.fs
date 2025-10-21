namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketMetricState<'Bucket, 'Name> = { assignments: ResizeArray<aws.S3BucketMetric.S3BucketMetricConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_metric">aws_s3_bucket_metric</a>.
    /// </summary>
    type S3BucketMetricBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketMetricState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketMetricState<Missing, Missing>)

        member _.Zero(()) : S3BucketMetricState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketMetricState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_metric#bucket-1">S3BucketMetric#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketMetricState<Missing, 'Name>, value: string) : S3BucketMetricState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketMetricState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_metric#name-1">S3BucketMetric#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: S3BucketMetricState<'Bucket, Missing>, value: string) : S3BucketMetricState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : S3BucketMetricState<'Bucket, Present>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_metric#filter-1">S3BucketMetric#filter</a>
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: S3BucketMetricState<'Bucket, 'Name>, value: aws.S3BucketMetric.S3BucketMetricFilter) : S3BucketMetricState<'Bucket, 'Name> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : S3BucketMetricState<'Bucket, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_metric#id-1">S3BucketMetric#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketMetricState<'Bucket, 'Name>, value: string) : S3BucketMetricState<'Bucket, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketMetricState<'Bucket, 'Name>

        member _.Run(state: S3BucketMetricState<Present, Present>) : aws.S3BucketMetric.S3BucketMetric =
            let config = aws.S3BucketMetric.S3BucketMetricConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketMetric.S3BucketMetric(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketMetric: missing required arguments. Must call: bucket, name.", 9999, IsError = true)>]
        member _.Run(_: S3BucketMetricState<_, _>) : aws.S3BucketMetric.S3BucketMetric =
            Unchecked.defaultof<aws.S3BucketMetric.S3BucketMetric>
