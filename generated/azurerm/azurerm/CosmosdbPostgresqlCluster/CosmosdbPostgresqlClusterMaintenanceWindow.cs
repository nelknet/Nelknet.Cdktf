using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbPostgresqlCluster
{
    [JsiiByValue(fqn: "azurerm.cosmosdbPostgresqlCluster.CosmosdbPostgresqlClusterMaintenanceWindow")]
    public class CosmosdbPostgresqlClusterMaintenanceWindow : azurerm.CosmosdbPostgresqlCluster.ICosmosdbPostgresqlClusterMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#day_of_week CosmosdbPostgresqlCluster#day_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#start_hour CosmosdbPostgresqlCluster#start_hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartHour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_cluster#start_minute CosmosdbPostgresqlCluster#start_minute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startMinute", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartMinute
        {
            get;
            set;
        }
    }
}
