using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevCenterCatalog
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.devCenterCatalog.DevCenterCatalogCatalogGithub")]
    public class DevCenterCatalogCatalogGithub : azurerm.DevCenterCatalog.IDevCenterCatalogCatalogGithub
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#branch DevCenterCatalog#branch}.</summary>
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
        public string Branch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#key_vault_key_url DevCenterCatalog#key_vault_key_url}.</summary>
        [JsiiProperty(name: "keyVaultKeyUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultKeyUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#path DevCenterCatalog#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#uri DevCenterCatalog#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public string Uri
        {
            get;
            set;
        }
    }
}
