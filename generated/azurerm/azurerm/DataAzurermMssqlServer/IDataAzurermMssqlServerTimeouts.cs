using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMssqlServer
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMssqlServerTimeouts), fullyQualifiedName: "azurerm.dataAzurermMssqlServer.DataAzurermMssqlServerTimeouts")]
    public interface IDataAzurermMssqlServerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_server#read DataAzurermMssqlServer#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMssqlServerTimeouts), fullyQualifiedName: "azurerm.dataAzurermMssqlServer.DataAzurermMssqlServerTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMssqlServer.IDataAzurermMssqlServerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_server#read DataAzurermMssqlServer#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
