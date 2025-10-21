using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksStaticWebLayer
{
    [JsiiClass(nativeType: typeof(aws.OpsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingOutputReference), fullyQualifiedName: "aws.opsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpsworksStaticWebLayerLoadBasedAutoScalingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpsworksStaticWebLayerLoadBasedAutoScalingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpsworksStaticWebLayerLoadBasedAutoScalingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksStaticWebLayerLoadBasedAutoScalingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDownscaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingDownscaling\"}}]")]
        public virtual void PutDownscaling(aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScalingDownscaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScalingDownscaling)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpscaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingUpscaling\"}}]")]
        public virtual void PutUpscaling(aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScalingUpscaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScalingUpscaling)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDownscaling")]
        public virtual void ResetDownscaling()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnable")]
        public virtual void ResetEnable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpscaling")]
        public virtual void ResetUpscaling()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingDownscalingOutputReference\"}")]
        public virtual aws.OpsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingDownscalingOutputReference Downscaling
        {
            get => GetInstanceProperty<aws.OpsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingDownscalingOutputReference>()!;
        }

        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingUpscalingOutputReference\"}")]
        public virtual aws.OpsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingUpscalingOutputReference Upscaling
        {
            get => GetInstanceProperty<aws.OpsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingUpscalingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "downscalingInput", typeJson: "{\"fqn\":\"aws.opsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        public virtual aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScalingDownscaling? DownscalingInput
        {
            get => GetInstanceProperty<aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScalingDownscaling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upscalingInput", typeJson: "{\"fqn\":\"aws.opsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        public virtual aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScalingUpscaling? UpscalingInput
        {
            get => GetInstanceProperty<aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScalingUpscaling?>();
        }

        [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enable
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opsworksStaticWebLayer.OpsworksStaticWebLayerLoadBasedAutoScaling\"}", isOptional: true)]
        public virtual aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScaling? InternalValue
        {
            get => GetInstanceProperty<aws.OpsworksStaticWebLayer.IOpsworksStaticWebLayerLoadBasedAutoScaling?>();
            set => SetInstanceProperty(value);
        }
    }
}
