using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MediaServicesAccountFilter
{
    [JsiiInterface(nativeType: typeof(IMediaServicesAccountFilterTrackSelection), fullyQualifiedName: "azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTrackSelection")]
    public interface IMediaServicesAccountFilterTrackSelection
    {
        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#condition MediaServicesAccountFilter#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTrackSelectionCondition\"},\"kind\":\"array\"}}]}}")]
        object Condition
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMediaServicesAccountFilterTrackSelection), fullyQualifiedName: "azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTrackSelection")]
        internal sealed class _Proxy : DeputyBase, azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterTrackSelection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#condition MediaServicesAccountFilter#condition}
            /// </remarks>
            [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTrackSelectionCondition\"},\"kind\":\"array\"}}]}}")]
            public object Condition
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
