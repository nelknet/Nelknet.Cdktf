using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventgridSystemTopic
{
    [JsiiByValue(fqn: "azurerm.dataAzurermEventgridSystemTopic.DataAzurermEventgridSystemTopicTimeouts")]
    public class DataAzurermEventgridSystemTopicTimeouts : azurerm.DataAzurermEventgridSystemTopic.IDataAzurermEventgridSystemTopicTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_system_topic#read DataAzurermEventgridSystemTopic#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
