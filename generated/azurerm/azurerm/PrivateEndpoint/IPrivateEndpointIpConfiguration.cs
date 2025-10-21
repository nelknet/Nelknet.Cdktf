using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PrivateEndpoint
{
    [JsiiInterface(nativeType: typeof(IPrivateEndpointIpConfiguration), fullyQualifiedName: "azurerm.privateEndpoint.PrivateEndpointIpConfiguration")]
    public interface IPrivateEndpointIpConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#name PrivateEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#private_ip_address PrivateEndpoint#private_ip_address}.</summary>
        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateIpAddress
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#member_name PrivateEndpoint#member_name}.</summary>
        [JsiiProperty(name: "memberName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MemberName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#subresource_name PrivateEndpoint#subresource_name}.</summary>
        [JsiiProperty(name: "subresourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubresourceName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrivateEndpointIpConfiguration), fullyQualifiedName: "azurerm.privateEndpoint.PrivateEndpointIpConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.PrivateEndpoint.IPrivateEndpointIpConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#name PrivateEndpoint#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#private_ip_address PrivateEndpoint#private_ip_address}.</summary>
            [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateIpAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#member_name PrivateEndpoint#member_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memberName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MemberName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#subresource_name PrivateEndpoint#subresource_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subresourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubresourceName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
