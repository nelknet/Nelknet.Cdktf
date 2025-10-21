using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MapsAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mapsAccount.MapsAccountCors")]
    public class MapsAccountCors : azurerm.MapsAccount.IMapsAccountCors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#allowed_origins MapsAccount#allowed_origins}.</summary>
        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AllowedOrigins
        {
            get;
            set;
        }
    }
}
