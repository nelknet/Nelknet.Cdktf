using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricManagedCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricManagedClusterCustomFabricSetting), fullyQualifiedName: "azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterCustomFabricSetting")]
    public interface IServiceFabricManagedClusterCustomFabricSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#parameter ServiceFabricManagedCluster#parameter}.</summary>
        [JsiiProperty(name: "parameter", typeJson: "{\"primitive\":\"string\"}")]
        string Parameter
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#section ServiceFabricManagedCluster#section}.</summary>
        [JsiiProperty(name: "section", typeJson: "{\"primitive\":\"string\"}")]
        string Section
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#value ServiceFabricManagedCluster#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricManagedClusterCustomFabricSetting), fullyQualifiedName: "azurerm.serviceFabricManagedCluster.ServiceFabricManagedClusterCustomFabricSetting")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricManagedCluster.IServiceFabricManagedClusterCustomFabricSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#parameter ServiceFabricManagedCluster#parameter}.</summary>
            [JsiiProperty(name: "parameter", typeJson: "{\"primitive\":\"string\"}")]
            public string Parameter
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#section ServiceFabricManagedCluster#section}.</summary>
            [JsiiProperty(name: "section", typeJson: "{\"primitive\":\"string\"}")]
            public string Section
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_managed_cluster#value ServiceFabricManagedCluster#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
