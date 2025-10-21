using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderDistributionConfiguration
{
    [JsiiClass(nativeType: typeof(aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionOutputReference), fullyQualifiedName: "aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ImagebuilderDistributionConfigurationDistributionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ImagebuilderDistributionConfigurationDistributionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderDistributionConfigurationDistributionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderDistributionConfigurationDistributionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAmiDistributionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration\"}}]")]
        public virtual void PutAmiDistributionConfiguration(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContainerDistributionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration\"}}]")]
        public virtual void PutContainerDistributionConfiguration(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFastLaunchConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionFastLaunchConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFastLaunchConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionFastLaunchConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionFastLaunchConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionFastLaunchConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLaunchTemplateConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionLaunchTemplateConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLaunchTemplateConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionLaunchTemplateConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionLaunchTemplateConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionLaunchTemplateConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3ExportConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionS3ExportConfiguration\"}}]")]
        public virtual void PutS3ExportConfiguration(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionS3ExportConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionS3ExportConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSsmParameterConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionSsmParameterConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSsmParameterConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionSsmParameterConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionSsmParameterConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionSsmParameterConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmiDistributionConfiguration")]
        public virtual void ResetAmiDistributionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerDistributionConfiguration")]
        public virtual void ResetContainerDistributionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFastLaunchConfiguration")]
        public virtual void ResetFastLaunchConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchTemplateConfiguration")]
        public virtual void ResetLaunchTemplateConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicenseConfigurationArns")]
        public virtual void ResetLicenseConfigurationArns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3ExportConfiguration")]
        public virtual void ResetS3ExportConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSsmParameterConfiguration")]
        public virtual void ResetSsmParameterConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "amiDistributionConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionAmiDistributionConfigurationOutputReference\"}")]
        public virtual aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionAmiDistributionConfigurationOutputReference AmiDistributionConfiguration
        {
            get => GetInstanceProperty<aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionAmiDistributionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "containerDistributionConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionContainerDistributionConfigurationOutputReference\"}")]
        public virtual aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionContainerDistributionConfigurationOutputReference ContainerDistributionConfiguration
        {
            get => GetInstanceProperty<aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionContainerDistributionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "fastLaunchConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationList\"}")]
        public virtual aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationList FastLaunchConfiguration
        {
            get => GetInstanceProperty<aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationList>()!;
        }

        [JsiiProperty(name: "launchTemplateConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionLaunchTemplateConfigurationList\"}")]
        public virtual aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionLaunchTemplateConfigurationList LaunchTemplateConfiguration
        {
            get => GetInstanceProperty<aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionLaunchTemplateConfigurationList>()!;
        }

        [JsiiProperty(name: "s3ExportConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionS3ExportConfigurationOutputReference\"}")]
        public virtual aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionS3ExportConfigurationOutputReference S3ExportConfiguration
        {
            get => GetInstanceProperty<aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionS3ExportConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "ssmParameterConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionSsmParameterConfigurationList\"}")]
        public virtual aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionSsmParameterConfigurationList SsmParameterConfiguration
        {
            get => GetInstanceProperty<aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionSsmParameterConfigurationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amiDistributionConfigurationInput", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration\"}", isOptional: true)]
        public virtual aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration? AmiDistributionConfigurationInput
        {
            get => GetInstanceProperty<aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionAmiDistributionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerDistributionConfigurationInput", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration\"}", isOptional: true)]
        public virtual aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration? ContainerDistributionConfigurationInput
        {
            get => GetInstanceProperty<aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionContainerDistributionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fastLaunchConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionFastLaunchConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FastLaunchConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchTemplateConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionLaunchTemplateConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LaunchTemplateConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseConfigurationArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LicenseConfigurationArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ExportConfigurationInput", typeJson: "{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionS3ExportConfiguration\"}", isOptional: true)]
        public virtual aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionS3ExportConfiguration? S3ExportConfigurationInput
        {
            get => GetInstanceProperty<aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistributionS3ExportConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ssmParameterConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistributionSsmParameterConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SsmParameterConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "licenseConfigurationArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LicenseConfigurationArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.imagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistribution\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistribution cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderDistributionConfiguration.IImagebuilderDistributionConfigurationDistribution).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
