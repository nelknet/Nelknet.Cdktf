using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectInstanceStorageConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig")]
    public class ConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig : aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#firehose_arn ConnectInstanceStorageConfig#firehose_arn}.</summary>
        [JsiiProperty(name: "firehoseArn", typeJson: "{\"primitive\":\"string\"}")]
        public string FirehoseArn
        {
            get;
            set;
        }
    }
}
