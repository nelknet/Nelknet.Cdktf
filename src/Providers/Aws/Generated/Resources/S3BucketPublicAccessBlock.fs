namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketPublicAccessBlockState<'Bucket> = { assignments: ResizeArray<aws.S3BucketPublicAccessBlock.S3BucketPublicAccessBlockConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_public_access_block">aws_s3_bucket_public_access_block</a>.
    /// </summary>
    type S3BucketPublicAccessBlockBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketPublicAccessBlockState<Missing> =
            ({ assignments = ResizeArray() } : S3BucketPublicAccessBlockState<Missing>)

        member _.Zero(()) : S3BucketPublicAccessBlockState<Missing> =
            ({ assignments = ResizeArray() } : S3BucketPublicAccessBlockState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_public_access_block#bucket-1">S3BucketPublicAccessBlock#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketPublicAccessBlockState<Missing>, value: string) : S3BucketPublicAccessBlockState<Present> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketPublicAccessBlockState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_public_access_block#block_public_acls-1">S3BucketPublicAccessBlock#block_public_acls</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "block_public_acls">]
        member _.BlockPublicAcls(state: S3BucketPublicAccessBlockState<'Bucket>, value: bool) : S3BucketPublicAccessBlockState<'Bucket> =
            state.assignments.Add(fun config -> config.BlockPublicAcls <- value)
            state : S3BucketPublicAccessBlockState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_public_access_block#block_public_acls-1">S3BucketPublicAccessBlock#block_public_acls</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "block_public_acls">]
        member _.BlockPublicAcls(state: S3BucketPublicAccessBlockState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : S3BucketPublicAccessBlockState<'Bucket> =
            state.assignments.Add(fun config -> config.BlockPublicAcls <- value)
            state : S3BucketPublicAccessBlockState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_public_access_block#block_public_policy-1">S3BucketPublicAccessBlock#block_public_policy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "block_public_policy">]
        member _.BlockPublicPolicy(state: S3BucketPublicAccessBlockState<'Bucket>, value: bool) : S3BucketPublicAccessBlockState<'Bucket> =
            state.assignments.Add(fun config -> config.BlockPublicPolicy <- value)
            state : S3BucketPublicAccessBlockState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_public_access_block#block_public_policy-1">S3BucketPublicAccessBlock#block_public_policy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "block_public_policy">]
        member _.BlockPublicPolicy(state: S3BucketPublicAccessBlockState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : S3BucketPublicAccessBlockState<'Bucket> =
            state.assignments.Add(fun config -> config.BlockPublicPolicy <- value)
            state : S3BucketPublicAccessBlockState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_public_access_block#id-1">S3BucketPublicAccessBlock#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketPublicAccessBlockState<'Bucket>, value: string) : S3BucketPublicAccessBlockState<'Bucket> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketPublicAccessBlockState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_public_access_block#ignore_public_acls-1">S3BucketPublicAccessBlock#ignore_public_acls</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ignore_public_acls">]
        member _.IgnorePublicAcls(state: S3BucketPublicAccessBlockState<'Bucket>, value: bool) : S3BucketPublicAccessBlockState<'Bucket> =
            state.assignments.Add(fun config -> config.IgnorePublicAcls <- value)
            state : S3BucketPublicAccessBlockState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_public_access_block#ignore_public_acls-1">S3BucketPublicAccessBlock#ignore_public_acls</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ignore_public_acls">]
        member _.IgnorePublicAcls(state: S3BucketPublicAccessBlockState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : S3BucketPublicAccessBlockState<'Bucket> =
            state.assignments.Add(fun config -> config.IgnorePublicAcls <- value)
            state : S3BucketPublicAccessBlockState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_public_access_block#restrict_public_buckets-1">S3BucketPublicAccessBlock#restrict_public_buckets</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "restrict_public_buckets">]
        member _.RestrictPublicBuckets(state: S3BucketPublicAccessBlockState<'Bucket>, value: bool) : S3BucketPublicAccessBlockState<'Bucket> =
            state.assignments.Add(fun config -> config.RestrictPublicBuckets <- value)
            state : S3BucketPublicAccessBlockState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_public_access_block#restrict_public_buckets-1">S3BucketPublicAccessBlock#restrict_public_buckets</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "restrict_public_buckets">]
        member _.RestrictPublicBuckets(state: S3BucketPublicAccessBlockState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : S3BucketPublicAccessBlockState<'Bucket> =
            state.assignments.Add(fun config -> config.RestrictPublicBuckets <- value)
            state : S3BucketPublicAccessBlockState<'Bucket>

        member _.Run(state: S3BucketPublicAccessBlockState<Present>) : aws.S3BucketPublicAccessBlock.S3BucketPublicAccessBlock =
            let config = aws.S3BucketPublicAccessBlock.S3BucketPublicAccessBlockConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketPublicAccessBlock.S3BucketPublicAccessBlock(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketPublicAccessBlock: missing required arguments. Must call: bucket.", 9999, IsError = true)>]
        member _.Run(_: S3BucketPublicAccessBlockState<_>) : aws.S3BucketPublicAccessBlock.S3BucketPublicAccessBlock =
            Unchecked.defaultof<aws.S3BucketPublicAccessBlock.S3BucketPublicAccessBlock>
