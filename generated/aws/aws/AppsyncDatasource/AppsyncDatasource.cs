using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource aws_appsync_datasource}.</summary>
    [JsiiClass(nativeType: typeof(aws.AppsyncDatasource.AppsyncDatasource), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasource", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceConfig\"}}]")]
    public class AppsyncDatasource : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource aws_appsync_datasource} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AppsyncDatasource(Constructs.Construct scope, string id, aws.AppsyncDatasource.IAppsyncDatasourceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.AppsyncDatasource.IAppsyncDatasourceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncDatasource(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncDatasource(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a AppsyncDatasource resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AppsyncDatasource to import.</param>
        /// <param name="importFromId">The id of the existing AppsyncDatasource that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AppsyncDatasource to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AppsyncDatasource to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AppsyncDatasource that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AppsyncDatasource to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.AppsyncDatasource.AppsyncDatasource), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDynamodbConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceDynamodbConfig\"}}]")]
        public virtual void PutDynamodbConfig(aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putElasticsearchConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceElasticsearchConfig\"}}]")]
        public virtual void PutElasticsearchConfig(aws.AppsyncDatasource.IAppsyncDatasourceElasticsearchConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncDatasource.IAppsyncDatasourceElasticsearchConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEventBridgeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceEventBridgeConfig\"}}]")]
        public virtual void PutEventBridgeConfig(aws.AppsyncDatasource.IAppsyncDatasourceEventBridgeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncDatasource.IAppsyncDatasourceEventBridgeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfig\"}}]")]
        public virtual void PutHttpConfig(aws.AppsyncDatasource.IAppsyncDatasourceHttpConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncDatasource.IAppsyncDatasourceHttpConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceLambdaConfig\"}}]")]
        public virtual void PutLambdaConfig(aws.AppsyncDatasource.IAppsyncDatasourceLambdaConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncDatasource.IAppsyncDatasourceLambdaConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpensearchserviceConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceOpensearchserviceConfig\"}}]")]
        public virtual void PutOpensearchserviceConfig(aws.AppsyncDatasource.IAppsyncDatasourceOpensearchserviceConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncDatasource.IAppsyncDatasourceOpensearchserviceConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRelationalDatabaseConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceRelationalDatabaseConfig\"}}]")]
        public virtual void PutRelationalDatabaseConfig(aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodbConfig")]
        public virtual void ResetDynamodbConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearchConfig")]
        public virtual void ResetElasticsearchConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventBridgeConfig")]
        public virtual void ResetEventBridgeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpConfig")]
        public virtual void ResetHttpConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaConfig")]
        public virtual void ResetLambdaConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpensearchserviceConfig")]
        public virtual void ResetOpensearchserviceConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRelationalDatabaseConfig")]
        public virtual void ResetRelationalDatabaseConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceRoleArn")]
        public virtual void ResetServiceRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.AppsyncDatasource.AppsyncDatasource))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dynamodbConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceDynamodbConfigOutputReference\"}")]
        public virtual aws.AppsyncDatasource.AppsyncDatasourceDynamodbConfigOutputReference DynamodbConfig
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.AppsyncDatasourceDynamodbConfigOutputReference>()!;
        }

        [JsiiProperty(name: "elasticsearchConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceElasticsearchConfigOutputReference\"}")]
        public virtual aws.AppsyncDatasource.AppsyncDatasourceElasticsearchConfigOutputReference ElasticsearchConfig
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.AppsyncDatasourceElasticsearchConfigOutputReference>()!;
        }

        [JsiiProperty(name: "eventBridgeConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceEventBridgeConfigOutputReference\"}")]
        public virtual aws.AppsyncDatasource.AppsyncDatasourceEventBridgeConfigOutputReference EventBridgeConfig
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.AppsyncDatasourceEventBridgeConfigOutputReference>()!;
        }

        [JsiiProperty(name: "httpConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigOutputReference\"}")]
        public virtual aws.AppsyncDatasource.AppsyncDatasourceHttpConfigOutputReference HttpConfig
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.AppsyncDatasourceHttpConfigOutputReference>()!;
        }

        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceLambdaConfigOutputReference\"}")]
        public virtual aws.AppsyncDatasource.AppsyncDatasourceLambdaConfigOutputReference LambdaConfig
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.AppsyncDatasourceLambdaConfigOutputReference>()!;
        }

        [JsiiProperty(name: "opensearchserviceConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceOpensearchserviceConfigOutputReference\"}")]
        public virtual aws.AppsyncDatasource.AppsyncDatasourceOpensearchserviceConfigOutputReference OpensearchserviceConfig
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.AppsyncDatasourceOpensearchserviceConfigOutputReference>()!;
        }

        [JsiiProperty(name: "relationalDatabaseConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceRelationalDatabaseConfigOutputReference\"}")]
        public virtual aws.AppsyncDatasource.AppsyncDatasourceRelationalDatabaseConfigOutputReference RelationalDatabaseConfig
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.AppsyncDatasourceRelationalDatabaseConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbConfigInput", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceDynamodbConfig\"}", isOptional: true)]
        public virtual aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfig? DynamodbConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceDynamodbConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchConfigInput", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceElasticsearchConfig\"}", isOptional: true)]
        public virtual aws.AppsyncDatasource.IAppsyncDatasourceElasticsearchConfig? ElasticsearchConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceElasticsearchConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventBridgeConfigInput", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceEventBridgeConfig\"}", isOptional: true)]
        public virtual aws.AppsyncDatasource.IAppsyncDatasourceEventBridgeConfig? EventBridgeConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceEventBridgeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpConfigInput", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfig\"}", isOptional: true)]
        public virtual aws.AppsyncDatasource.IAppsyncDatasourceHttpConfig? HttpConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceHttpConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfigInput", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceLambdaConfig\"}", isOptional: true)]
        public virtual aws.AppsyncDatasource.IAppsyncDatasourceLambdaConfig? LambdaConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceLambdaConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opensearchserviceConfigInput", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceOpensearchserviceConfig\"}", isOptional: true)]
        public virtual aws.AppsyncDatasource.IAppsyncDatasourceOpensearchserviceConfig? OpensearchserviceConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceOpensearchserviceConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "relationalDatabaseConfigInput", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceRelationalDatabaseConfig\"}", isOptional: true)]
        public virtual aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfig? RelationalDatabaseConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceRelationalDatabaseConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
