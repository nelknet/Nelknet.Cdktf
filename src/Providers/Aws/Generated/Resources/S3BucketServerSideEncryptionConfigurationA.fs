namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketServerSideEncryptionConfigurationAState<'Bucket, 'Rule> = { assignments: ResizeArray<aws.S3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_server_side_encryption_configuration">aws_s3_bucket_server_side_encryption_configuration</a>.
    /// </summary>
    type S3BucketServerSideEncryptionConfigurationABuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketServerSideEncryptionConfigurationAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketServerSideEncryptionConfigurationAState<Missing, Missing>)

        member _.Zero(()) : S3BucketServerSideEncryptionConfigurationAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketServerSideEncryptionConfigurationAState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_server_side_encryption_configuration#bucket-1">S3BucketServerSideEncryptionConfigurationA#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketServerSideEncryptionConfigurationAState<Missing, 'Rule>, value: string) : S3BucketServerSideEncryptionConfigurationAState<Present, 'Rule> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketServerSideEncryptionConfigurationAState<Present, 'Rule>)

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_server_side_encryption_configuration#rule-1">S3BucketServerSideEncryptionConfigurationA#rule</a> Accepts: aws.IResolvable | aws.S3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationRuleA[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: S3BucketServerSideEncryptionConfigurationAState<'Bucket, Missing>, value: HashiCorp.Cdktf.IResolvable) : S3BucketServerSideEncryptionConfigurationAState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Rule <- value)
            ({ assignments = state.assignments } : S3BucketServerSideEncryptionConfigurationAState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_server_side_encryption_configuration#expected_bucket_owner-1">S3BucketServerSideEncryptionConfigurationA#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: S3BucketServerSideEncryptionConfigurationAState<'Bucket, 'Rule>, value: string) : S3BucketServerSideEncryptionConfigurationAState<'Bucket, 'Rule> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : S3BucketServerSideEncryptionConfigurationAState<'Bucket, 'Rule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_server_side_encryption_configuration#id-1">S3BucketServerSideEncryptionConfigurationA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketServerSideEncryptionConfigurationAState<'Bucket, 'Rule>, value: string) : S3BucketServerSideEncryptionConfigurationAState<'Bucket, 'Rule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketServerSideEncryptionConfigurationAState<'Bucket, 'Rule>

        member _.Run(state: S3BucketServerSideEncryptionConfigurationAState<Present, Present>) : aws.S3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationA =
            let config = aws.S3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationAConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketServerSideEncryptionConfigurationA: missing required arguments. Must call: bucket, rule.", 9999, IsError = true)>]
        member _.Run(_: S3BucketServerSideEncryptionConfigurationAState<_, _>) : aws.S3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationA =
            Unchecked.defaultof<aws.S3BucketServerSideEncryptionConfiguration.S3BucketServerSideEncryptionConfigurationA>
