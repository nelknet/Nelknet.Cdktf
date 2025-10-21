using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SesEventDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sesEventDestination.SesEventDestinationCloudwatchDestination")]
    public class SesEventDestinationCloudwatchDestination : aws.SesEventDestination.ISesEventDestinationCloudwatchDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#default_value SesEventDestination#default_value}.</summary>
        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#dimension_name SesEventDestination#dimension_name}.</summary>
        [JsiiProperty(name: "dimensionName", typeJson: "{\"primitive\":\"string\"}")]
        public string DimensionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#value_source SesEventDestination#value_source}.</summary>
        [JsiiProperty(name: "valueSource", typeJson: "{\"primitive\":\"string\"}")]
        public string ValueSource
        {
            get;
            set;
        }
    }
}
