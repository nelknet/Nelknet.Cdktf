using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiByValue(fqn: "aws.launchTemplate.LaunchTemplateMaintenanceOptions")]
    public class LaunchTemplateMaintenanceOptions : aws.LaunchTemplate.ILaunchTemplateMaintenanceOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#auto_recovery LaunchTemplate#auto_recovery}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoRecovery
        {
            get;
            set;
        }
    }
}
