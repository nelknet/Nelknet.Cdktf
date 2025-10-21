using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiByValue(fqn: "azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailySchedule")]
    public class AutomanageConfigurationBackupRetentionPolicyDailySchedule : azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailySchedule
    {
        /// <summary>retention_duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#retention_duration AutomanageConfiguration#retention_duration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retentionDuration", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailyScheduleRetentionDuration\"}", isOptional: true)]
        public azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailyScheduleRetentionDuration? RetentionDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#retention_times AutomanageConfiguration#retention_times}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionTimes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RetentionTimes
        {
            get;
            set;
        }
    }
}
