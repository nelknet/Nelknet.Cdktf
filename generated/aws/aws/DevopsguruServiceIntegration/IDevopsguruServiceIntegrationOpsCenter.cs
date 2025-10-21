using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruServiceIntegration
{
    [JsiiInterface(nativeType: typeof(IDevopsguruServiceIntegrationOpsCenter), fullyQualifiedName: "aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationOpsCenter")]
    public interface IDevopsguruServiceIntegrationOpsCenter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_service_integration#opt_in_status DevopsguruServiceIntegration#opt_in_status}.</summary>
        [JsiiProperty(name: "optInStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OptInStatus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsguruServiceIntegrationOpsCenter), fullyQualifiedName: "aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationOpsCenter")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationOpsCenter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_service_integration#opt_in_status DevopsguruServiceIntegration#opt_in_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "optInStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OptInStatus
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
