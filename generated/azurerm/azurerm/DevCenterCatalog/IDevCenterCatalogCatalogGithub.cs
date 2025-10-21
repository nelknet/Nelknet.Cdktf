using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevCenterCatalog
{
    [JsiiInterface(nativeType: typeof(IDevCenterCatalogCatalogGithub), fullyQualifiedName: "azurerm.devCenterCatalog.DevCenterCatalogCatalogGithub")]
    public interface IDevCenterCatalogCatalogGithub
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#branch DevCenterCatalog#branch}.</summary>
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
        string Branch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#key_vault_key_url DevCenterCatalog#key_vault_key_url}.</summary>
        [JsiiProperty(name: "keyVaultKeyUrl", typeJson: "{\"primitive\":\"string\"}")]
        string KeyVaultKeyUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#path DevCenterCatalog#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#uri DevCenterCatalog#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        string Uri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevCenterCatalogCatalogGithub), fullyQualifiedName: "azurerm.devCenterCatalog.DevCenterCatalogCatalogGithub")]
        internal sealed class _Proxy : DeputyBase, azurerm.DevCenterCatalog.IDevCenterCatalogCatalogGithub
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#branch DevCenterCatalog#branch}.</summary>
            [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
            public string Branch
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#key_vault_key_url DevCenterCatalog#key_vault_key_url}.</summary>
            [JsiiProperty(name: "keyVaultKeyUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyVaultKeyUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#path DevCenterCatalog#path}.</summary>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#uri DevCenterCatalog#uri}.</summary>
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
            public string Uri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
