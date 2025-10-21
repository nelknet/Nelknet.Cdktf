using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SfnStateMachine
{
    [JsiiInterface(nativeType: typeof(ISfnStateMachineLoggingConfiguration), fullyQualifiedName: "aws.sfnStateMachine.SfnStateMachineLoggingConfiguration")]
    public interface ISfnStateMachineLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#include_execution_data SfnStateMachine#include_execution_data}.</summary>
        [JsiiProperty(name: "includeExecutionData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeExecutionData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#level SfnStateMachine#level}.</summary>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Level
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#log_destination SfnStateMachine#log_destination}.</summary>
        [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogDestination
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISfnStateMachineLoggingConfiguration), fullyQualifiedName: "aws.sfnStateMachine.SfnStateMachineLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SfnStateMachine.ISfnStateMachineLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#include_execution_data SfnStateMachine#include_execution_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeExecutionData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeExecutionData
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#level SfnStateMachine#level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Level
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#log_destination SfnStateMachine#log_destination}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logDestination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogDestination
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
