using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiInterface(nativeType: typeof(ISagemakerSpaceSpaceSettingsJupyterServerAppSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettings")]
    public interface ISagemakerSpaceSpaceSettingsJupyterServerAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#default_resource_spec SagemakerSpace#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec\"}")]
        aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec DefaultResourceSpec
        {
            get;
        }

        /// <summary>code_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#code_repository SagemakerSpace#code_repository}
        /// </remarks>
        [JsiiProperty(name: "codeRepository", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettingsCodeRepository\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CodeRepository
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#lifecycle_config_arns SagemakerSpace#lifecycle_config_arns}.</summary>
        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LifecycleConfigArns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerSpaceSpaceSettingsJupyterServerAppSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#default_resource_spec SagemakerSpace#default_resource_spec}
            /// </remarks>
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec\"}")]
            public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterServerAppSettingsDefaultResourceSpec>()!;
            }

            /// <summary>code_repository block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#code_repository SagemakerSpace#code_repository}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeRepository", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterServerAppSettingsCodeRepository\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CodeRepository
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#lifecycle_config_arns SagemakerSpace#lifecycle_config_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LifecycleConfigArns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
