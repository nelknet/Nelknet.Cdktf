namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsS3BucketPolicyState<'Bucket> = { assignments: ResizeArray<aws.DataAwsS3BucketPolicy.DataAwsS3BucketPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_policy">aws_s3_bucket_policy</a>.
    /// </summary>
    type DataAwsS3BucketPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsS3BucketPolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsS3BucketPolicyState<Missing>)

        member _.Zero(()) : DataAwsS3BucketPolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsS3BucketPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_policy#bucket-1">DataAwsS3BucketPolicy#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: DataAwsS3BucketPolicyState<Missing>, value: string) : DataAwsS3BucketPolicyState<Present> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : DataAwsS3BucketPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_policy#id-1">DataAwsS3BucketPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsS3BucketPolicyState<'Bucket>, value: string) : DataAwsS3BucketPolicyState<'Bucket> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsS3BucketPolicyState<'Bucket>

        member _.Run(state: DataAwsS3BucketPolicyState<Present>) : aws.DataAwsS3BucketPolicy.DataAwsS3BucketPolicy =
            let config = aws.DataAwsS3BucketPolicy.DataAwsS3BucketPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsS3BucketPolicy.DataAwsS3BucketPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsS3BucketPolicy: missing required arguments. Must call: bucket.", 9999, IsError = true)>]
        member _.Run(_: DataAwsS3BucketPolicyState<_>) : aws.DataAwsS3BucketPolicy.DataAwsS3BucketPolicy =
            Unchecked.defaultof<aws.DataAwsS3BucketPolicy.DataAwsS3BucketPolicy>
