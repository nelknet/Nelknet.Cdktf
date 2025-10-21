using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildFleet
{
    [JsiiByValue(fqn: "aws.codebuildFleet.CodebuildFleetComputeConfiguration")]
    public class CodebuildFleetComputeConfiguration : aws.CodebuildFleet.ICodebuildFleetComputeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#disk CodebuildFleet#disk}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disk", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Disk
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#machine_type CodebuildFleet#machine_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "machineType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MachineType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#memory CodebuildFleet#memory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Memory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#vcpu CodebuildFleet#vcpu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vcpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Vcpu
        {
            get;
            set;
        }
    }
}
