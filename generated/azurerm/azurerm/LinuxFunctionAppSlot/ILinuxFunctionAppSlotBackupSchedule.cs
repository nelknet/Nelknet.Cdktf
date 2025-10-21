using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionAppSlot
{
    [JsiiInterface(nativeType: typeof(ILinuxFunctionAppSlotBackupSchedule), fullyQualifiedName: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotBackupSchedule")]
    public interface ILinuxFunctionAppSlotBackupSchedule
    {
        /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#frequency_interval LinuxFunctionAppSlot#frequency_interval}
        /// </remarks>
        [JsiiProperty(name: "frequencyInterval", typeJson: "{\"primitive\":\"number\"}")]
        double FrequencyInterval
        {
            get;
        }

        /// <summary>The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#frequency_unit LinuxFunctionAppSlot#frequency_unit}
        /// </remarks>
        [JsiiProperty(name: "frequencyUnit", typeJson: "{\"primitive\":\"string\"}")]
        string FrequencyUnit
        {
            get;
        }

        /// <summary>Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#keep_at_least_one_backup LinuxFunctionAppSlot#keep_at_least_one_backup}
        /// </remarks>
        [JsiiProperty(name: "keepAtLeastOneBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KeepAtLeastOneBackup
        {
            get
            {
                return null;
            }
        }

        /// <summary>After how many days backups should be deleted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#retention_period_days LinuxFunctionAppSlot#retention_period_days}
        /// </remarks>
        [JsiiProperty(name: "retentionPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetentionPeriodDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>When the schedule should start working in RFC-3339 format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#start_time LinuxFunctionAppSlot#start_time}
        /// </remarks>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxFunctionAppSlotBackupSchedule), fullyQualifiedName: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotBackupSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotBackupSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#frequency_interval LinuxFunctionAppSlot#frequency_interval}
            /// </remarks>
            [JsiiProperty(name: "frequencyInterval", typeJson: "{\"primitive\":\"number\"}")]
            public double FrequencyInterval
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#frequency_unit LinuxFunctionAppSlot#frequency_unit}
            /// </remarks>
            [JsiiProperty(name: "frequencyUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string FrequencyUnit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#keep_at_least_one_backup LinuxFunctionAppSlot#keep_at_least_one_backup}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keepAtLeastOneBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? KeepAtLeastOneBackup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>After how many days backups should be deleted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#retention_period_days LinuxFunctionAppSlot#retention_period_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPeriodDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>When the schedule should start working in RFC-3339 format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app_slot#start_time LinuxFunctionAppSlot#start_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
