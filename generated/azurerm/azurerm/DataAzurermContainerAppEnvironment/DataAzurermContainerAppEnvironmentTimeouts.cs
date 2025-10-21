using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermContainerAppEnvironment
{
    [JsiiByValue(fqn: "azurerm.dataAzurermContainerAppEnvironment.DataAzurermContainerAppEnvironmentTimeouts")]
    public class DataAzurermContainerAppEnvironmentTimeouts : azurerm.DataAzurermContainerAppEnvironment.IDataAzurermContainerAppEnvironmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_app_environment#read DataAzurermContainerAppEnvironment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
