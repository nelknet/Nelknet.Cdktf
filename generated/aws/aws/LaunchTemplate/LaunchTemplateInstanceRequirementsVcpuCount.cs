using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.launchTemplate.LaunchTemplateInstanceRequirementsVcpuCount")]
    public class LaunchTemplateInstanceRequirementsVcpuCount : aws.LaunchTemplate.ILaunchTemplateInstanceRequirementsVcpuCount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#min LaunchTemplate#min}.</summary>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        public double Min
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#max LaunchTemplate#max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Max
        {
            get;
            set;
        }
    }
}
