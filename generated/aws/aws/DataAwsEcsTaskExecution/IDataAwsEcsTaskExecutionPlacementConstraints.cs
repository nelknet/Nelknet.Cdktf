using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEcsTaskExecution
{
    [JsiiInterface(nativeType: typeof(IDataAwsEcsTaskExecutionPlacementConstraints), fullyQualifiedName: "aws.dataAwsEcsTaskExecution.DataAwsEcsTaskExecutionPlacementConstraints")]
    public interface IDataAwsEcsTaskExecutionPlacementConstraints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#type DataAwsEcsTaskExecution#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#expression DataAwsEcsTaskExecution#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expression
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEcsTaskExecutionPlacementConstraints), fullyQualifiedName: "aws.dataAwsEcsTaskExecution.DataAwsEcsTaskExecutionPlacementConstraints")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEcsTaskExecution.IDataAwsEcsTaskExecutionPlacementConstraints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#type DataAwsEcsTaskExecution#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#expression DataAwsEcsTaskExecution#expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expression
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
