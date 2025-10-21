using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AnalysisServicesServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.analysisServicesServer.AnalysisServicesServerIpv4FirewallRule")]
    public class AnalysisServicesServerIpv4FirewallRule : azurerm.AnalysisServicesServer.IAnalysisServicesServerIpv4FirewallRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#name AnalysisServicesServer#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#range_end AnalysisServicesServer#range_end}.</summary>
        [JsiiProperty(name: "rangeEnd", typeJson: "{\"primitive\":\"string\"}")]
        public string RangeEnd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#range_start AnalysisServicesServer#range_start}.</summary>
        [JsiiProperty(name: "rangeStart", typeJson: "{\"primitive\":\"string\"}")]
        public string RangeStart
        {
            get;
            set;
        }
    }
}
