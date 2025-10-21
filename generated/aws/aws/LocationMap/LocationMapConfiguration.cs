using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LocationMap
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.locationMap.LocationMapConfiguration")]
    public class LocationMapConfiguration : aws.LocationMap.ILocationMapConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_map#style LocationMap#style}.</summary>
        [JsiiProperty(name: "style", typeJson: "{\"primitive\":\"string\"}")]
        public string Style
        {
            get;
            set;
        }
    }
}
