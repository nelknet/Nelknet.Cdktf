using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorOriginGroup
{
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupLoadBalancingOutputReference), fullyQualifiedName: "azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupLoadBalancingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CdnFrontdoorOriginGroupLoadBalancingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CdnFrontdoorOriginGroupLoadBalancingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CdnFrontdoorOriginGroupLoadBalancingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorOriginGroupLoadBalancingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAdditionalLatencyInMilliseconds")]
        public virtual void ResetAdditionalLatencyInMilliseconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSampleSize")]
        public virtual void ResetSampleSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccessfulSamplesRequired")]
        public virtual void ResetSuccessfulSamplesRequired()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalLatencyInMillisecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AdditionalLatencyInMillisecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sampleSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SampleSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "successfulSamplesRequiredInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SuccessfulSamplesRequiredInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "additionalLatencyInMilliseconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AdditionalLatencyInMilliseconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sampleSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SampleSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "successfulSamplesRequired", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SuccessfulSamplesRequired
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorOriginGroup.CdnFrontdoorOriginGroupLoadBalancing\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupLoadBalancing? InternalValue
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorOriginGroup.ICdnFrontdoorOriginGroupLoadBalancing?>();
            set => SetInstanceProperty(value);
        }
    }
}
