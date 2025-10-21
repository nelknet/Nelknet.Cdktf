using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusWorkspaceConfiguration
{
    [JsiiInterface(nativeType: typeof(IPrometheusWorkspaceConfigurationLimitsPerLabelSetLimits), fullyQualifiedName: "aws.prometheusWorkspaceConfiguration.PrometheusWorkspaceConfigurationLimitsPerLabelSetLimits")]
    public interface IPrometheusWorkspaceConfigurationLimitsPerLabelSetLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace_configuration#max_series PrometheusWorkspaceConfiguration#max_series}.</summary>
        [JsiiProperty(name: "maxSeries", typeJson: "{\"primitive\":\"number\"}")]
        double MaxSeries
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusWorkspaceConfigurationLimitsPerLabelSetLimits), fullyQualifiedName: "aws.prometheusWorkspaceConfiguration.PrometheusWorkspaceConfigurationLimitsPerLabelSetLimits")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusWorkspaceConfiguration.IPrometheusWorkspaceConfigurationLimitsPerLabelSetLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace_configuration#max_series PrometheusWorkspaceConfiguration#max_series}.</summary>
            [JsiiProperty(name: "maxSeries", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxSeries
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
