using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MediaServicesAccountFilter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterPresentationTimeRange")]
    public class MediaServicesAccountFilterPresentationTimeRange : azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterPresentationTimeRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#unit_timescale_in_milliseconds MediaServicesAccountFilter#unit_timescale_in_milliseconds}.</summary>
        [JsiiProperty(name: "unitTimescaleInMilliseconds", typeJson: "{\"primitive\":\"number\"}")]
        public double UnitTimescaleInMilliseconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#end_in_units MediaServicesAccountFilter#end_in_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endInUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EndInUnits
        {
            get;
            set;
        }

        private object? _forceEnd;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#force_end MediaServicesAccountFilter#force_end}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forceEnd", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ForceEnd
        {
            get => _forceEnd;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _forceEnd = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#live_backoff_in_units MediaServicesAccountFilter#live_backoff_in_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "liveBackoffInUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LiveBackoffInUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#presentation_window_in_units MediaServicesAccountFilter#presentation_window_in_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "presentationWindowInUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PresentationWindowInUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#start_in_units MediaServicesAccountFilter#start_in_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startInUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartInUnits
        {
            get;
            set;
        }
    }
}
