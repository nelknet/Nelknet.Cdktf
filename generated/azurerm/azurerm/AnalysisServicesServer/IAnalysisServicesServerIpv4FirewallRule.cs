using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AnalysisServicesServer
{
    [JsiiInterface(nativeType: typeof(IAnalysisServicesServerIpv4FirewallRule), fullyQualifiedName: "azurerm.analysisServicesServer.AnalysisServicesServerIpv4FirewallRule")]
    public interface IAnalysisServicesServerIpv4FirewallRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#name AnalysisServicesServer#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#range_end AnalysisServicesServer#range_end}.</summary>
        [JsiiProperty(name: "rangeEnd", typeJson: "{\"primitive\":\"string\"}")]
        string RangeEnd
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#range_start AnalysisServicesServer#range_start}.</summary>
        [JsiiProperty(name: "rangeStart", typeJson: "{\"primitive\":\"string\"}")]
        string RangeStart
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAnalysisServicesServerIpv4FirewallRule), fullyQualifiedName: "azurerm.analysisServicesServer.AnalysisServicesServerIpv4FirewallRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.AnalysisServicesServer.IAnalysisServicesServerIpv4FirewallRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#name AnalysisServicesServer#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#range_end AnalysisServicesServer#range_end}.</summary>
            [JsiiProperty(name: "rangeEnd", typeJson: "{\"primitive\":\"string\"}")]
            public string RangeEnd
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/analysis_services_server#range_start AnalysisServicesServer#range_start}.</summary>
            [JsiiProperty(name: "rangeStart", typeJson: "{\"primitive\":\"string\"}")]
            public string RangeStart
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
