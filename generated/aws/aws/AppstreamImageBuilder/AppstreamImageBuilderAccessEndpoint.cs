using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamImageBuilder
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appstreamImageBuilder.AppstreamImageBuilderAccessEndpoint")]
    public class AppstreamImageBuilderAccessEndpoint : aws.AppstreamImageBuilder.IAppstreamImageBuilderAccessEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#endpoint_type AppstreamImageBuilder#endpoint_type}.</summary>
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        public string EndpointType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#vpce_id AppstreamImageBuilder#vpce_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpceId
        {
            get;
            set;
        }
    }
}
