using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KustoCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.kustoCluster.KustoClusterOptimizedAutoScale")]
    public class KustoClusterOptimizedAutoScale : azurerm.KustoCluster.IKustoClusterOptimizedAutoScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#maximum_instances KustoCluster#maximum_instances}.</summary>
        [JsiiProperty(name: "maximumInstances", typeJson: "{\"primitive\":\"number\"}")]
        public double MaximumInstances
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#minimum_instances KustoCluster#minimum_instances}.</summary>
        [JsiiProperty(name: "minimumInstances", typeJson: "{\"primitive\":\"number\"}")]
        public double MinimumInstances
        {
            get;
            set;
        }
    }
}
