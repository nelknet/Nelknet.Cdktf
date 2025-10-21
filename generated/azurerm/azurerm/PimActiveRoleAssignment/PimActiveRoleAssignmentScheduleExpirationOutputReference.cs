using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PimActiveRoleAssignment
{
    [JsiiClass(nativeType: typeof(azurerm.PimActiveRoleAssignment.PimActiveRoleAssignmentScheduleExpirationOutputReference), fullyQualifiedName: "azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentScheduleExpirationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PimActiveRoleAssignmentScheduleExpirationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PimActiveRoleAssignmentScheduleExpirationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PimActiveRoleAssignmentScheduleExpirationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PimActiveRoleAssignmentScheduleExpirationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDurationDays")]
        public virtual void ResetDurationDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDurationHours")]
        public virtual void ResetDurationHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndDateTime")]
        public virtual void ResetEndDateTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "durationDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DurationDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "durationHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DurationHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endDateTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndDateTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "durationDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DurationDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "durationHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DurationHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endDateTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndDateTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.pimActiveRoleAssignment.PimActiveRoleAssignmentScheduleExpiration\"}", isOptional: true)]
        public virtual azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentScheduleExpiration? InternalValue
        {
            get => GetInstanceProperty<azurerm.PimActiveRoleAssignment.IPimActiveRoleAssignmentScheduleExpiration?>();
            set => SetInstanceProperty(value);
        }
    }
}
