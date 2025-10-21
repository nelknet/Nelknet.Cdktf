using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectInstanceStorageConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisStreamConfig")]
    public class ConnectInstanceStorageConfigStorageConfigKinesisStreamConfig : aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisStreamConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_instance_storage_config#stream_arn ConnectInstanceStorageConfig#stream_arn}.</summary>
        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        public string StreamArn
        {
            get;
            set;
        }
    }
}
