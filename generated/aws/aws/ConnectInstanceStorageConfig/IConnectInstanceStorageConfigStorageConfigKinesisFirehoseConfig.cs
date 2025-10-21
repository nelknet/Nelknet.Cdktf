using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectInstanceStorageConfig
{
    [JsiiInterface(nativeType: typeof(IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig), fullyQualifiedName: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig")]
    public interface IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#firehose_arn ConnectInstanceStorageConfig#firehose_arn}.</summary>
        [JsiiProperty(name: "firehoseArn", typeJson: "{\"primitive\":\"string\"}")]
        string FirehoseArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig), fullyQualifiedName: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#firehose_arn ConnectInstanceStorageConfig#firehose_arn}.</summary>
            [JsiiProperty(name: "firehoseArn", typeJson: "{\"primitive\":\"string\"}")]
            public string FirehoseArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
