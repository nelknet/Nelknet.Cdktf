using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksMemcachedLayer
{
    [JsiiInterface(nativeType: typeof(IOpsworksMemcachedLayerLoadBasedAutoScalingDownscaling), fullyQualifiedName: "aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingDownscaling")]
    public interface IOpsworksMemcachedLayerLoadBasedAutoScalingDownscaling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#alarms OpsworksMemcachedLayer#alarms}.</summary>
        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Alarms
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#cpu_threshold OpsworksMemcachedLayer#cpu_threshold}.</summary>
        [JsiiProperty(name: "cpuThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#ignore_metrics_time OpsworksMemcachedLayer#ignore_metrics_time}.</summary>
        [JsiiProperty(name: "ignoreMetricsTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IgnoreMetricsTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#instance_count OpsworksMemcachedLayer#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#load_threshold OpsworksMemcachedLayer#load_threshold}.</summary>
        [JsiiProperty(name: "loadThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LoadThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#memory_threshold OpsworksMemcachedLayer#memory_threshold}.</summary>
        [JsiiProperty(name: "memoryThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#thresholds_wait_time OpsworksMemcachedLayer#thresholds_wait_time}.</summary>
        [JsiiProperty(name: "thresholdsWaitTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThresholdsWaitTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpsworksMemcachedLayerLoadBasedAutoScalingDownscaling), fullyQualifiedName: "aws.opsworksMemcachedLayer.OpsworksMemcachedLayerLoadBasedAutoScalingDownscaling")]
        internal sealed class _Proxy : DeputyBase, aws.OpsworksMemcachedLayer.IOpsworksMemcachedLayerLoadBasedAutoScalingDownscaling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#alarms OpsworksMemcachedLayer#alarms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Alarms
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#cpu_threshold OpsworksMemcachedLayer#cpu_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#ignore_metrics_time OpsworksMemcachedLayer#ignore_metrics_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ignoreMetricsTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IgnoreMetricsTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#instance_count OpsworksMemcachedLayer#instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#load_threshold OpsworksMemcachedLayer#load_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LoadThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#memory_threshold OpsworksMemcachedLayer#memory_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_memcached_layer#thresholds_wait_time OpsworksMemcachedLayer#thresholds_wait_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thresholdsWaitTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThresholdsWaitTime
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
