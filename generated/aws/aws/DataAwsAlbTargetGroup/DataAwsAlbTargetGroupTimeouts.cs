using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAlbTargetGroup
{
    [JsiiByValue(fqn: "aws.dataAwsAlbTargetGroup.DataAwsAlbTargetGroupTimeouts")]
    public class DataAwsAlbTargetGroupTimeouts : aws.DataAwsAlbTargetGroup.IDataAwsAlbTargetGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_target_group#read DataAwsAlbTargetGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
