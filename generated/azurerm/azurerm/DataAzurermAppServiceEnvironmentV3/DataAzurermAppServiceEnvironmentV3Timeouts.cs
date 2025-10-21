using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppServiceEnvironmentV3
{
    [JsiiByValue(fqn: "azurerm.dataAzurermAppServiceEnvironmentV3.DataAzurermAppServiceEnvironmentV3Timeouts")]
    public class DataAzurermAppServiceEnvironmentV3Timeouts : azurerm.DataAzurermAppServiceEnvironmentV3.IDataAzurermAppServiceEnvironmentV3Timeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_environment_v3#read DataAzurermAppServiceEnvironmentV3#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
