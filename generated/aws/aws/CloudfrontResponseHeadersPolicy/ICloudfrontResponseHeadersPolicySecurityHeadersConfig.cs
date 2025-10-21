using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontResponseHeadersPolicy
{
    [JsiiInterface(nativeType: typeof(ICloudfrontResponseHeadersPolicySecurityHeadersConfig), fullyQualifiedName: "aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfig")]
    public interface ICloudfrontResponseHeadersPolicySecurityHeadersConfig
    {
        /// <summary>content_security_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#content_security_policy CloudfrontResponseHeadersPolicy#content_security_policy}
        /// </remarks>
        [JsiiProperty(name: "contentSecurityPolicy", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy? ContentSecurityPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>content_type_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#content_type_options CloudfrontResponseHeadersPolicy#content_type_options}
        /// </remarks>
        [JsiiProperty(name: "contentTypeOptions", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions? ContentTypeOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>frame_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#frame_options CloudfrontResponseHeadersPolicy#frame_options}
        /// </remarks>
        [JsiiProperty(name: "frameOptions", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions? FrameOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>referrer_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#referrer_policy CloudfrontResponseHeadersPolicy#referrer_policy}
        /// </remarks>
        [JsiiProperty(name: "referrerPolicy", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy? ReferrerPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>strict_transport_security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#strict_transport_security CloudfrontResponseHeadersPolicy#strict_transport_security}
        /// </remarks>
        [JsiiProperty(name: "strictTransportSecurity", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity? StrictTransportSecurity
        {
            get
            {
                return null;
            }
        }

        /// <summary>xss_protection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#xss_protection CloudfrontResponseHeadersPolicy#xss_protection}
        /// </remarks>
        [JsiiProperty(name: "xssProtection", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection? XssProtection
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontResponseHeadersPolicySecurityHeadersConfig), fullyQualifiedName: "aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>content_security_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#content_security_policy CloudfrontResponseHeadersPolicy#content_security_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentSecurityPolicy", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy\"}", isOptional: true)]
            public aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy? ContentSecurityPolicy
            {
                get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy?>();
            }

            /// <summary>content_type_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#content_type_options CloudfrontResponseHeadersPolicy#content_type_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentTypeOptions", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions\"}", isOptional: true)]
            public aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions? ContentTypeOptions
            {
                get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions?>();
            }

            /// <summary>frame_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#frame_options CloudfrontResponseHeadersPolicy#frame_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frameOptions", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions\"}", isOptional: true)]
            public aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions? FrameOptions
            {
                get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions?>();
            }

            /// <summary>referrer_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#referrer_policy CloudfrontResponseHeadersPolicy#referrer_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "referrerPolicy", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy\"}", isOptional: true)]
            public aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy? ReferrerPolicy
            {
                get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy?>();
            }

            /// <summary>strict_transport_security block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#strict_transport_security CloudfrontResponseHeadersPolicy#strict_transport_security}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "strictTransportSecurity", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity\"}", isOptional: true)]
            public aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity? StrictTransportSecurity
            {
                get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity?>();
            }

            /// <summary>xss_protection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#xss_protection CloudfrontResponseHeadersPolicy#xss_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xssProtection", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection\"}", isOptional: true)]
            public aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection? XssProtection
            {
                get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection?>();
            }
        }
    }
}
