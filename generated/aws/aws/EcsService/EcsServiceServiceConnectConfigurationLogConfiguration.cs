using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsService.EcsServiceServiceConnectConfigurationLogConfiguration")]
    public class EcsServiceServiceConnectConfigurationLogConfiguration : aws.EcsService.IEcsServiceServiceConnectConfigurationLogConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#log_driver EcsService#log_driver}.</summary>
        [JsiiProperty(name: "logDriver", typeJson: "{\"primitive\":\"string\"}")]
        public string LogDriver
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#options EcsService#options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Options
        {
            get;
            set;
        }

        private object? _secretOption;

        /// <summary>secret_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#secret_option EcsService#secret_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretOption", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationLogConfigurationSecretOption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecretOption
        {
            get => _secretOption;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.EcsService.IEcsServiceServiceConnectConfigurationLogConfigurationSecretOption[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceServiceConnectConfigurationLogConfigurationSecretOption).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secretOption = value;
            }
        }
    }
}
