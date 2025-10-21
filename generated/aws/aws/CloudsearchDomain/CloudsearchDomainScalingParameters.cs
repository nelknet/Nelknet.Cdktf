using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudsearchDomain
{
    [JsiiByValue(fqn: "aws.cloudsearchDomain.CloudsearchDomainScalingParameters")]
    public class CloudsearchDomainScalingParameters : aws.CloudsearchDomain.ICloudsearchDomainScalingParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#desired_instance_type CloudsearchDomain#desired_instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "desiredInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DesiredInstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#desired_partition_count CloudsearchDomain#desired_partition_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "desiredPartitionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DesiredPartitionCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#desired_replication_count CloudsearchDomain#desired_replication_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "desiredReplicationCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DesiredReplicationCount
        {
            get;
            set;
        }
    }
}
