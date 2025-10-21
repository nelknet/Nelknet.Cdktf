using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EvidentlyProject
{
    [JsiiInterface(nativeType: typeof(IEvidentlyProjectDataDeliveryCloudwatchLogs), fullyQualifiedName: "aws.evidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogs")]
    public interface IEvidentlyProjectDataDeliveryCloudwatchLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#log_group EvidentlyProject#log_group}.</summary>
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEvidentlyProjectDataDeliveryCloudwatchLogs), fullyQualifiedName: "aws.evidentlyProject.EvidentlyProjectDataDeliveryCloudwatchLogs")]
        internal sealed class _Proxy : DeputyBase, aws.EvidentlyProject.IEvidentlyProjectDataDeliveryCloudwatchLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_project#log_group EvidentlyProject#log_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
