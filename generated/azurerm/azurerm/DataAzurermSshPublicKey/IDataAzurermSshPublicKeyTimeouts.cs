using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSshPublicKey
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSshPublicKeyTimeouts), fullyQualifiedName: "azurerm.dataAzurermSshPublicKey.DataAzurermSshPublicKeyTimeouts")]
    public interface IDataAzurermSshPublicKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ssh_public_key#read DataAzurermSshPublicKey#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSshPublicKeyTimeouts), fullyQualifiedName: "azurerm.dataAzurermSshPublicKey.DataAzurermSshPublicKeyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSshPublicKey.IDataAzurermSshPublicKeyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/ssh_public_key#read DataAzurermSshPublicKey#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
