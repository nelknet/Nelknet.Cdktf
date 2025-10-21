using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LoadTest
{
    [JsiiInterface(nativeType: typeof(ILoadTestEncryptionIdentity), fullyQualifiedName: "azurerm.loadTest.LoadTestEncryptionIdentity")]
    public interface ILoadTestEncryptionIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#identity_id LoadTest#identity_id}.</summary>
        [JsiiProperty(name: "identityId", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#type LoadTest#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadTestEncryptionIdentity), fullyQualifiedName: "azurerm.loadTest.LoadTestEncryptionIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.LoadTest.ILoadTestEncryptionIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#identity_id LoadTest#identity_id}.</summary>
            [JsiiProperty(name: "identityId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/load_test#type LoadTest#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
