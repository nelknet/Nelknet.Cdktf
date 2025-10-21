using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicy")]
    public class SagemakerEndpointDeploymentConfigRollingUpdatePolicy : aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicy
    {
        /// <summary>maximum_batch_size block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#maximum_batch_size SagemakerEndpoint#maximum_batch_size}
        /// </remarks>
        [JsiiProperty(name: "maximumBatchSize", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize\"}")]
        public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize MaximumBatchSize
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#maximum_execution_timeout_in_seconds SagemakerEndpoint#maximum_execution_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumExecutionTimeoutInSeconds
        {
            get;
            set;
        }

        /// <summary>rollback_maximum_batch_size block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#rollback_maximum_batch_size SagemakerEndpoint#rollback_maximum_batch_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rollbackMaximumBatchSize", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize\"}", isOptional: true)]
        public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize? RollbackMaximumBatchSize
        {
            get;
            set;
        }
    }
}
