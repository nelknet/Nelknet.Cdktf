using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CustomerprofilesDomain
{
    [JsiiClass(nativeType: typeof(aws.CustomerprofilesDomain.CustomerprofilesDomainMatchingJobScheduleOutputReference), fullyQualifiedName: "aws.customerprofilesDomain.CustomerprofilesDomainMatchingJobScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CustomerprofilesDomainMatchingJobScheduleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CustomerprofilesDomainMatchingJobScheduleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CustomerprofilesDomainMatchingJobScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CustomerprofilesDomainMatchingJobScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "dayOfTheWeekInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DayOfTheWeekInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dayOfTheWeek", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DayOfTheWeek
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Time
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.customerprofilesDomain.CustomerprofilesDomainMatchingJobSchedule\"}", isOptional: true)]
        public virtual aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingJobSchedule? InternalValue
        {
            get => GetInstanceProperty<aws.CustomerprofilesDomain.ICustomerprofilesDomainMatchingJobSchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
