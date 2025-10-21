using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontOriginRequestPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfig")]
    public class CloudfrontOriginRequestPolicyCookiesConfig : aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#cookie_behavior CloudfrontOriginRequestPolicy#cookie_behavior}.</summary>
        [JsiiProperty(name: "cookieBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public string CookieBehavior
        {
            get;
            set;
        }

        /// <summary>cookies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#cookies CloudfrontOriginRequestPolicy#cookies}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfigCookies\"}", isOptional: true)]
        public aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfigCookies? Cookies
        {
            get;
            set;
        }
    }
}
