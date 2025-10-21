using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorMetricAlert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorMetricAlert.MonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteria")]
    public class MonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteria : azurerm.MonitorMetricAlert.IMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#component_id MonitorMetricAlert#component_id}.</summary>
        [JsiiProperty(name: "componentId", typeJson: "{\"primitive\":\"string\"}")]
        public string ComponentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#failed_location_count MonitorMetricAlert#failed_location_count}.</summary>
        [JsiiProperty(name: "failedLocationCount", typeJson: "{\"primitive\":\"number\"}")]
        public double FailedLocationCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_metric_alert#web_test_id MonitorMetricAlert#web_test_id}.</summary>
        [JsiiProperty(name: "webTestId", typeJson: "{\"primitive\":\"string\"}")]
        public string WebTestId
        {
            get;
            set;
        }
    }
}
