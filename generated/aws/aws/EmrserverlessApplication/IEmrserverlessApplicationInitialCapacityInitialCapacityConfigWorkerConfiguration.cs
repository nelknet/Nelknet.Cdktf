using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrserverlessApplication
{
    [JsiiInterface(nativeType: typeof(IEmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration")]
    public interface IEmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#cpu EmrserverlessApplication#cpu}.</summary>
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}")]
        string Cpu
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#memory EmrserverlessApplication#memory}.</summary>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}")]
        string Memory
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#disk EmrserverlessApplication#disk}.</summary>
        [JsiiProperty(name: "disk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Disk
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration), fullyQualifiedName: "aws.emrserverlessApplication.EmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.EmrserverlessApplication.IEmrserverlessApplicationInitialCapacityInitialCapacityConfigWorkerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#cpu EmrserverlessApplication#cpu}.</summary>
            [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}")]
            public string Cpu
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#memory EmrserverlessApplication#memory}.</summary>
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}")]
            public string Memory
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#disk EmrserverlessApplication#disk}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Disk
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
