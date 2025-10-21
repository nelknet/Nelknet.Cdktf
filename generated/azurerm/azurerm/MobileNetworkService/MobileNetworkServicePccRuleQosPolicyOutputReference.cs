using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkService
{
    [JsiiClass(nativeType: typeof(azurerm.MobileNetworkService.MobileNetworkServicePccRuleQosPolicyOutputReference), fullyQualifiedName: "azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MobileNetworkServicePccRuleQosPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MobileNetworkServicePccRuleQosPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MobileNetworkServicePccRuleQosPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MobileNetworkServicePccRuleQosPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGuaranteedBitRate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyGuaranteedBitRate\"}}]")]
        public virtual void PutGuaranteedBitRate(azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyGuaranteedBitRate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyGuaranteedBitRate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaximumBitRate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyMaximumBitRate\"}}]")]
        public virtual void PutMaximumBitRate(azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyMaximumBitRate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyMaximumBitRate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllocationAndRetentionPriorityLevel")]
        public virtual void ResetAllocationAndRetentionPriorityLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGuaranteedBitRate")]
        public virtual void ResetGuaranteedBitRate()
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

        [JsiiProperty(name: "guaranteedBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyGuaranteedBitRateOutputReference\"}")]
        public virtual azurerm.MobileNetworkService.MobileNetworkServicePccRuleQosPolicyGuaranteedBitRateOutputReference GuaranteedBitRate
        {
            get => GetInstanceProperty<azurerm.MobileNetworkService.MobileNetworkServicePccRuleQosPolicyGuaranteedBitRateOutputReference>()!;
        }

        [JsiiProperty(name: "maximumBitRate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyMaximumBitRateOutputReference\"}")]
        public virtual azurerm.MobileNetworkService.MobileNetworkServicePccRuleQosPolicyMaximumBitRateOutputReference MaximumBitRate
        {
            get => GetInstanceProperty<azurerm.MobileNetworkService.MobileNetworkServicePccRuleQosPolicyMaximumBitRateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationAndRetentionPriorityLevelInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AllocationAndRetentionPriorityLevelInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "guaranteedBitRateInput", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyGuaranteedBitRate\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyGuaranteedBitRate? GuaranteedBitRateInput
        {
            get => GetInstanceProperty<azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyGuaranteedBitRate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumBitRateInput", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyMaximumBitRate\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyMaximumBitRate? MaximumBitRateInput
        {
            get => GetInstanceProperty<azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicyMaximumBitRate?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicy\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
