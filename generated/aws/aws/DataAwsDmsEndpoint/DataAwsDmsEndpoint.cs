using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsDmsEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_endpoint aws_dms_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsDmsEndpoint.DataAwsDmsEndpoint), fullyQualifiedName: "aws.dataAwsDmsEndpoint.DataAwsDmsEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsDmsEndpoint.DataAwsDmsEndpointConfig\"}}]")]
    public class DataAwsDmsEndpoint : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_endpoint aws_dms_endpoint} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsDmsEndpoint(Constructs.Construct scope, string id, aws.DataAwsDmsEndpoint.IDataAwsDmsEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsDmsEndpoint.IDataAwsDmsEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDmsEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDmsEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsDmsEndpoint resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsDmsEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsDmsEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsDmsEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsDmsEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/dms_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsDmsEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsDmsEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsDmsEndpoint.DataAwsDmsEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsDmsEndpoint.DataAwsDmsEndpoint))!;

        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "elasticsearchSettings", typeJson: "{\"fqn\":\"aws.dataAwsDmsEndpoint.DataAwsDmsEndpointElasticsearchSettingsList\"}")]
        public virtual aws.DataAwsDmsEndpoint.DataAwsDmsEndpointElasticsearchSettingsList ElasticsearchSettings
        {
            get => GetInstanceProperty<aws.DataAwsDmsEndpoint.DataAwsDmsEndpointElasticsearchSettingsList>()!;
        }

        [JsiiProperty(name: "endpointArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "extraConnectionAttributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExtraConnectionAttributes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kafkaSettings", typeJson: "{\"fqn\":\"aws.dataAwsDmsEndpoint.DataAwsDmsEndpointKafkaSettingsList\"}")]
        public virtual aws.DataAwsDmsEndpoint.DataAwsDmsEndpointKafkaSettingsList KafkaSettings
        {
            get => GetInstanceProperty<aws.DataAwsDmsEndpoint.DataAwsDmsEndpointKafkaSettingsList>()!;
        }

        [JsiiProperty(name: "kinesisSettings", typeJson: "{\"fqn\":\"aws.dataAwsDmsEndpoint.DataAwsDmsEndpointKinesisSettingsList\"}")]
        public virtual aws.DataAwsDmsEndpoint.DataAwsDmsEndpointKinesisSettingsList KinesisSettings
        {
            get => GetInstanceProperty<aws.DataAwsDmsEndpoint.DataAwsDmsEndpointKinesisSettingsList>()!;
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mongodbSettings", typeJson: "{\"fqn\":\"aws.dataAwsDmsEndpoint.DataAwsDmsEndpointMongodbSettingsList\"}")]
        public virtual aws.DataAwsDmsEndpoint.DataAwsDmsEndpointMongodbSettingsList MongodbSettings
        {
            get => GetInstanceProperty<aws.DataAwsDmsEndpoint.DataAwsDmsEndpointMongodbSettingsList>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "postgresSettings", typeJson: "{\"fqn\":\"aws.dataAwsDmsEndpoint.DataAwsDmsEndpointPostgresSettingsList\"}")]
        public virtual aws.DataAwsDmsEndpoint.DataAwsDmsEndpointPostgresSettingsList PostgresSettings
        {
            get => GetInstanceProperty<aws.DataAwsDmsEndpoint.DataAwsDmsEndpointPostgresSettingsList>()!;
        }

        [JsiiProperty(name: "redisSettings", typeJson: "{\"fqn\":\"aws.dataAwsDmsEndpoint.DataAwsDmsEndpointRedisSettingsList\"}")]
        public virtual aws.DataAwsDmsEndpoint.DataAwsDmsEndpointRedisSettingsList RedisSettings
        {
            get => GetInstanceProperty<aws.DataAwsDmsEndpoint.DataAwsDmsEndpointRedisSettingsList>()!;
        }

        [JsiiProperty(name: "redshiftSettings", typeJson: "{\"fqn\":\"aws.dataAwsDmsEndpoint.DataAwsDmsEndpointRedshiftSettingsList\"}")]
        public virtual aws.DataAwsDmsEndpoint.DataAwsDmsEndpointRedshiftSettingsList RedshiftSettings
        {
            get => GetInstanceProperty<aws.DataAwsDmsEndpoint.DataAwsDmsEndpointRedshiftSettingsList>()!;
        }

        [JsiiProperty(name: "s3Settings", typeJson: "{\"fqn\":\"aws.dataAwsDmsEndpoint.DataAwsDmsEndpointS3SettingsList\"}")]
        public virtual aws.DataAwsDmsEndpoint.DataAwsDmsEndpointS3SettingsList S3Settings
        {
            get => GetInstanceProperty<aws.DataAwsDmsEndpoint.DataAwsDmsEndpointS3SettingsList>()!;
        }

        [JsiiProperty(name: "secretsManagerAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretsManagerAccessRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secretsManagerArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretsManagerArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceAccessRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccessRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointId
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
