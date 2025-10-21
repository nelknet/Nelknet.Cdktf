using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSetEventDestination
{
    [JsiiInterface(nativeType: typeof(ISesv2ConfigurationSetEventDestinationEventDestinationCloudWatchDestinationDimensionConfiguration), fullyQualifiedName: "aws.sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationEventDestinationCloudWatchDestinationDimensionConfiguration")]
    public interface ISesv2ConfigurationSetEventDestinationEventDestinationCloudWatchDestinationDimensionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#default_dimension_value Sesv2ConfigurationSetEventDestination#default_dimension_value}.</summary>
        [JsiiProperty(name: "defaultDimensionValue", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultDimensionValue
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#dimension_name Sesv2ConfigurationSetEventDestination#dimension_name}.</summary>
        [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}")]
        string DimensionName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#dimension_value_source Sesv2ConfigurationSetEventDestination#dimension_value_source}.</summary>
        [JsiiProperty(name: "dimensionValueSource", typeJson: "{\"primitive\":\"string\"}")]
        string DimensionValueSource
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2ConfigurationSetEventDestinationEventDestinationCloudWatchDestinationDimensionConfiguration), fullyQualifiedName: "aws.sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationEventDestinationCloudWatchDestinationDimensionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2ConfigurationSetEventDestination.ISesv2ConfigurationSetEventDestinationEventDestinationCloudWatchDestinationDimensionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#default_dimension_value Sesv2ConfigurationSetEventDestination#default_dimension_value}.</summary>
            [JsiiProperty(name: "defaultDimensionValue", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultDimensionValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#dimension_name Sesv2ConfigurationSetEventDestination#dimension_name}.</summary>
            [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}")]
            public string DimensionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#dimension_value_source Sesv2ConfigurationSetEventDestination#dimension_value_source}.</summary>
            [JsiiProperty(name: "dimensionValueSource", typeJson: "{\"primitive\":\"string\"}")]
            public string DimensionValueSource
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
