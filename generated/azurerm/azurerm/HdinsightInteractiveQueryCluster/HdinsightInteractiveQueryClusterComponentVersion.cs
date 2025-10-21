using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightInteractiveQueryCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.hdinsightInteractiveQueryCluster.HdinsightInteractiveQueryClusterComponentVersion")]
    public class HdinsightInteractiveQueryClusterComponentVersion : azurerm.HdinsightInteractiveQueryCluster.IHdinsightInteractiveQueryClusterComponentVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_interactive_query_cluster#interactive_hive HdinsightInteractiveQueryCluster#interactive_hive}.</summary>
        [JsiiProperty(name: "interactiveHive", typeJson: "{\"primitive\":\"string\"}")]
        public string InteractiveHive
        {
            get;
            set;
        }
    }
}
