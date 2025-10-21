using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvschatLoggingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ivschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfigurationFirehose")]
    public class IvschatLoggingConfigurationDestinationConfigurationFirehose : aws.IvschatLoggingConfiguration.IIvschatLoggingConfigurationDestinationConfigurationFirehose
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#delivery_stream_name IvschatLoggingConfiguration#delivery_stream_name}.</summary>
        [JsiiProperty(name: "deliveryStreamName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeliveryStreamName
        {
            get;
            set;
        }
    }
}
