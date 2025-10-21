using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventgridDomainTopic
{
    [JsiiByValue(fqn: "azurerm.dataAzurermEventgridDomainTopic.DataAzurermEventgridDomainTopicTimeouts")]
    public class DataAzurermEventgridDomainTopicTimeouts : azurerm.DataAzurermEventgridDomainTopic.IDataAzurermEventgridDomainTopicTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain_topic#read DataAzurermEventgridDomainTopic#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
