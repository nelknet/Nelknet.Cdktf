namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlBucketPolicyState<'Bucket, 'Policy> = { assignments: ResizeArray<aws.S3ControlBucketPolicy.S3ControlBucketPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_policy">aws_s3control_bucket_policy</a>.
    /// </summary>
    type S3ControlBucketPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlBucketPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlBucketPolicyState<Missing, Missing>)

        member _.Zero(()) : S3ControlBucketPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlBucketPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_policy#bucket-1">S3ControlBucketPolicy#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3ControlBucketPolicyState<Missing, 'Policy>, value: string) : S3ControlBucketPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3ControlBucketPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_policy#policy-1">S3ControlBucketPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: S3ControlBucketPolicyState<'Bucket, Missing>, value: string) : S3ControlBucketPolicyState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : S3ControlBucketPolicyState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_bucket_policy#id-1">S3ControlBucketPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3ControlBucketPolicyState<'Bucket, 'Policy>, value: string) : S3ControlBucketPolicyState<'Bucket, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3ControlBucketPolicyState<'Bucket, 'Policy>

        member _.Run(state: S3ControlBucketPolicyState<Present, Present>) : aws.S3ControlBucketPolicy.S3ControlBucketPolicy =
            let config = aws.S3ControlBucketPolicy.S3ControlBucketPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlBucketPolicy.S3ControlBucketPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlBucketPolicy: missing required arguments. Must call: bucket, policy.", 9999, IsError = true)>]
        member _.Run(_: S3ControlBucketPolicyState<_, _>) : aws.S3ControlBucketPolicy.S3ControlBucketPolicy =
            Unchecked.defaultof<aws.S3ControlBucketPolicy.S3ControlBucketPolicy>
