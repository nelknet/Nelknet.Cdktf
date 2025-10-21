using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CustomProvider
{
    [JsiiInterface(nativeType: typeof(ICustomProviderResourceType), fullyQualifiedName: "azurerm.customProvider.CustomProviderResourceType")]
    public interface ICustomProviderResourceType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#endpoint CustomProvider#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        string Endpoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#name CustomProvider#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#routing_type CustomProvider#routing_type}.</summary>
        [JsiiProperty(name: "routingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoutingType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomProviderResourceType), fullyQualifiedName: "azurerm.customProvider.CustomProviderResourceType")]
        internal sealed class _Proxy : DeputyBase, azurerm.CustomProvider.ICustomProviderResourceType
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#endpoint CustomProvider#endpoint}.</summary>
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string Endpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#name CustomProvider#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#routing_type CustomProvider#routing_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoutingType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
