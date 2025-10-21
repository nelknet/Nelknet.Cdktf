using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusWorkspace
{
    [JsiiInterface(nativeType: typeof(IPrometheusWorkspaceLoggingConfiguration), fullyQualifiedName: "aws.prometheusWorkspace.PrometheusWorkspaceLoggingConfiguration")]
    public interface IPrometheusWorkspaceLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace#log_group_arn PrometheusWorkspace#log_group_arn}.</summary>
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPrometheusWorkspaceLoggingConfiguration), fullyQualifiedName: "aws.prometheusWorkspace.PrometheusWorkspaceLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.PrometheusWorkspace.IPrometheusWorkspaceLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace#log_group_arn PrometheusWorkspace#log_group_arn}.</summary>
            [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
