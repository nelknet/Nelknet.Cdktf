using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsFunctionApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.windowsFunctionApp.WindowsFunctionAppAuthSettingsV2AzureStaticWebAppV2")]
    public class WindowsFunctionAppAuthSettingsV2AzureStaticWebAppV2 : azurerm.WindowsFunctionApp.IWindowsFunctionAppAuthSettingsV2AzureStaticWebAppV2
    {
        /// <summary>The ID of the Client to use to authenticate with Azure Static Web App Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/windows_function_app#client_id WindowsFunctionApp#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientId
        {
            get;
            set;
        }
    }
}
