using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MediaServicesAccountFilter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTrackSelection")]
    public class MediaServicesAccountFilterTrackSelection : azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterTrackSelection
    {
        private object _condition;

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#condition MediaServicesAccountFilter#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterTrackSelectionCondition\"},\"kind\":\"array\"}}]}}")]
        public object Condition
        {
            get => _condition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterTrackSelectionCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterTrackSelectionCondition).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterTrackSelectionCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _condition = value;
            }
        }
    }
}
