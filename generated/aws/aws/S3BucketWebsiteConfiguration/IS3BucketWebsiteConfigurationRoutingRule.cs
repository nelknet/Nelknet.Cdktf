using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3BucketWebsiteConfiguration
{
    [JsiiInterface(nativeType: typeof(IS3BucketWebsiteConfigurationRoutingRule), fullyQualifiedName: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRule")]
    public interface IS3BucketWebsiteConfigurationRoutingRule
    {
        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#redirect S3BucketWebsiteConfiguration#redirect}
        /// </remarks>
        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleRedirect\"}")]
        aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRuleRedirect Redirect
        {
            get;
        }

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#condition S3BucketWebsiteConfiguration#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleCondition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRuleCondition? Condition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketWebsiteConfigurationRoutingRule), fullyQualifiedName: "aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRule")]
        internal sealed class _Proxy : DeputyBase, aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>redirect block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#redirect S3BucketWebsiteConfiguration#redirect}
            /// </remarks>
            [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleRedirect\"}")]
            public aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRuleRedirect Redirect
            {
                get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRuleRedirect>()!;
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_website_configuration#condition S3BucketWebsiteConfiguration#condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.s3BucketWebsiteConfiguration.S3BucketWebsiteConfigurationRoutingRuleCondition\"}", isOptional: true)]
            public aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRuleCondition? Condition
            {
                get => GetInstanceProperty<aws.S3BucketWebsiteConfiguration.IS3BucketWebsiteConfigurationRoutingRuleCondition?>();
            }
        }
    }
}
