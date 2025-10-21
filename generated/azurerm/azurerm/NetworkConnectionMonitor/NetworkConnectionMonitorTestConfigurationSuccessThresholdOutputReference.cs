using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetworkConnectionMonitor
{
    [JsiiClass(nativeType: typeof(azurerm.NetworkConnectionMonitor.NetworkConnectionMonitorTestConfigurationSuccessThresholdOutputReference), fullyQualifiedName: "azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationSuccessThresholdOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetworkConnectionMonitorTestConfigurationSuccessThresholdOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetworkConnectionMonitorTestConfigurationSuccessThresholdOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NetworkConnectionMonitorTestConfigurationSuccessThresholdOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkConnectionMonitorTestConfigurationSuccessThresholdOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetChecksFailedPercent")]
        public virtual void ResetChecksFailedPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoundTripTimeMs")]
        public virtual void ResetRoundTripTimeMs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "checksFailedPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ChecksFailedPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roundTripTimeMsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RoundTripTimeMsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "checksFailedPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ChecksFailedPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roundTripTimeMs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RoundTripTimeMs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.networkConnectionMonitor.NetworkConnectionMonitorTestConfigurationSuccessThreshold\"}", isOptional: true)]
        public virtual azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationSuccessThreshold? InternalValue
        {
            get => GetInstanceProperty<azurerm.NetworkConnectionMonitor.INetworkConnectionMonitorTestConfigurationSuccessThreshold?>();
            set => SetInstanceProperty(value);
        }
    }
}
