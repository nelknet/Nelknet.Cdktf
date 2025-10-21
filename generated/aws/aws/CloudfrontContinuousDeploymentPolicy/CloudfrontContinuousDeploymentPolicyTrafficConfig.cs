using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontContinuousDeploymentPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicyTrafficConfig")]
    public class CloudfrontContinuousDeploymentPolicyTrafficConfig : aws.CloudfrontContinuousDeploymentPolicy.ICloudfrontContinuousDeploymentPolicyTrafficConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#type CloudfrontContinuousDeploymentPolicy#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _singleHeaderConfig;

        /// <summary>single_header_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#single_header_config CloudfrontContinuousDeploymentPolicy#single_header_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleHeaderConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicyTrafficConfigSingleHeaderConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SingleHeaderConfig
        {
            get => _singleHeaderConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontContinuousDeploymentPolicy.ICloudfrontContinuousDeploymentPolicyTrafficConfigSingleHeaderConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudfrontContinuousDeploymentPolicy.ICloudfrontContinuousDeploymentPolicyTrafficConfigSingleHeaderConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _singleHeaderConfig = value;
            }
        }

        private object? _singleWeightConfig;

        /// <summary>single_weight_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_continuous_deployment_policy#single_weight_config CloudfrontContinuousDeploymentPolicy#single_weight_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleWeightConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontContinuousDeploymentPolicy.CloudfrontContinuousDeploymentPolicyTrafficConfigSingleWeightConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SingleWeightConfig
        {
            get => _singleWeightConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontContinuousDeploymentPolicy.ICloudfrontContinuousDeploymentPolicyTrafficConfigSingleWeightConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudfrontContinuousDeploymentPolicy.ICloudfrontContinuousDeploymentPolicyTrafficConfigSingleWeightConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _singleWeightConfig = value;
            }
        }
    }
}
