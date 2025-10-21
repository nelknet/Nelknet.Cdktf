using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiByValue(fqn: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupThroughputConfig")]
    public class SagemakerFeatureGroupThroughputConfig : aws.SagemakerFeatureGroup.ISagemakerFeatureGroupThroughputConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#provisioned_read_capacity_units SagemakerFeatureGroup#provisioned_read_capacity_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "provisionedReadCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ProvisionedReadCapacityUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#provisioned_write_capacity_units SagemakerFeatureGroup#provisioned_write_capacity_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "provisionedWriteCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ProvisionedWriteCapacityUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#throughput_mode SagemakerFeatureGroup#throughput_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "throughputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ThroughputMode
        {
            get;
            set;
        }
    }
}
