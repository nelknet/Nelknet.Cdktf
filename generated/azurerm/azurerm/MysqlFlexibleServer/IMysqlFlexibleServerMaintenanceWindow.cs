using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MysqlFlexibleServer
{
    [JsiiInterface(nativeType: typeof(IMysqlFlexibleServerMaintenanceWindow), fullyQualifiedName: "azurerm.mysqlFlexibleServer.MysqlFlexibleServerMaintenanceWindow")]
    public interface IMysqlFlexibleServerMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#day_of_week MysqlFlexibleServer#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DayOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#start_hour MysqlFlexibleServer#start_hour}.</summary>
        [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartHour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#start_minute MysqlFlexibleServer#start_minute}.</summary>
        [JsiiProperty(name: "startMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartMinute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMysqlFlexibleServerMaintenanceWindow), fullyQualifiedName: "azurerm.mysqlFlexibleServer.MysqlFlexibleServerMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, azurerm.MysqlFlexibleServer.IMysqlFlexibleServerMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#day_of_week MysqlFlexibleServer#day_of_week}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DayOfWeek
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#start_hour MysqlFlexibleServer#start_hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartHour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#start_minute MysqlFlexibleServer#start_minute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartMinute
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
