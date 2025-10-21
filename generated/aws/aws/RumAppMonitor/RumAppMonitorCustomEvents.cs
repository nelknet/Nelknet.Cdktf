using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RumAppMonitor
{
    [JsiiByValue(fqn: "aws.rumAppMonitor.RumAppMonitorCustomEvents")]
    public class RumAppMonitorCustomEvents : aws.RumAppMonitor.IRumAppMonitorCustomEvents
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#status RumAppMonitor#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
