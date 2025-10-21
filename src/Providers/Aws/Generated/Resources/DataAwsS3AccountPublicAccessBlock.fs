namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsS3AccountPublicAccessBlockState = { assignments: ResizeArray<aws.DataAwsS3AccountPublicAccessBlock.DataAwsS3AccountPublicAccessBlockConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_account_public_access_block">aws_s3_account_public_access_block</a>.
    /// </summary>
    type DataAwsS3AccountPublicAccessBlockBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsS3AccountPublicAccessBlockState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsS3AccountPublicAccessBlockState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_account_public_access_block#account_id-1">DataAwsS3AccountPublicAccessBlock#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: DataAwsS3AccountPublicAccessBlockState, value: string) : DataAwsS3AccountPublicAccessBlockState =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : DataAwsS3AccountPublicAccessBlockState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_account_public_access_block#id-1">DataAwsS3AccountPublicAccessBlock#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsS3AccountPublicAccessBlockState, value: string) : DataAwsS3AccountPublicAccessBlockState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsS3AccountPublicAccessBlockState

        member _.Run(state: DataAwsS3AccountPublicAccessBlockState) : aws.DataAwsS3AccountPublicAccessBlock.DataAwsS3AccountPublicAccessBlock =
            let config = aws.DataAwsS3AccountPublicAccessBlock.DataAwsS3AccountPublicAccessBlockConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsS3AccountPublicAccessBlock.DataAwsS3AccountPublicAccessBlock(StackContext.get (), logicalId, config)
