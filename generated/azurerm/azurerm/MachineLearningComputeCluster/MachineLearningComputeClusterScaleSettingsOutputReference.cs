using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MachineLearningComputeCluster
{
    [JsiiClass(nativeType: typeof(azurerm.MachineLearningComputeCluster.MachineLearningComputeClusterScaleSettingsOutputReference), fullyQualifiedName: "azurerm.machineLearningComputeCluster.MachineLearningComputeClusterScaleSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MachineLearningComputeClusterScaleSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MachineLearningComputeClusterScaleSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MachineLearningComputeClusterScaleSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MachineLearningComputeClusterScaleSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxNodeCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxNodeCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minNodeCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinNodeCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleDownNodesAfterIdleDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScaleDownNodesAfterIdleDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxNodeCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinNodeCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scaleDownNodesAfterIdleDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScaleDownNodesAfterIdleDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.machineLearningComputeCluster.MachineLearningComputeClusterScaleSettings\"}", isOptional: true)]
        public virtual azurerm.MachineLearningComputeCluster.IMachineLearningComputeClusterScaleSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.MachineLearningComputeCluster.IMachineLearningComputeClusterScaleSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
