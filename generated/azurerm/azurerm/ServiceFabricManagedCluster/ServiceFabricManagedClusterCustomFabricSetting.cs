using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricManagedCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterCustomFabricSetting")]
    public class ServiceFabricManagedClusterCustomFabricSetting : azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterCustomFabricSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#parameter ServiceFabricManagedCluster#parameter}.</summary>
        [JsiiProperty(name: "parameter", typeJson: "{\"primitive\":\"string\"}")]
        public string Parameter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#section ServiceFabricManagedCluster#section}.</summary>
        [JsiiProperty(name: "section", typeJson: "{\"primitive\":\"string\"}")]
        public string Section
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#value ServiceFabricManagedCluster#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
