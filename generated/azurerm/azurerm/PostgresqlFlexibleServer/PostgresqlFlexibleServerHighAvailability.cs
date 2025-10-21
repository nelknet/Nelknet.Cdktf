using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PostgresqlFlexibleServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerHighAvailability")]
    public class PostgresqlFlexibleServerHighAvailability : azurerm.PostgresqlFlexibleServer.IPostgresqlFlexibleServerHighAvailability
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#mode PostgresqlFlexibleServer#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#standby_availability_zone PostgresqlFlexibleServer#standby_availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "standbyAvailabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StandbyAvailabilityZone
        {
            get;
            set;
        }
    }
}
