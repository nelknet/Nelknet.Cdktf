using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDigitalTwinsInstance
{
    [JsiiByValue(fqn: "azurerm.dataAzurermDigitalTwinsInstance.DataAzurermDigitalTwinsInstanceTimeouts")]
    public class DataAzurermDigitalTwinsInstanceTimeouts : azurerm.DataAzurermDigitalTwinsInstance.IDataAzurermDigitalTwinsInstanceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/digital_twins_instance#read DataAzurermDigitalTwinsInstance#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
