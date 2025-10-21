using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PostgresqlServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.postgresqlServer.PostgresqlServerIdentity")]
    public class PostgresqlServerIdentity : azurerm.PostgresqlServer.IPostgresqlServerIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_server#type PostgresqlServer#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
