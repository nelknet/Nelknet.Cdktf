using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DsqlCluster
{
    [JsiiInterface(nativeType: typeof(IDsqlClusterMultiRegionProperties), fullyQualifiedName: "aws.dsqlCluster.DsqlClusterMultiRegionProperties")]
    public interface IDsqlClusterMultiRegionProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster#clusters DsqlCluster#clusters}.</summary>
        [JsiiProperty(name: "clusters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Clusters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster#witness_region DsqlCluster#witness_region}.</summary>
        [JsiiProperty(name: "witnessRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WitnessRegion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDsqlClusterMultiRegionProperties), fullyQualifiedName: "aws.dsqlCluster.DsqlClusterMultiRegionProperties")]
        internal sealed class _Proxy : DeputyBase, aws.DsqlCluster.IDsqlClusterMultiRegionProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster#clusters DsqlCluster#clusters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Clusters
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster#witness_region DsqlCluster#witness_region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "witnessRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WitnessRegion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
