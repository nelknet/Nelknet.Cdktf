using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiByValue(fqn: "aws.appsyncDatasource.AppsyncDatasourceRelationalDatabaseConfig")]
    public class AppsyncDatasourceRelationalDatabaseConfig : aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfig
    {
        /// <summary>http_endpoint_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#http_endpoint_config AppsyncDatasource#http_endpoint_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpEndpointConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceRelationalDatabaseConfigHttpEndpointConfig\"}", isOptional: true)]
        public aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfigHttpEndpointConfig? HttpEndpointConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#source_type AppsyncDatasource#source_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceType
        {
            get;
            set;
        }
    }
}
