using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontOriginRequestPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfig")]
    public class CloudfrontOriginRequestPolicyQueryStringsConfig : aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#query_string_behavior CloudfrontOriginRequestPolicy#query_string_behavior}.</summary>
        [JsiiProperty(name: "queryStringBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public string QueryStringBehavior
        {
            get;
            set;
        }

        /// <summary>query_strings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#query_strings CloudfrontOriginRequestPolicy#query_strings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryStrings", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings\"}", isOptional: true)]
        public aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings? QueryStrings
        {
            get;
            set;
        }
    }
}
