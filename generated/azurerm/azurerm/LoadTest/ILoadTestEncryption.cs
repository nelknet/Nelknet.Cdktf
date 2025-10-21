using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LoadTest
{
    [JsiiInterface(nativeType: typeof(ILoadTestEncryption), fullyQualifiedName: "azurerm.loadTest.LoadTestEncryption")]
    public interface ILoadTestEncryption
    {
        /// <summary>identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#identity LoadTest#identity}
        /// </remarks>
        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.loadTest.LoadTestEncryptionIdentity\"}")]
        azurerm.LoadTest.ILoadTestEncryptionIdentity Identity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#key_url LoadTest#key_url}.</summary>
        [JsiiProperty(name: "keyUrl", typeJson: "{\"primitive\":\"string\"}")]
        string KeyUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadTestEncryption), fullyQualifiedName: "azurerm.loadTest.LoadTestEncryption")]
        internal sealed class _Proxy : DeputyBase, azurerm.LoadTest.ILoadTestEncryption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#identity LoadTest#identity}
            /// </remarks>
            [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.loadTest.LoadTestEncryptionIdentity\"}")]
            public azurerm.LoadTest.ILoadTestEncryptionIdentity Identity
            {
                get => GetInstanceProperty<azurerm.LoadTest.ILoadTestEncryptionIdentity>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#key_url LoadTest#key_url}.</summary>
            [JsiiProperty(name: "keyUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
