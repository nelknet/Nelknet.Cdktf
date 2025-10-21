namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketCorsConfigurationState<'Bucket, 'CorsRule> = { assignments: ResizeArray<aws.S3BucketCorsConfiguration.S3BucketCorsConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_cors_configuration">aws_s3_bucket_cors_configuration</a>.
    /// </summary>
    type S3BucketCorsConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketCorsConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketCorsConfigurationState<Missing, Missing>)

        member _.Zero(()) : S3BucketCorsConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketCorsConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_cors_configuration#bucket-1">S3BucketCorsConfiguration#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketCorsConfigurationState<Missing, 'CorsRule>, value: string) : S3BucketCorsConfigurationState<Present, 'CorsRule> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketCorsConfigurationState<Present, 'CorsRule>)

        /// <summary>
        /// cors_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_cors_configuration#cors_rule-1">S3BucketCorsConfiguration#cors_rule</a> Accepts: aws.IResolvable | aws.S3BucketCorsConfiguration.S3BucketCorsConfigurationCorsRule[]
        /// </summary>
        [<CustomOperation "cors_rule">]
        member _.CorsRule(state: S3BucketCorsConfigurationState<'Bucket, Missing>, value: HashiCorp.Cdktf.IResolvable) : S3BucketCorsConfigurationState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.CorsRule <- value)
            ({ assignments = state.assignments } : S3BucketCorsConfigurationState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_cors_configuration#expected_bucket_owner-1">S3BucketCorsConfiguration#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: S3BucketCorsConfigurationState<'Bucket, 'CorsRule>, value: string) : S3BucketCorsConfigurationState<'Bucket, 'CorsRule> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : S3BucketCorsConfigurationState<'Bucket, 'CorsRule>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_cors_configuration#id-1">S3BucketCorsConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketCorsConfigurationState<'Bucket, 'CorsRule>, value: string) : S3BucketCorsConfigurationState<'Bucket, 'CorsRule> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketCorsConfigurationState<'Bucket, 'CorsRule>

        member _.Run(state: S3BucketCorsConfigurationState<Present, Present>) : aws.S3BucketCorsConfiguration.S3BucketCorsConfiguration =
            let config = aws.S3BucketCorsConfiguration.S3BucketCorsConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketCorsConfiguration.S3BucketCorsConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketCorsConfiguration: missing required arguments. Must call: bucket, cors_rule.", 9999, IsError = true)>]
        member _.Run(_: S3BucketCorsConfigurationState<_, _>) : aws.S3BucketCorsConfiguration.S3BucketCorsConfiguration =
            Unchecked.defaultof<aws.S3BucketCorsConfiguration.S3BucketCorsConfiguration>
