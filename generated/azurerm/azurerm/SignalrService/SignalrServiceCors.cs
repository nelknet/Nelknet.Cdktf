using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SignalrService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.signalrService.SignalrServiceCors")]
    public class SignalrServiceCors : azurerm.SignalrService.ISignalrServiceCors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service#allowed_origins SignalrService#allowed_origins}.</summary>
        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AllowedOrigins
        {
            get;
            set;
        }
    }
}
