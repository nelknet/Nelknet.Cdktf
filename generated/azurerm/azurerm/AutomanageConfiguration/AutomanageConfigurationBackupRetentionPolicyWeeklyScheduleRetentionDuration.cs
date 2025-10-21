using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiByValue(fqn: "azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklyScheduleRetentionDuration")]
    public class AutomanageConfigurationBackupRetentionPolicyWeeklyScheduleRetentionDuration : azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklyScheduleRetentionDuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#count AutomanageConfiguration#count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#duration_type AutomanageConfiguration#duration_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "durationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DurationType
        {
            get;
            set;
        }
    }
}
