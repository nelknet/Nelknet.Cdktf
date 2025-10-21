using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoLocalRulestackOutboundTrustCertificateAssociation
{
    [JsiiInterface(nativeType: typeof(IPaloAltoLocalRulestackOutboundTrustCertificateAssociationTimeouts), fullyQualifiedName: "azurerm.paloAltoLocalRulestackOutboundTrustCertificateAssociation.PaloAltoLocalRulestackOutboundTrustCertificateAssociationTimeouts")]
    public interface IPaloAltoLocalRulestackOutboundTrustCertificateAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_trust_certificate_association#create PaloAltoLocalRulestackOutboundTrustCertificateAssociation#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_trust_certificate_association#delete PaloAltoLocalRulestackOutboundTrustCertificateAssociation#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_trust_certificate_association#read PaloAltoLocalRulestackOutboundTrustCertificateAssociation#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaloAltoLocalRulestackOutboundTrustCertificateAssociationTimeouts), fullyQualifiedName: "azurerm.paloAltoLocalRulestackOutboundTrustCertificateAssociation.PaloAltoLocalRulestackOutboundTrustCertificateAssociationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.PaloAltoLocalRulestackOutboundTrustCertificateAssociation.IPaloAltoLocalRulestackOutboundTrustCertificateAssociationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_trust_certificate_association#create PaloAltoLocalRulestackOutboundTrustCertificateAssociation#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_trust_certificate_association#delete PaloAltoLocalRulestackOutboundTrustCertificateAssociation#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/palo_alto_local_rulestack_outbound_trust_certificate_association#read PaloAltoLocalRulestackOutboundTrustCertificateAssociation#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
