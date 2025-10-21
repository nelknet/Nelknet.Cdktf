using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkAttachedDataNetwork
{
    [JsiiClass(nativeType: typeof(azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference), fullyQualifiedName: "azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationPortRange\"}}]")]
        public virtual void PutPortRange(azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationPortRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationPortRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIcmpPinholeTimeoutInSeconds")]
        public virtual void ResetIcmpPinholeTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPinholeMaximumNumber")]
        public virtual void ResetPinholeMaximumNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPortRange")]
        public virtual void ResetPortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTcpPinholeTimeoutInSeconds")]
        public virtual void ResetTcpPinholeTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTcpPortReuseMinimumHoldTimeInSeconds")]
        public virtual void ResetTcpPortReuseMinimumHoldTimeInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUdpPinholeTimeoutInSeconds")]
        public virtual void ResetUdpPinholeTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUdpPortReuseMinimumHoldTimeInSeconds")]
        public virtual void ResetUdpPortReuseMinimumHoldTimeInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "portRange", typeJson: "{\"fqn\":\"azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationPortRangeOutputReference\"}")]
        public virtual azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationPortRangeOutputReference PortRange
        {
            get => GetInstanceProperty<azurerm.MobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationPortRangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "icmpPinholeTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IcmpPinholeTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pinholeMaximumNumberInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PinholeMaximumNumberInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portRangeInput", typeJson: "{\"fqn\":\"azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslationPortRange\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationPortRange? PortRangeInput
        {
            get => GetInstanceProperty<azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationPortRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpPinholeTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TcpPinholeTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpPortReuseMinimumHoldTimeInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TcpPortReuseMinimumHoldTimeInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "udpPinholeTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UdpPinholeTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "udpPortReuseMinimumHoldTimeInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UdpPortReuseMinimumHoldTimeInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "icmpPinholeTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IcmpPinholeTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pinholeMaximumNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PinholeMaximumNumber
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tcpPinholeTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TcpPinholeTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tcpPortReuseMinimumHoldTimeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TcpPortReuseMinimumHoldTimeInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "udpPinholeTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UdpPinholeTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "udpPortReuseMinimumHoldTimeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UdpPortReuseMinimumHoldTimeInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.mobileNetworkAttachedDataNetwork.MobileNetworkAttachedDataNetworkNetworkAddressPortTranslation\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkNetworkAddressPortTranslation? InternalValue
        {
            get => GetInstanceProperty<azurerm.MobileNetworkAttachedDataNetwork.IMobileNetworkAttachedDataNetworkNetworkAddressPortTranslation?>();
            set => SetInstanceProperty(value);
        }
    }
}
