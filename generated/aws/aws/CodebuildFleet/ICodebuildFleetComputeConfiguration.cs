using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildFleet
{
    [JsiiInterface(nativeType: typeof(ICodebuildFleetComputeConfiguration), fullyQualifiedName: "aws.codebuildFleet.CodebuildFleetComputeConfiguration")]
    public interface ICodebuildFleetComputeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#disk CodebuildFleet#disk}.</summary>
        [JsiiProperty(name: "disk", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Disk
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#machine_type CodebuildFleet#machine_type}.</summary>
        [JsiiProperty(name: "machineType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MachineType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#memory CodebuildFleet#memory}.</summary>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Memory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#vcpu CodebuildFleet#vcpu}.</summary>
        [JsiiProperty(name: "vcpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Vcpu
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildFleetComputeConfiguration), fullyQualifiedName: "aws.codebuildFleet.CodebuildFleetComputeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.CodebuildFleet.ICodebuildFleetComputeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#disk CodebuildFleet#disk}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disk", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Disk
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#machine_type CodebuildFleet#machine_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "machineType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MachineType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#memory CodebuildFleet#memory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Memory
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_fleet#vcpu CodebuildFleet#vcpu}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vcpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Vcpu
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
