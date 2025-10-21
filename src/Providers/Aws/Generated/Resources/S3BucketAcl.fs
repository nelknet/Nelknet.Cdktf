namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketAclState<'Bucket> = { assignments: ResizeArray<aws.S3BucketAcl.S3BucketAclConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl">aws_s3_bucket_acl</a>.
    /// </summary>
    type S3BucketAclBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketAclState<Missing> =
            ({ assignments = ResizeArray() } : S3BucketAclState<Missing>)

        member _.Zero(()) : S3BucketAclState<Missing> =
            ({ assignments = ResizeArray() } : S3BucketAclState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#bucket-1">S3BucketAcl#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketAclState<Missing>, value: string) : S3BucketAclState<Present> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketAclState<Present>)

        /// <summary>
        /// access_control_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#access_control_policy-1">S3BucketAcl#access_control_policy</a>
        /// </summary>
        [<CustomOperation "access_control_policy">]
        member _.AccessControlPolicy(state: S3BucketAclState<'Bucket>, value: aws.S3BucketAcl.S3BucketAclAccessControlPolicy) : S3BucketAclState<'Bucket> =
            state.assignments.Add(fun config -> config.AccessControlPolicy <- value)
            state : S3BucketAclState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#acl-1">S3BucketAcl#acl</a>.
        /// </summary>
        [<CustomOperation "acl">]
        member _.Acl(state: S3BucketAclState<'Bucket>, value: string) : S3BucketAclState<'Bucket> =
            state.assignments.Add(fun config -> config.Acl <- value)
            state : S3BucketAclState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#expected_bucket_owner-1">S3BucketAcl#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: S3BucketAclState<'Bucket>, value: string) : S3BucketAclState<'Bucket> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : S3BucketAclState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_acl#id-1">S3BucketAcl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketAclState<'Bucket>, value: string) : S3BucketAclState<'Bucket> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketAclState<'Bucket>

        member _.Run(state: S3BucketAclState<Present>) : aws.S3BucketAcl.S3BucketAcl =
            let config = aws.S3BucketAcl.S3BucketAclConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketAcl.S3BucketAcl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketAcl: missing required arguments. Must call: bucket.", 9999, IsError = true)>]
        member _.Run(_: S3BucketAclState<_>) : aws.S3BucketAcl.S3BucketAcl =
            Unchecked.defaultof<aws.S3BucketAcl.S3BucketAcl>
