using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpsworksEcsClusterLayer
{
    [JsiiClass(nativeType: typeof(aws.OpsworksEcsClusterLayer.OpsworksEcsClusterLayerLoadBasedAutoScalingDownscalingOutputReference), fullyQualifiedName: "aws.opsworksEcsClusterLayer.OpsworksEcsClusterLayerLoadBasedAutoScalingDownscalingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpsworksEcsClusterLayerLoadBasedAutoScalingDownscalingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpsworksEcsClusterLayerLoadBasedAutoScalingDownscalingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksEcsClusterLayerLoadBasedAutoScalingDownscalingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpsworksEcsClusterLayerLoadBasedAutoScalingDownscalingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAlarms")]
        public virtual void ResetAlarms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuThreshold")]
        public virtual void ResetCpuThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIgnoreMetricsTime")]
        public virtual void ResetIgnoreMetricsTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceCount")]
        public virtual void ResetInstanceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadThreshold")]
        public virtual void ResetLoadThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMemoryThreshold")]
        public virtual void ResetMemoryThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThresholdsWaitTime")]
        public virtual void ResetThresholdsWaitTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "alarmsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AlarmsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CpuThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ignoreMetricsTimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IgnoreMetricsTimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LoadThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemoryThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thresholdsWaitTimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThresholdsWaitTimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Alarms
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cpuThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ignoreMetricsTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IgnoreMetricsTime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoadThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memoryThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thresholdsWaitTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThresholdsWaitTime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opsworksEcsClusterLayer.OpsworksEcsClusterLayerLoadBasedAutoScalingDownscaling\"}", isOptional: true)]
        public virtual aws.OpsworksEcsClusterLayer.IOpsworksEcsClusterLayerLoadBasedAutoScalingDownscaling? InternalValue
        {
            get => GetInstanceProperty<aws.OpsworksEcsClusterLayer.IOpsworksEcsClusterLayerLoadBasedAutoScalingDownscaling?>();
            set => SetInstanceProperty(value);
        }
    }
}
