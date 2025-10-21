using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceConfig")]
    public interface IAppsyncDatasourceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#api_id AppsyncDatasource#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#name AppsyncDatasource#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#type AppsyncDatasource#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#description AppsyncDatasource#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodb_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#dynamodb_config AppsyncDatasource#dynamodb_config}
        /// </remarks>
        [JsiiProperty(name: "dynamodbConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceDynamodbConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfig? DynamodbConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>elasticsearch_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#elasticsearch_config AppsyncDatasource#elasticsearch_config}
        /// </remarks>
        [JsiiProperty(name: "elasticsearchConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceElasticsearchConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncDatasource.IAppsyncDatasourceElasticsearchConfig? ElasticsearchConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>event_bridge_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#event_bridge_config AppsyncDatasource#event_bridge_config}
        /// </remarks>
        [JsiiProperty(name: "eventBridgeConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceEventBridgeConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncDatasource.IAppsyncDatasourceEventBridgeConfig? EventBridgeConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#http_config AppsyncDatasource#http_config}
        /// </remarks>
        [JsiiProperty(name: "httpConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncDatasource.IAppsyncDatasourceHttpConfig? HttpConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#id AppsyncDatasource#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#lambda_config AppsyncDatasource#lambda_config}
        /// </remarks>
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceLambdaConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncDatasource.IAppsyncDatasourceLambdaConfig? LambdaConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>opensearchservice_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#opensearchservice_config AppsyncDatasource#opensearchservice_config}
        /// </remarks>
        [JsiiProperty(name: "opensearchserviceConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceOpensearchserviceConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncDatasource.IAppsyncDatasourceOpensearchserviceConfig? OpensearchserviceConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>relational_database_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#relational_database_config AppsyncDatasource#relational_database_config}
        /// </remarks>
        [JsiiProperty(name: "relationalDatabaseConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceRelationalDatabaseConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfig? RelationalDatabaseConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#service_role_arn AppsyncDatasource#service_role_arn}.</summary>
        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceRoleArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncDatasource.IAppsyncDatasourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#api_id AppsyncDatasource#api_id}.</summary>
            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#name AppsyncDatasource#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#type AppsyncDatasource#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#description AppsyncDatasource#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dynamodb_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#dynamodb_config AppsyncDatasource#dynamodb_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodbConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceDynamodbConfig\"}", isOptional: true)]
            public aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfig? DynamodbConfig
            {
                get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfig?>();
            }

            /// <summary>elasticsearch_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#elasticsearch_config AppsyncDatasource#elasticsearch_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearchConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceElasticsearchConfig\"}", isOptional: true)]
            public aws.AppsyncDatasource.IAppsyncDatasourceElasticsearchConfig? ElasticsearchConfig
            {
                get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceElasticsearchConfig?>();
            }

            /// <summary>event_bridge_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#event_bridge_config AppsyncDatasource#event_bridge_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventBridgeConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceEventBridgeConfig\"}", isOptional: true)]
            public aws.AppsyncDatasource.IAppsyncDatasourceEventBridgeConfig? EventBridgeConfig
            {
                get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceEventBridgeConfig?>();
            }

            /// <summary>http_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#http_config AppsyncDatasource#http_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfig\"}", isOptional: true)]
            public aws.AppsyncDatasource.IAppsyncDatasourceHttpConfig? HttpConfig
            {
                get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceHttpConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#id AppsyncDatasource#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lambda_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#lambda_config AppsyncDatasource#lambda_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceLambdaConfig\"}", isOptional: true)]
            public aws.AppsyncDatasource.IAppsyncDatasourceLambdaConfig? LambdaConfig
            {
                get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceLambdaConfig?>();
            }

            /// <summary>opensearchservice_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#opensearchservice_config AppsyncDatasource#opensearchservice_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "opensearchserviceConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceOpensearchserviceConfig\"}", isOptional: true)]
            public aws.AppsyncDatasource.IAppsyncDatasourceOpensearchserviceConfig? OpensearchserviceConfig
            {
                get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceOpensearchserviceConfig?>();
            }

            /// <summary>relational_database_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#relational_database_config AppsyncDatasource#relational_database_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relationalDatabaseConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceRelationalDatabaseConfig\"}", isOptional: true)]
            public aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfig? RelationalDatabaseConfig
            {
                get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#service_role_arn AppsyncDatasource#service_role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceRoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
