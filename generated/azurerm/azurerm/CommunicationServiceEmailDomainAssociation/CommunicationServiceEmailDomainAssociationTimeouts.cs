using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CommunicationServiceEmailDomainAssociation
{
    [JsiiByValue(fqn: "azurerm.communicationServiceEmailDomainAssociation.CommunicationServiceEmailDomainAssociationTimeouts")]
    public class CommunicationServiceEmailDomainAssociationTimeouts : azurerm.CommunicationServiceEmailDomainAssociation.ICommunicationServiceEmailDomainAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service_email_domain_association#create CommunicationServiceEmailDomainAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service_email_domain_association#delete CommunicationServiceEmailDomainAssociation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/communication_service_email_domain_association#read CommunicationServiceEmailDomainAssociation#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
