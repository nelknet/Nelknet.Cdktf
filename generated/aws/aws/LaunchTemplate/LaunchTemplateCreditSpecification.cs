using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiByValue(fqn: "aws.launchTemplate.LaunchTemplateCreditSpecification")]
    public class LaunchTemplateCreditSpecification : aws.LaunchTemplate.ILaunchTemplateCreditSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#cpu_credits LaunchTemplate#cpu_credits}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuCredits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CpuCredits
        {
            get;
            set;
        }
    }
}
