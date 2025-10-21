using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiClass(nativeType: typeof(azurerm.AutomanageConfiguration.AutomanageConfigurationBackupRetentionPolicyOutputReference), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutomanageConfigurationBackupRetentionPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutomanageConfigurationBackupRetentionPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutomanageConfigurationBackupRetentionPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomanageConfigurationBackupRetentionPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDailySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailySchedule\"}}]")]
        public virtual void PutDailySchedule(azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailySchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailySchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWeeklySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklySchedule\"}}]")]
        public virtual void PutWeeklySchedule(azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklySchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklySchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDailySchedule")]
        public virtual void ResetDailySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionPolicyType")]
        public virtual void ResetRetentionPolicyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeeklySchedule")]
        public virtual void ResetWeeklySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dailySchedule", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailyScheduleOutputReference\"}")]
        public virtual azurerm.AutomanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailyScheduleOutputReference DailySchedule
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailyScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "weeklySchedule", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklyScheduleOutputReference\"}")]
        public virtual azurerm.AutomanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklyScheduleOutputReference WeeklySchedule
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklyScheduleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dailyScheduleInput", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailySchedule\"}", isOptional: true)]
        public virtual azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailySchedule? DailyScheduleInput
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailySchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPolicyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RetentionPolicyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weeklyScheduleInput", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklySchedule\"}", isOptional: true)]
        public virtual azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklySchedule? WeeklyScheduleInput
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklySchedule?>();
        }

        [JsiiProperty(name: "retentionPolicyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetentionPolicyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicy\"}", isOptional: true)]
        public virtual azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicy? InternalValue
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
