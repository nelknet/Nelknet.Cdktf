using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTokenPassword
{
    [JsiiInterface(nativeType: typeof(IContainerRegistryTokenPasswordPassword2), fullyQualifiedName: "azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2")]
    public interface IContainerRegistryTokenPasswordPassword2
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#expiry ContainerRegistryTokenPassword#expiry}.</summary>
        [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expiry
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRegistryTokenPasswordPassword2), fullyQualifiedName: "azurerm.containerRegistryTokenPassword.ContainerRegistryTokenPasswordPassword2")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerRegistryTokenPassword.IContainerRegistryTokenPasswordPassword2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token_password#expiry ContainerRegistryTokenPassword#expiry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expiry
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
