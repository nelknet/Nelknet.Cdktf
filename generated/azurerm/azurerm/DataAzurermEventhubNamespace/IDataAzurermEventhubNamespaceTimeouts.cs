using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventhubNamespace
{
    [JsiiInterface(nativeType: typeof(IDataAzurermEventhubNamespaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventhubNamespace.DataAzurermEventhubNamespaceTimeouts")]
    public interface IDataAzurermEventhubNamespaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace#read DataAzurermEventhubNamespace#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermEventhubNamespaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventhubNamespace.DataAzurermEventhubNamespaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermEventhubNamespace.IDataAzurermEventhubNamespaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace#read DataAzurermEventhubNamespace#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
