using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PrivateEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.privateEndpoint.PrivateEndpointIpConfiguration")]
    public class PrivateEndpointIpConfiguration : azurerm.PrivateEndpoint.IPrivateEndpointIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#name PrivateEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#private_ip_address PrivateEndpoint#private_ip_address}.</summary>
        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#member_name PrivateEndpoint#member_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memberName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MemberName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#subresource_name PrivateEndpoint#subresource_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subresourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubresourceName
        {
            get;
            set;
        }
    }
}
