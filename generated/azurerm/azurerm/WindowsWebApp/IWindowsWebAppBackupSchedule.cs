using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiInterface(nativeType: typeof(IWindowsWebAppBackupSchedule), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppBackupSchedule")]
    public interface IWindowsWebAppBackupSchedule
    {
        /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#frequency_interval WindowsWebApp#frequency_interval}
        /// </remarks>
        [JsiiProperty(name: "frequencyInterval", typeJson: "{\"primitive\":\"number\"}")]
        double FrequencyInterval
        {
            get;
        }

        /// <summary>The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#frequency_unit WindowsWebApp#frequency_unit}
        /// </remarks>
        [JsiiProperty(name: "frequencyUnit", typeJson: "{\"primitive\":\"string\"}")]
        string FrequencyUnit
        {
            get;
        }

        /// <summary>Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#keep_at_least_one_backup WindowsWebApp#keep_at_least_one_backup}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#retention_period_days WindowsWebApp#retention_period_days}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#start_time WindowsWebApp#start_time}
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

        [JsiiTypeProxy(nativeType: typeof(IWindowsWebAppBackupSchedule), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppBackupSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.WindowsWebApp.IWindowsWebAppBackupSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#frequency_interval WindowsWebApp#frequency_interval}
            /// </remarks>
            [JsiiProperty(name: "frequencyInterval", typeJson: "{\"primitive\":\"number\"}")]
            public double FrequencyInterval
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#frequency_unit WindowsWebApp#frequency_unit}
            /// </remarks>
            [JsiiProperty(name: "frequencyUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string FrequencyUnit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#keep_at_least_one_backup WindowsWebApp#keep_at_least_one_backup}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keepAtLeastOneBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? KeepAtLeastOneBackup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>After how many days backups should be deleted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#retention_period_days WindowsWebApp#retention_period_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetentionPeriodDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>When the schedule should start working in RFC-3339 format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_web_app#start_time WindowsWebApp#start_time}
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
