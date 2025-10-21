using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.M2Application
{
    [JsiiByValue(fqn: "aws.m2Application.M2ApplicationDefinition")]
    public class M2ApplicationDefinition : aws.M2Application.IM2ApplicationDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#content M2Application#content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Content
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_application#s3_location M2Application#s3_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Location
        {
            get;
            set;
        }
    }
}
