using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksNodejsAppLayer
{
    [JsiiByValue(fqn: "aws.opsworksNodejsAppLayer.OpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling")]
    public class OpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling : aws.OpsworksNodejsAppLayer.IOpsworksNodejsAppLayerLoadBasedAutoScalingUpscaling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#alarms OpsworksNodejsAppLayer#alarms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Alarms
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#cpu_threshold OpsworksNodejsAppLayer#cpu_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#ignore_metrics_time OpsworksNodejsAppLayer#ignore_metrics_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreMetricsTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IgnoreMetricsTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#instance_count OpsworksNodejsAppLayer#instance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#load_threshold OpsworksNodejsAppLayer#load_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LoadThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#memory_threshold OpsworksNodejsAppLayer#memory_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_nodejs_app_layer#thresholds_wait_time OpsworksNodejsAppLayer#thresholds_wait_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thresholdsWaitTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThresholdsWaitTime
        {
            get;
            set;
        }
    }
}
