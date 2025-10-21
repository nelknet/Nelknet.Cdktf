using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAutoscalingGroups
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsAutoscalingGroups.DataAwsAutoscalingGroupsFilter")]
    public class DataAwsAutoscalingGroupsFilter : aws.DataAwsAutoscalingGroups.IDataAwsAutoscalingGroupsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/autoscaling_groups#name DataAwsAutoscalingGroups#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/autoscaling_groups#values DataAwsAutoscalingGroups#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
