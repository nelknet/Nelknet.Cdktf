using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightSparkCluster
{
    [JsiiInterface(nativeType: typeof(IHdinsightSparkClusterNetwork), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterNetwork")]
    public interface IHdinsightSparkClusterNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#connection_direction HdinsightSparkCluster#connection_direction}.</summary>
        [JsiiProperty(name: "connectionDirection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConnectionDirection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#private_link_enabled HdinsightSparkCluster#private_link_enabled}.</summary>
        [JsiiProperty(name: "privateLinkEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateLinkEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IHdinsightSparkClusterNetwork), fullyQualifiedName: "azurerm.hdinsightSparkCluster.HdinsightSparkClusterNetwork")]
        internal sealed class _Proxy : DeputyBase, azurerm.HdinsightSparkCluster.IHdinsightSparkClusterNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#connection_direction HdinsightSparkCluster#connection_direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectionDirection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConnectionDirection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_spark_cluster#private_link_enabled HdinsightSparkCluster#private_link_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateLinkEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PrivateLinkEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
