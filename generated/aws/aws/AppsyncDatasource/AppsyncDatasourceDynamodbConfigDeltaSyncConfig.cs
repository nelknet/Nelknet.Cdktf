using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncDatasource.AppsyncDatasourceDynamodbConfigDeltaSyncConfig")]
    public class AppsyncDatasourceDynamodbConfigDeltaSyncConfig : aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfigDeltaSyncConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#delta_sync_table_name AppsyncDatasource#delta_sync_table_name}.</summary>
        [JsiiProperty(name: "deltaSyncTableName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeltaSyncTableName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#base_table_ttl AppsyncDatasource#base_table_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "baseTableTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BaseTableTtl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#delta_sync_table_ttl AppsyncDatasource#delta_sync_table_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deltaSyncTableTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeltaSyncTableTtl
        {
            get;
            set;
        }
    }
}
