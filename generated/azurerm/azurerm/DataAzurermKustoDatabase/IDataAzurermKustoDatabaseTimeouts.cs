using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKustoDatabase
{
    [JsiiInterface(nativeType: typeof(IDataAzurermKustoDatabaseTimeouts), fullyQualifiedName: "azurerm.dataAzurermKustoDatabase.DataAzurermKustoDatabaseTimeouts")]
    public interface IDataAzurermKustoDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_database#read DataAzurermKustoDatabase#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermKustoDatabaseTimeouts), fullyQualifiedName: "azurerm.dataAzurermKustoDatabase.DataAzurermKustoDatabaseTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermKustoDatabase.IDataAzurermKustoDatabaseTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kusto_database#read DataAzurermKustoDatabase#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
