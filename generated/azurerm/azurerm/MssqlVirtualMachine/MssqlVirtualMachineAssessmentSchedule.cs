using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineAssessmentSchedule")]
    public class MssqlVirtualMachineAssessmentSchedule : azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAssessmentSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#day_of_week MssqlVirtualMachine#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        public string DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#start_time MssqlVirtualMachine#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public string StartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#monthly_occurrence MssqlVirtualMachine#monthly_occurrence}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monthlyOccurrence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MonthlyOccurrence
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#weekly_interval MssqlVirtualMachine#weekly_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weeklyInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WeeklyInterval
        {
            get;
            set;
        }
    }
}
