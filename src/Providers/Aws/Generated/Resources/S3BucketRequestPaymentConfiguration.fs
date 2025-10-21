namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketRequestPaymentConfigurationState<'Bucket, 'Payer> = { assignments: ResizeArray<aws.S3BucketRequestPaymentConfiguration.S3BucketRequestPaymentConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_request_payment_configuration">aws_s3_bucket_request_payment_configuration</a>.
    /// </summary>
    type S3BucketRequestPaymentConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketRequestPaymentConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketRequestPaymentConfigurationState<Missing, Missing>)

        member _.Zero(()) : S3BucketRequestPaymentConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketRequestPaymentConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_request_payment_configuration#bucket-1">S3BucketRequestPaymentConfiguration#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketRequestPaymentConfigurationState<Missing, 'Payer>, value: string) : S3BucketRequestPaymentConfigurationState<Present, 'Payer> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketRequestPaymentConfigurationState<Present, 'Payer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_request_payment_configuration#payer-1">S3BucketRequestPaymentConfiguration#payer</a>.
        /// </summary>
        [<CustomOperation "payer">]
        member _.Payer(state: S3BucketRequestPaymentConfigurationState<'Bucket, Missing>, value: string) : S3BucketRequestPaymentConfigurationState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Payer <- value)
            ({ assignments = state.assignments } : S3BucketRequestPaymentConfigurationState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_request_payment_configuration#expected_bucket_owner-1">S3BucketRequestPaymentConfiguration#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: S3BucketRequestPaymentConfigurationState<'Bucket, 'Payer>, value: string) : S3BucketRequestPaymentConfigurationState<'Bucket, 'Payer> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : S3BucketRequestPaymentConfigurationState<'Bucket, 'Payer>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_request_payment_configuration#id-1">S3BucketRequestPaymentConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketRequestPaymentConfigurationState<'Bucket, 'Payer>, value: string) : S3BucketRequestPaymentConfigurationState<'Bucket, 'Payer> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketRequestPaymentConfigurationState<'Bucket, 'Payer>

        member _.Run(state: S3BucketRequestPaymentConfigurationState<Present, Present>) : aws.S3BucketRequestPaymentConfiguration.S3BucketRequestPaymentConfiguration =
            let config = aws.S3BucketRequestPaymentConfiguration.S3BucketRequestPaymentConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketRequestPaymentConfiguration.S3BucketRequestPaymentConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketRequestPaymentConfiguration: missing required arguments. Must call: bucket, payer.", 9999, IsError = true)>]
        member _.Run(_: S3BucketRequestPaymentConfigurationState<_, _>) : aws.S3BucketRequestPaymentConfiguration.S3BucketRequestPaymentConfiguration =
            Unchecked.defaultof<aws.S3BucketRequestPaymentConfiguration.S3BucketRequestPaymentConfiguration>
