using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminInstanceAccessControlAttributes
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssoadminInstanceAccessControlAttributes.SsoadminInstanceAccessControlAttributesAttributeValue")]
    public class SsoadminInstanceAccessControlAttributesAttributeValue : aws.SsoadminInstanceAccessControlAttributes.ISsoadminInstanceAccessControlAttributesAttributeValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_instance_access_control_attributes#source SsoadminInstanceAccessControlAttributes#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Source
        {
            get;
            set;
        }
    }
}
