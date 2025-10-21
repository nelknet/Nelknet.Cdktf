using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NeptuneCluster
{
    [JsiiByValue(fqn: "aws.neptuneCluster.NeptuneClusterServerlessV2ScalingConfiguration")]
    public class NeptuneClusterServerlessV2ScalingConfiguration : aws.NeptuneCluster.INeptuneClusterServerlessV2ScalingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#max_capacity NeptuneCluster#max_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/neptune_cluster#min_capacity NeptuneCluster#min_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinCapacity
        {
            get;
            set;
        }
    }
}
