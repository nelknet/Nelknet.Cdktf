using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseSqlPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.synapseSqlPool.SynapseSqlPoolRestore")]
    public class SynapseSqlPoolRestore : azurerm.SynapseSqlPool.ISynapseSqlPoolRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#point_in_time SynapseSqlPool#point_in_time}.</summary>
        [JsiiProperty(name: "pointInTime", typeJson: "{\"primitive\":\"string\"}")]
        public string PointInTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#source_database_id SynapseSqlPool#source_database_id}.</summary>
        [JsiiProperty(name: "sourceDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceDatabaseId
        {
            get;
            set;
        }
    }
}
