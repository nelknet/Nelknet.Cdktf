namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketVersioningAState<'Bucket, 'VersioningConfiguration> = { assignments: ResizeArray<aws.S3BucketVersioning.S3BucketVersioningAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning">aws_s3_bucket_versioning</a>.
    /// </summary>
    type S3BucketVersioningABuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketVersioningAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketVersioningAState<Missing, Missing>)

        member _.Zero(()) : S3BucketVersioningAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketVersioningAState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning#bucket-1">S3BucketVersioningA#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketVersioningAState<Missing, 'VersioningConfiguration>, value: string) : S3BucketVersioningAState<Present, 'VersioningConfiguration> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketVersioningAState<Present, 'VersioningConfiguration>)

        /// <summary>
        /// versioning_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning#versioning_configuration-1">S3BucketVersioningA#versioning_configuration</a>
        /// </summary>
        [<CustomOperation "versioning_configuration">]
        member _.VersioningConfiguration(state: S3BucketVersioningAState<'Bucket, Missing>, value: aws.S3BucketVersioning.S3BucketVersioningVersioningConfiguration) : S3BucketVersioningAState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.VersioningConfiguration <- value)
            ({ assignments = state.assignments } : S3BucketVersioningAState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning#expected_bucket_owner-1">S3BucketVersioningA#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: S3BucketVersioningAState<'Bucket, 'VersioningConfiguration>, value: string) : S3BucketVersioningAState<'Bucket, 'VersioningConfiguration> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : S3BucketVersioningAState<'Bucket, 'VersioningConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning#id-1">S3BucketVersioningA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketVersioningAState<'Bucket, 'VersioningConfiguration>, value: string) : S3BucketVersioningAState<'Bucket, 'VersioningConfiguration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketVersioningAState<'Bucket, 'VersioningConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_versioning#mfa-1">S3BucketVersioningA#mfa</a>.
        /// </summary>
        [<CustomOperation "mfa">]
        member _.Mfa(state: S3BucketVersioningAState<'Bucket, 'VersioningConfiguration>, value: string) : S3BucketVersioningAState<'Bucket, 'VersioningConfiguration> =
            state.assignments.Add(fun config -> config.Mfa <- value)
            state : S3BucketVersioningAState<'Bucket, 'VersioningConfiguration>

        member _.Run(state: S3BucketVersioningAState<Present, Present>) : aws.S3BucketVersioning.S3BucketVersioningA =
            let config = aws.S3BucketVersioning.S3BucketVersioningAConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketVersioning.S3BucketVersioningA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketVersioningA: missing required arguments. Must call: bucket, versioning_configuration.", 9999, IsError = true)>]
        member _.Run(_: S3BucketVersioningAState<_, _>) : aws.S3BucketVersioning.S3BucketVersioningA =
            Unchecked.defaultof<aws.S3BucketVersioning.S3BucketVersioningA>
