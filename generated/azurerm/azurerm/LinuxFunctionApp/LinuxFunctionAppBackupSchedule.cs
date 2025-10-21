using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.linuxFunctionApp.LinuxFunctionAppBackupSchedule")]
    public class LinuxFunctionAppBackupSchedule : azurerm.LinuxFunctionApp.ILinuxFunctionAppBackupSchedule
    {
        /// <summary>How often the backup should be executed (e.g. for weekly backup, this should be set to `7` and `frequency_unit` should be set to `Day`).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#frequency_interval LinuxFunctionApp#frequency_interval}
        /// </remarks>
        [JsiiProperty(name: "frequencyInterval", typeJson: "{\"primitive\":\"number\"}")]
        public double FrequencyInterval
        {
            get;
            set;
        }

        /// <summary>The unit of time for how often the backup should take place. Possible values include: `Day` and `Hour`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#frequency_unit LinuxFunctionApp#frequency_unit}
        /// </remarks>
        [JsiiProperty(name: "frequencyUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string FrequencyUnit
        {
            get;
            set;
        }

        private object? _keepAtLeastOneBackup;

        /// <summary>Should the service keep at least one backup, regardless of age of backup. Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#keep_at_least_one_backup LinuxFunctionApp#keep_at_least_one_backup}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keepAtLeastOneBackup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? KeepAtLeastOneBackup
        {
            get => _keepAtLeastOneBackup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keepAtLeastOneBackup = value;
            }
        }

        /// <summary>After how many days backups should be deleted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#retention_period_days LinuxFunctionApp#retention_period_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetentionPeriodDays
        {
            get;
            set;
        }

        /// <summary>When the schedule should start working in RFC-3339 format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_function_app#start_time LinuxFunctionApp#start_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartTime
        {
            get;
            set;
        }
    }
}
