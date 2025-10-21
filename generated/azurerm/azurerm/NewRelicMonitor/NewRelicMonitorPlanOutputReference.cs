using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NewRelicMonitor
{
    [JsiiClass(nativeType: typeof(azurerm.NewRelicMonitor.NewRelicMonitorPlanOutputReference), fullyQualifiedName: "azurerm.newRelicMonitor.NewRelicMonitorPlanOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NewRelicMonitorPlanOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NewRelicMonitorPlanOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NewRelicMonitorPlanOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NewRelicMonitorPlanOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBillingCycle")]
        public virtual void ResetBillingCycle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlanId")]
        public virtual void ResetPlanId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsageType")]
        public virtual void ResetUsageType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingCycleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BillingCycleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "effectiveDateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EffectiveDateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "billingCycle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingCycle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "effectiveDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EffectiveDate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "planId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorPlan\"}", isOptional: true)]
        public virtual azurerm.NewRelicMonitor.INewRelicMonitorPlan? InternalValue
        {
            get => GetInstanceProperty<azurerm.NewRelicMonitor.INewRelicMonitorPlan?>();
            set => SetInstanceProperty(value);
        }
    }
}
