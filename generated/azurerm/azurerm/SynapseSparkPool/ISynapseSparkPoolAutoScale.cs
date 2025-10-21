using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseSparkPool
{
    [JsiiInterface(nativeType: typeof(ISynapseSparkPoolAutoScale), fullyQualifiedName: "azurerm.synapseSparkPool.SynapseSparkPoolAutoScale")]
    public interface ISynapseSparkPoolAutoScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#max_node_count SynapseSparkPool#max_node_count}.</summary>
        [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double MaxNodeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#min_node_count SynapseSparkPool#min_node_count}.</summary>
        [JsiiProperty(name: "minNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double MinNodeCount
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISynapseSparkPoolAutoScale), fullyQualifiedName: "azurerm.synapseSparkPool.SynapseSparkPoolAutoScale")]
        internal sealed class _Proxy : DeputyBase, azurerm.SynapseSparkPool.ISynapseSparkPoolAutoScale
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#max_node_count SynapseSparkPool#max_node_count}.</summary>
            [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxNodeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#min_node_count SynapseSparkPool#min_node_count}.</summary>
            [JsiiProperty(name: "minNodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MinNodeCount
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
