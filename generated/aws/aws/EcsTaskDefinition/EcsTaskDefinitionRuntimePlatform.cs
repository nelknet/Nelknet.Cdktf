using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskDefinition
{
    [JsiiByValue(fqn: "aws.ecsTaskDefinition.EcsTaskDefinitionRuntimePlatform")]
    public class EcsTaskDefinitionRuntimePlatform : aws.EcsTaskDefinition.IEcsTaskDefinitionRuntimePlatform
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#cpu_architecture EcsTaskDefinition#cpu_architecture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuArchitecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CpuArchitecture
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#operating_system_family EcsTaskDefinition#operating_system_family}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operatingSystemFamily", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OperatingSystemFamily
        {
            get;
            set;
        }
    }
}
