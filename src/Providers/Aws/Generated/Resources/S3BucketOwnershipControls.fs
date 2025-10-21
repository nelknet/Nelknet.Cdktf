namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketOwnershipControlsState<'Bucket, 'Rule> = { assignments: ResizeArray<aws.S3BucketOwnershipControls.S3BucketOwnershipControlsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_ownership_controls">aws_s3_bucket_ownership_controls</a>.
    /// </summary>
    type S3BucketOwnershipControlsBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketOwnershipControlsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketOwnershipControlsState<Missing, Missing>)

        member _.Zero(()) : S3BucketOwnershipControlsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketOwnershipControlsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_ownership_controls#bucket-1">S3BucketOwnershipControls#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketOwnershipControlsState<Missing, 'Rule>, value: string) : S3BucketOwnershipControlsState<Present, 'Rule> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketOwnershipControlsState<Present, 'Rule>)

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_ownership_controls#rule-1">S3BucketOwnershipControls#rule</a>
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: S3BucketOwnershipControlsState<'Bucket, Missing>, value: aws.S3BucketOwnershipControls.S3BucketOwnershipControlsRule) : S3BucketOwnershipControlsState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Rule <- value)
            ({ assignments = state.assignments } : S3BucketOwnershipControlsState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_ownership_controls#id-1">S3BucketOwnershipControls#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketOwnershipControlsState<'Bucket, 'Rule>, value: string) : S3BucketOwnershipControlsState<'Bucket, 'Rule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketOwnershipControlsState<'Bucket, 'Rule>

        member _.Run(state: S3BucketOwnershipControlsState<Present, Present>) : aws.S3BucketOwnershipControls.S3BucketOwnershipControls =
            let config = aws.S3BucketOwnershipControls.S3BucketOwnershipControlsConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketOwnershipControls.S3BucketOwnershipControls(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketOwnershipControls: missing required arguments. Must call: bucket, rule.", 9999, IsError = true)>]
        member _.Run(_: S3BucketOwnershipControlsState<_, _>) : aws.S3BucketOwnershipControls.S3BucketOwnershipControls =
            Unchecked.defaultof<aws.S3BucketOwnershipControls.S3BucketOwnershipControls>
