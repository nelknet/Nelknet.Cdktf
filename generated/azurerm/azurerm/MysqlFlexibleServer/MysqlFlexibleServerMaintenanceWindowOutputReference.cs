using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MysqlFlexibleServer
{
    [JsiiClass(nativeType: typeof(azurerm.MysqlFlexibleServer.MysqlFlexibleServerMaintenanceWindowOutputReference), fullyQualifiedName: "azurerm.mysqlFlexibleServer.MysqlFlexibleServerMaintenanceWindowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MysqlFlexibleServerMaintenanceWindowOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MysqlFlexibleServerMaintenanceWindowOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MysqlFlexibleServerMaintenanceWindowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlFlexibleServerMaintenanceWindowOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDayOfWeek")]
        public virtual void ResetDayOfWeek()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartHour")]
        public virtual void ResetStartHour()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartMinute")]
        public virtual void ResetStartMinute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeekInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DayOfWeekInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startHourInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StartHourInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startMinuteInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StartMinuteInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DayOfWeek
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartHour
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startMinute", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartMinute
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerMaintenanceWindow\"}", isOptional: true)]
        public virtual azurerm.MysqlFlexibleServer.IMysqlFlexibleServerMaintenanceWindow? InternalValue
        {
            get => GetInstanceProperty<azurerm.MysqlFlexibleServer.IMysqlFlexibleServerMaintenanceWindow?>();
            set => SetInstanceProperty(value);
        }
    }
}
