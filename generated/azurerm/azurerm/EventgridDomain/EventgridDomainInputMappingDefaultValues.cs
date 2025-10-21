using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridDomain
{
    [JsiiByValue(fqn: "azurerm.eventgridDomain.EventgridDomainInputMappingDefaultValues")]
    public class EventgridDomainInputMappingDefaultValues : azurerm.EventgridDomain.IEventgridDomainInputMappingDefaultValues
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#data_version EventgridDomain#data_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#event_type EventgridDomain#event_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#subject EventgridDomain#subject}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Subject
        {
            get;
            set;
        }
    }
}
