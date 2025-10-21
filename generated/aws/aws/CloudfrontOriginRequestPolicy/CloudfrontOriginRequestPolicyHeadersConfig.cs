using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontOriginRequestPolicy
{
    [JsiiByValue(fqn: "aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyHeadersConfig")]
    public class CloudfrontOriginRequestPolicyHeadersConfig : aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyHeadersConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#header_behavior CloudfrontOriginRequestPolicy#header_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headerBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeaderBehavior
        {
            get;
            set;
        }

        /// <summary>headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#headers CloudfrontOriginRequestPolicy#headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyHeadersConfigHeaders\"}", isOptional: true)]
        public aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyHeadersConfigHeaders? Headers
        {
            get;
            set;
        }
    }
}
