using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PostgresqlFlexibleServer
{
    [JsiiByValue(fqn: "azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerMaintenanceWindow")]
    public class PostgresqlFlexibleServerMaintenanceWindow : azurerm.PostgresqlFlexibleServer.IPostgresqlFlexibleServerMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#day_of_week PostgresqlFlexibleServer#day_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#start_hour PostgresqlFlexibleServer#start_hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartHour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#start_minute PostgresqlFlexibleServer#start_minute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartMinute
        {
            get;
            set;
        }
    }
}
