using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiInterface(nativeType: typeof(IAppflowFlowTriggerConfigTriggerPropertiesScheduled), fullyQualifiedName: "aws.appflowFlow.AppflowFlowTriggerConfigTriggerPropertiesScheduled")]
    public interface IAppflowFlowTriggerConfigTriggerPropertiesScheduled
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#schedule_expression AppflowFlow#schedule_expression}.</summary>
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
        string ScheduleExpression
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#data_pull_mode AppflowFlow#data_pull_mode}.</summary>
        [JsiiProperty(name: "dataPullMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataPullMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#first_execution_from AppflowFlow#first_execution_from}.</summary>
        [JsiiProperty(name: "firstExecutionFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirstExecutionFrom
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#schedule_end_time AppflowFlow#schedule_end_time}.</summary>
        [JsiiProperty(name: "scheduleEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduleEndTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#schedule_offset AppflowFlow#schedule_offset}.</summary>
        [JsiiProperty(name: "scheduleOffset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScheduleOffset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#schedule_start_time AppflowFlow#schedule_start_time}.</summary>
        [JsiiProperty(name: "scheduleStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduleStartTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#timezone AppflowFlow#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Timezone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowFlowTriggerConfigTriggerPropertiesScheduled), fullyQualifiedName: "aws.appflowFlow.AppflowFlowTriggerConfigTriggerPropertiesScheduled")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerPropertiesScheduled
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#schedule_expression AppflowFlow#schedule_expression}.</summary>
            [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string ScheduleExpression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#data_pull_mode AppflowFlow#data_pull_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataPullMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataPullMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#first_execution_from AppflowFlow#first_execution_from}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "firstExecutionFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirstExecutionFrom
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#schedule_end_time AppflowFlow#schedule_end_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduleEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduleEndTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#schedule_offset AppflowFlow#schedule_offset}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduleOffset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScheduleOffset
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#schedule_start_time AppflowFlow#schedule_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduleStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduleStartTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#timezone AppflowFlow#timezone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Timezone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
