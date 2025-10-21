using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appflowFlow.AppflowFlowTriggerConfigTriggerPropertiesScheduled")]
    public class AppflowFlowTriggerConfigTriggerPropertiesScheduled : aws.AppflowFlow.IAppflowFlowTriggerConfigTriggerPropertiesScheduled
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#schedule_expression AppflowFlow#schedule_expression}.</summary>
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}")]
        public string ScheduleExpression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#data_pull_mode AppflowFlow#data_pull_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataPullMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataPullMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#first_execution_from AppflowFlow#first_execution_from}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firstExecutionFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirstExecutionFrom
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#schedule_end_time AppflowFlow#schedule_end_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScheduleEndTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#schedule_offset AppflowFlow#schedule_offset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleOffset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ScheduleOffset
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#schedule_start_time AppflowFlow#schedule_start_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScheduleStartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_flow#timezone AppflowFlow#timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timezone
        {
            get;
            set;
        }
    }
}
