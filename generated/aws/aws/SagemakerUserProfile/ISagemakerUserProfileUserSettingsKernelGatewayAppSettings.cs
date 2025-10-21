using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiInterface(nativeType: typeof(ISagemakerUserProfileUserSettingsKernelGatewayAppSettings), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsKernelGatewayAppSettings")]
    public interface ISagemakerUserProfileUserSettingsKernelGatewayAppSettings
    {
        /// <summary>custom_image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#custom_image SagemakerUserProfile#custom_image}
        /// </remarks>
        [JsiiProperty(name: "customImage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomImage
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#default_resource_spec SagemakerUserProfile#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#lifecycle_config_arns SagemakerUserProfile#lifecycle_config_arns}.</summary>
        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LifecycleConfigArns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerUserProfileUserSettingsKernelGatewayAppSettings), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsKernelGatewayAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_image block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#custom_image SagemakerUserProfile#custom_image}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customImage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomImage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#default_resource_spec SagemakerUserProfile#default_resource_spec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#lifecycle_config_arns SagemakerUserProfile#lifecycle_config_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LifecycleConfigArns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
