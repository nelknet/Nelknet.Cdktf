using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SignalrService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.signalrService.SignalrServiceUpstreamEndpoint")]
    public class SignalrServiceUpstreamEndpoint : azurerm.SignalrService.ISignalrServiceUpstreamEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#category_pattern SignalrService#category_pattern}.</summary>
        [JsiiProperty(name: "categoryPattern", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CategoryPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#event_pattern SignalrService#event_pattern}.</summary>
        [JsiiProperty(name: "eventPattern", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] EventPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#hub_pattern SignalrService#hub_pattern}.</summary>
        [JsiiProperty(name: "hubPattern", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] HubPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#url_template SignalrService#url_template}.</summary>
        [JsiiProperty(name: "urlTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public string UrlTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#user_assigned_identity_id SignalrService#user_assigned_identity_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAssignedIdentityId
        {
            get;
            set;
        }
    }
}
