using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontResponseHeadersPolicy
{
    [JsiiInterface(nativeType: typeof(ICloudfrontResponseHeadersPolicyCorsConfig), fullyQualifiedName: "aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfig")]
    public interface ICloudfrontResponseHeadersPolicyCorsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#access_control_allow_credentials CloudfrontResponseHeadersPolicy#access_control_allow_credentials}.</summary>
        [JsiiProperty(name: "accessControlAllowCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object AccessControlAllowCredentials
        {
            get;
        }

        /// <summary>access_control_allow_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#access_control_allow_headers CloudfrontResponseHeadersPolicy#access_control_allow_headers}
        /// </remarks>
        [JsiiProperty(name: "accessControlAllowHeaders", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders\"}")]
        aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders AccessControlAllowHeaders
        {
            get;
        }

        /// <summary>access_control_allow_methods block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#access_control_allow_methods CloudfrontResponseHeadersPolicy#access_control_allow_methods}
        /// </remarks>
        [JsiiProperty(name: "accessControlAllowMethods", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods\"}")]
        aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods AccessControlAllowMethods
        {
            get;
        }

        /// <summary>access_control_allow_origins block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#access_control_allow_origins CloudfrontResponseHeadersPolicy#access_control_allow_origins}
        /// </remarks>
        [JsiiProperty(name: "accessControlAllowOrigins", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins\"}")]
        aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins AccessControlAllowOrigins
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#origin_override CloudfrontResponseHeadersPolicy#origin_override}.</summary>
        [JsiiProperty(name: "originOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object OriginOverride
        {
            get;
        }

        /// <summary>access_control_expose_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#access_control_expose_headers CloudfrontResponseHeadersPolicy#access_control_expose_headers}
        /// </remarks>
        [JsiiProperty(name: "accessControlExposeHeaders", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders? AccessControlExposeHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#access_control_max_age_sec CloudfrontResponseHeadersPolicy#access_control_max_age_sec}.</summary>
        [JsiiProperty(name: "accessControlMaxAgeSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AccessControlMaxAgeSec
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontResponseHeadersPolicyCorsConfig), fullyQualifiedName: "aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#access_control_allow_credentials CloudfrontResponseHeadersPolicy#access_control_allow_credentials}.</summary>
            [JsiiProperty(name: "accessControlAllowCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object AccessControlAllowCredentials
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>access_control_allow_headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#access_control_allow_headers CloudfrontResponseHeadersPolicy#access_control_allow_headers}
            /// </remarks>
            [JsiiProperty(name: "accessControlAllowHeaders", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders\"}")]
            public aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders AccessControlAllowHeaders
            {
                get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders>()!;
            }

            /// <summary>access_control_allow_methods block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#access_control_allow_methods CloudfrontResponseHeadersPolicy#access_control_allow_methods}
            /// </remarks>
            [JsiiProperty(name: "accessControlAllowMethods", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods\"}")]
            public aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods AccessControlAllowMethods
            {
                get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods>()!;
            }

            /// <summary>access_control_allow_origins block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#access_control_allow_origins CloudfrontResponseHeadersPolicy#access_control_allow_origins}
            /// </remarks>
            [JsiiProperty(name: "accessControlAllowOrigins", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins\"}")]
            public aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins AccessControlAllowOrigins
            {
                get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#origin_override CloudfrontResponseHeadersPolicy#origin_override}.</summary>
            [JsiiProperty(name: "originOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object OriginOverride
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>access_control_expose_headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#access_control_expose_headers CloudfrontResponseHeadersPolicy#access_control_expose_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessControlExposeHeaders", typeJson: "{\"fqn\":\"aws.cloudfrontResponseHeadersPolicy.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders\"}", isOptional: true)]
            public aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders? AccessControlExposeHeaders
            {
                get => GetInstanceProperty<aws.CloudfrontResponseHeadersPolicy.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_response_headers_policy#access_control_max_age_sec CloudfrontResponseHeadersPolicy#access_control_max_age_sec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessControlMaxAgeSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AccessControlMaxAgeSec
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
