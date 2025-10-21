using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyLaunch
{
    [JsiiInterface(nativeType: typeof(IEvidentlyLaunchMetricMonitors), fullyQualifiedName: "aws.evidentlyLaunch.EvidentlyLaunchMetricMonitors")]
    public interface IEvidentlyLaunchMetricMonitors
    {
        /// <summary>metric_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#metric_definition EvidentlyLaunch#metric_definition}
        /// </remarks>
        [JsiiProperty(name: "metricDefinition", typeJson: "{\"fqn\":\"aws.evidentlyLaunch.EvidentlyLaunchMetricMonitorsMetricDefinition\"}")]
        aws.EvidentlyLaunch.IEvidentlyLaunchMetricMonitorsMetricDefinition MetricDefinition
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEvidentlyLaunchMetricMonitors), fullyQualifiedName: "aws.evidentlyLaunch.EvidentlyLaunchMetricMonitors")]
        internal sealed class _Proxy : DeputyBase, aws.EvidentlyLaunch.IEvidentlyLaunchMetricMonitors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>metric_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_launch#metric_definition EvidentlyLaunch#metric_definition}
            /// </remarks>
            [JsiiProperty(name: "metricDefinition", typeJson: "{\"fqn\":\"aws.evidentlyLaunch.EvidentlyLaunchMetricMonitorsMetricDefinition\"}")]
            public aws.EvidentlyLaunch.IEvidentlyLaunchMetricMonitorsMetricDefinition MetricDefinition
            {
                get => GetInstanceProperty<aws.EvidentlyLaunch.IEvidentlyLaunchMetricMonitorsMetricDefinition>()!;
            }
        }
    }
}
