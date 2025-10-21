using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceRelationalDatabaseConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceRelationalDatabaseConfig")]
    public interface IAppsyncDatasourceRelationalDatabaseConfig
    {
        /// <summary>http_endpoint_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#http_endpoint_config AppsyncDatasource#http_endpoint_config}
        /// </remarks>
        [JsiiProperty(name: "httpEndpointConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceRelationalDatabaseConfigHttpEndpointConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfigHttpEndpointConfig? HttpEndpointConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#source_type AppsyncDatasource#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceRelationalDatabaseConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceRelationalDatabaseConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>http_endpoint_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#http_endpoint_config AppsyncDatasource#http_endpoint_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpEndpointConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceRelationalDatabaseConfigHttpEndpointConfig\"}", isOptional: true)]
            public aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfigHttpEndpointConfig? HttpEndpointConfig
            {
                get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfigHttpEndpointConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#source_type AppsyncDatasource#source_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
