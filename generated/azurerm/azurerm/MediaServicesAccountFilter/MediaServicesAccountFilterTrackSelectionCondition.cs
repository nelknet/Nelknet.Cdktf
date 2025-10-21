using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MediaServicesAccountFilter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTrackSelectionCondition")]
    public class MediaServicesAccountFilterTrackSelectionCondition : azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterTrackSelectionCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#operation MediaServicesAccountFilter#operation}.</summary>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public string Operation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#property MediaServicesAccountFilter#property}.</summary>
        [JsiiProperty(name: "property", typeJson: "{\"primitive\":\"string\"}")]
        public string Property
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#value MediaServicesAccountFilter#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
