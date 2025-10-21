using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentConfig
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentConfigTrafficRoutingConfig), fullyQualifiedName: "aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfig")]
    public interface ICodedeployDeploymentConfigTrafficRoutingConfig
    {
        /// <summary>time_based_canary block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#time_based_canary CodedeployDeploymentConfig#time_based_canary}
        /// </remarks>
        [JsiiProperty(name: "timeBasedCanary", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary? TimeBasedCanary
        {
            get
            {
                return null;
            }
        }

        /// <summary>time_based_linear block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#time_based_linear CodedeployDeploymentConfig#time_based_linear}
        /// </remarks>
        [JsiiProperty(name: "timeBasedLinear", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear? TimeBasedLinear
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#type CodedeployDeploymentConfig#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentConfigTrafficRoutingConfig), fullyQualifiedName: "aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>time_based_canary block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#time_based_canary CodedeployDeploymentConfig#time_based_canary}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeBasedCanary", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary\"}", isOptional: true)]
            public aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary? TimeBasedCanary
            {
                get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary?>();
            }

            /// <summary>time_based_linear block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#time_based_linear CodedeployDeploymentConfig#time_based_linear}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeBasedLinear", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear\"}", isOptional: true)]
            public aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear? TimeBasedLinear
            {
                get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#type CodedeployDeploymentConfig#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
