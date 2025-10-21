using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationRunbook
{
    [JsiiByValue(fqn: "azurerm.automationRunbook.AutomationRunbookJobSchedule")]
    public class AutomationRunbookJobSchedule : azurerm.AutomationRunbook.IAutomationRunbookJobSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#job_schedule_id AutomationRunbook#job_schedule_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jobScheduleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JobScheduleId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#parameters AutomationRunbook#parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#run_on AutomationRunbook#run_on}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RunOn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_runbook#schedule_name AutomationRunbook#schedule_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScheduleName
        {
            get;
            set;
        }
    }
}
