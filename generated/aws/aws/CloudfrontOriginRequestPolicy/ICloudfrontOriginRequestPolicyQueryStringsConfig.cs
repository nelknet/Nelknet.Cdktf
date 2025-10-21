using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontOriginRequestPolicy
{
    [JsiiInterface(nativeType: typeof(ICloudfrontOriginRequestPolicyQueryStringsConfig), fullyQualifiedName: "aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfig")]
    public interface ICloudfrontOriginRequestPolicyQueryStringsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#query_string_behavior CloudfrontOriginRequestPolicy#query_string_behavior}.</summary>
        [JsiiProperty(name: "queryStringBehavior", typeJson: "{\"primitive\":\"string\"}")]
        string QueryStringBehavior
        {
            get;
        }

        /// <summary>query_strings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#query_strings CloudfrontOriginRequestPolicy#query_strings}
        /// </remarks>
        [JsiiProperty(name: "queryStrings", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings? QueryStrings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontOriginRequestPolicyQueryStringsConfig), fullyQualifiedName: "aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#query_string_behavior CloudfrontOriginRequestPolicy#query_string_behavior}.</summary>
            [JsiiProperty(name: "queryStringBehavior", typeJson: "{\"primitive\":\"string\"}")]
            public string QueryStringBehavior
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>query_strings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_origin_request_policy#query_strings CloudfrontOriginRequestPolicy#query_strings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryStrings", typeJson: "{\"fqn\":\"aws.cloudfrontOriginRequestPolicy.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings\"}", isOptional: true)]
            public aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings? QueryStrings
            {
                get => GetInstanceProperty<aws.CloudfrontOriginRequestPolicy.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings?>();
            }
        }
    }
}
