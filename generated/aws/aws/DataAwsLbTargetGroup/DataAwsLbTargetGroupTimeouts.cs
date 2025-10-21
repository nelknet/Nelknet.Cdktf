using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbTargetGroup
{
    [JsiiByValue(fqn: "aws.dataAwsLbTargetGroup.DataAwsLbTargetGroupTimeouts")]
    public class DataAwsLbTargetGroupTimeouts : aws.DataAwsLbTargetGroup.IDataAwsLbTargetGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_target_group#read DataAwsLbTargetGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
