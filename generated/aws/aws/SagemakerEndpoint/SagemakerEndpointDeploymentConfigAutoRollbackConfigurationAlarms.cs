using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerEndpoint.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms")]
    public class SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms : aws.SagemakerEndpoint.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint#alarm_name SagemakerEndpoint#alarm_name}.</summary>
        [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}")]
        public string AlarmName
        {
            get;
            set;
        }
    }
}
