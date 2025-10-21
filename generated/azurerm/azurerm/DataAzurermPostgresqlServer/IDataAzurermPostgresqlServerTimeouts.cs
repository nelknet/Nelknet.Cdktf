using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPostgresqlServer
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPostgresqlServerTimeouts), fullyQualifiedName: "azurerm.dataAzurermPostgresqlServer.DataAzurermPostgresqlServerTimeouts")]
    public interface IDataAzurermPostgresqlServerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_server#read DataAzurermPostgresqlServer#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPostgresqlServerTimeouts), fullyQualifiedName: "azurerm.dataAzurermPostgresqlServer.DataAzurermPostgresqlServerTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPostgresqlServer.IDataAzurermPostgresqlServerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_server#read DataAzurermPostgresqlServer#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
