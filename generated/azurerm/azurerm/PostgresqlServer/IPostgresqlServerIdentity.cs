using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PostgresqlServer
{
    [JsiiInterface(nativeType: typeof(IPostgresqlServerIdentity), fullyQualifiedName: "azurerm.postgresqlServer.PostgresqlServerIdentity")]
    public interface IPostgresqlServerIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#type PostgresqlServer#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPostgresqlServerIdentity), fullyQualifiedName: "azurerm.postgresqlServer.PostgresqlServerIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.PostgresqlServer.IPostgresqlServerIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#type PostgresqlServer#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
