using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KinesisFirehoseDeliveryStream
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream aws_kinesis_firehose_delivery_stream}.</summary>
    [JsiiClass(nativeType: typeof(aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStream), fullyQualifiedName: "aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStream", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamConfig\"}}]")]
    public class KinesisFirehoseDeliveryStream : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream aws_kinesis_firehose_delivery_stream} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KinesisFirehoseDeliveryStream(Constructs.Construct scope, string id, aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStream(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisFirehoseDeliveryStream(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a KinesisFirehoseDeliveryStream resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the KinesisFirehoseDeliveryStream to import.</param>
        /// <param name="importFromId">The id of the existing KinesisFirehoseDeliveryStream that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the KinesisFirehoseDeliveryStream to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the KinesisFirehoseDeliveryStream to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesis_firehose_delivery_stream#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing KinesisFirehoseDeliveryStream that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the KinesisFirehoseDeliveryStream to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStream), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putElasticsearchConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamElasticsearchConfiguration\"}}]")]
        public virtual void PutElasticsearchConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtendedS3Configuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamExtendedS3Configuration\"}}]")]
        public virtual void PutExtendedS3Configuration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamExtendedS3Configuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamExtendedS3Configuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpEndpointConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamHttpEndpointConfiguration\"}}]")]
        public virtual void PutHttpEndpointConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamHttpEndpointConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamHttpEndpointConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIcebergConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamIcebergConfiguration\"}}]")]
        public virtual void PutIcebergConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamIcebergConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamIcebergConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisSourceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration\"}}]")]
        public virtual void PutKinesisSourceConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMskSourceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamMskSourceConfiguration\"}}]")]
        public virtual void PutMskSourceConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamMskSourceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamMskSourceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpensearchConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchConfiguration\"}}]")]
        public virtual void PutOpensearchConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamOpensearchConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamOpensearchConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpensearchserverlessConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchserverlessConfiguration\"}}]")]
        public virtual void PutOpensearchserverlessConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamOpensearchserverlessConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamOpensearchserverlessConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedshiftConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"}}]")]
        public virtual void PutRedshiftConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServerSideEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamServerSideEncryption\"}}]")]
        public virtual void PutServerSideEncryption(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamServerSideEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamServerSideEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnowflakeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSnowflakeConfiguration\"}}]")]
        public virtual void PutSnowflakeConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamSnowflakeConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamSnowflakeConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSplunkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSplunkConfiguration\"}}]")]
        public virtual void PutSplunkConfiguration(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamSplunkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamSplunkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArn")]
        public virtual void ResetArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationId")]
        public virtual void ResetDestinationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearchConfiguration")]
        public virtual void ResetElasticsearchConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtendedS3Configuration")]
        public virtual void ResetExtendedS3Configuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpEndpointConfiguration")]
        public virtual void ResetHttpEndpointConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcebergConfiguration")]
        public virtual void ResetIcebergConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisSourceConfiguration")]
        public virtual void ResetKinesisSourceConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMskSourceConfiguration")]
        public virtual void ResetMskSourceConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpensearchConfiguration")]
        public virtual void ResetOpensearchConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpensearchserverlessConfiguration")]
        public virtual void ResetOpensearchserverlessConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedshiftConfiguration")]
        public virtual void ResetRedshiftConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerSideEncryption")]
        public virtual void ResetServerSideEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnowflakeConfiguration")]
        public virtual void ResetSnowflakeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSplunkConfiguration")]
        public virtual void ResetSplunkConfiguration()
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

        [JsiiMethod(name: "resetVersionId")]
        public virtual void ResetVersionId()
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
        = GetStaticProperty<string>(typeof(aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStream))!;

        [JsiiProperty(name: "elasticsearchConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamElasticsearchConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamElasticsearchConfigurationOutputReference ElasticsearchConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamElasticsearchConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "extendedS3Configuration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationOutputReference ExtendedS3Configuration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamExtendedS3ConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "httpEndpointConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamHttpEndpointConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamHttpEndpointConfigurationOutputReference HttpEndpointConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamHttpEndpointConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "icebergConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamIcebergConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamIcebergConfigurationOutputReference IcebergConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamIcebergConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "kinesisSourceConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamKinesisSourceConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamKinesisSourceConfigurationOutputReference KinesisSourceConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamKinesisSourceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "mskSourceConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamMskSourceConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamMskSourceConfigurationOutputReference MskSourceConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamMskSourceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "opensearchConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchConfigurationOutputReference OpensearchConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "opensearchserverlessConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationOutputReference OpensearchserverlessConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "redshiftConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference RedshiftConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamServerSideEncryptionOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamServerSideEncryptionOutputReference ServerSideEncryption
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamServerSideEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "snowflakeConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSnowflakeConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSnowflakeConfigurationOutputReference SnowflakeConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSnowflakeConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "splunkConfiguration", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSplunkConfigurationOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSplunkConfigurationOutputReference SplunkConfiguration
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSplunkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamTimeoutsOutputReference\"}")]
        public virtual aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamElasticsearchConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration? ElasticsearchConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamElasticsearchConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extendedS3ConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamExtendedS3Configuration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamExtendedS3Configuration? ExtendedS3ConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamExtendedS3Configuration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpEndpointConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamHttpEndpointConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamHttpEndpointConfiguration? HttpEndpointConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamHttpEndpointConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "icebergConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamIcebergConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamIcebergConfiguration? IcebergConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamIcebergConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisSourceConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamKinesisSourceConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration? KinesisSourceConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamKinesisSourceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mskSourceConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamMskSourceConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamMskSourceConfiguration? MskSourceConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamMskSourceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opensearchConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamOpensearchConfiguration? OpensearchConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamOpensearchConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opensearchserverlessConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamOpensearchserverlessConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamOpensearchserverlessConfiguration? OpensearchserverlessConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamOpensearchserverlessConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redshiftConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamRedshiftConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfiguration? RedshiftConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamRedshiftConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamServerSideEncryption\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamServerSideEncryption? ServerSideEncryptionInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamServerSideEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snowflakeConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSnowflakeConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamSnowflakeConfiguration? SnowflakeConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamSnowflakeConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "splunkConfigurationInput", typeJson: "{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamSplunkConfiguration\"}", isOptional: true)]
        public virtual aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamSplunkConfiguration? SplunkConfigurationInput
        {
            get => GetInstanceProperty<aws.KinesisFirehoseDeliveryStream.IKinesisFirehoseDeliveryStreamSplunkConfiguration?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.kinesisFirehoseDeliveryStream.KinesisFirehoseDeliveryStreamTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Destination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationId
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

        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
