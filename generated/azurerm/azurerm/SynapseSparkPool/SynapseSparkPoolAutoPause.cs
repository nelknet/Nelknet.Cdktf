using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseSparkPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.synapseSparkPool.SynapseSparkPoolAutoPause")]
    public class SynapseSparkPoolAutoPause : azurerm.SynapseSparkPool.ISynapseSparkPoolAutoPause
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#delay_in_minutes SynapseSparkPool#delay_in_minutes}.</summary>
        [JsiiProperty(name: "delayInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public double DelayInMinutes
        {
            get;
            set;
        }
    }
}
