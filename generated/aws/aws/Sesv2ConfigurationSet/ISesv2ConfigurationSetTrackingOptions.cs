using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiInterface(nativeType: typeof(ISesv2ConfigurationSetTrackingOptions), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetTrackingOptions")]
    public interface ISesv2ConfigurationSetTrackingOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#custom_redirect_domain Sesv2ConfigurationSet#custom_redirect_domain}.</summary>
        [JsiiProperty(name: "customRedirectDomain", typeJson: "{\"primitive\":\"string\"}")]
        string CustomRedirectDomain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#https_policy Sesv2ConfigurationSet#https_policy}.</summary>
        [JsiiProperty(name: "httpsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpsPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2ConfigurationSetTrackingOptions), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetTrackingOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetTrackingOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#custom_redirect_domain Sesv2ConfigurationSet#custom_redirect_domain}.</summary>
            [JsiiProperty(name: "customRedirectDomain", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomRedirectDomain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#https_policy Sesv2ConfigurationSet#https_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpsPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
