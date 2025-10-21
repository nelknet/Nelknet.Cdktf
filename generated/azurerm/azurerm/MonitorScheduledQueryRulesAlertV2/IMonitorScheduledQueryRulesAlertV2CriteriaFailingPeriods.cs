using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorScheduledQueryRulesAlertV2
{
    [JsiiInterface(nativeType: typeof(IMonitorScheduledQueryRulesAlertV2CriteriaFailingPeriods), fullyQualifiedName: "azurerm.monitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2CriteriaFailingPeriods")]
    public interface IMonitorScheduledQueryRulesAlertV2CriteriaFailingPeriods
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#minimum_failing_periods_to_trigger_alert MonitorScheduledQueryRulesAlertV2#minimum_failing_periods_to_trigger_alert}.</summary>
        [JsiiProperty(name: "minimumFailingPeriodsToTriggerAlert", typeJson: "{\"primitive\":\"number\"}")]
        double MinimumFailingPeriodsToTriggerAlert
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#number_of_evaluation_periods MonitorScheduledQueryRulesAlertV2#number_of_evaluation_periods}.</summary>
        [JsiiProperty(name: "numberOfEvaluationPeriods", typeJson: "{\"primitive\":\"number\"}")]
        double NumberOfEvaluationPeriods
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorScheduledQueryRulesAlertV2CriteriaFailingPeriods), fullyQualifiedName: "azurerm.monitorScheduledQueryRulesAlertV2.MonitorScheduledQueryRulesAlertV2CriteriaFailingPeriods")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorScheduledQueryRulesAlertV2.IMonitorScheduledQueryRulesAlertV2CriteriaFailingPeriods
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#minimum_failing_periods_to_trigger_alert MonitorScheduledQueryRulesAlertV2#minimum_failing_periods_to_trigger_alert}.</summary>
            [JsiiProperty(name: "minimumFailingPeriodsToTriggerAlert", typeJson: "{\"primitive\":\"number\"}")]
            public double MinimumFailingPeriodsToTriggerAlert
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_scheduled_query_rules_alert_v2#number_of_evaluation_periods MonitorScheduledQueryRulesAlertV2#number_of_evaluation_periods}.</summary>
            [JsiiProperty(name: "numberOfEvaluationPeriods", typeJson: "{\"primitive\":\"number\"}")]
            public double NumberOfEvaluationPeriods
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
