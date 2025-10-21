using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersResourceParameters")]
    public class CloudwatchEventConnectionInvocationConnectivityParametersResourceParameters : aws.CloudwatchEventConnection.ICloudwatchEventConnectionInvocationConnectivityParametersResourceParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#resource_configuration_arn CloudwatchEventConnection#resource_configuration_arn}.</summary>
        [JsiiProperty(name: "resourceConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceConfigurationArn
        {
            get;
            set;
        }
    }
}
