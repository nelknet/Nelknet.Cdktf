using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectInstanceStorageConfig
{
    [JsiiInterface(nativeType: typeof(IConnectInstanceStorageConfigStorageConfig), fullyQualifiedName: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfig")]
    public interface IConnectInstanceStorageConfigStorageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#storage_type ConnectInstanceStorageConfig#storage_type}.</summary>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        string StorageType
        {
            get;
        }

        /// <summary>kinesis_firehose_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#kinesis_firehose_config ConnectInstanceStorageConfig#kinesis_firehose_config}
        /// </remarks>
        [JsiiProperty(name: "kinesisFirehoseConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig? KinesisFirehoseConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_stream_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#kinesis_stream_config ConnectInstanceStorageConfig#kinesis_stream_config}
        /// </remarks>
        [JsiiProperty(name: "kinesisStreamConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisStreamConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisStreamConfig? KinesisStreamConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_video_stream_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#kinesis_video_stream_config ConnectInstanceStorageConfig#kinesis_video_stream_config}
        /// </remarks>
        [JsiiProperty(name: "kinesisVideoStreamConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig? KinesisVideoStreamConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#s3_config ConnectInstanceStorageConfig#s3_config}
        /// </remarks>
        [JsiiProperty(name: "s3Config", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3Config\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3Config? S3Config
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectInstanceStorageConfigStorageConfig), fullyQualifiedName: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#storage_type ConnectInstanceStorageConfig#storage_type}.</summary>
            [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>kinesis_firehose_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#kinesis_firehose_config ConnectInstanceStorageConfig#kinesis_firehose_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisFirehoseConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig\"}", isOptional: true)]
            public aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig? KinesisFirehoseConfig
            {
                get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig?>();
            }

            /// <summary>kinesis_stream_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#kinesis_stream_config ConnectInstanceStorageConfig#kinesis_stream_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisStreamConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisStreamConfig\"}", isOptional: true)]
            public aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisStreamConfig? KinesisStreamConfig
            {
                get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisStreamConfig?>();
            }

            /// <summary>kinesis_video_stream_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#kinesis_video_stream_config ConnectInstanceStorageConfig#kinesis_video_stream_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisVideoStreamConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig\"}", isOptional: true)]
            public aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig? KinesisVideoStreamConfig
            {
                get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig?>();
            }

            /// <summary>s3_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#s3_config ConnectInstanceStorageConfig#s3_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Config", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3Config\"}", isOptional: true)]
            public aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3Config? S3Config
            {
                get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3Config?>();
            }
        }
    }
}
