namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketPolicyState<'Bucket, 'Policy> = { assignments: ResizeArray<aws.S3BucketPolicy.S3BucketPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_policy">aws_s3_bucket_policy</a>.
    /// </summary>
    type S3BucketPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketPolicyState<Missing, Missing>)

        member _.Zero(()) : S3BucketPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_policy#bucket-1">S3BucketPolicy#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketPolicyState<Missing, 'Policy>, value: string) : S3BucketPolicyState<Present, 'Policy> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketPolicyState<Present, 'Policy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_policy#policy-1">S3BucketPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: S3BucketPolicyState<'Bucket, Missing>, value: string) : S3BucketPolicyState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : S3BucketPolicyState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_policy#id-1">S3BucketPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketPolicyState<'Bucket, 'Policy>, value: string) : S3BucketPolicyState<'Bucket, 'Policy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketPolicyState<'Bucket, 'Policy>

        member _.Run(state: S3BucketPolicyState<Present, Present>) : aws.S3BucketPolicy.S3BucketPolicy =
            let config = aws.S3BucketPolicy.S3BucketPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketPolicy.S3BucketPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketPolicy: missing required arguments. Must call: bucket, policy.", 9999, IsError = true)>]
        member _.Run(_: S3BucketPolicyState<_, _>) : aws.S3BucketPolicy.S3BucketPolicy =
            Unchecked.defaultof<aws.S3BucketPolicy.S3BucketPolicy>
