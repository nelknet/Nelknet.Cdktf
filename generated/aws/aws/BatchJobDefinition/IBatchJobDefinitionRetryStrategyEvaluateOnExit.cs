using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchJobDefinition
{
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionRetryStrategyEvaluateOnExit), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionRetryStrategyEvaluateOnExit")]
    public interface IBatchJobDefinitionRetryStrategyEvaluateOnExit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#action BatchJobDefinition#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#on_exit_code BatchJobDefinition#on_exit_code}.</summary>
        [JsiiProperty(name: "onExitCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnExitCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#on_reason BatchJobDefinition#on_reason}.</summary>
        [JsiiProperty(name: "onReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnReason
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#on_status_reason BatchJobDefinition#on_status_reason}.</summary>
        [JsiiProperty(name: "onStatusReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnStatusReason
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionRetryStrategyEvaluateOnExit), fullyQualifiedName: "aws.batchJobDefinition.BatchJobDefinitionRetryStrategyEvaluateOnExit")]
        internal sealed class _Proxy : DeputyBase, aws.BatchJobDefinition.IBatchJobDefinitionRetryStrategyEvaluateOnExit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#action BatchJobDefinition#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#on_exit_code BatchJobDefinition#on_exit_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onExitCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnExitCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#on_reason BatchJobDefinition#on_reason}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnReason
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#on_status_reason BatchJobDefinition#on_status_reason}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onStatusReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnStatusReason
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
