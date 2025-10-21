using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hpcCache.HpcCacheDirectoryFlatFile")]
    public class HpcCacheDirectoryFlatFile : azurerm.HpcCache.IHpcCacheDirectoryFlatFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#group_file_uri HpcCache#group_file_uri}.</summary>
        [JsiiProperty(name: "groupFileUri", typeJson: "{\"primitive\":\"string\"}")]
        public string GroupFileUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#password_file_uri HpcCache#password_file_uri}.</summary>
        [JsiiProperty(name: "passwordFileUri", typeJson: "{\"primitive\":\"string\"}")]
        public string PasswordFileUri
        {
            get;
            set;
        }
    }
}
