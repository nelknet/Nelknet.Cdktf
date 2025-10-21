using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskDefinition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsTaskDefinition.EcsTaskDefinitionEphemeralStorage")]
    public class EcsTaskDefinitionEphemeralStorage : aws.EcsTaskDefinition.IEcsTaskDefinitionEphemeralStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#size_in_gib EcsTaskDefinition#size_in_gib}.</summary>
        [JsiiProperty(name: "sizeInGib", typeJson: "{\"primitive\":\"number\"}")]
        public double SizeInGib
        {
            get;
            set;
        }
    }
}
