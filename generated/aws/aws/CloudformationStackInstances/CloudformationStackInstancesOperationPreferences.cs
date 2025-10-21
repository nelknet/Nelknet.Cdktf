using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudformationStackInstances
{
    [JsiiByValue(fqn: "aws.cloudformationStackInstances.CloudformationStackInstancesOperationPreferences")]
    public class CloudformationStackInstancesOperationPreferences : aws.CloudformationStackInstances.ICloudformationStackInstancesOperationPreferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#concurrency_mode CloudformationStackInstances#concurrency_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "concurrencyMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConcurrencyMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#failure_tolerance_count CloudformationStackInstances#failure_tolerance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureToleranceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureToleranceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#failure_tolerance_percentage CloudformationStackInstances#failure_tolerance_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureTolerancePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureTolerancePercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#max_concurrent_count CloudformationStackInstances#max_concurrent_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#max_concurrent_percentage CloudformationStackInstances#max_concurrent_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentPercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#region_concurrency_type CloudformationStackInstances#region_concurrency_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regionConcurrencyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegionConcurrencyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#region_order CloudformationStackInstances#region_order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regionOrder", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RegionOrder
        {
            get;
            set;
        }
    }
}
