using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontCachePolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontCachePolicy.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig")]
    public class CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig : aws.CloudfrontCachePolicy.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_cache_policy#cookie_behavior CloudfrontCachePolicy#cookie_behavior}.</summary>
        [JsiiProperty(name: "cookieBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public string CookieBehavior
        {
            get;
            set;
        }

        /// <summary>cookies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_cache_policy#cookies CloudfrontCachePolicy#cookies}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfrontCachePolicy.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies\"}", isOptional: true)]
        public aws.CloudfrontCachePolicy.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies? Cookies
        {
            get;
            set;
        }
    }
}
