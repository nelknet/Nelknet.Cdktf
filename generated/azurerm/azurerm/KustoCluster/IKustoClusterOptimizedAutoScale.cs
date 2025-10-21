using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KustoCluster
{
    [JsiiInterface(nativeType: typeof(IKustoClusterOptimizedAutoScale), fullyQualifiedName: "azurerm.kustoCluster.KustoClusterOptimizedAutoScale")]
    public interface IKustoClusterOptimizedAutoScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#maximum_instances KustoCluster#maximum_instances}.</summary>
        [JsiiProperty(name: "maximumInstances", typeJson: "{\"primitive\":\"number\"}")]
        double MaximumInstances
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#minimum_instances KustoCluster#minimum_instances}.</summary>
        [JsiiProperty(name: "minimumInstances", typeJson: "{\"primitive\":\"number\"}")]
        double MinimumInstances
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKustoClusterOptimizedAutoScale), fullyQualifiedName: "azurerm.kustoCluster.KustoClusterOptimizedAutoScale")]
        internal sealed class _Proxy : DeputyBase, azurerm.KustoCluster.IKustoClusterOptimizedAutoScale
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#maximum_instances KustoCluster#maximum_instances}.</summary>
            [JsiiProperty(name: "maximumInstances", typeJson: "{\"primitive\":\"number\"}")]
            public double MaximumInstances
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#minimum_instances KustoCluster#minimum_instances}.</summary>
            [JsiiProperty(name: "minimumInstances", typeJson: "{\"primitive\":\"number\"}")]
            public double MinimumInstances
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
