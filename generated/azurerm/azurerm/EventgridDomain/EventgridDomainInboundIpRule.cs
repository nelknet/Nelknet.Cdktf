using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridDomain
{
    [JsiiByValue(fqn: "azurerm.eventgridDomain.EventgridDomainInboundIpRule")]
    public class EventgridDomainInboundIpRule : azurerm.EventgridDomain.IEventgridDomainInboundIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#action EventgridDomain#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventgrid_domain#ip_mask EventgridDomain#ip_mask}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipMask", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpMask
        {
            get;
            set;
        }
    }
}
