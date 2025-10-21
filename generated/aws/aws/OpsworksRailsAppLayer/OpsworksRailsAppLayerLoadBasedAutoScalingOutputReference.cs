using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksRailsAppLayer
{
    [JsiiClass(nativeType: typeof(aws.OpsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScalingOutputReference), fullyQualifiedName: "aws.opsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScalingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpsworksRailsAppLayerLoadBasedAutoScalingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpsworksRailsAppLayerLoadBasedAutoScalingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpsworksRailsAppLayerLoadBasedAutoScalingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksRailsAppLayerLoadBasedAutoScalingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDownscaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScalingDownscaling\"}}]")]
        public virtual void PutDownscaling(aws.OpsworksRailsAppLayer.IOpsworksRailsAppLayerLoadBasedAutoScalingDownscaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpsworksRailsAppLayer.IOpsworksRailsAppLayerLoadBasedAutoScalingDownscaling)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpscaling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.opsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScalingUpscaling\"}}]")]
        public virtual void PutUpscaling(aws.OpsworksRailsAppLayer.IOpsworksRailsAppLayerLoadBasedAutoScalingUpscaling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.OpsworksRailsAppLayer.IOpsworksRailsAppLayerLoadBasedAutoScalingUpscaling)}, new object[]{@value});
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

        [JsiiProperty(name: "downscaling", typeJson: "{\"fqn\":\"aws.opsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScalingDownscalingOutputReference\"}")]
        public virtual aws.OpsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScalingDownscalingOutputReference Downscaling
        {
            get => GetInstanceProperty<aws.OpsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScalingDownscalingOutputReference>()!;
        }

        [JsiiProperty(name: "upscaling", typeJson: "{\"fqn\":\"aws.opsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScalingUpscalingOutputReference\"}")]
        public virtual aws.OpsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScalingUpscalingOutputReference Upscaling
        {
            get => GetInstanceProperty<aws.OpsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScalingUpscalingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "downscalingInput", typeJson: "{\"fqn\":\"aws.opsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        public virtual aws.OpsworksRailsAppLayer.IOpsworksRailsAppLayerLoadBasedAutoScalingDownscaling? DownscalingInput
        {
            get => GetInstanceProperty<aws.OpsworksRailsAppLayer.IOpsworksRailsAppLayerLoadBasedAutoScalingDownscaling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upscalingInput", typeJson: "{\"fqn\":\"aws.opsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScalingUpscaling\"}", isOptional: true)]
        public virtual aws.OpsworksRailsAppLayer.IOpsworksRailsAppLayerLoadBasedAutoScalingUpscaling? UpscalingInput
        {
            get => GetInstanceProperty<aws.OpsworksRailsAppLayer.IOpsworksRailsAppLayerLoadBasedAutoScalingUpscaling?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opsworksRailsAppLayer.OpsworksRailsAppLayerLoadBasedAutoScaling\"}", isOptional: true)]
        public virtual aws.OpsworksRailsAppLayer.IOpsworksRailsAppLayerLoadBasedAutoScaling? InternalValue
        {
            get => GetInstanceProperty<aws.OpsworksRailsAppLayer.IOpsworksRailsAppLayerLoadBasedAutoScaling?>();
            set => SetInstanceProperty(value);
        }
    }
}
