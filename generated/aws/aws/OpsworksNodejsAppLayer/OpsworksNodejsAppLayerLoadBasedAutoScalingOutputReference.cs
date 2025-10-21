using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksNodejsAppLayer
{
    [JsiiClass(nativeType: typeof(aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingOutputReference), fullyQualifiedName: "aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpsworksNodejsAppLayerLoadBasedAutoScalingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpsworksNodejsAppLayerLoadBasedAutoScalingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpsworksNodejsAppLayerLoadBasedAutoScalingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksNodejsAppLayerLoadBasedAutoScalingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDownscaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling\"}}]")]
        public virtual void PutDownscaling(aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpscaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling\"}}]")]
        public virtual void PutUpscaling(aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling)}, new object[]{@value});
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

        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingDownscalingOutputReference\"}")]
        public virtual aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingDownscalingOutputReference Downscaling
        {
            get => GetInstanceProperty<aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingDownscalingOutputReference>()!;
        }

        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingUpscalingOutputReference\"}")]
        public virtual aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingUpscalingOutputReference Upscaling
        {
            get => GetInstanceProperty<aws.OpsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingUpscalingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "downscalingInput", typeJson: "{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        public virtual aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling? DownscalingInput
        {
            get => GetInstanceProperty<aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingDownscaling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upscalingInput", typeJson: "{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        public virtual aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling? UpscalingInput
        {
            get => GetInstanceProperty<aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScaling\"}", isOptional: true)]
        public virtual aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScaling? InternalValue
        {
            get => GetInstanceProperty<aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScaling?>();
            set => SetInstanceProperty(value);
        }
    }
}
