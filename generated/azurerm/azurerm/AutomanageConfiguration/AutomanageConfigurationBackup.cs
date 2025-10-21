using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiByValue(fqn: "azurerm.automanageConfiguration.AutomanageConfigurationBackup")]
    public class AutomanageConfigurationBackup : azurerm.AutomanageConfiguration.IAutomanageConfigurationBackup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#instant_rp_retention_range_in_days AutomanageConfiguration#instant_rp_retention_range_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instantRpRetentionRangeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstantRpRetentionRangeInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#policy_name AutomanageConfiguration#policy_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyName
        {
            get;
            set;
        }

        /// <summary>retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#retention_policy AutomanageConfiguration#retention_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicy\"}", isOptional: true)]
        public azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicy? RetentionPolicy
        {
            get;
            set;
        }

        /// <summary>schedule_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_policy AutomanageConfiguration#schedule_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schedulePolicy", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupSchedulePolicy\"}", isOptional: true)]
        public azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupSchedulePolicy? SchedulePolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#time_zone AutomanageConfiguration#time_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeZone
        {
            get;
            set;
        }
    }
}
