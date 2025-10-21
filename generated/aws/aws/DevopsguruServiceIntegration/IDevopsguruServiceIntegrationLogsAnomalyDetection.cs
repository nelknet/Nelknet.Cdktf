using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruServiceIntegration
{
    [JsiiInterface(nativeType: typeof(IDevopsguruServiceIntegrationLogsAnomalyDetection), fullyQualifiedName: "aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationLogsAnomalyDetection")]
    public interface IDevopsguruServiceIntegrationLogsAnomalyDetection
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

        [JsiiTypeProxy(nativeType: typeof(IDevopsguruServiceIntegrationLogsAnomalyDetection), fullyQualifiedName: "aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationLogsAnomalyDetection")]
        internal sealed class _Proxy : DeputyBase, aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationLogsAnomalyDetection
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
