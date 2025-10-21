using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseSparkPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.synapseSparkPool.SynapseSparkPoolAutoScale")]
    public class SynapseSparkPoolAutoScale : azurerm.SynapseSparkPool.ISynapseSparkPoolAutoScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#max_node_count SynapseSparkPool#max_node_count}.</summary>
        [JsiiProperty(name: "maxNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxNodeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#min_node_count SynapseSparkPool#min_node_count}.</summary>
        [JsiiProperty(name: "minNodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MinNodeCount
        {
            get;
            set;
        }
    }
}
