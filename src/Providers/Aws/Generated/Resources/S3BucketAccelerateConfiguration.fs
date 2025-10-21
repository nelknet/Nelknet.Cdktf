namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketAccelerateConfigurationState<'Bucket, 'Status> = { assignments: ResizeArray<aws.S3BucketAccelerateConfiguration.S3BucketAccelerateConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_accelerate_configuration">aws_s3_bucket_accelerate_configuration</a>.
    /// </summary>
    type S3BucketAccelerateConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketAccelerateConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketAccelerateConfigurationState<Missing, Missing>)

        member _.Zero(()) : S3BucketAccelerateConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketAccelerateConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_accelerate_configuration#bucket-1">S3BucketAccelerateConfiguration#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketAccelerateConfigurationState<Missing, 'Status>, value: string) : S3BucketAccelerateConfigurationState<Present, 'Status> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketAccelerateConfigurationState<Present, 'Status>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_accelerate_configuration#status-1">S3BucketAccelerateConfiguration#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: S3BucketAccelerateConfigurationState<'Bucket, Missing>, value: string) : S3BucketAccelerateConfigurationState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Status <- value)
            ({ assignments = state.assignments } : S3BucketAccelerateConfigurationState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_accelerate_configuration#expected_bucket_owner-1">S3BucketAccelerateConfiguration#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: S3BucketAccelerateConfigurationState<'Bucket, 'Status>, value: string) : S3BucketAccelerateConfigurationState<'Bucket, 'Status> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : S3BucketAccelerateConfigurationState<'Bucket, 'Status>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_accelerate_configuration#id-1">S3BucketAccelerateConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketAccelerateConfigurationState<'Bucket, 'Status>, value: string) : S3BucketAccelerateConfigurationState<'Bucket, 'Status> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketAccelerateConfigurationState<'Bucket, 'Status>

        member _.Run(state: S3BucketAccelerateConfigurationState<Present, Present>) : aws.S3BucketAccelerateConfiguration.S3BucketAccelerateConfiguration =
            let config = aws.S3BucketAccelerateConfiguration.S3BucketAccelerateConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketAccelerateConfiguration.S3BucketAccelerateConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketAccelerateConfiguration: missing required arguments. Must call: bucket, status.", 9999, IsError = true)>]
        member _.Run(_: S3BucketAccelerateConfigurationState<_, _>) : aws.S3BucketAccelerateConfiguration.S3BucketAccelerateConfiguration =
            Unchecked.defaultof<aws.S3BucketAccelerateConfiguration.S3BucketAccelerateConfiguration>
