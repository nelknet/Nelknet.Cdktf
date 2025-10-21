namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlBucketLifecycleConfigurationState<'Bucket, 'Rule> = { assignments: ResizeArray<aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_lifecycle_configuration">aws_s3control_bucket_lifecycle_configuration</a>.
    /// </summary>
    type S3ControlBucketLifecycleConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlBucketLifecycleConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlBucketLifecycleConfigurationState<Missing, Missing>)

        member _.Zero(()) : S3ControlBucketLifecycleConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlBucketLifecycleConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_lifecycle_configuration#bucket-1">S3ControlBucketLifecycleConfiguration#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3ControlBucketLifecycleConfigurationState<Missing, 'Rule>, value: string) : S3ControlBucketLifecycleConfigurationState<Present, 'Rule> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3ControlBucketLifecycleConfigurationState<Present, 'Rule>)

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_lifecycle_configuration#rule-1">S3ControlBucketLifecycleConfiguration#rule</a> Accepts: aws.IResolvable | aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: S3ControlBucketLifecycleConfigurationState<'Bucket, Missing>, value: HashiCorp.Cdktf.IResolvable) : S3ControlBucketLifecycleConfigurationState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Rule <- value)
            ({ assignments = state.assignments } : S3ControlBucketLifecycleConfigurationState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_lifecycle_configuration#id-1">S3ControlBucketLifecycleConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3ControlBucketLifecycleConfigurationState<'Bucket, 'Rule>, value: string) : S3ControlBucketLifecycleConfigurationState<'Bucket, 'Rule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3ControlBucketLifecycleConfigurationState<'Bucket, 'Rule>

        member _.Run(state: S3ControlBucketLifecycleConfigurationState<Present, Present>) : aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfiguration =
            let config = aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlBucketLifecycleConfiguration: missing required arguments. Must call: bucket, rule.", 9999, IsError = true)>]
        member _.Run(_: S3ControlBucketLifecycleConfigurationState<_, _>) : aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfiguration =
            Unchecked.defaultof<aws.S3ControlBucketLifecycleConfiguration.S3ControlBucketLifecycleConfiguration>
