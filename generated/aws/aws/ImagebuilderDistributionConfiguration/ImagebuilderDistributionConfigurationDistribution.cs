using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderDistributionConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistribution")]
    public class ImagebuilderDistributionConfigurationDistribution : aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistribution
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#region ImagebuilderDistributionConfiguration#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public string Region
        {
            get;
            set;
        }

        /// <summary>ami_distribution_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#ami_distribution_configuration ImagebuilderDistributionConfiguration#ami_distribution_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amiDistributionConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration\"}", isOptional: true)]
        public aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration? AmiDistributionConfiguration
        {
            get;
            set;
        }

        /// <summary>container_distribution_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#container_distribution_configuration ImagebuilderDistributionConfiguration#container_distribution_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerDistributionConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration\"}", isOptional: true)]
        public aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration? ContainerDistributionConfiguration
        {
            get;
            set;
        }

        private object? _fastLaunchConfiguration;

        /// <summary>fast_launch_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#fast_launch_configuration ImagebuilderDistributionConfiguration#fast_launch_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fastLaunchConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionFastLaunchConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FastLaunchConfiguration
        {
            get => _fastLaunchConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionFastLaunchConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionFastLaunchConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fastLaunchConfiguration = value;
            }
        }

        private object? _launchTemplateConfiguration;

        /// <summary>launch_template_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#launch_template_configuration ImagebuilderDistributionConfiguration#launch_template_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionLaunchTemplateConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LaunchTemplateConfiguration
        {
            get => _launchTemplateConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionLaunchTemplateConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionLaunchTemplateConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _launchTemplateConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#license_configuration_arns ImagebuilderDistributionConfiguration#license_configuration_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "licenseConfigurationArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? LicenseConfigurationArns
        {
            get;
            set;
        }

        /// <summary>s3_export_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#s3_export_configuration ImagebuilderDistributionConfiguration#s3_export_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3ExportConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionS3ExportConfiguration\"}", isOptional: true)]
        public aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionS3ExportConfiguration? S3ExportConfiguration
        {
            get;
            set;
        }

        private object? _ssmParameterConfiguration;

        /// <summary>ssm_parameter_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#ssm_parameter_configuration ImagebuilderDistributionConfiguration#ssm_parameter_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ssmParameterConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionSsmParameterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SsmParameterConfiguration
        {
            get => _ssmParameterConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionSsmParameterConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionSsmParameterConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ssmParameterConfiguration = value;
            }
        }
    }
}
