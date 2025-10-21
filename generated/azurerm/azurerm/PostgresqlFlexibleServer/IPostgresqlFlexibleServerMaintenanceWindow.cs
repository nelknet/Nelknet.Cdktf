using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PostgresqlFlexibleServer
{
    [JsiiInterface(nativeType: typeof(IPostgresqlFlexibleServerMaintenanceWindow), fullyQualifiedName: "azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerMaintenanceWindow")]
    public interface IPostgresqlFlexibleServerMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#day_of_week PostgresqlFlexibleServer#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DayOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#start_hour PostgresqlFlexibleServer#start_hour}.</summary>
        [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartHour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#start_minute PostgresqlFlexibleServer#start_minute}.</summary>
        [JsiiProperty(name: "startMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartMinute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPostgresqlFlexibleServerMaintenanceWindow), fullyQualifiedName: "azurerm.postgresqlFlexibleServer.PostgresqlFlexibleServerMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, azurerm.PostgresqlFlexibleServer.IPostgresqlFlexibleServerMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#day_of_week PostgresqlFlexibleServer#day_of_week}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DayOfWeek
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#start_hour PostgresqlFlexibleServer#start_hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartHour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/postgresql_flexible_server#start_minute PostgresqlFlexibleServer#start_minute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartMinute
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
