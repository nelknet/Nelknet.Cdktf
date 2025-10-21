using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.serviceFabricCluster.ServiceFabricClusterNodeTypeEphemeralPorts")]
    public class ServiceFabricClusterNodeTypeEphemeralPorts : azurerm.ServiceFabricCluster.IServiceFabricClusterNodeTypeEphemeralPorts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#end_port ServiceFabricCluster#end_port}.</summary>
        [JsiiProperty(name: "endPort", typeJson: "{\"primitive\":\"number\"}")]
        public double EndPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#start_port ServiceFabricCluster#start_port}.</summary>
        [JsiiProperty(name: "startPort", typeJson: "{\"primitive\":\"number\"}")]
        public double StartPort
        {
            get;
            set;
        }
    }
}
