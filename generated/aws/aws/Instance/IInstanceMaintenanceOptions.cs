using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiInterface(nativeType: typeof(IInstanceMaintenanceOptions), fullyQualifiedName: "aws.instance.InstanceMaintenanceOptions")]
    public interface IInstanceMaintenanceOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#auto_recovery Instance#auto_recovery}.</summary>
        [JsiiProperty(name: "autoRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoRecovery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceMaintenanceOptions), fullyQualifiedName: "aws.instance.InstanceMaintenanceOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Instance.IInstanceMaintenanceOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#auto_recovery Instance#auto_recovery}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoRecovery
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
