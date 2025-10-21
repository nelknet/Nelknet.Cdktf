using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsEndpoint
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint aws_dms_endpoint}.</summary>
    [JsiiClass(nativeType: typeof(aws.DmsEndpoint.DmsEndpoint), fullyQualifiedName: "aws.dmsEndpoint.DmsEndpoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dmsEndpoint.DmsEndpointConfig\"}}]")]
    public class DmsEndpoint : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint aws_dms_endpoint} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DmsEndpoint(Constructs.Construct scope, string id, aws.DmsEndpoint.IDmsEndpointConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DmsEndpoint.IDmsEndpointConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpoint(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DmsEndpoint resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DmsEndpoint to import.</param>
        /// <param name="importFromId">The id of the existing DmsEndpoint that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DmsEndpoint to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DmsEndpoint to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DmsEndpoint that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DmsEndpoint to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DmsEndpoint.DmsEndpoint), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putElasticsearchSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dmsEndpoint.DmsEndpointElasticsearchSettings\"}}]")]
        public virtual void PutElasticsearchSettings(aws.DmsEndpoint.IDmsEndpointElasticsearchSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DmsEndpoint.IDmsEndpointElasticsearchSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKafkaSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dmsEndpoint.DmsEndpointKafkaSettings\"}}]")]
        public virtual void PutKafkaSettings(aws.DmsEndpoint.IDmsEndpointKafkaSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DmsEndpoint.IDmsEndpointKafkaSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dmsEndpoint.DmsEndpointKinesisSettings\"}}]")]
        public virtual void PutKinesisSettings(aws.DmsEndpoint.IDmsEndpointKinesisSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DmsEndpoint.IDmsEndpointKinesisSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMongodbSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dmsEndpoint.DmsEndpointMongodbSettings\"}}]")]
        public virtual void PutMongodbSettings(aws.DmsEndpoint.IDmsEndpointMongodbSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DmsEndpoint.IDmsEndpointMongodbSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPostgresSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dmsEndpoint.DmsEndpointPostgresSettings\"}}]")]
        public virtual void PutPostgresSettings(aws.DmsEndpoint.IDmsEndpointPostgresSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DmsEndpoint.IDmsEndpointPostgresSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedisSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dmsEndpoint.DmsEndpointRedisSettings\"}}]")]
        public virtual void PutRedisSettings(aws.DmsEndpoint.IDmsEndpointRedisSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DmsEndpoint.IDmsEndpointRedisSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedshiftSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dmsEndpoint.DmsEndpointRedshiftSettings\"}}]")]
        public virtual void PutRedshiftSettings(aws.DmsEndpoint.IDmsEndpointRedshiftSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DmsEndpoint.IDmsEndpointRedshiftSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Settings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dmsEndpoint.DmsEndpointS3Settings\"}}]")]
        public virtual void PutS3Settings(aws.DmsEndpoint.IDmsEndpointS3Settings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DmsEndpoint.IDmsEndpointS3Settings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dmsEndpoint.DmsEndpointTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.DmsEndpoint.IDmsEndpointTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DmsEndpoint.IDmsEndpointTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificateArn")]
        public virtual void ResetCertificateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabaseName")]
        public virtual void ResetDatabaseName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearchSettings")]
        public virtual void ResetElasticsearchSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtraConnectionAttributes")]
        public virtual void ResetExtraConnectionAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKafkaSettings")]
        public virtual void ResetKafkaSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisSettings")]
        public virtual void ResetKinesisSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyArn")]
        public virtual void ResetKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMongodbSettings")]
        public virtual void ResetMongodbSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassword")]
        public virtual void ResetPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPauseReplicationTasks")]
        public virtual void ResetPauseReplicationTasks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostgresSettings")]
        public virtual void ResetPostgresSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedisSettings")]
        public virtual void ResetRedisSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedshiftSettings")]
        public virtual void ResetRedshiftSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Settings")]
        public virtual void ResetS3Settings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretsManagerAccessRoleArn")]
        public virtual void ResetSecretsManagerAccessRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretsManagerArn")]
        public virtual void ResetSecretsManagerArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerName")]
        public virtual void ResetServerName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceAccessRole")]
        public virtual void ResetServiceAccessRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslMode")]
        public virtual void ResetSslMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsername")]
        public virtual void ResetUsername()
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
        = GetStaticProperty<string>(typeof(aws.DmsEndpoint.DmsEndpoint))!;

        [JsiiProperty(name: "elasticsearchSettings", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointElasticsearchSettingsOutputReference\"}")]
        public virtual aws.DmsEndpoint.DmsEndpointElasticsearchSettingsOutputReference ElasticsearchSettings
        {
            get => GetInstanceProperty<aws.DmsEndpoint.DmsEndpointElasticsearchSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "endpointArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kafkaSettings", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointKafkaSettingsOutputReference\"}")]
        public virtual aws.DmsEndpoint.DmsEndpointKafkaSettingsOutputReference KafkaSettings
        {
            get => GetInstanceProperty<aws.DmsEndpoint.DmsEndpointKafkaSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "kinesisSettings", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointKinesisSettingsOutputReference\"}")]
        public virtual aws.DmsEndpoint.DmsEndpointKinesisSettingsOutputReference KinesisSettings
        {
            get => GetInstanceProperty<aws.DmsEndpoint.DmsEndpointKinesisSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "mongodbSettings", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointMongodbSettingsOutputReference\"}")]
        public virtual aws.DmsEndpoint.DmsEndpointMongodbSettingsOutputReference MongodbSettings
        {
            get => GetInstanceProperty<aws.DmsEndpoint.DmsEndpointMongodbSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "postgresSettings", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointPostgresSettingsOutputReference\"}")]
        public virtual aws.DmsEndpoint.DmsEndpointPostgresSettingsOutputReference PostgresSettings
        {
            get => GetInstanceProperty<aws.DmsEndpoint.DmsEndpointPostgresSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "redisSettings", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointRedisSettingsOutputReference\"}")]
        public virtual aws.DmsEndpoint.DmsEndpointRedisSettingsOutputReference RedisSettings
        {
            get => GetInstanceProperty<aws.DmsEndpoint.DmsEndpointRedisSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "redshiftSettings", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointRedshiftSettingsOutputReference\"}")]
        public virtual aws.DmsEndpoint.DmsEndpointRedshiftSettingsOutputReference RedshiftSettings
        {
            get => GetInstanceProperty<aws.DmsEndpoint.DmsEndpointRedshiftSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "s3Settings", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointS3SettingsOutputReference\"}")]
        public virtual aws.DmsEndpoint.DmsEndpointS3SettingsOutputReference S3Settings
        {
            get => GetInstanceProperty<aws.DmsEndpoint.DmsEndpointS3SettingsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointTimeoutsOutputReference\"}")]
        public virtual aws.DmsEndpoint.DmsEndpointTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.DmsEndpoint.DmsEndpointTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchSettingsInput", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointElasticsearchSettings\"}", isOptional: true)]
        public virtual aws.DmsEndpoint.IDmsEndpointElasticsearchSettings? ElasticsearchSettingsInput
        {
            get => GetInstanceProperty<aws.DmsEndpoint.IDmsEndpointElasticsearchSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EngineNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extraConnectionAttributesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExtraConnectionAttributesInput
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
        [JsiiProperty(name: "kafkaSettingsInput", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointKafkaSettings\"}", isOptional: true)]
        public virtual aws.DmsEndpoint.IDmsEndpointKafkaSettings? KafkaSettingsInput
        {
            get => GetInstanceProperty<aws.DmsEndpoint.IDmsEndpointKafkaSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisSettingsInput", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointKinesisSettings\"}", isOptional: true)]
        public virtual aws.DmsEndpoint.IDmsEndpointKinesisSettings? KinesisSettingsInput
        {
            get => GetInstanceProperty<aws.DmsEndpoint.IDmsEndpointKinesisSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mongodbSettingsInput", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointMongodbSettings\"}", isOptional: true)]
        public virtual aws.DmsEndpoint.IDmsEndpointMongodbSettings? MongodbSettingsInput
        {
            get => GetInstanceProperty<aws.DmsEndpoint.IDmsEndpointMongodbSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pauseReplicationTasksInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PauseReplicationTasksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postgresSettingsInput", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointPostgresSettings\"}", isOptional: true)]
        public virtual aws.DmsEndpoint.IDmsEndpointPostgresSettings? PostgresSettingsInput
        {
            get => GetInstanceProperty<aws.DmsEndpoint.IDmsEndpointPostgresSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redisSettingsInput", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointRedisSettings\"}", isOptional: true)]
        public virtual aws.DmsEndpoint.IDmsEndpointRedisSettings? RedisSettingsInput
        {
            get => GetInstanceProperty<aws.DmsEndpoint.IDmsEndpointRedisSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redshiftSettingsInput", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointRedshiftSettings\"}", isOptional: true)]
        public virtual aws.DmsEndpoint.IDmsEndpointRedshiftSettings? RedshiftSettingsInput
        {
            get => GetInstanceProperty<aws.DmsEndpoint.IDmsEndpointRedshiftSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3SettingsInput", typeJson: "{\"fqn\":\"aws.dmsEndpoint.DmsEndpointS3Settings\"}", isOptional: true)]
        public virtual aws.DmsEndpoint.IDmsEndpointS3Settings? S3SettingsInput
        {
            get => GetInstanceProperty<aws.DmsEndpoint.IDmsEndpointS3Settings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretsManagerAccessRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretsManagerAccessRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretsManagerArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretsManagerArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceAccessRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.dmsEndpoint.DmsEndpointTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "engineName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extraConnectionAttributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExtraConnectionAttributes
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

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pauseReplicationTasks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PauseReplicationTasks
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretsManagerAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretsManagerAccessRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretsManagerArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretsManagerArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceAccessRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccessRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslMode
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
