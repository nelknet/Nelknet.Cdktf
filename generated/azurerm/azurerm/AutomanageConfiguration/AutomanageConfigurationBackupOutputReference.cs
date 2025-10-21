using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiClass(nativeType: typeof(azurerm.AutomanageConfiguration.AutomanageConfigurationBackupOutputReference), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationBackupOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutomanageConfigurationBackupOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutomanageConfigurationBackupOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutomanageConfigurationBackupOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomanageConfigurationBackupOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRetentionPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicy\"}}]")]
        public virtual void PutRetentionPolicy(azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedulePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupSchedulePolicy\"}}]")]
        public virtual void PutSchedulePolicy(azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupSchedulePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupSchedulePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInstantRpRetentionRangeInDays")]
        public virtual void ResetInstantRpRetentionRangeInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicyName")]
        public virtual void ResetPolicyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionPolicy")]
        public virtual void ResetRetentionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedulePolicy")]
        public virtual void ResetSchedulePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeZone")]
        public virtual void ResetTimeZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyOutputReference\"}")]
        public virtual azurerm.AutomanageConfiguration.AutomanageConfigurationBackupRetentionPolicyOutputReference RetentionPolicy
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.AutomanageConfigurationBackupRetentionPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "schedulePolicy", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupSchedulePolicyOutputReference\"}")]
        public virtual azurerm.AutomanageConfiguration.AutomanageConfigurationBackupSchedulePolicyOutputReference SchedulePolicy
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.AutomanageConfigurationBackupSchedulePolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instantRpRetentionRangeInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstantRpRetentionRangeInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPolicyInput", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicy\"}", isOptional: true)]
        public virtual azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicy? RetentionPolicyInput
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulePolicyInput", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupSchedulePolicy\"}", isOptional: true)]
        public virtual azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupSchedulePolicy? SchedulePolicyInput
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupSchedulePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "instantRpRetentionRangeInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstantRpRetentionRangeInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackup\"}", isOptional: true)]
        public virtual azurerm.AutomanageConfiguration.IAutomanageConfigurationBackup? InternalValue
        {
            get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackup?>();
            set => SetInstanceProperty(value);
        }
    }
}
