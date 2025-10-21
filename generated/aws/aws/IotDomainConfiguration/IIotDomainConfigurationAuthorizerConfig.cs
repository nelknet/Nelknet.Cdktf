using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotDomainConfiguration
{
    [JsiiInterface(nativeType: typeof(IIotDomainConfigurationAuthorizerConfig), fullyQualifiedName: "aws.iotDomainConfiguration.IotDomainConfigurationAuthorizerConfig")]
    public interface IIotDomainConfigurationAuthorizerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#allow_authorizer_override IotDomainConfiguration#allow_authorizer_override}.</summary>
        [JsiiProperty(name: "allowAuthorizerOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowAuthorizerOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#default_authorizer_name IotDomainConfiguration#default_authorizer_name}.</summary>
        [JsiiProperty(name: "defaultAuthorizerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultAuthorizerName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotDomainConfigurationAuthorizerConfig), fullyQualifiedName: "aws.iotDomainConfiguration.IotDomainConfigurationAuthorizerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IotDomainConfiguration.IIotDomainConfigurationAuthorizerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#allow_authorizer_override IotDomainConfiguration#allow_authorizer_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowAuthorizerOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowAuthorizerOverride
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#default_authorizer_name IotDomainConfiguration#default_authorizer_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultAuthorizerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultAuthorizerName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
