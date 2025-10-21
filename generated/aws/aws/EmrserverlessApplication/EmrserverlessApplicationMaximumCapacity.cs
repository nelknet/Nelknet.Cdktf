using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emrserverlessApplication.EmrserverlessApplicationMaximumCapacity")]
    public class EmrserverlessApplicationMaximumCapacity : aws.EmrserverlessApplication.IEmrserverlessApplicationMaximumCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#cpu EmrserverlessApplication#cpu}.</summary>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}")]
        public string Cpu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#memory EmrserverlessApplication#memory}.</summary>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}")]
        public string Memory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#disk EmrserverlessApplication#disk}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Disk
        {
            get;
            set;
        }
    }
}
