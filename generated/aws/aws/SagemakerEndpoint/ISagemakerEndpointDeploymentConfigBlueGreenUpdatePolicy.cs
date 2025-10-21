using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpoint
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy), fullyQualifiedName: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy")]
    public interface ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy
    {
        /// <summary>traffic_routing_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#traffic_routing_configuration SagemakerEndpoint#traffic_routing_configuration}
        /// </remarks>
        [JsiiProperty(name: "trafficRoutingConfiguration", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration\"}")]
        aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration TrafficRoutingConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#maximum_execution_timeout_in_seconds SagemakerEndpoint#maximum_execution_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "maximumExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumExecutionTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#termination_wait_in_seconds SagemakerEndpoint#termination_wait_in_seconds}.</summary>
        [JsiiProperty(name: "terminationWaitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TerminationWaitInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy), fullyQualifiedName: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>traffic_routing_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#traffic_routing_configuration SagemakerEndpoint#traffic_routing_configuration}
            /// </remarks>
            [JsiiProperty(name: "trafficRoutingConfiguration", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration\"}")]
            public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration TrafficRoutingConfiguration
            {
                get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#maximum_execution_timeout_in_seconds SagemakerEndpoint#maximum_execution_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumExecutionTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#termination_wait_in_seconds SagemakerEndpoint#termination_wait_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "terminationWaitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TerminationWaitInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
