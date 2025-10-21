using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudformationStackSet
{
    [JsiiByValue(fqn: "aws.cloudformationStackSet.CloudformationStackSetOperationPreferences")]
    public class CloudformationStackSetOperationPreferences : aws.CloudformationStackSet.ICloudformationStackSetOperationPreferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#failure_tolerance_count CloudformationStackSet#failure_tolerance_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureToleranceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureToleranceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#failure_tolerance_percentage CloudformationStackSet#failure_tolerance_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureTolerancePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureTolerancePercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#max_concurrent_count CloudformationStackSet#max_concurrent_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#max_concurrent_percentage CloudformationStackSet#max_concurrent_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentPercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#region_concurrency_type CloudformationStackSet#region_concurrency_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regionConcurrencyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegionConcurrencyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set#region_order CloudformationStackSet#region_order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regionOrder", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RegionOrder
        {
            get;
            set;
        }
    }
}
