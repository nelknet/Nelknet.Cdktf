using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeDataLake
{
    [JsiiByValue(fqn: "aws.securitylakeDataLake.SecuritylakeDataLakeConfigurationLifecycleConfiguration")]
    public class SecuritylakeDataLakeConfigurationLifecycleConfiguration : aws.SecuritylakeDataLake.ISecuritylakeDataLakeConfigurationLifecycleConfiguration
    {
        private object? _expiration;

        /// <summary>expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#expiration SecuritylakeDataLake#expiration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expiration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeDataLake.SecuritylakeDataLakeConfigurationLifecycleConfigurationExpiration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Expiration
        {
            get => _expiration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecuritylakeDataLake.ISecuritylakeDataLakeConfigurationLifecycleConfigurationExpiration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecuritylakeDataLake.ISecuritylakeDataLakeConfigurationLifecycleConfigurationExpiration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _expiration = value;
            }
        }

        private object? _transition;

        /// <summary>transition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#transition SecuritylakeDataLake#transition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeDataLake.SecuritylakeDataLakeConfigurationLifecycleConfigurationTransition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Transition
        {
            get => _transition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SecuritylakeDataLake.ISecuritylakeDataLakeConfigurationLifecycleConfigurationTransition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecuritylakeDataLake.ISecuritylakeDataLakeConfigurationLifecycleConfigurationTransition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _transition = value;
            }
        }
    }
}
