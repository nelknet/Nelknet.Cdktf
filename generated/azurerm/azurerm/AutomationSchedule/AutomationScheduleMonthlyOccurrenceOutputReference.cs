using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSchedule
{
    [JsiiClass(nativeType: typeof(azurerm.AutomationSchedule.AutomationScheduleMonthlyOccurrenceOutputReference), fullyQualifiedName: "azurerm.automationSchedule.AutomationScheduleMonthlyOccurrenceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutomationScheduleMonthlyOccurrenceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutomationScheduleMonthlyOccurrenceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutomationScheduleMonthlyOccurrenceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomationScheduleMonthlyOccurrenceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "dayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DayInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "occurrenceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OccurrenceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Day
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "occurrence", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Occurrence
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.automationSchedule.AutomationScheduleMonthlyOccurrence\"}", isOptional: true)]
        public virtual azurerm.AutomationSchedule.IAutomationScheduleMonthlyOccurrence? InternalValue
        {
            get => GetInstanceProperty<azurerm.AutomationSchedule.IAutomationScheduleMonthlyOccurrence?>();
            set => SetInstanceProperty(value);
        }
    }
}
