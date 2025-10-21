using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEcsTaskExecution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEcsTaskExecution.DataAwsEcsTaskExecutionOverridesContainerOverridesResourceRequirements")]
    public class DataAwsEcsTaskExecutionOverridesContainerOverridesResourceRequirements : aws.DataAwsEcsTaskExecution.IDataAwsEcsTaskExecutionOverridesContainerOverridesResourceRequirements
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#type DataAwsEcsTaskExecution#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#value DataAwsEcsTaskExecution#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
