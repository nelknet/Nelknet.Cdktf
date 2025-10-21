using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSchedule
{
    [JsiiInterface(nativeType: typeof(IAutomationScheduleMonthlyOccurrence), fullyQualifiedName: "azurerm.automationSchedule.AutomationScheduleMonthlyOccurrence")]
    public interface IAutomationScheduleMonthlyOccurrence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#day AutomationSchedule#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        string Day
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#occurrence AutomationSchedule#occurrence}.</summary>
        [JsiiProperty(name: "occurrence", typeJson: "{\"primitive\":\"number\"}")]
        double Occurrence
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomationScheduleMonthlyOccurrence), fullyQualifiedName: "azurerm.automationSchedule.AutomationScheduleMonthlyOccurrence")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomationSchedule.IAutomationScheduleMonthlyOccurrence
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#day AutomationSchedule#day}.</summary>
            [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
            public string Day
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_schedule#occurrence AutomationSchedule#occurrence}.</summary>
            [JsiiProperty(name: "occurrence", typeJson: "{\"primitive\":\"number\"}")]
            public double Occurrence
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
