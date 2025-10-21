using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LocationPlaceIndex
{
    [JsiiByValue(fqn: "aws.locationPlaceIndex.LocationPlaceIndexDataSourceConfiguration")]
    public class LocationPlaceIndexDataSourceConfiguration : aws.LocationPlaceIndex.ILocationPlaceIndexDataSourceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_place_index#intended_use LocationPlaceIndex#intended_use}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intendedUse", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IntendedUse
        {
            get;
            set;
        }
    }
}
