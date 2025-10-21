using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NatGatewayPublicIpPrefixAssociation
{
    [JsiiInterface(nativeType: typeof(INatGatewayPublicIpPrefixAssociationTimeouts), fullyQualifiedName: "azurerm.natGatewayPublicIpPrefixAssociation.NatGatewayPublicIpPrefixAssociationTimeouts")]
    public interface INatGatewayPublicIpPrefixAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_prefix_association#create NatGatewayPublicIpPrefixAssociation#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_prefix_association#delete NatGatewayPublicIpPrefixAssociation#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_prefix_association#read NatGatewayPublicIpPrefixAssociation#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INatGatewayPublicIpPrefixAssociationTimeouts), fullyQualifiedName: "azurerm.natGatewayPublicIpPrefixAssociation.NatGatewayPublicIpPrefixAssociationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.NatGatewayPublicIpPrefixAssociation.INatGatewayPublicIpPrefixAssociationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_prefix_association#create NatGatewayPublicIpPrefixAssociation#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_prefix_association#delete NatGatewayPublicIpPrefixAssociation#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nat_gateway_public_ip_prefix_association#read NatGatewayPublicIpPrefixAssociation#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
