using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricClusterNodeTypeApplicationPorts), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterNodeTypeApplicationPorts")]
    public interface IServiceFabricClusterNodeTypeApplicationPorts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#end_port ServiceFabricCluster#end_port}.</summary>
        [JsiiProperty(name: "endPort", typeJson: "{\"primitive\":\"number\"}")]
        double EndPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#start_port ServiceFabricCluster#start_port}.</summary>
        [JsiiProperty(name: "startPort", typeJson: "{\"primitive\":\"number\"}")]
        double StartPort
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricClusterNodeTypeApplicationPorts), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterNodeTypeApplicationPorts")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricCluster.IServiceFabricClusterNodeTypeApplicationPorts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#end_port ServiceFabricCluster#end_port}.</summary>
            [JsiiProperty(name: "endPort", typeJson: "{\"primitive\":\"number\"}")]
            public double EndPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#start_port ServiceFabricCluster#start_port}.</summary>
            [JsiiProperty(name: "startPort", typeJson: "{\"primitive\":\"number\"}")]
            public double StartPort
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
