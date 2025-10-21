using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusWorkspaceConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.prometheusWorkspaceConfiguration.PrometheusWorkspaceConfigurationLimitsPerLabelSetLimits")]
    public class PrometheusWorkspaceConfigurationLimitsPerLabelSetLimits : aws.PrometheusWorkspaceConfiguration.IPrometheusWorkspaceConfigurationLimitsPerLabelSetLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace_configuration#max_series PrometheusWorkspaceConfiguration#max_series}.</summary>
        [JsiiProperty(name: "maxSeries", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxSeries
        {
            get;
            set;
        }
    }
}
