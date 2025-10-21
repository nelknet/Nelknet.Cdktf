using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotDomainConfiguration
{
    [JsiiByValue(fqn: "aws.iotDomainConfiguration.IotDomainConfigurationAuthorizerConfig")]
    public class IotDomainConfigurationAuthorizerConfig : aws.IotDomainConfiguration.IIotDomainConfigurationAuthorizerConfig
    {
        private object? _allowAuthorizerOverride;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#allow_authorizer_override IotDomainConfiguration#allow_authorizer_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowAuthorizerOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowAuthorizerOverride
        {
            get => _allowAuthorizerOverride;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowAuthorizerOverride = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#default_authorizer_name IotDomainConfiguration#default_authorizer_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultAuthorizerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultAuthorizerName
        {
            get;
            set;
        }
    }
}
