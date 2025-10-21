using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MediaServicesAccountFilter
{
    [JsiiClass(nativeType: typeof(azurerm.MediaServicesAccountFilter.MediaServicesAccountFilterPresentationTimeRangeOutputReference), fullyQualifiedName: "azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterPresentationTimeRangeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MediaServicesAccountFilterPresentationTimeRangeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MediaServicesAccountFilterPresentationTimeRangeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MediaServicesAccountFilterPresentationTimeRangeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MediaServicesAccountFilterPresentationTimeRangeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEndInUnits")]
        public virtual void ResetEndInUnits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceEnd")]
        public virtual void ResetForceEnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLiveBackoffInUnits")]
        public virtual void ResetLiveBackoffInUnits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPresentationWindowInUnits")]
        public virtual void ResetPresentationWindowInUnits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartInUnits")]
        public virtual void ResetStartInUnits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "endInUnitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EndInUnitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceEndInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceEndInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "liveBackoffInUnitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LiveBackoffInUnitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "presentationWindowInUnitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PresentationWindowInUnitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startInUnitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StartInUnitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unitTimescaleInMillisecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UnitTimescaleInMillisecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "endInUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EndInUnits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceEnd", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceEnd
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

        [JsiiProperty(name: "liveBackoffInUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LiveBackoffInUnits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "presentationWindowInUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PresentationWindowInUnits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startInUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartInUnits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "unitTimescaleInMilliseconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UnitTimescaleInMilliseconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterPresentationTimeRange\"}", isOptional: true)]
        public virtual azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterPresentationTimeRange? InternalValue
        {
            get => GetInstanceProperty<azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterPresentationTimeRange?>();
            set => SetInstanceProperty(value);
        }
    }
}
