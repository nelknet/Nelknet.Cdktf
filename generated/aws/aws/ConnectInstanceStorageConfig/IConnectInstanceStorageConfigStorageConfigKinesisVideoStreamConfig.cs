using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectInstanceStorageConfig
{
    [JsiiInterface(nativeType: typeof(IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig), fullyQualifiedName: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig")]
    public interface IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig
    {
        /// <summary>encryption_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#encryption_config ConnectInstanceStorageConfig#encryption_config}
        /// </remarks>
        [JsiiProperty(name: "encryptionConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig\"}")]
        aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig EncryptionConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#prefix ConnectInstanceStorageConfig#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        string Prefix
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#retention_period_hours ConnectInstanceStorageConfig#retention_period_hours}.</summary>
        [JsiiProperty(name: "retentionPeriodHours", typeJson: "{\"primitive\":\"number\"}")]
        double RetentionPeriodHours
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig), fullyQualifiedName: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>encryption_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#encryption_config ConnectInstanceStorageConfig#encryption_config}
            /// </remarks>
            [JsiiProperty(name: "encryptionConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig\"}")]
            public aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig EncryptionConfig
            {
                get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#prefix ConnectInstanceStorageConfig#prefix}.</summary>
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
            public string Prefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#retention_period_hours ConnectInstanceStorageConfig#retention_period_hours}.</summary>
            [JsiiProperty(name: "retentionPeriodHours", typeJson: "{\"primitive\":\"number\"}")]
            public double RetentionPeriodHours
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
