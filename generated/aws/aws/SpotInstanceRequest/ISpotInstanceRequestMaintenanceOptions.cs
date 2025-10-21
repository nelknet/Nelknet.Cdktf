using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SpotInstanceRequest
{
    [JsiiInterface(nativeType: typeof(ISpotInstanceRequestMaintenanceOptions), fullyQualifiedName: "aws.spotInstanceRequest.SpotInstanceRequestMaintenanceOptions")]
    public interface ISpotInstanceRequestMaintenanceOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#auto_recovery SpotInstanceRequest#auto_recovery}.</summary>
        [JsiiProperty(name: "autoRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoRecovery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpotInstanceRequestMaintenanceOptions), fullyQualifiedName: "aws.spotInstanceRequest.SpotInstanceRequestMaintenanceOptions")]
        internal sealed class _Proxy : DeputyBase, aws.SpotInstanceRequest.ISpotInstanceRequestMaintenanceOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_instance_request#auto_recovery SpotInstanceRequest#auto_recovery}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoRecovery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoRecovery
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
