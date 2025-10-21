using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PrivateEndpoint
{
    [JsiiInterface(nativeType: typeof(IPrivateEndpointPrivateServiceConnection), fullyQualifiedName: "azurerm.privateEndpoint.PrivateEndpointPrivateServiceConnection")]
    public interface IPrivateEndpointPrivateServiceConnection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#is_manual_connection PrivateEndpoint#is_manual_connection}.</summary>
        [JsiiProperty(name: "isManualConnection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object IsManualConnection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#name PrivateEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#private_connection_resource_alias PrivateEndpoint#private_connection_resource_alias}.</summary>
        [JsiiProperty(name: "privateConnectionResourceAlias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateConnectionResourceAlias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#private_connection_resource_id PrivateEndpoint#private_connection_resource_id}.</summary>
        [JsiiProperty(name: "privateConnectionResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateConnectionResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#request_message PrivateEndpoint#request_message}.</summary>
        [JsiiProperty(name: "requestMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RequestMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#subresource_names PrivateEndpoint#subresource_names}.</summary>
        [JsiiProperty(name: "subresourceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubresourceNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPrivateEndpointPrivateServiceConnection), fullyQualifiedName: "azurerm.privateEndpoint.PrivateEndpointPrivateServiceConnection")]
        internal sealed class _Proxy : DeputyBase, azurerm.PrivateEndpoint.IPrivateEndpointPrivateServiceConnection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#is_manual_connection PrivateEndpoint#is_manual_connection}.</summary>
            [JsiiProperty(name: "isManualConnection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object IsManualConnection
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#name PrivateEndpoint#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#private_connection_resource_alias PrivateEndpoint#private_connection_resource_alias}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateConnectionResourceAlias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateConnectionResourceAlias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#private_connection_resource_id PrivateEndpoint#private_connection_resource_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateConnectionResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateConnectionResourceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#request_message PrivateEndpoint#request_message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RequestMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#subresource_names PrivateEndpoint#subresource_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subresourceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubresourceNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
