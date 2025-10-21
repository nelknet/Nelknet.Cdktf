using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvschatLoggingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationS3")]
    public class IvschatLoggingConfigurationDestinationConfigurationS3 : aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#bucket_name IvschatLoggingConfiguration#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }
    }
}
