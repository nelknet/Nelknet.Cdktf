namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketAnalyticsConfigurationState<'Bucket, 'Name> = { assignments: ResizeArray<aws.S3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration">aws_s3_bucket_analytics_configuration</a>.
    /// </summary>
    type S3BucketAnalyticsConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketAnalyticsConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketAnalyticsConfigurationState<Missing, Missing>)

        member _.Zero(()) : S3BucketAnalyticsConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketAnalyticsConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#bucket-1">S3BucketAnalyticsConfiguration#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketAnalyticsConfigurationState<Missing, 'Name>, value: string) : S3BucketAnalyticsConfigurationState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketAnalyticsConfigurationState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#name-1">S3BucketAnalyticsConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: S3BucketAnalyticsConfigurationState<'Bucket, Missing>, value: string) : S3BucketAnalyticsConfigurationState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : S3BucketAnalyticsConfigurationState<'Bucket, Present>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#filter-1">S3BucketAnalyticsConfiguration#filter</a>
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: S3BucketAnalyticsConfigurationState<'Bucket, 'Name>, value: aws.S3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationFilter) : S3BucketAnalyticsConfigurationState<'Bucket, 'Name> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : S3BucketAnalyticsConfigurationState<'Bucket, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#id-1">S3BucketAnalyticsConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketAnalyticsConfigurationState<'Bucket, 'Name>, value: string) : S3BucketAnalyticsConfigurationState<'Bucket, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketAnalyticsConfigurationState<'Bucket, 'Name>

        /// <summary>
        /// storage_class_analysis block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_analytics_configuration#storage_class_analysis-1">S3BucketAnalyticsConfiguration#storage_class_analysis</a>
        /// </summary>
        [<CustomOperation "storage_class_analysis">]
        member _.StorageClassAnalysis(state: S3BucketAnalyticsConfigurationState<'Bucket, 'Name>, value: aws.S3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationStorageClassAnalysis) : S3BucketAnalyticsConfigurationState<'Bucket, 'Name> =
            state.assignments.Add(fun config -> config.StorageClassAnalysis <- value)
            state : S3BucketAnalyticsConfigurationState<'Bucket, 'Name>

        member _.Run(state: S3BucketAnalyticsConfigurationState<Present, Present>) : aws.S3BucketAnalyticsConfiguration.S3BucketAnalyticsConfiguration =
            let config = aws.S3BucketAnalyticsConfiguration.S3BucketAnalyticsConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketAnalyticsConfiguration.S3BucketAnalyticsConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketAnalyticsConfiguration: missing required arguments. Must call: bucket, name.", 9999, IsError = true)>]
        member _.Run(_: S3BucketAnalyticsConfigurationState<_, _>) : aws.S3BucketAnalyticsConfiguration.S3BucketAnalyticsConfiguration =
            Unchecked.defaultof<aws.S3BucketAnalyticsConfiguration.S3BucketAnalyticsConfiguration>
