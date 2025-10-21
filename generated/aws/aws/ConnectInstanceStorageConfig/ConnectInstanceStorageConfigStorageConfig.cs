using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectInstanceStorageConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfig")]
    public class ConnectInstanceStorageConfigStorageConfig : aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#storage_type ConnectInstanceStorageConfig#storage_type}.</summary>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageType
        {
            get;
            set;
        }

        /// <summary>kinesis_firehose_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#kinesis_firehose_config ConnectInstanceStorageConfig#kinesis_firehose_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisFirehoseConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig\"}", isOptional: true)]
        public aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig? KinesisFirehoseConfig
        {
            get;
            set;
        }

        /// <summary>kinesis_stream_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#kinesis_stream_config ConnectInstanceStorageConfig#kinesis_stream_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisStreamConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisStreamConfig\"}", isOptional: true)]
        public aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisStreamConfig? KinesisStreamConfig
        {
            get;
            set;
        }

        /// <summary>kinesis_video_stream_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#kinesis_video_stream_config ConnectInstanceStorageConfig#kinesis_video_stream_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisVideoStreamConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig\"}", isOptional: true)]
        public aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig? KinesisVideoStreamConfig
        {
            get;
            set;
        }

        /// <summary>s3_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#s3_config ConnectInstanceStorageConfig#s3_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Config", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3Config\"}", isOptional: true)]
        public aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3Config? S3Config
        {
            get;
            set;
        }
    }
}
