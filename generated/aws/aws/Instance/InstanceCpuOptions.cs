using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiByValue(fqn: "aws.instance.InstanceCpuOptions")]
    public class InstanceCpuOptions : aws.Instance.IInstanceCpuOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#amd_sev_snp Instance#amd_sev_snp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "amdSevSnp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmdSevSnp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#core_count Instance#core_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoreCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#threads_per_core Instance#threads_per_core}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadsPerCore
        {
            get;
            set;
        }
    }
}
