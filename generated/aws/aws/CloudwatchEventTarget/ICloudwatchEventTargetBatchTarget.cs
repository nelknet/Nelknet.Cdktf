using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetBatchTarget), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetBatchTarget")]
    public interface ICloudwatchEventTargetBatchTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#job_definition CloudwatchEventTarget#job_definition}.</summary>
        [JsiiProperty(name: "jobDefinition", typeJson: "{\"primitive\":\"string\"}")]
        string JobDefinition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#job_name CloudwatchEventTarget#job_name}.</summary>
        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
        string JobName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#array_size CloudwatchEventTarget#array_size}.</summary>
        [JsiiProperty(name: "arraySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ArraySize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#job_attempts CloudwatchEventTarget#job_attempts}.</summary>
        [JsiiProperty(name: "jobAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? JobAttempts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetBatchTarget), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetBatchTarget")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventTarget.ICloudwatchEventTargetBatchTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#job_definition CloudwatchEventTarget#job_definition}.</summary>
            [JsiiProperty(name: "jobDefinition", typeJson: "{\"primitive\":\"string\"}")]
            public string JobDefinition
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#job_name CloudwatchEventTarget#job_name}.</summary>
            [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
            public string JobName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#array_size CloudwatchEventTarget#array_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "arraySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ArraySize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_target#job_attempts CloudwatchEventTarget#job_attempts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jobAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? JobAttempts
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
