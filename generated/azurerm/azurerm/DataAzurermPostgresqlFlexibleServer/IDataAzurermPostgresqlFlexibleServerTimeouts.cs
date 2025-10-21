using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermPostgresqlFlexibleServer
{
    [JsiiInterface(nativeType: typeof(IDataAzurermPostgresqlFlexibleServerTimeouts), fullyQualifiedName: "azurerm.dataAzurermPostgresqlFlexibleServer.DataAzurermPostgresqlFlexibleServerTimeouts")]
    public interface IDataAzurermPostgresqlFlexibleServerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_flexible_server#read DataAzurermPostgresqlFlexibleServer#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermPostgresqlFlexibleServerTimeouts), fullyQualifiedName: "azurerm.dataAzurermPostgresqlFlexibleServer.DataAzurermPostgresqlFlexibleServerTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermPostgresqlFlexibleServer.IDataAzurermPostgresqlFlexibleServerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/postgresql_flexible_server#read DataAzurermPostgresqlFlexibleServer#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
