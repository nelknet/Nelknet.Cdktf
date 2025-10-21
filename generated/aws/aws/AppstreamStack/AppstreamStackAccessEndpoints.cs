using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appstreamStack.AppstreamStackAccessEndpoints")]
    public class AppstreamStackAccessEndpoints : aws.AppstreamStack.IAppstreamStackAccessEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#endpoint_type AppstreamStack#endpoint_type}.</summary>
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public string EndpointType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#vpce_id AppstreamStack#vpce_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpceId
        {
            get;
            set;
        }
    }
}
