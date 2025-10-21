namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketWebsiteConfigurationState<'Bucket> = { assignments: ResizeArray<aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration">aws_s3_bucket_website_configuration</a>.
    /// </summary>
    type S3BucketWebsiteConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketWebsiteConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : S3BucketWebsiteConfigurationState<Missing>)

        member _.Zero(()) : S3BucketWebsiteConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : S3BucketWebsiteConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#bucket-1">S3BucketWebsiteConfiguration#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketWebsiteConfigurationState<Missing>, value: string) : S3BucketWebsiteConfigurationState<Present> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketWebsiteConfigurationState<Present>)

        /// <summary>
        /// error_document block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#error_document-1">S3BucketWebsiteConfiguration#error_document</a>
        /// </summary>
        [<CustomOperation "error_document">]
        member _.ErrorDocument(state: S3BucketWebsiteConfigurationState<'Bucket>, value: aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationErrorDocument) : S3BucketWebsiteConfigurationState<'Bucket> =
            state.assignments.Add(fun config -> config.ErrorDocument <- value)
            state : S3BucketWebsiteConfigurationState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#expected_bucket_owner-1">S3BucketWebsiteConfiguration#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: S3BucketWebsiteConfigurationState<'Bucket>, value: string) : S3BucketWebsiteConfigurationState<'Bucket> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : S3BucketWebsiteConfigurationState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#id-1">S3BucketWebsiteConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketWebsiteConfigurationState<'Bucket>, value: string) : S3BucketWebsiteConfigurationState<'Bucket> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketWebsiteConfigurationState<'Bucket>

        /// <summary>
        /// index_document block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#index_document-1">S3BucketWebsiteConfiguration#index_document</a>
        /// </summary>
        [<CustomOperation "index_document">]
        member _.IndexDocument(state: S3BucketWebsiteConfigurationState<'Bucket>, value: aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationIndexDocument) : S3BucketWebsiteConfigurationState<'Bucket> =
            state.assignments.Add(fun config -> config.IndexDocument <- value)
            state : S3BucketWebsiteConfigurationState<'Bucket>

        /// <summary>
        /// redirect_all_requests_to block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#redirect_all_requests_to-1">S3BucketWebsiteConfiguration#redirect_all_requests_to</a>
        /// </summary>
        [<CustomOperation "redirect_all_requests_to">]
        member _.RedirectAllRequestsTo(state: S3BucketWebsiteConfigurationState<'Bucket>, value: aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRedirectAllRequestsTo) : S3BucketWebsiteConfigurationState<'Bucket> =
            state.assignments.Add(fun config -> config.RedirectAllRequestsTo <- value)
            state : S3BucketWebsiteConfigurationState<'Bucket>

        /// <summary>
        /// routing_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#routing_rule-1">S3BucketWebsiteConfiguration#routing_rule</a> Accepts: aws.IResolvable | aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRule[]
        /// </summary>
        [<CustomOperation "routing_rule">]
        member _.RoutingRule(state: S3BucketWebsiteConfigurationState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : S3BucketWebsiteConfigurationState<'Bucket> =
            state.assignments.Add(fun config -> config.RoutingRule <- value)
            state : S3BucketWebsiteConfigurationState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#routing_rules-1">S3BucketWebsiteConfiguration#routing_rules</a>.
        /// </summary>
        [<CustomOperation "routing_rules">]
        member _.RoutingRules(state: S3BucketWebsiteConfigurationState<'Bucket>, value: string) : S3BucketWebsiteConfigurationState<'Bucket> =
            state.assignments.Add(fun config -> config.RoutingRules <- value)
            state : S3BucketWebsiteConfigurationState<'Bucket>

        member _.Run(state: S3BucketWebsiteConfigurationState<Present>) : aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfiguration =
            let config = aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketWebsiteConfiguration: missing required arguments. Must call: bucket.", 9999, IsError = true)>]
        member _.Run(_: S3BucketWebsiteConfigurationState<_>) : aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfiguration =
            Unchecked.defaultof<aws.S3BucketWebsiteConfiguration.S3BucketWebsiteConfiguration>
