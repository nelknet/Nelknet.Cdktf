namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketLifecycleConfigurationState<'Bucket> = { assignments: ResizeArray<aws.S3BucketLifecycleConfiguration.S3BucketLifecycleConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration">aws_s3_bucket_lifecycle_configuration</a>.
    /// </summary>
    type S3BucketLifecycleConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketLifecycleConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : S3BucketLifecycleConfigurationState<Missing>)

        member _.Zero(()) : S3BucketLifecycleConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : S3BucketLifecycleConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#bucket-1">S3BucketLifecycleConfiguration#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketLifecycleConfigurationState<Missing>, value: string) : S3BucketLifecycleConfigurationState<Present> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketLifecycleConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#expected_bucket_owner-1">S3BucketLifecycleConfiguration#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: S3BucketLifecycleConfigurationState<'Bucket>, value: string) : S3BucketLifecycleConfigurationState<'Bucket> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : S3BucketLifecycleConfigurationState<'Bucket>

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#rule-1">S3BucketLifecycleConfiguration#rule</a> Accepts: aws.IResolvable | aws.S3BucketLifecycleConfiguration.S3BucketLifecycleConfigurationRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: S3BucketLifecycleConfigurationState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : S3BucketLifecycleConfigurationState<'Bucket> =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : S3BucketLifecycleConfigurationState<'Bucket>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#timeouts-1">S3BucketLifecycleConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: S3BucketLifecycleConfigurationState<'Bucket>, value: aws.S3BucketLifecycleConfiguration.S3BucketLifecycleConfigurationTimeouts) : S3BucketLifecycleConfigurationState<'Bucket> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : S3BucketLifecycleConfigurationState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_lifecycle_configuration#transition_default_minimum_object_size-1">S3BucketLifecycleConfiguration#transition_default_minimum_object_size</a>.
        /// </summary>
        [<CustomOperation "transition_default_minimum_object_size">]
        member _.TransitionDefaultMinimumObjectSize(state: S3BucketLifecycleConfigurationState<'Bucket>, value: string) : S3BucketLifecycleConfigurationState<'Bucket> =
            state.assignments.Add(fun config -> config.TransitionDefaultMinimumObjectSize <- value)
            state : S3BucketLifecycleConfigurationState<'Bucket>

        member _.Run(state: S3BucketLifecycleConfigurationState<Present>) : aws.S3BucketLifecycleConfiguration.S3BucketLifecycleConfiguration =
            let config = aws.S3BucketLifecycleConfiguration.S3BucketLifecycleConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketLifecycleConfiguration.S3BucketLifecycleConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketLifecycleConfiguration: missing required arguments. Must call: bucket.", 9999, IsError = true)>]
        member _.Run(_: S3BucketLifecycleConfigurationState<_>) : aws.S3BucketLifecycleConfiguration.S3BucketLifecycleConfiguration =
            Unchecked.defaultof<aws.S3BucketLifecycleConfiguration.S3BucketLifecycleConfiguration>
