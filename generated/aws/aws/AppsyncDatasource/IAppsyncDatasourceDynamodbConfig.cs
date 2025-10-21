using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceDynamodbConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceDynamodbConfig")]
    public interface IAppsyncDatasourceDynamodbConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#table_name AppsyncDatasource#table_name}.</summary>
        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        string TableName
        {
            get;
        }

        /// <summary>delta_sync_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#delta_sync_config AppsyncDatasource#delta_sync_config}
        /// </remarks>
        [JsiiProperty(name: "deltaSyncConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceDynamodbConfigDeltaSyncConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfigDeltaSyncConfig? DeltaSyncConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#region AppsyncDatasource#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#use_caller_credentials AppsyncDatasource#use_caller_credentials}.</summary>
        [JsiiProperty(name: "useCallerCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseCallerCredentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#versioned AppsyncDatasource#versioned}.</summary>
        [JsiiProperty(name: "versioned", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Versioned
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceDynamodbConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceDynamodbConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#table_name AppsyncDatasource#table_name}.</summary>
            [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
            public string TableName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>delta_sync_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#delta_sync_config AppsyncDatasource#delta_sync_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deltaSyncConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceDynamodbConfigDeltaSyncConfig\"}", isOptional: true)]
            public aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfigDeltaSyncConfig? DeltaSyncConfig
            {
                get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfigDeltaSyncConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#region AppsyncDatasource#region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#use_caller_credentials AppsyncDatasource#use_caller_credentials}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useCallerCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseCallerCredentials
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#versioned AppsyncDatasource#versioned}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versioned", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Versioned
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
