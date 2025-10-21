using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppintegrationsEventIntegration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appintegrationsEventIntegration.AppintegrationsEventIntegrationEventFilter")]
    public class AppintegrationsEventIntegrationEventFilter : aws.AppintegrationsEventIntegration.IAppintegrationsEventIntegrationEventFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_event_integration#source AppintegrationsEventIntegration#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }
    }
}
