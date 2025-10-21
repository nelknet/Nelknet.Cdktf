using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SesConfigurationSet
{
    [JsiiInterface(nativeType: typeof(ISesConfigurationSetTrackingOptions), fullyQualifiedName: "aws.sesConfigurationSet.SesConfigurationSetTrackingOptions")]
    public interface ISesConfigurationSetTrackingOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#custom_redirect_domain SesConfigurationSet#custom_redirect_domain}.</summary>
        [JsiiProperty(name: "customRedirectDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomRedirectDomain
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesConfigurationSetTrackingOptions), fullyQualifiedName: "aws.sesConfigurationSet.SesConfigurationSetTrackingOptions")]
        internal sealed class _Proxy : DeputyBase, aws.SesConfigurationSet.ISesConfigurationSetTrackingOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#custom_redirect_domain SesConfigurationSet#custom_redirect_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customRedirectDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomRedirectDomain
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
