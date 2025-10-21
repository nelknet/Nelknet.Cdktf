using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAadb2CDirectory
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAadb2CDirectoryTimeouts), fullyQualifiedName: "azurerm.dataAzurermAadb2CDirectory.DataAzurermAadb2CDirectoryTimeouts")]
    public interface IDataAzurermAadb2CDirectoryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/aadb2c_directory#read DataAzurermAadb2CDirectory#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAadb2CDirectoryTimeouts), fullyQualifiedName: "azurerm.dataAzurermAadb2CDirectory.DataAzurermAadb2CDirectoryTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAadb2CDirectory.IDataAzurermAadb2CDirectoryTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/aadb2c_directory#read DataAzurermAadb2CDirectory#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
