using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiByValue(fqn: "azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicy")]
    public class AutomanageConfigurationBackupRetentionPolicy : azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicy
    {
        /// <summary>daily_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#daily_schedule AutomanageConfiguration#daily_schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dailySchedule", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailySchedule\"}", isOptional: true)]
        public azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailySchedule? DailySchedule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#retention_policy_type AutomanageConfiguration#retention_policy_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPolicyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RetentionPolicyType
        {
            get;
            set;
        }

        /// <summary>weekly_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#weekly_schedule AutomanageConfiguration#weekly_schedule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "weeklySchedule", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklySchedule\"}", isOptional: true)]
        public azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklySchedule? WeeklySchedule
        {
            get;
            set;
        }
    }
}
