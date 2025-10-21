using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MediaServicesAccountFilter
{
    [JsiiInterface(nativeType: typeof(IMediaServicesAccountFilterPresentationTimeRange), fullyQualifiedName: "azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterPresentationTimeRange")]
    public interface IMediaServicesAccountFilterPresentationTimeRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#unit_timescale_in_milliseconds MediaServicesAccountFilter#unit_timescale_in_milliseconds}.</summary>
        [JsiiProperty(name: "unitTimescaleInMilliseconds", typeJson: "{\"primitive\":\"number\"}")]
        double UnitTimescaleInMilliseconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#end_in_units MediaServicesAccountFilter#end_in_units}.</summary>
        [JsiiProperty(name: "endInUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? EndInUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#force_end MediaServicesAccountFilter#force_end}.</summary>
        [JsiiProperty(name: "forceEnd", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ForceEnd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#live_backoff_in_units MediaServicesAccountFilter#live_backoff_in_units}.</summary>
        [JsiiProperty(name: "liveBackoffInUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LiveBackoffInUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#presentation_window_in_units MediaServicesAccountFilter#presentation_window_in_units}.</summary>
        [JsiiProperty(name: "presentationWindowInUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PresentationWindowInUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#start_in_units MediaServicesAccountFilter#start_in_units}.</summary>
        [JsiiProperty(name: "startInUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartInUnits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMediaServicesAccountFilterPresentationTimeRange), fullyQualifiedName: "azurerm.mediaServicesAccountFilter.MediaServicesAccountFilterPresentationTimeRange")]
        internal sealed class _Proxy : DeputyBase, azurerm.MediaServicesAccountFilter.IMediaServicesAccountFilterPresentationTimeRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#unit_timescale_in_milliseconds MediaServicesAccountFilter#unit_timescale_in_milliseconds}.</summary>
            [JsiiProperty(name: "unitTimescaleInMilliseconds", typeJson: "{\"primitive\":\"number\"}")]
            public double UnitTimescaleInMilliseconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#end_in_units MediaServicesAccountFilter#end_in_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endInUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? EndInUnits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#force_end MediaServicesAccountFilter#force_end}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forceEnd", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ForceEnd
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#live_backoff_in_units MediaServicesAccountFilter#live_backoff_in_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "liveBackoffInUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LiveBackoffInUnits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#presentation_window_in_units MediaServicesAccountFilter#presentation_window_in_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "presentationWindowInUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PresentationWindowInUnits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/media_services_account_filter#start_in_units MediaServicesAccountFilter#start_in_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startInUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartInUnits
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
