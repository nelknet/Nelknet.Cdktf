using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpointConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerEndpointConfiguration.SagemakerEndpointConfigurationDataCaptureConfigCaptureOptions")]
    public class SagemakerEndpointConfigurationDataCaptureConfigCaptureOptions : aws.SagemakerEndpointConfiguration.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#capture_mode SagemakerEndpointConfiguration#capture_mode}.</summary>
        [JsiiProperty(name: "captureMode", typeJson: "{\"primitive\":\"string\"}")]
        public string CaptureMode
        {
            get;
            set;
        }
    }
}
