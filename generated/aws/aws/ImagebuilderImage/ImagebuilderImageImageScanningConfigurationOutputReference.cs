using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderImage
{
    [JsiiClass(nativeType: typeof(aws.ImagebuilderImage.ImagebuilderImageImageScanningConfigurationOutputReference), fullyQualifiedName: "aws.imagebuilderImage.ImagebuilderImageImageScanningConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ImagebuilderImageImageScanningConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ImagebuilderImageImageScanningConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderImageImageScanningConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderImageImageScanningConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEcrConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageImageScanningConfigurationEcrConfiguration\"}}]")]
        public virtual void PutEcrConfiguration(aws.ImagebuilderImage.IImagebuilderImageImageScanningConfigurationEcrConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ImagebuilderImage.IImagebuilderImageImageScanningConfigurationEcrConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEcrConfiguration")]
        public virtual void ResetEcrConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageScanningEnabled")]
        public virtual void ResetImageScanningEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ecrConfiguration", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageImageScanningConfigurationEcrConfigurationOutputReference\"}")]
        public virtual aws.ImagebuilderImage.ImagebuilderImageImageScanningConfigurationEcrConfigurationOutputReference EcrConfiguration
        {
            get => GetInstanceProperty<aws.ImagebuilderImage.ImagebuilderImageImageScanningConfigurationEcrConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecrConfigurationInput", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageImageScanningConfigurationEcrConfiguration\"}", isOptional: true)]
        public virtual aws.ImagebuilderImage.IImagebuilderImageImageScanningConfigurationEcrConfiguration? EcrConfigurationInput
        {
            get => GetInstanceProperty<aws.ImagebuilderImage.IImagebuilderImageImageScanningConfigurationEcrConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageScanningEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ImageScanningEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "imageScanningEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ImageScanningEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.imagebuilderImage.ImagebuilderImageImageScanningConfiguration\"}", isOptional: true)]
        public virtual aws.ImagebuilderImage.IImagebuilderImageImageScanningConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.ImagebuilderImage.IImagebuilderImageImageScanningConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
