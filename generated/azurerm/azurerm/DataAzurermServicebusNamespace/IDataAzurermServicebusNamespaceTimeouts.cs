using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermServicebusNamespace
{
    [JsiiInterface(nativeType: typeof(IDataAzurermServicebusNamespaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermServicebusNamespace.DataAzurermServicebusNamespaceTimeouts")]
    public interface IDataAzurermServicebusNamespaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace#read DataAzurermServicebusNamespace#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermServicebusNamespaceTimeouts), fullyQualifiedName: "azurerm.dataAzurermServicebusNamespace.DataAzurermServicebusNamespaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermServicebusNamespace.IDataAzurermServicebusNamespaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace#read DataAzurermServicebusNamespace#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
