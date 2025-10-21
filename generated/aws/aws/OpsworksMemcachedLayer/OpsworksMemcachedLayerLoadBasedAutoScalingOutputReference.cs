using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksMemcachedLayer
{
    [JsiiClass(nativeType: typeof(aws.OpsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingOutputReference), fullyQualifiedName: "aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpsworksMemcachedLayerLoadBasedAutoScalingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpsworksMemcachedLayerLoadBasedAutoScalingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpsworksMemcachedLayerLoadBasedAutoScalingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksMemcachedLayerLoadBasedAutoScalingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDownscaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingDownscaling\"}}]")]
        public virtual void PutDownscaling(aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingDownscaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingDownscaling)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpscaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingUpscaling\"}}]")]
        public virtual void PutUpscaling(aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingUpscaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingUpscaling)}, new object[]{@value});
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

        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingDownscalingOutputReference\"}")]
        public virtual aws.OpsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingDownscalingOutputReference Downscaling
        {
            get => GetInstanceProperty<aws.OpsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingDownscalingOutputReference>()!;
        }

        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingUpscalingOutputReference\"}")]
        public virtual aws.OpsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingUpscalingOutputReference Upscaling
        {
            get => GetInstanceProperty<aws.OpsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingUpscalingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "downscalingInput", typeJson: "{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        public virtual aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingDownscaling? DownscalingInput
        {
            get => GetInstanceProperty<aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingDownscaling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upscalingInput", typeJson: "{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        public virtual aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingUpscaling? UpscalingInput
        {
            get => GetInstanceProperty<aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingUpscaling?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScaling\"}", isOptional: true)]
        public virtual aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScaling? InternalValue
        {
            get => GetInstanceProperty<aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScaling?>();
            set => SetInstanceProperty(value);
        }
    }
}
