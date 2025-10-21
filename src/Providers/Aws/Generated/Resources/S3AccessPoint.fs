namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3AccessPointState<'Bucket, 'Name> = { assignments: ResizeArray<aws.S3AccessPoint.S3AccessPointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_access_point">aws_s3_access_point</a>.
    /// </summary>
    type S3AccessPointBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3AccessPointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3AccessPointState<Missing, Missing>)

        member _.Zero(()) : S3AccessPointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3AccessPointState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_access_point#bucket-1">S3AccessPoint#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3AccessPointState<Missing, 'Name>, value: string) : S3AccessPointState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3AccessPointState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_access_point#name-1">S3AccessPoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: S3AccessPointState<'Bucket, Missing>, value: string) : S3AccessPointState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : S3AccessPointState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_access_point#account_id-1">S3AccessPoint#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: S3AccessPointState<'Bucket, 'Name>, value: string) : S3AccessPointState<'Bucket, 'Name> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : S3AccessPointState<'Bucket, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_access_point#bucket_account_id-1">S3AccessPoint#bucket_account_id</a>.
        /// </summary>
        [<CustomOperation "bucket_account_id">]
        member _.BucketAccountId(state: S3AccessPointState<'Bucket, 'Name>, value: string) : S3AccessPointState<'Bucket, 'Name> =
            state.assignments.Add(fun config -> config.BucketAccountId <- value)
            state : S3AccessPointState<'Bucket, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_access_point#id-1">S3AccessPoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3AccessPointState<'Bucket, 'Name>, value: string) : S3AccessPointState<'Bucket, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3AccessPointState<'Bucket, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_access_point#policy-1">S3AccessPoint#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: S3AccessPointState<'Bucket, 'Name>, value: string) : S3AccessPointState<'Bucket, 'Name> =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : S3AccessPointState<'Bucket, 'Name>

        /// <summary>
        /// public_access_block_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_access_point#public_access_block_configuration-1">S3AccessPoint#public_access_block_configuration</a>
        /// </summary>
        [<CustomOperation "public_access_block_configuration">]
        member _.PublicAccessBlockConfiguration(state: S3AccessPointState<'Bucket, 'Name>, value: aws.S3AccessPoint.S3AccessPointPublicAccessBlockConfiguration) : S3AccessPointState<'Bucket, 'Name> =
            state.assignments.Add(fun config -> config.PublicAccessBlockConfiguration <- value)
            state : S3AccessPointState<'Bucket, 'Name>

        /// <summary>
        /// vpc_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_access_point#vpc_configuration-1">S3AccessPoint#vpc_configuration</a>
        /// </summary>
        [<CustomOperation "vpc_configuration">]
        member _.VpcConfiguration(state: S3AccessPointState<'Bucket, 'Name>, value: aws.S3AccessPoint.S3AccessPointVpcConfiguration) : S3AccessPointState<'Bucket, 'Name> =
            state.assignments.Add(fun config -> config.VpcConfiguration <- value)
            state : S3AccessPointState<'Bucket, 'Name>

        member _.Run(state: S3AccessPointState<Present, Present>) : aws.S3AccessPoint.S3AccessPoint =
            let config = aws.S3AccessPoint.S3AccessPointConfig()
            for setter in state.assignments do
                setter config
            aws.S3AccessPoint.S3AccessPoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3AccessPoint: missing required arguments. Must call: bucket, name.", 9999, IsError = true)>]
        member _.Run(_: S3AccessPointState<_, _>) : aws.S3AccessPoint.S3AccessPoint =
            Unchecked.defaultof<aws.S3AccessPoint.S3AccessPoint>
