using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiClass(nativeType: typeof(azurerm.AutomanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailyScheduleOutputReference), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailyScheduleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutomanageConfigurationBackupRetentionPolicyDailyScheduleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutomanageConfigurationBackupRetentionPolicyDailyScheduleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutomanageConfigurationBackupRetentionPolicyDailyScheduleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomanageConfigurationBackupRetentionPolicyDailyScheduleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRetentionDuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailyScheduleRetentionDuration\"}}]")]
        public virtual void PutRetentionDuration(azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailyScheduleRetentionDuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailyScheduleRetentionDuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRetentionDuration")]
        public virtual void ResetRetentionDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionTimes")]
        public virtual void ResetRetentionTimes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "retentionDuration", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailyScheduleRetentionDurationOutputReference\"}")]
        public virtual azurerm.AutomanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailyScheduleRetentionDurationOutputReference RetentionDuration
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailyScheduleRetentionDurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionDurationInput", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailyScheduleRetentionDuration\"}", isOptional: true)]
        public virtual azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailyScheduleRetentionDuration? RetentionDurationInput
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailyScheduleRetentionDuration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionTimesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RetentionTimesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "retentionTimes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RetentionTimes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailySchedule\"}", isOptional: true)]
        public virtual azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailySchedule? InternalValue
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailySchedule?>();
            set => SetInstanceProperty(value);
        }
    }
}
