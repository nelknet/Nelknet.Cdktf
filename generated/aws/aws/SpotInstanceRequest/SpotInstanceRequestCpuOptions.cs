using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotInstanceRequest
{
    [JsiiByValue(fqn: "aws.spotInstanceRequest.SpotInstanceRequestCpuOptions")]
    public class SpotInstanceRequestCpuOptions : aws.SpotInstanceRequest.ISpotInstanceRequestCpuOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#amd_sev_snp SpotInstanceRequest#amd_sev_snp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "amdSevSnp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AmdSevSnp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#core_count SpotInstanceRequest#core_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoreCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#threads_per_core SpotInstanceRequest#threads_per_core}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "threadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThreadsPerCore
        {
            get;
            set;
        }
    }
}
