using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotInstanceRequest
{
    [JsiiInterface(nativeType: typeof(ISpotInstanceRequestCpuOptions), fullyQualifiedName: "aws.spotInstanceRequest.SpotInstanceRequestCpuOptions")]
    public interface ISpotInstanceRequestCpuOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#amd_sev_snp SpotInstanceRequest#amd_sev_snp}.</summary>
        [JsiiProperty(name: "amdSevSnp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmdSevSnp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#core_count SpotInstanceRequest#core_count}.</summary>
        [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CoreCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#threads_per_core SpotInstanceRequest#threads_per_core}.</summary>
        [JsiiProperty(name: "threadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ThreadsPerCore
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotInstanceRequestCpuOptions), fullyQualifiedName: "aws.spotInstanceRequest.SpotInstanceRequestCpuOptions")]
        internal sealed class _Proxy : DeputyBase, aws.SpotInstanceRequest.ISpotInstanceRequestCpuOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#amd_sev_snp SpotInstanceRequest#amd_sev_snp}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "amdSevSnp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmdSevSnp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#core_count SpotInstanceRequest#core_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "coreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CoreCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#threads_per_core SpotInstanceRequest#threads_per_core}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "threadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ThreadsPerCore
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
