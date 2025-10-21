using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectInstanceStorageConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig")]
    public class ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig : aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig
    {
        /// <summary>encryption_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#encryption_config ConnectInstanceStorageConfig#encryption_config}
        /// </remarks>
        [JsiiProperty(name: "encryptionConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig\"}")]
        public aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig EncryptionConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#prefix ConnectInstanceStorageConfig#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public string Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#retention_period_hours ConnectInstanceStorageConfig#retention_period_hours}.</summary>
        [JsiiProperty(name: "retentionPeriodHours", typeJson: "{\"primitive\":\"number\"}")]
        public double RetentionPeriodHours
        {
            get;
            set;
        }
    }
}
