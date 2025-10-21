using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KustoCluster
{
    [JsiiInterface(nativeType: typeof(IKustoClusterVirtualNetworkConfiguration), fullyQualifiedName: "azurerm.kustoCluster.KustoClusterVirtualNetworkConfiguration")]
    public interface IKustoClusterVirtualNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#data_management_public_ip_id KustoCluster#data_management_public_ip_id}.</summary>
        [JsiiProperty(name: "dataManagementPublicIpId", typeJson: "{\"primitive\":\"string\"}")]
        string DataManagementPublicIpId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#engine_public_ip_id KustoCluster#engine_public_ip_id}.</summary>
        [JsiiProperty(name: "enginePublicIpId", typeJson: "{\"primitive\":\"string\"}")]
        string EnginePublicIpId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#subnet_id KustoCluster#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKustoClusterVirtualNetworkConfiguration), fullyQualifiedName: "azurerm.kustoCluster.KustoClusterVirtualNetworkConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.KustoCluster.IKustoClusterVirtualNetworkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#data_management_public_ip_id KustoCluster#data_management_public_ip_id}.</summary>
            [JsiiProperty(name: "dataManagementPublicIpId", typeJson: "{\"primitive\":\"string\"}")]
            public string DataManagementPublicIpId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#engine_public_ip_id KustoCluster#engine_public_ip_id}.</summary>
            [JsiiProperty(name: "enginePublicIpId", typeJson: "{\"primitive\":\"string\"}")]
            public string EnginePublicIpId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#subnet_id KustoCluster#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
