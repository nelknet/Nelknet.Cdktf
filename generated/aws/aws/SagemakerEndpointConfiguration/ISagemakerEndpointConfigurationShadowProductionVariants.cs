using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointConfigurationShadowProductionVariants), fullyQualifiedName: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariants")]
    public interface ISagemakerEndpointConfigurationShadowProductionVariants
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#model_name SagemakerEndpointConfiguration#model_name}.</summary>
        [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}")]
        string ModelName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#accelerator_type SagemakerEndpointConfiguration#accelerator_type}.</summary>
        [JsiiProperty(name: "acceleratorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AcceleratorType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#container_startup_health_check_timeout_in_seconds SagemakerEndpointConfiguration#container_startup_health_check_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "containerStartupHealthCheckTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ContainerStartupHealthCheckTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>core_dump_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#core_dump_config SagemakerEndpointConfiguration#core_dump_config}
        /// </remarks>
        [JsiiProperty(name: "coreDumpConfig", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsCoreDumpConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsCoreDumpConfig? CoreDumpConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#enable_ssm_access SagemakerEndpointConfiguration#enable_ssm_access}.</summary>
        [JsiiProperty(name: "enableSsmAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableSsmAccess
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#inference_ami_version SagemakerEndpointConfiguration#inference_ami_version}.</summary>
        [JsiiProperty(name: "inferenceAmiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InferenceAmiVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#initial_instance_count SagemakerEndpointConfiguration#initial_instance_count}.</summary>
        [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InitialInstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#initial_variant_weight SagemakerEndpointConfiguration#initial_variant_weight}.</summary>
        [JsiiProperty(name: "initialVariantWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InitialVariantWeight
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#instance_type SagemakerEndpointConfiguration#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>managed_instance_scaling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#managed_instance_scaling SagemakerEndpointConfiguration#managed_instance_scaling}
        /// </remarks>
        [JsiiProperty(name: "managedInstanceScaling", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsManagedInstanceScaling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsManagedInstanceScaling? ManagedInstanceScaling
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#model_data_download_timeout_in_seconds SagemakerEndpointConfiguration#model_data_download_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "modelDataDownloadTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ModelDataDownloadTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>routing_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#routing_config SagemakerEndpointConfiguration#routing_config}
        /// </remarks>
        [JsiiProperty(name: "routingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsRoutingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RoutingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>serverless_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#serverless_config SagemakerEndpointConfiguration#serverless_config}
        /// </remarks>
        [JsiiProperty(name: "serverlessConfig", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsServerlessConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsServerlessConfig? ServerlessConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#variant_name SagemakerEndpointConfiguration#variant_name}.</summary>
        [JsiiProperty(name: "variantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VariantName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#volume_size_in_gb SagemakerEndpointConfiguration#volume_size_in_gb}.</summary>
        [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VolumeSizeInGb
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointConfigurationShadowProductionVariants), fullyQualifiedName: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariants")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariants
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#model_name SagemakerEndpointConfiguration#model_name}.</summary>
            [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#accelerator_type SagemakerEndpointConfiguration#accelerator_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AcceleratorType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#container_startup_health_check_timeout_in_seconds SagemakerEndpointConfiguration#container_startup_health_check_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerStartupHealthCheckTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ContainerStartupHealthCheckTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>core_dump_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#core_dump_config SagemakerEndpointConfiguration#core_dump_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "coreDumpConfig", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsCoreDumpConfig\"}", isOptional: true)]
            public aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsCoreDumpConfig? CoreDumpConfig
            {
                get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsCoreDumpConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#enable_ssm_access SagemakerEndpointConfiguration#enable_ssm_access}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableSsmAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableSsmAccess
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#inference_ami_version SagemakerEndpointConfiguration#inference_ami_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inferenceAmiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InferenceAmiVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#initial_instance_count SagemakerEndpointConfiguration#initial_instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InitialInstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#initial_variant_weight SagemakerEndpointConfiguration#initial_variant_weight}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "initialVariantWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InitialVariantWeight
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#instance_type SagemakerEndpointConfiguration#instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>managed_instance_scaling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#managed_instance_scaling SagemakerEndpointConfiguration#managed_instance_scaling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedInstanceScaling", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsManagedInstanceScaling\"}", isOptional: true)]
            public aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsManagedInstanceScaling? ManagedInstanceScaling
            {
                get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsManagedInstanceScaling?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#model_data_download_timeout_in_seconds SagemakerEndpointConfiguration#model_data_download_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelDataDownloadTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ModelDataDownloadTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>routing_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#routing_config SagemakerEndpointConfiguration#routing_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routingConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsRoutingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RoutingConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>serverless_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#serverless_config SagemakerEndpointConfiguration#serverless_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverlessConfig", typeJson: "{\"fqn\":\"aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariantsServerlessConfig\"}", isOptional: true)]
            public aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsServerlessConfig? ServerlessConfig
            {
                get => GetInstanceProperty<aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationShadowProductionVariantsServerlessConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#variant_name SagemakerEndpointConfiguration#variant_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "variantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VariantName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#volume_size_in_gb SagemakerEndpointConfiguration#volume_size_in_gb}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "volumeSizeInGb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VolumeSizeInGb
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
