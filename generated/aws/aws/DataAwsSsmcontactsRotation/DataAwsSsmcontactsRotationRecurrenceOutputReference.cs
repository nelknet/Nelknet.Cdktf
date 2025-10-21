using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSsmcontactsRotation
{
    [JsiiClass(nativeType: typeof(aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceOutputReference), fullyQualifiedName: "aws.dataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsSsmcontactsRotationRecurrenceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsSsmcontactsRotationRecurrenceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSsmcontactsRotationRecurrenceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSsmcontactsRotationRecurrenceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dailySettings", typeJson: "{\"fqn\":\"aws.dataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceDailySettingsList\"}")]
        public virtual aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceDailySettingsList DailySettings
        {
            get => GetInstanceProperty<aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceDailySettingsList>()!;
        }

        [JsiiProperty(name: "monthlySettings", typeJson: "{\"fqn\":\"aws.dataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceMonthlySettingsList\"}")]
        public virtual aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceMonthlySettingsList MonthlySettings
        {
            get => GetInstanceProperty<aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceMonthlySettingsList>()!;
        }

        [JsiiProperty(name: "numberOfOnCalls", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfOnCalls
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "recurrenceMultiplier", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecurrenceMultiplier
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shiftCoverages", typeJson: "{\"fqn\":\"aws.dataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceShiftCoveragesList\"}")]
        public virtual aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceShiftCoveragesList ShiftCoverages
        {
            get => GetInstanceProperty<aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceShiftCoveragesList>()!;
        }

        [JsiiProperty(name: "weeklySettings", typeJson: "{\"fqn\":\"aws.dataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceWeeklySettingsList\"}")]
        public virtual aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceWeeklySettingsList WeeklySettings
        {
            get => GetInstanceProperty<aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrenceWeeklySettingsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationRecurrence\"}", isOptional: true)]
        public virtual aws.DataAwsSsmcontactsRotation.IDataAwsSsmcontactsRotationRecurrence? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsSsmcontactsRotation.IDataAwsSsmcontactsRotationRecurrence?>();
            set => SetInstanceProperty(value);
        }
    }
}
