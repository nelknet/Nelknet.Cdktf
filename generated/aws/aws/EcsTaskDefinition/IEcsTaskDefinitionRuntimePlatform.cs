using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskDefinition
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionRuntimePlatform), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionRuntimePlatform")]
    public interface IEcsTaskDefinitionRuntimePlatform
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#cpu_architecture EcsTaskDefinition#cpu_architecture}.</summary>
        [JsiiProperty(name: "cpuArchitecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CpuArchitecture
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#operating_system_family EcsTaskDefinition#operating_system_family}.</summary>
        [JsiiProperty(name: "operatingSystemFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperatingSystemFamily
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionRuntimePlatform), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionRuntimePlatform")]
        internal sealed class _Proxy : DeputyBase, aws.EcsTaskDefinition.IEcsTaskDefinitionRuntimePlatform
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#cpu_architecture EcsTaskDefinition#cpu_architecture}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuArchitecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CpuArchitecture
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#operating_system_family EcsTaskDefinition#operating_system_family}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operatingSystemFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperatingSystemFamily
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
