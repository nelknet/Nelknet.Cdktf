using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.StoragegatewayGateway
{
    [JsiiClass(nativeType: typeof(aws.StoragegatewayGateway.StoragegatewayGatewayMaintenanceStartTimeOutputReference), fullyQualifiedName: "aws.storagegatewayGateway.StoragegatewayGatewayMaintenanceStartTimeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StoragegatewayGatewayMaintenanceStartTimeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StoragegatewayGatewayMaintenanceStartTimeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StoragegatewayGatewayMaintenanceStartTimeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StoragegatewayGatewayMaintenanceStartTimeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDayOfMonth")]
        public virtual void ResetDayOfMonth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDayOfWeek")]
        public virtual void ResetDayOfWeek()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinuteOfHour")]
        public virtual void ResetMinuteOfHour()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dayOfMonthInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DayOfMonthInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeekInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DayOfWeekInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hourOfDayInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HourOfDayInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minuteOfHourInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinuteOfHourInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DayOfMonth
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DayOfWeek
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HourOfDay
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minuteOfHour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinuteOfHour
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.storagegatewayGateway.StoragegatewayGatewayMaintenanceStartTime\"}", isOptional: true)]
        public virtual aws.StoragegatewayGateway.IStoragegatewayGatewayMaintenanceStartTime? InternalValue
        {
            get => GetInstanceProperty<aws.StoragegatewayGateway.IStoragegatewayGatewayMaintenanceStartTime?>();
            set => SetInstanceProperty(value);
        }
    }
}
