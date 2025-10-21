using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LoadTest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.loadTest.LoadTestEncryption")]
    public class LoadTestEncryption : azurerm.LoadTest.ILoadTestEncryption
    {
        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#identity LoadTest#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.loadTest.LoadTestEncryptionIdentity\"}")]
        public azurerm.LoadTest.ILoadTestEncryptionIdentity Identity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#key_url LoadTest#key_url}.</summary>
        [JsiiProperty(name: "keyUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyUrl
        {
            get;
            set;
        }
    }
}
