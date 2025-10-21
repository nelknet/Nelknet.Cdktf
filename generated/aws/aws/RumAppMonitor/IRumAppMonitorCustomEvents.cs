using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RumAppMonitor
{
    [JsiiInterface(nativeType: typeof(IRumAppMonitorCustomEvents), fullyQualifiedName: "aws.rumAppMonitor.RumAppMonitorCustomEvents")]
    public interface IRumAppMonitorCustomEvents
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#status RumAppMonitor#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRumAppMonitorCustomEvents), fullyQualifiedName: "aws.rumAppMonitor.RumAppMonitorCustomEvents")]
        internal sealed class _Proxy : DeputyBase, aws.RumAppMonitor.IRumAppMonitorCustomEvents
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_app_monitor#status RumAppMonitor#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
