using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiByValue(fqn: "azurerm.automanageConfiguration.AutomanageConfigurationBackupSchedulePolicy")]
    public class AutomanageConfigurationBackupSchedulePolicy : azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupSchedulePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_policy_type AutomanageConfiguration#schedule_policy_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schedulePolicyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SchedulePolicyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_run_days AutomanageConfiguration#schedule_run_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleRunDays", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ScheduleRunDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_run_frequency AutomanageConfiguration#schedule_run_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleRunFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScheduleRunFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_run_times AutomanageConfiguration#schedule_run_times}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleRunTimes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ScheduleRunTimes
        {
            get;
            set;
        }
    }
}
