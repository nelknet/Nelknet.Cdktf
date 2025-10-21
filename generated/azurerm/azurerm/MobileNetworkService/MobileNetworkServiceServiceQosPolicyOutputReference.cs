using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkService
{
    [JsiiClass(nativeType: typeof(azurerm.MobileNetworkService.MobileNetworkServiceServiceQosPolicyOutputReference), fullyQualifiedName: "azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MobileNetworkServiceServiceQosPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MobileNetworkServiceServiceQosPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MobileNetworkServiceServiceQosPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MobileNetworkServiceServiceQosPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMaximumBitRate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicyMaximumBitRate\"}}]")]
        public virtual void PutMaximumBitRate(azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicyMaximumBitRate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicyMaximumBitRate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllocationAndRetentionPriorityLevel")]
        public virtual void ResetAllocationAndRetentionPriorityLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreemptionCapability")]
        public virtual void ResetPreemptionCapability()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreemptionVulnerability")]
        public virtual void ResetPreemptionVulnerability()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQosIndicator")]
        public virtual void ResetQosIndicator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "maximumBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicyMaximumBitRateOutputReference\"}")]
        public virtual azurerm.MobileNetworkService.MobileNetworkServiceServiceQosPolicyMaximumBitRateOutputReference MaximumBitRate
        {
            get => GetInstanceProperty<azurerm.MobileNetworkService.MobileNetworkServiceServiceQosPolicyMaximumBitRateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationAndRetentionPriorityLevelInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AllocationAndRetentionPriorityLevelInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumBitRateInput", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicyMaximumBitRate\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicyMaximumBitRate? MaximumBitRateInput
        {
            get => GetInstanceProperty<azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicyMaximumBitRate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preemptionCapabilityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreemptionCapabilityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preemptionVulnerabilityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreemptionVulnerabilityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "qosIndicatorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QosIndicatorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "allocationAndRetentionPriorityLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AllocationAndRetentionPriorityLevel
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preemptionCapability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreemptionCapability
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preemptionVulnerability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreemptionVulnerability
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "qosIndicator", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QosIndicator
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServiceServiceQosPolicy\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.MobileNetworkService.IMobileNetworkServiceServiceQosPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
