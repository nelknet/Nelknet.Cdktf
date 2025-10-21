using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DatadogMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.datadogMonitor.DatadogMonitorDatadogOrganization")]
    public class DatadogMonitorDatadogOrganization : azurerm.DatadogMonitor.IDatadogMonitorDatadogOrganization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#api_key DatadogMonitor#api_key}.</summary>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#application_key DatadogMonitor#application_key}.</summary>
        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ApplicationKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#enterprise_app_id DatadogMonitor#enterprise_app_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enterpriseAppId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EnterpriseAppId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#linking_auth_code DatadogMonitor#linking_auth_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "linkingAuthCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LinkingAuthCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#linking_client_id DatadogMonitor#linking_client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "linkingClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LinkingClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/datadog_monitor#redirect_uri DatadogMonitor#redirect_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedirectUri
        {
            get;
            set;
        }
    }
}
