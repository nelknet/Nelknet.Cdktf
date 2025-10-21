using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiByValue(fqn: "aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleInPolicy")]
    public class MskconnectConnectorCapacityAutoscalingScaleInPolicy : aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleInPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#cpu_utilization_percentage MskconnectConnector#cpu_utilization_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuUtilizationPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuUtilizationPercentage
        {
            get;
            set;
        }
    }
}
