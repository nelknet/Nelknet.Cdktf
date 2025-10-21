using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAlb
{
    [JsiiByValue(fqn: "aws.dataAwsAlb.DataAwsAlbTimeouts")]
    public class DataAwsAlbTimeouts : aws.DataAwsAlb.IDataAwsAlbTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb#read DataAwsAlb#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
