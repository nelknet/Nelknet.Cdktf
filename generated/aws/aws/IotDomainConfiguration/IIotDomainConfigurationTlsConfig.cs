using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotDomainConfiguration
{
    [JsiiInterface(nativeType: typeof(IIotDomainConfigurationTlsConfig), fullyQualifiedName: "aws.iotDomainConfiguration.IotDomainConfigurationTlsConfig")]
    public interface IIotDomainConfigurationTlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#security_policy IotDomainConfiguration#security_policy}.</summary>
        [JsiiProperty(name: "securityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotDomainConfigurationTlsConfig), fullyQualifiedName: "aws.iotDomainConfiguration.IotDomainConfigurationTlsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IotDomainConfiguration.IIotDomainConfigurationTlsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#security_policy IotDomainConfiguration#security_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
