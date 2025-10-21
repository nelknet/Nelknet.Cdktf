using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration")]
    public class SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration : aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#type SagemakerEndpoint#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#wait_interval_in_seconds SagemakerEndpoint#wait_interval_in_seconds}.</summary>
        [JsiiProperty(name: "waitIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double WaitIntervalInSeconds
        {
            get;
            set;
        }

        /// <summary>canary_size block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#canary_size SagemakerEndpoint#canary_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "canarySize", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize\"}", isOptional: true)]
        public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize? CanarySize
        {
            get;
            set;
        }

        /// <summary>linear_step_size block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#linear_step_size SagemakerEndpoint#linear_step_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "linearStepSize", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize\"}", isOptional: true)]
        public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize? LinearStepSize
        {
            get;
            set;
        }
    }
}
