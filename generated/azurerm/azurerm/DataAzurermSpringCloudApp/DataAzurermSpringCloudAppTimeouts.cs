using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSpringCloudApp
{
    [JsiiByValue(fqn: "azurerm.dataAzurermSpringCloudApp.DataAzurermSpringCloudAppTimeouts")]
    public class DataAzurermSpringCloudAppTimeouts : azurerm.DataAzurermSpringCloudApp.IDataAzurermSpringCloudAppTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_app#read DataAzurermSpringCloudApp#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
