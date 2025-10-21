using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMssqlDatabase
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMssqlDatabaseTimeouts), fullyQualifiedName: "azurerm.dataAzurermMssqlDatabase.DataAzurermMssqlDatabaseTimeouts")]
    public interface IDataAzurermMssqlDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_database#read DataAzurermMssqlDatabase#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMssqlDatabaseTimeouts), fullyQualifiedName: "azurerm.dataAzurermMssqlDatabase.DataAzurermMssqlDatabaseTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMssqlDatabase.IDataAzurermMssqlDatabaseTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_database#read DataAzurermMssqlDatabase#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
