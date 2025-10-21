using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLaunchTemplate
{
    [JsiiByValue(fqn: "aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateTimeouts")]
    public class DataAwsLaunchTemplateTimeouts : aws.DataAwsLaunchTemplate.IDataAwsLaunchTemplateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_template#read DataAwsLaunchTemplate#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
