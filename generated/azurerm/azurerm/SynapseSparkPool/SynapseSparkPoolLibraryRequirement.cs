using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseSparkPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.synapseSparkPool.SynapseSparkPoolLibraryRequirement")]
    public class SynapseSparkPoolLibraryRequirement : azurerm.SynapseSparkPool.ISynapseSparkPoolLibraryRequirement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#content SynapseSparkPool#content}.</summary>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public string Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_spark_pool#filename SynapseSparkPool#filename}.</summary>
        [JsiiProperty(name: "filename", typeJson: "{\"primitive\":\"string\"}")]
        public string Filename
        {
            get;
            set;
        }
    }
}
