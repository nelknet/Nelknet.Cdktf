using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiByValue(fqn: "aws.launchTemplate.LaunchTemplateCpuOptions")]
    public class LaunchTemplateCpuOptions : aws.LaunchTemplate.ILaunchTemplateCpuOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#amd_sev_snp LaunchTemplate#amd_sev_snp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "amdSevSnp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmdSevSnp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#core_count LaunchTemplate#core_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoreCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#threads_per_core LaunchTemplate#threads_per_core}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadsPerCore
        {
            get;
            set;
        }
    }
}
