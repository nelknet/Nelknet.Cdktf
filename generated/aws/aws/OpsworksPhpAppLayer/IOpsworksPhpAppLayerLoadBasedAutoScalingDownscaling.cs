using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksPhpAppLayer
{
    [JsiiInterface(nativeType: typeof(IOpsworksPhpAppLayerLoadBasedAutoScalingDownscaling), fullyQualifiedName: "aws.opsworksPhpAppLayer.OpsworksPhpAppLayerLoadBasedAutoScalingDownscaling")]
    public interface IOpsworksPhpAppLayerLoadBasedAutoScalingDownscaling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#alarms OpsworksPhpAppLayer#alarms}.</summary>
        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Alarms
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#cpu_threshold OpsworksPhpAppLayer#cpu_threshold}.</summary>
        [JsiiProperty(name: "cpuThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#ignore_metrics_time OpsworksPhpAppLayer#ignore_metrics_time}.</summary>
        [JsiiProperty(name: "ignoreMetricsTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IgnoreMetricsTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#instance_count OpsworksPhpAppLayer#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#load_threshold OpsworksPhpAppLayer#load_threshold}.</summary>
        [JsiiProperty(name: "loadThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LoadThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#memory_threshold OpsworksPhpAppLayer#memory_threshold}.</summary>
        [JsiiProperty(name: "memoryThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#thresholds_wait_time OpsworksPhpAppLayer#thresholds_wait_time}.</summary>
        [JsiiProperty(name: "thresholdsWaitTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThresholdsWaitTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksPhpAppLayerLoadBasedAutoScalingDownscaling), fullyQualifiedName: "aws.opsworksPhpAppLayer.OpsworksPhpAppLayerLoadBasedAutoScalingDownscaling")]
        internal sealed class _Proxy : DeputyBase, aws.OpsworksPhpAppLayer.IOpsworksPhpAppLayerLoadBasedAutoScalingDownscaling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#alarms OpsworksPhpAppLayer#alarms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Alarms
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#cpu_threshold OpsworksPhpAppLayer#cpu_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#ignore_metrics_time OpsworksPhpAppLayer#ignore_metrics_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreMetricsTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IgnoreMetricsTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#instance_count OpsworksPhpAppLayer#instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#load_threshold OpsworksPhpAppLayer#load_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LoadThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#memory_threshold OpsworksPhpAppLayer#memory_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_php_app_layer#thresholds_wait_time OpsworksPhpAppLayer#thresholds_wait_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thresholdsWaitTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThresholdsWaitTime
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
