using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KustoCluster
{
    [JsiiClass(nativeType: typeof(azurerm.KustoCluster.KustoClusterOptimizedAutoScaleOutputReference), fullyQualifiedName: "azurerm.kustoCluster.KustoClusterOptimizedAutoScaleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KustoClusterOptimizedAutoScaleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KustoClusterOptimizedAutoScaleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KustoClusterOptimizedAutoScaleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KustoClusterOptimizedAutoScaleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumInstancesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumInstancesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumInstancesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumInstancesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maximumInstances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumInstances
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumInstances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumInstances
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.kustoCluster.KustoClusterOptimizedAutoScale\"}", isOptional: true)]
        public virtual azurerm.KustoCluster.IKustoClusterOptimizedAutoScale? InternalValue
        {
            get => GetInstanceProperty<azurerm.KustoCluster.IKustoClusterOptimizedAutoScale?>();
            set => SetInstanceProperty(value);
        }
    }
}
