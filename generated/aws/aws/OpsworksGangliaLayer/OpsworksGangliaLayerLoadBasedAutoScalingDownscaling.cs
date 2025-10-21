using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksGangliaLayer
{
    [JsiiByValue(fqn: "aws.opsworksGangliaLayer.OpsworksGangliaLayerLoadBasedAutoScalingDownscaling")]
    public class OpsworksGangliaLayerLoadBasedAutoScalingDownscaling : aws.OpsworksGangliaLayer.IOpsworksGangliaLayerLoadBasedAutoScalingDownscaling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#alarms OpsworksGangliaLayer#alarms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Alarms
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#cpu_threshold OpsworksGangliaLayer#cpu_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#ignore_metrics_time OpsworksGangliaLayer#ignore_metrics_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreMetricsTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IgnoreMetricsTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#instance_count OpsworksGangliaLayer#instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#load_threshold OpsworksGangliaLayer#load_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LoadThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#memory_threshold OpsworksGangliaLayer#memory_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_ganglia_layer#thresholds_wait_time OpsworksGangliaLayer#thresholds_wait_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thresholdsWaitTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThresholdsWaitTime
        {
            get;
            set;
        }
    }
}
