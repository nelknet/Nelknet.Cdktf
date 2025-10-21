using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiInterface(nativeType: typeof(ISagemakerSpaceSpaceSettingsJupyterLabAppSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettings")]
    public interface ISagemakerSpaceSpaceSettingsJupyterLabAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#default_resource_spec SagemakerSpace#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec\"}")]
        aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec DefaultResourceSpec
        {
            get;
        }

        /// <summary>app_lifecycle_management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#app_lifecycle_management SagemakerSpace#app_lifecycle_management}
        /// </remarks>
        [JsiiProperty(name: "appLifecycleManagement", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement
        {
            get
            {
                return null;
            }
        }

        /// <summary>code_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#code_repository SagemakerSpace#code_repository}
        /// </remarks>
        [JsiiProperty(name: "codeRepository", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsCodeRepository\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CodeRepository
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerSpaceSpaceSettingsJupyterLabAppSettings), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#default_resource_spec SagemakerSpace#default_resource_spec}
            /// </remarks>
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec\"}")]
            public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec>()!;
            }

            /// <summary>app_lifecycle_management block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#app_lifecycle_management SagemakerSpace#app_lifecycle_management}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appLifecycleManagement", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement\"}", isOptional: true)]
            public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement
            {
                get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement?>();
            }

            /// <summary>code_repository block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#code_repository SagemakerSpace#code_repository}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeRepository", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsCodeRepository\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CodeRepository
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
