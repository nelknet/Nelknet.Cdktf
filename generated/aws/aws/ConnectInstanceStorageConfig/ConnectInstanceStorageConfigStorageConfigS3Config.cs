using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectInstanceStorageConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3Config")]
    public class ConnectInstanceStorageConfigStorageConfigS3Config : aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3Config
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#bucket_name ConnectInstanceStorageConfig#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#bucket_prefix ConnectInstanceStorageConfig#bucket_prefix}.</summary>
        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketPrefix
        {
            get;
            set;
        }

        /// <summary>encryption_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#encryption_config ConnectInstanceStorageConfig#encryption_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3ConfigEncryptionConfig\"}", isOptional: true)]
        public aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3ConfigEncryptionConfig? EncryptionConfig
        {
            get;
            set;
        }
    }
}
