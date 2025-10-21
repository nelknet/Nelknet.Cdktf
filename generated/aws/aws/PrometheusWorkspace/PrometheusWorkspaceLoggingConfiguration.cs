using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PrometheusWorkspace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.prometheusWorkspace.PrometheusWorkspaceLoggingConfiguration")]
    public class PrometheusWorkspaceLoggingConfiguration : aws.PrometheusWorkspace.IPrometheusWorkspaceLoggingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/prometheus_workspace#log_group_arn PrometheusWorkspace#log_group_arn}.</summary>
        [JsiiProperty(name: "logGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupArn
        {
            get;
            set;
        }
    }
}
