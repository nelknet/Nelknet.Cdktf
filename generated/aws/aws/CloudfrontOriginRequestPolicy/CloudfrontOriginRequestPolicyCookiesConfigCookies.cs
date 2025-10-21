using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontOriginRequestPolicy
{
    [JsiiByValue(fqn: "aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyCookiesConfigCookies")]
    public class CloudfrontOriginRequestPolicyCookiesConfigCookies : aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyCookiesConfigCookies
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#items CloudfrontOriginRequestPolicy#items}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Items
        {
            get;
            set;
        }
    }
}
