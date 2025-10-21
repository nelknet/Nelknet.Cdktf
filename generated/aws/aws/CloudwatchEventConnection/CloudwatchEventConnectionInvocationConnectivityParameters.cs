using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParameters")]
    public class CloudwatchEventConnectionInvocationConnectivityParameters : aws.CloudwatchEventConnection.ICloudwatchEventConnectionInvocationConnectivityParameters
    {
        /// <summary>resource_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_connection#resource_parameters CloudwatchEventConnection#resource_parameters}
        /// </remarks>
        [JsiiProperty(name: "resourceParameters", typeJson: "{\"fqn\":\"aws.cloudwatchEventConnection.CloudwatchEventConnectionInvocationConnectivityParametersResourceParameters\"}")]
        public aws.CloudwatchEventConnection.ICloudwatchEventConnectionInvocationConnectivityParametersResourceParameters ResourceParameters
        {
            get;
            set;
        }
    }
}
