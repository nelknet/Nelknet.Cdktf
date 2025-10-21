using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNginxDeployment
{
    [JsiiByValue(fqn: "azurerm.dataAzurermNginxDeployment.DataAzurermNginxDeploymentTimeouts")]
    public class DataAzurermNginxDeploymentTimeouts : azurerm.DataAzurermNginxDeployment.IDataAzurermNginxDeploymentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_deployment#read DataAzurermNginxDeployment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
