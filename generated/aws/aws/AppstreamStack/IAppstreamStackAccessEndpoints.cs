using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamStack
{
    [JsiiInterface(nativeType: typeof(IAppstreamStackAccessEndpoints), fullyQualifiedName: "aws.appstreamStack.AppstreamStackAccessEndpoints")]
    public interface IAppstreamStackAccessEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#endpoint_type AppstreamStack#endpoint_type}.</summary>
        [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#vpce_id AppstreamStack#vpce_id}.</summary>
        [JsiiProperty(name: "vpceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpceId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppstreamStackAccessEndpoints), fullyQualifiedName: "aws.appstreamStack.AppstreamStackAccessEndpoints")]
        internal sealed class _Proxy : DeputyBase, aws.AppstreamStack.IAppstreamStackAccessEndpoints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#endpoint_type AppstreamStack#endpoint_type}.</summary>
            [JsiiProperty(name: "endpointType", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#vpce_id AppstreamStack#vpce_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpceId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
