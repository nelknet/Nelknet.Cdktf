using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceDynamodbConfigDeltaSyncConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceDynamodbConfigDeltaSyncConfig")]
    public interface IAppsyncDatasourceDynamodbConfigDeltaSyncConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#delta_sync_table_name AppsyncDatasource#delta_sync_table_name}.</summary>
        [JsiiProperty(name: "deltaSyncTableName", typeJson: "{\"primitive\":\"string\"}")]
        string DeltaSyncTableName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#base_table_ttl AppsyncDatasource#base_table_ttl}.</summary>
        [JsiiProperty(name: "baseTableTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BaseTableTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#delta_sync_table_ttl AppsyncDatasource#delta_sync_table_ttl}.</summary>
        [JsiiProperty(name: "deltaSyncTableTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeltaSyncTableTtl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceDynamodbConfigDeltaSyncConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceDynamodbConfigDeltaSyncConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfigDeltaSyncConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#delta_sync_table_name AppsyncDatasource#delta_sync_table_name}.</summary>
            [JsiiProperty(name: "deltaSyncTableName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeltaSyncTableName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#base_table_ttl AppsyncDatasource#base_table_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "baseTableTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BaseTableTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#delta_sync_table_ttl AppsyncDatasource#delta_sync_table_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deltaSyncTableTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeltaSyncTableTtl
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
