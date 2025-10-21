using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseSqlPool
{
    [JsiiInterface(nativeType: typeof(ISynapseSqlPoolRestore), fullyQualifiedName: "azurerm.synapseSqlPool.SynapseSqlPoolRestore")]
    public interface ISynapseSqlPoolRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#point_in_time SynapseSqlPool#point_in_time}.</summary>
        [JsiiProperty(name: "pointInTime", typeJson: "{\"primitive\":\"string\"}")]
        string PointInTime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#source_database_id SynapseSqlPool#source_database_id}.</summary>
        [JsiiProperty(name: "sourceDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        string SourceDatabaseId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISynapseSqlPoolRestore), fullyQualifiedName: "azurerm.synapseSqlPool.SynapseSqlPoolRestore")]
        internal sealed class _Proxy : DeputyBase, azurerm.SynapseSqlPool.ISynapseSqlPoolRestore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#point_in_time SynapseSqlPool#point_in_time}.</summary>
            [JsiiProperty(name: "pointInTime", typeJson: "{\"primitive\":\"string\"}")]
            public string PointInTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_sql_pool#source_database_id SynapseSqlPool#source_database_id}.</summary>
            [JsiiProperty(name: "sourceDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceDatabaseId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
