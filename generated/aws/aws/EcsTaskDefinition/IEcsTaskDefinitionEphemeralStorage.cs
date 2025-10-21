using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskDefinition
{
    [JsiiInterface(nativeType: typeof(IEcsTaskDefinitionEphemeralStorage), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionEphemeralStorage")]
    public interface IEcsTaskDefinitionEphemeralStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#size_in_gib EcsTaskDefinition#size_in_gib}.</summary>
        [JsiiProperty(name: "sizeInGib", typeJson: "{\"primitive\":\"number\"}")]
        double SizeInGib
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsTaskDefinitionEphemeralStorage), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionEphemeralStorage")]
        internal sealed class _Proxy : DeputyBase, aws.EcsTaskDefinition.IEcsTaskDefinitionEphemeralStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#size_in_gib EcsTaskDefinition#size_in_gib}.</summary>
            [JsiiProperty(name: "sizeInGib", typeJson: "{\"primitive\":\"number\"}")]
            public double SizeInGib
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
