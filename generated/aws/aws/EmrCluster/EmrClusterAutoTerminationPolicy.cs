using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiByValue(fqn: "aws.emrCluster.EmrClusterAutoTerminationPolicy")]
    public class EmrClusterAutoTerminationPolicy : aws.EmrCluster.IEmrClusterAutoTerminationPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#idle_timeout EmrCluster#idle_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idleTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IdleTimeout
        {
            get;
            set;
        }
    }
}
