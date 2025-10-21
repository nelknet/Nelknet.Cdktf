using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelDataConnectorMicrosoftCloudAppSecurity
{
    [JsiiByValue(fqn: "azurerm.sentinelDataConnectorMicrosoftCloudAppSecurity.SentinelDataConnectorMicrosoftCloudAppSecurityTimeouts")]
    public class SentinelDataConnectorMicrosoftCloudAppSecurityTimeouts : azurerm.SentinelDataConnectorMicrosoftCloudAppSecurity.ISentinelDataConnectorMicrosoftCloudAppSecurityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#create SentinelDataConnectorMicrosoftCloudAppSecurity#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#delete SentinelDataConnectorMicrosoftCloudAppSecurity#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#read SentinelDataConnectorMicrosoftCloudAppSecurity#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_cloud_app_security#update SentinelDataConnectorMicrosoftCloudAppSecurity#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
