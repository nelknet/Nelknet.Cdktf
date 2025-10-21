using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudsearchDomain
{
    [JsiiInterface(nativeType: typeof(ICloudsearchDomainScalingParameters), fullyQualifiedName: "aws.cloudsearchDomain.CloudsearchDomainScalingParameters")]
    public interface ICloudsearchDomainScalingParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#desired_instance_type CloudsearchDomain#desired_instance_type}.</summary>
        [JsiiProperty(name: "desiredInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DesiredInstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#desired_partition_count CloudsearchDomain#desired_partition_count}.</summary>
        [JsiiProperty(name: "desiredPartitionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DesiredPartitionCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#desired_replication_count CloudsearchDomain#desired_replication_count}.</summary>
        [JsiiProperty(name: "desiredReplicationCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DesiredReplicationCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudsearchDomainScalingParameters), fullyQualifiedName: "aws.cloudsearchDomain.CloudsearchDomainScalingParameters")]
        internal sealed class _Proxy : DeputyBase, aws.CloudsearchDomain.ICloudsearchDomainScalingParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#desired_instance_type CloudsearchDomain#desired_instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "desiredInstanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DesiredInstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#desired_partition_count CloudsearchDomain#desired_partition_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "desiredPartitionCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DesiredPartitionCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#desired_replication_count CloudsearchDomain#desired_replication_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "desiredReplicationCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DesiredReplicationCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
