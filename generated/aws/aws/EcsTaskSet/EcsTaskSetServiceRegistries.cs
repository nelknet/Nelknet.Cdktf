using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsTaskSet.EcsTaskSetServiceRegistries")]
    public class EcsTaskSetServiceRegistries : aws.EcsTaskSet.IEcsTaskSetServiceRegistries
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#registry_arn EcsTaskSet#registry_arn}.</summary>
        [JsiiProperty(name: "registryArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RegistryArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#container_name EcsTaskSet#container_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#container_port EcsTaskSet#container_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ContainerPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#port EcsTaskSet#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}
