using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpoint
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointDeploymentConfig), fullyQualifiedName: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfig")]
    public interface ISagemakerEndpointDeploymentConfig
    {
        /// <summary>auto_rollback_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#auto_rollback_configuration SagemakerEndpoint#auto_rollback_configuration}
        /// </remarks>
        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration? AutoRollbackConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>blue_green_update_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#blue_green_update_policy SagemakerEndpoint#blue_green_update_policy}
        /// </remarks>
        [JsiiProperty(name: "blueGreenUpdatePolicy", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy? BlueGreenUpdatePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>rolling_update_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#rolling_update_policy SagemakerEndpoint#rolling_update_policy}
        /// </remarks>
        [JsiiProperty(name: "rollingUpdatePolicy", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicy? RollingUpdatePolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointDeploymentConfig), fullyQualifiedName: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>auto_rollback_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#auto_rollback_configuration SagemakerEndpoint#auto_rollback_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration\"}", isOptional: true)]
            public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration? AutoRollbackConfiguration
            {
                get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration?>();
            }

            /// <summary>blue_green_update_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#blue_green_update_policy SagemakerEndpoint#blue_green_update_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blueGreenUpdatePolicy", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy\"}", isOptional: true)]
            public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy? BlueGreenUpdatePolicy
            {
                get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy?>();
            }

            /// <summary>rolling_update_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#rolling_update_policy SagemakerEndpoint#rolling_update_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rollingUpdatePolicy", typeJson: "{\"fqn\":\"aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigRollingUpdatePolicy\"}", isOptional: true)]
            public aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicy? RollingUpdatePolicy
            {
                get => GetInstanceProperty<aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigRollingUpdatePolicy?>();
            }
        }
    }
}
