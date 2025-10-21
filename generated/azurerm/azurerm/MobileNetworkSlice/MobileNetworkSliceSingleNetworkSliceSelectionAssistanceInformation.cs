using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkSlice
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mobileNetworkSlice.MobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation")]
    public class MobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation : azurerm.MobileNetworkSlice.IMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#slice_service_type MobileNetworkSlice#slice_service_type}.</summary>
        [JsiiProperty(name: "sliceServiceType", typeJson: "{\"primitive\":\"number\"}")]
        public double SliceServiceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#slice_differentiator MobileNetworkSlice#slice_differentiator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sliceDifferentiator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SliceDifferentiator
        {
            get;
            set;
        }
    }
}
