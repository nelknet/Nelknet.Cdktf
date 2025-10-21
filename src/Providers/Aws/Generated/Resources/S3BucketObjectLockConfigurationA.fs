namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketObjectLockConfigurationAState<'Bucket> = { assignments: ResizeArray<aws.S3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object_lock_configuration">aws_s3_bucket_object_lock_configuration</a>.
    /// </summary>
    type S3BucketObjectLockConfigurationABuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketObjectLockConfigurationAState<Missing> =
            ({ assignments = ResizeArray() } : S3BucketObjectLockConfigurationAState<Missing>)

        member _.Zero(()) : S3BucketObjectLockConfigurationAState<Missing> =
            ({ assignments = ResizeArray() } : S3BucketObjectLockConfigurationAState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object_lock_configuration#bucket-1">S3BucketObjectLockConfigurationA#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketObjectLockConfigurationAState<Missing>, value: string) : S3BucketObjectLockConfigurationAState<Present> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketObjectLockConfigurationAState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object_lock_configuration#expected_bucket_owner-1">S3BucketObjectLockConfigurationA#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: S3BucketObjectLockConfigurationAState<'Bucket>, value: string) : S3BucketObjectLockConfigurationAState<'Bucket> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : S3BucketObjectLockConfigurationAState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object_lock_configuration#id-1">S3BucketObjectLockConfigurationA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketObjectLockConfigurationAState<'Bucket>, value: string) : S3BucketObjectLockConfigurationAState<'Bucket> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketObjectLockConfigurationAState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object_lock_configuration#object_lock_enabled-1">S3BucketObjectLockConfigurationA#object_lock_enabled</a>.
        /// </summary>
        [<CustomOperation "object_lock_enabled">]
        member _.ObjectLockEnabled(state: S3BucketObjectLockConfigurationAState<'Bucket>, value: string) : S3BucketObjectLockConfigurationAState<'Bucket> =
            state.assignments.Add(fun config -> config.ObjectLockEnabled <- value)
            state : S3BucketObjectLockConfigurationAState<'Bucket>

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object_lock_configuration#rule-1">S3BucketObjectLockConfigurationA#rule</a>
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: S3BucketObjectLockConfigurationAState<'Bucket>, value: aws.S3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationRuleA) : S3BucketObjectLockConfigurationAState<'Bucket> =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : S3BucketObjectLockConfigurationAState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object_lock_configuration#token-1">S3BucketObjectLockConfigurationA#token</a>.
        /// </summary>
        [<CustomOperation "token">]
        member _.Token(state: S3BucketObjectLockConfigurationAState<'Bucket>, value: string) : S3BucketObjectLockConfigurationAState<'Bucket> =
            state.assignments.Add(fun config -> config.Token <- value)
            state : S3BucketObjectLockConfigurationAState<'Bucket>

        member _.Run(state: S3BucketObjectLockConfigurationAState<Present>) : aws.S3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationA =
            let config = aws.S3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationAConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketObjectLockConfigurationA: missing required arguments. Must call: bucket.", 9999, IsError = true)>]
        member _.Run(_: S3BucketObjectLockConfigurationAState<_>) : aws.S3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationA =
            Unchecked.defaultof<aws.S3BucketObjectLockConfiguration.S3BucketObjectLockConfigurationA>
