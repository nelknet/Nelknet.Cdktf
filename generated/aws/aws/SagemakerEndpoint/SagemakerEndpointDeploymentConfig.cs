using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpoint
{
    [JsiiByValue(fqn: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfig")]
    public class SagemakerEndpointDeploymentConfig : aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfig
    {
        /// <summary>auto_rollback_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#auto_rollback_configuration SagemakerEndpoint#auto_rollback_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration\"}", isOptional: true)]
        public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration? AutoRollbackConfiguration
        {
            get;
            set;
        }

        /// <summary>blue_green_update_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#blue_green_update_policy SagemakerEndpoint#blue_green_update_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blueGreenUpdatePolicy", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy\"}", isOptional: true)]
        public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy? BlueGreenUpdatePolicy
        {
            get;
            set;
        }

        /// <summary>rolling_update_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#rolling_update_policy SagemakerEndpoint#rolling_update_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rollingUpdatePolicy", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicy\"}", isOptional: true)]
        public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicy? RollingUpdatePolicy
        {
            get;
            set;
        }
    }
}
