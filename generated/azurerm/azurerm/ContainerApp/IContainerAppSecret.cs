using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerApp
{
    [JsiiInterface(nativeType: typeof(IContainerAppSecret), fullyQualifiedName: "azurerm.containerApp.ContainerAppSecret")]
    public interface IContainerAppSecret
    {
        /// <summary>The secret name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#name ContainerApp#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The identity to use for accessing key vault reference.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#identity ContainerApp#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Identity
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#key_vault_secret_id ContainerApp#key_vault_secret_id}
        /// </remarks>
        [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyVaultSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The value for this secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#value ContainerApp#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerAppSecret), fullyQualifiedName: "azurerm.containerApp.ContainerAppSecret")]
        internal sealed class _Proxy : DeputyBase, azurerm.ContainerApp.IContainerAppSecret
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The secret name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#name ContainerApp#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The identity to use for accessing key vault reference.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#identity ContainerApp#identity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Identity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#key_vault_secret_id ContainerApp#key_vault_secret_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyVaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyVaultSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The value for this secret.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app#value ContainerApp#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
