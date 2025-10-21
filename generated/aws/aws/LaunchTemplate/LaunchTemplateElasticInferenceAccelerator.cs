using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.launchTemplate.LaunchTemplateElasticInferenceAccelerator")]
    public class LaunchTemplateElasticInferenceAccelerator : aws.LaunchTemplate.ILaunchTemplateElasticInferenceAccelerator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#type LaunchTemplate#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
