using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectConnector
{
    [JsiiInterface(nativeType: typeof(IMskconnectConnectorCapacityAutoscalingScaleOutPolicy), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicy")]
    public interface IMskconnectConnectorCapacityAutoscalingScaleOutPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#cpu_utilization_percentage MskconnectConnector#cpu_utilization_percentage}.</summary>
        [JsiiProperty(name: "cpuUtilizationPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuUtilizationPercentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskconnectConnectorCapacityAutoscalingScaleOutPolicy), fullyQualifiedName: "aws.mskconnectConnector.MskconnectConnectorCapacityAutoscalingScaleOutPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.MskconnectConnector.IMskconnectConnectorCapacityAutoscalingScaleOutPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_connector#cpu_utilization_percentage MskconnectConnector#cpu_utilization_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuUtilizationPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuUtilizationPercentage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
