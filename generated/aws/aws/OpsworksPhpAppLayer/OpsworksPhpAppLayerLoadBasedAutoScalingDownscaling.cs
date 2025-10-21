using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksPhpAppLayer
{
    [JsiiByValue(fqn: "aws.opsworksPhpAppLayer.OpsworksPhpAppLayerLoadBasedAutoScalingDownscaling")]
    public class OpsworksPhpAppLayerLoadBasedAutoScalingDownscaling : aws.OpsworksPhpAppLayer.IOpsworksPhpAppLayerLoadBasedAutoScalingDownscaling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#alarms OpsworksPhpAppLayer#alarms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Alarms
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#cpu_threshold OpsworksPhpAppLayer#cpu_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#ignore_metrics_time OpsworksPhpAppLayer#ignore_metrics_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreMetricsTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IgnoreMetricsTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#instance_count OpsworksPhpAppLayer#instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#load_threshold OpsworksPhpAppLayer#load_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LoadThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#memory_threshold OpsworksPhpAppLayer#memory_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#thresholds_wait_time OpsworksPhpAppLayer#thresholds_wait_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thresholdsWaitTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThresholdsWaitTime
        {
            get;
            set;
        }
    }
}
