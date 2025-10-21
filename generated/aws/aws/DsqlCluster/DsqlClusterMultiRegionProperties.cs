using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DsqlCluster
{
    [JsiiByValue(fqn: "aws.dsqlCluster.DsqlClusterMultiRegionProperties")]
    public class DsqlClusterMultiRegionProperties : aws.DsqlCluster.IDsqlClusterMultiRegionProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster#clusters DsqlCluster#clusters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clusters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Clusters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dsql_cluster#witness_region DsqlCluster#witness_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "witnessRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WitnessRegion
        {
            get;
            set;
        }
    }
}
