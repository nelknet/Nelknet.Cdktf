using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpoint
{
    [JsiiByValue(fqn: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration")]
    public class SagemakerEndpointDeploymentConfigAutoRollbackConfiguration : aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration
    {
        private object? _alarms;

        /// <summary>alarms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#alarms SagemakerEndpoint#alarms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alarms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Alarms
        {
            get => _alarms;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _alarms = value;
            }
        }
    }
}
