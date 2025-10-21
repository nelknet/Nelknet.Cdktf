using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderDistributionConfiguration
{
    [JsiiInterface(nativeType: typeof(IImagebuilderDistributionConfigurationDistribution), fullyQualifiedName: "aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistribution")]
    public interface IImagebuilderDistributionConfigurationDistribution
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#region ImagebuilderDistributionConfiguration#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>ami_distribution_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#ami_distribution_configuration ImagebuilderDistributionConfiguration#ami_distribution_configuration}
        /// </remarks>
        [JsiiProperty(name: "amiDistributionConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration? AmiDistributionConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>container_distribution_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#container_distribution_configuration ImagebuilderDistributionConfiguration#container_distribution_configuration}
        /// </remarks>
        [JsiiProperty(name: "containerDistributionConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration? ContainerDistributionConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>fast_launch_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#fast_launch_configuration ImagebuilderDistributionConfiguration#fast_launch_configuration}
        /// </remarks>
        [JsiiProperty(name: "fastLaunchConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionFastLaunchConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FastLaunchConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>launch_template_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#launch_template_configuration ImagebuilderDistributionConfiguration#launch_template_configuration}
        /// </remarks>
        [JsiiProperty(name: "launchTemplateConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionLaunchTemplateConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LaunchTemplateConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#license_configuration_arns ImagebuilderDistributionConfiguration#license_configuration_arns}.</summary>
        [JsiiProperty(name: "licenseConfigurationArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LicenseConfigurationArns
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_export_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#s3_export_configuration ImagebuilderDistributionConfiguration#s3_export_configuration}
        /// </remarks>
        [JsiiProperty(name: "s3ExportConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionS3ExportConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionS3ExportConfiguration? S3ExportConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssm_parameter_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#ssm_parameter_configuration ImagebuilderDistributionConfiguration#ssm_parameter_configuration}
        /// </remarks>
        [JsiiProperty(name: "ssmParameterConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionSsmParameterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SsmParameterConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderDistributionConfigurationDistribution), fullyQualifiedName: "aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistribution")]
        internal sealed class _Proxy : DeputyBase, aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistribution
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#region ImagebuilderDistributionConfiguration#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ami_distribution_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#ami_distribution_configuration ImagebuilderDistributionConfiguration#ami_distribution_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amiDistributionConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration\"}", isOptional: true)]
            public aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration? AmiDistributionConfiguration
            {
                get => GetInstanceProperty<aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration?>();
            }

            /// <summary>container_distribution_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#container_distribution_configuration ImagebuilderDistributionConfiguration#container_distribution_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerDistributionConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration\"}", isOptional: true)]
            public aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration? ContainerDistributionConfiguration
            {
                get => GetInstanceProperty<aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration?>();
            }

            /// <summary>fast_launch_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#fast_launch_configuration ImagebuilderDistributionConfiguration#fast_launch_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fastLaunchConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionFastLaunchConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FastLaunchConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>launch_template_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#launch_template_configuration ImagebuilderDistributionConfiguration#launch_template_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "launchTemplateConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionLaunchTemplateConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LaunchTemplateConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#license_configuration_arns ImagebuilderDistributionConfiguration#license_configuration_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "licenseConfigurationArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LicenseConfigurationArns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>s3_export_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#s3_export_configuration ImagebuilderDistributionConfiguration#s3_export_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3ExportConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionS3ExportConfiguration\"}", isOptional: true)]
            public aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionS3ExportConfiguration? S3ExportConfiguration
            {
                get => GetInstanceProperty<aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionS3ExportConfiguration?>();
            }

            /// <summary>ssm_parameter_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#ssm_parameter_configuration ImagebuilderDistributionConfiguration#ssm_parameter_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssmParameterConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionSsmParameterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SsmParameterConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
