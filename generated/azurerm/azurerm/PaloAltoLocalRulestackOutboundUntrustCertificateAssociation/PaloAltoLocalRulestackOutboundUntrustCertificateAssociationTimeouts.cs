using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation
{
    [JsiiByValue(fqn: "azurerm.paloAltoLocalRulestackOutboundUntrustCertificateAssociation.PaloAltoLocalRulestackOutboundUntrustCertificateAssociationTimeouts")]
    public class PaloAltoLocalRulestackOutboundUntrustCertificateAssociationTimeouts : azurerm.PaloAltoLocalRulestackOutboundUntrustCertificateAssociation.IPaloAltoLocalRulestackOutboundUntrustCertificateAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_untrust_certificate_association#create PaloAltoLocalRulestackOutboundUntrustCertificateAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_untrust_certificate_association#delete PaloAltoLocalRulestackOutboundUntrustCertificateAssociation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_untrust_certificate_association#read PaloAltoLocalRulestackOutboundUntrustCertificateAssociation#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
