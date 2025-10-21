using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamImageBuilder
{
    [JsiiInterface(nativeType: typeof(IAppstreamImageBuilderAccessEndpoint), fullyQualifiedName: "aws.appstreamImageBuilder.AppstreamImageBuilderAccessEndpoint")]
    public interface IAppstreamImageBuilderAccessEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#endpoint_type AppstreamImageBuilder#endpoint_type}.</summary>
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#vpce_id AppstreamImageBuilder#vpce_id}.</summary>
        [JsiiProperty(name: "vpceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpceId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppstreamImageBuilderAccessEndpoint), fullyQualifiedName: "aws.appstreamImageBuilder.AppstreamImageBuilderAccessEndpoint")]
        internal sealed class _Proxy : DeputyBase, aws.AppstreamImageBuilder.IAppstreamImageBuilderAccessEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#endpoint_type AppstreamImageBuilder#endpoint_type}.</summary>
            [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_image_builder#vpce_id AppstreamImageBuilder#vpce_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpceId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
