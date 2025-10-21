using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpoint
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration), fullyQualifiedName: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration")]
    public interface ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration
    {
        /// <summary>alarms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#alarms SagemakerEndpoint#alarms}
        /// </remarks>
        [JsiiProperty(name: "alarms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Alarms
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration), fullyQualifiedName: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>alarms block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#alarms SagemakerEndpoint#alarms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alarms", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Alarms
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
