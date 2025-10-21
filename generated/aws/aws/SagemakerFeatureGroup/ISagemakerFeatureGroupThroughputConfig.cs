using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiInterface(nativeType: typeof(ISagemakerFeatureGroupThroughputConfig), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupThroughputConfig")]
    public interface ISagemakerFeatureGroupThroughputConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#provisioned_read_capacity_units SagemakerFeatureGroup#provisioned_read_capacity_units}.</summary>
        [JsiiProperty(name: "provisionedReadCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ProvisionedReadCapacityUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#provisioned_write_capacity_units SagemakerFeatureGroup#provisioned_write_capacity_units}.</summary>
        [JsiiProperty(name: "provisionedWriteCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ProvisionedWriteCapacityUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#throughput_mode SagemakerFeatureGroup#throughput_mode}.</summary>
        [JsiiProperty(name: "throughputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ThroughputMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFeatureGroupThroughputConfig), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupThroughputConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerFeatureGroup.ISagemakerFeatureGroupThroughputConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#provisioned_read_capacity_units SagemakerFeatureGroup#provisioned_read_capacity_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "provisionedReadCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ProvisionedReadCapacityUnits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#provisioned_write_capacity_units SagemakerFeatureGroup#provisioned_write_capacity_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "provisionedWriteCapacityUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ProvisionedWriteCapacityUnits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#throughput_mode SagemakerFeatureGroup#throughput_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "throughputMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ThroughputMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
