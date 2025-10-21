using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2FindingsFilter
{
    [JsiiByValue(fqn: "aws.macie2FindingsFilter.Macie2FindingsFilterTimeouts")]
    public class Macie2FindingsFilterTimeouts : aws.Macie2FindingsFilter.IMacie2FindingsFilterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_findings_filter#create Macie2FindingsFilter#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
