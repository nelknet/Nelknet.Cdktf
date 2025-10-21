using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppintegrationsEventIntegration
{
    [JsiiInterface(nativeType: typeof(IAppintegrationsEventIntegrationEventFilter), fullyQualifiedName: "aws.appintegrationsEventIntegration.AppintegrationsEventIntegrationEventFilter")]
    public interface IAppintegrationsEventIntegrationEventFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_event_integration#source AppintegrationsEventIntegration#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppintegrationsEventIntegrationEventFilter), fullyQualifiedName: "aws.appintegrationsEventIntegration.AppintegrationsEventIntegrationEventFilter")]
        internal sealed class _Proxy : DeputyBase, aws.AppintegrationsEventIntegration.IAppintegrationsEventIntegrationEventFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_event_integration#source AppintegrationsEventIntegration#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
