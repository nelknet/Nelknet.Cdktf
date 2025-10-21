using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamStack
{
    [JsiiByValue(fqn: "aws.appstreamStack.AppstreamStackStreamingExperienceSettings")]
    public class AppstreamStackStreamingExperienceSettings : aws.AppstreamStack.IAppstreamStackStreamingExperienceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#preferred_protocol AppstreamStack#preferred_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PreferredProtocol
        {
            get;
            set;
        }
    }
}
