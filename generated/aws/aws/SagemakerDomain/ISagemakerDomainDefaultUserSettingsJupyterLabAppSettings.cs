using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettingsJupyterLabAppSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettings")]
    public interface ISagemakerDomainDefaultUserSettingsJupyterLabAppSettings
    {
        /// <summary>app_lifecycle_management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#app_lifecycle_management SagemakerDomain#app_lifecycle_management}
        /// </remarks>
        [JsiiProperty(name: "appLifecycleManagement", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement
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

        /// <summary>code_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#code_repository SagemakerDomain#code_repository}
        /// </remarks>
        [JsiiProperty(name: "codeRepository", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsCodeRepository\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CodeRepository
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
        [JsiiProperty(name: "customImage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsCustomImage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec
        {
            get
            {
                return null;
            }
        }

        /// <summary>emr_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#emr_settings SagemakerDomain#emr_settings}
        /// </remarks>
        [JsiiProperty(name: "emrSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsEmrSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsEmrSettings? EmrSettings
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

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettingsJupyterLabAppSettings), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>app_lifecycle_management block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#app_lifecycle_management SagemakerDomain#app_lifecycle_management}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appLifecycleManagement", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#built_in_lifecycle_config_arn SagemakerDomain#built_in_lifecycle_config_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "builtInLifecycleConfigArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BuiltInLifecycleConfigArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>code_repository block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#code_repository SagemakerDomain#code_repository}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeRepository", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsCodeRepository\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CodeRepository
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_image block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#custom_image SagemakerDomain#custom_image}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customImage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsCustomImage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomImage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#default_resource_spec SagemakerDomain#default_resource_spec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsDefaultResourceSpec?>();
            }

            /// <summary>emr_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#emr_settings SagemakerDomain#emr_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emrSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsEmrSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsEmrSettings? EmrSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsEmrSettings?>();
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
