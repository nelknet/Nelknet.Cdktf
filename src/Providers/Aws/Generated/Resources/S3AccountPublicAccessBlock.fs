namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3AccountPublicAccessBlockState = { assignments: ResizeArray<aws.S3AccountPublicAccessBlock.S3AccountPublicAccessBlockConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_account_public_access_block">aws_s3_account_public_access_block</a>.
    /// </summary>
    type S3AccountPublicAccessBlockBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3AccountPublicAccessBlockState =
            { assignments = ResizeArray() }

        member _.Zero(()) : S3AccountPublicAccessBlockState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_account_public_access_block#account_id-1">S3AccountPublicAccessBlock#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: S3AccountPublicAccessBlockState, value: string) : S3AccountPublicAccessBlockState =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : S3AccountPublicAccessBlockState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_account_public_access_block#block_public_acls-1">S3AccountPublicAccessBlock#block_public_acls</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "block_public_acls">]
        member _.BlockPublicAcls(state: S3AccountPublicAccessBlockState, value: bool) : S3AccountPublicAccessBlockState =
            state.assignments.Add(fun config -> config.BlockPublicAcls <- value)
            state : S3AccountPublicAccessBlockState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_account_public_access_block#block_public_acls-1">S3AccountPublicAccessBlock#block_public_acls</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "block_public_acls">]
        member _.BlockPublicAcls(state: S3AccountPublicAccessBlockState, value: HashiCorp.Cdktf.IResolvable) : S3AccountPublicAccessBlockState =
            state.assignments.Add(fun config -> config.BlockPublicAcls <- value)
            state : S3AccountPublicAccessBlockState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_account_public_access_block#block_public_policy-1">S3AccountPublicAccessBlock#block_public_policy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "block_public_policy">]
        member _.BlockPublicPolicy(state: S3AccountPublicAccessBlockState, value: bool) : S3AccountPublicAccessBlockState =
            state.assignments.Add(fun config -> config.BlockPublicPolicy <- value)
            state : S3AccountPublicAccessBlockState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_account_public_access_block#block_public_policy-1">S3AccountPublicAccessBlock#block_public_policy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "block_public_policy">]
        member _.BlockPublicPolicy(state: S3AccountPublicAccessBlockState, value: HashiCorp.Cdktf.IResolvable) : S3AccountPublicAccessBlockState =
            state.assignments.Add(fun config -> config.BlockPublicPolicy <- value)
            state : S3AccountPublicAccessBlockState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_account_public_access_block#id-1">S3AccountPublicAccessBlock#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3AccountPublicAccessBlockState, value: string) : S3AccountPublicAccessBlockState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3AccountPublicAccessBlockState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_account_public_access_block#ignore_public_acls-1">S3AccountPublicAccessBlock#ignore_public_acls</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ignore_public_acls">]
        member _.IgnorePublicAcls(state: S3AccountPublicAccessBlockState, value: bool) : S3AccountPublicAccessBlockState =
            state.assignments.Add(fun config -> config.IgnorePublicAcls <- value)
            state : S3AccountPublicAccessBlockState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_account_public_access_block#ignore_public_acls-1">S3AccountPublicAccessBlock#ignore_public_acls</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ignore_public_acls">]
        member _.IgnorePublicAcls(state: S3AccountPublicAccessBlockState, value: HashiCorp.Cdktf.IResolvable) : S3AccountPublicAccessBlockState =
            state.assignments.Add(fun config -> config.IgnorePublicAcls <- value)
            state : S3AccountPublicAccessBlockState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_account_public_access_block#restrict_public_buckets-1">S3AccountPublicAccessBlock#restrict_public_buckets</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "restrict_public_buckets">]
        member _.RestrictPublicBuckets(state: S3AccountPublicAccessBlockState, value: bool) : S3AccountPublicAccessBlockState =
            state.assignments.Add(fun config -> config.RestrictPublicBuckets <- value)
            state : S3AccountPublicAccessBlockState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_account_public_access_block#restrict_public_buckets-1">S3AccountPublicAccessBlock#restrict_public_buckets</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "restrict_public_buckets">]
        member _.RestrictPublicBuckets(state: S3AccountPublicAccessBlockState, value: HashiCorp.Cdktf.IResolvable) : S3AccountPublicAccessBlockState =
            state.assignments.Add(fun config -> config.RestrictPublicBuckets <- value)
            state : S3AccountPublicAccessBlockState

        member _.Run(state: S3AccountPublicAccessBlockState) : aws.S3AccountPublicAccessBlock.S3AccountPublicAccessBlock =
            let config = aws.S3AccountPublicAccessBlock.S3AccountPublicAccessBlockConfig()
            for setter in state.assignments do
                setter config
            aws.S3AccountPublicAccessBlock.S3AccountPublicAccessBlock(StackContext.get (), logicalId, config)
