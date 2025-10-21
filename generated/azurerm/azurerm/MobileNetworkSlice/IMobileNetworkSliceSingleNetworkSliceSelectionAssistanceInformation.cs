using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkSlice
{
    [JsiiInterface(nativeType: typeof(IMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation), fullyQualifiedName: "azurerm.mobileNetworkSlice.MobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation")]
    public interface IMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#slice_service_type MobileNetworkSlice#slice_service_type}.</summary>
        [JsiiProperty(name: "sliceServiceType", typeJson: "{\"primitive\":\"number\"}")]
        double SliceServiceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#slice_differentiator MobileNetworkSlice#slice_differentiator}.</summary>
        [JsiiProperty(name: "sliceDifferentiator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SliceDifferentiator
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation), fullyQualifiedName: "azurerm.mobileNetworkSlice.MobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation")]
        internal sealed class _Proxy : DeputyBase, azurerm.MobileNetworkSlice.IMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#slice_service_type MobileNetworkSlice#slice_service_type}.</summary>
            [JsiiProperty(name: "sliceServiceType", typeJson: "{\"primitive\":\"number\"}")]
            public double SliceServiceType
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mobile_network_slice#slice_differentiator MobileNetworkSlice#slice_differentiator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sliceDifferentiator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SliceDifferentiator
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
