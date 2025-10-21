using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettingsCodeEditorAppSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettings")]
    public interface ISagemakerDomainDefaultUserSettingsCodeEditorAppSettings
    {
        /// <summary>app_lifecycle_management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#app_lifecycle_management SagemakerDomain#app_lifecycle_management}
        /// </remarks>
        [JsiiProperty(name: "appLifecycleManagement", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#built_in_lifecycle_config_arn SagemakerDomain#built_in_lifecycle_config_arn}.</summary>
        [JsiiProperty(name: "builtInLifecycleConfigArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BuiltInLifecycleConfigArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#custom_image SagemakerDomain#custom_image}
        /// </remarks>
        [JsiiProperty(name: "customImage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsCustomImage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#lifecycle_config_arns SagemakerDomain#lifecycle_config_arns}.</summary>
        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LifecycleConfigArns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettingsCodeEditorAppSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>app_lifecycle_management block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#app_lifecycle_management SagemakerDomain#app_lifecycle_management}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appLifecycleManagement", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#built_in_lifecycle_config_arn SagemakerDomain#built_in_lifecycle_config_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "builtInLifecycleConfigArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BuiltInLifecycleConfigArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>custom_image block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#custom_image SagemakerDomain#custom_image}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customImage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsCustomImage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomImage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec? DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsDefaultResourceSpec?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#lifecycle_config_arns SagemakerDomain#lifecycle_config_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LifecycleConfigArns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
