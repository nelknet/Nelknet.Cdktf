using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorMetricAlert
{
    [JsiiClass(nativeType: typeof(azurerm.MonitorMetricAlert.MonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaOutputReference), fullyQualifiedName: "azurerm.monitorMetricAlert.MonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComponentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failedLocationCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FailedLocationCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webTestIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WebTestIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "componentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComponentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "failedLocationCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailedLocationCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "webTestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebTestId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.monitorMetricAlert.MonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteria\"}", isOptional: true)]
        public virtual azurerm.MonitorMetricAlert.IMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteria? InternalValue
        {
            get => GetInstanceProperty<azurerm.MonitorMetricAlert.IMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
