using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpoint
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointDeploymentConfigRollingUpdatePolicy), fullyQualifiedName: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicy")]
    public interface ISagemakerEndpointDeploymentConfigRollingUpdatePolicy
    {
        /// <summary>maximum_batch_size block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#maximum_batch_size SagemakerEndpoint#maximum_batch_size}
        /// </remarks>
        [JsiiProperty(name: "maximumBatchSize", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize\"}")]
        aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize MaximumBatchSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#wait_interval_in_seconds SagemakerEndpoint#wait_interval_in_seconds}.</summary>
        [JsiiProperty(name: "waitIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double WaitIntervalInSeconds
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

        /// <summary>rollback_maximum_batch_size block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#rollback_maximum_batch_size SagemakerEndpoint#rollback_maximum_batch_size}
        /// </remarks>
        [JsiiProperty(name: "rollbackMaximumBatchSize", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize? RollbackMaximumBatchSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointDeploymentConfigRollingUpdatePolicy), fullyQualifiedName: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>maximum_batch_size block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#maximum_batch_size SagemakerEndpoint#maximum_batch_size}
            /// </remarks>
            [JsiiProperty(name: "maximumBatchSize", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize\"}")]
            public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize MaximumBatchSize
            {
                get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyMaximumBatchSize>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#wait_interval_in_seconds SagemakerEndpoint#wait_interval_in_seconds}.</summary>
            [JsiiProperty(name: "waitIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double WaitIntervalInSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#maximum_execution_timeout_in_seconds SagemakerEndpoint#maximum_execution_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumExecutionTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>rollback_maximum_batch_size block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#rollback_maximum_batch_size SagemakerEndpoint#rollback_maximum_batch_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rollbackMaximumBatchSize", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize\"}", isOptional: true)]
            public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize? RollbackMaximumBatchSize
            {
                get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicyRollbackMaximumBatchSize?>();
            }
        }
    }
}
