using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection
{
    [JsiiByValue(fqn: "azurerm.sentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionTimeouts")]
    public class SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionTimeouts : azurerm.SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection.ISentinelDataConnectorMicrosoftDefenderAdvancedThreatProtectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_defender_advanced_threat_protection#create SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_defender_advanced_threat_protection#delete SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_defender_advanced_threat_protection#read SentinelDataConnectorMicrosoftDefenderAdvancedThreatProtection#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
