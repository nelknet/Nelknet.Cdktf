using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StackHciCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.stackHciCluster.StackHciClusterIdentity")]
    public class StackHciClusterIdentity : azurerm.StackHciCluster.IStackHciClusterIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/stack_hci_cluster#type StackHciCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
