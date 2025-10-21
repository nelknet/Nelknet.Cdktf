using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamStack
{
    [JsiiInterface(nativeType: typeof(IAppstreamStackStreamingExperienceSettings), fullyQualifiedName: "aws.appstreamStack.AppstreamStackStreamingExperienceSettings")]
    public interface IAppstreamStackStreamingExperienceSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#preferred_protocol AppstreamStack#preferred_protocol}.</summary>
        [JsiiProperty(name: "preferredProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreferredProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppstreamStackStreamingExperienceSettings), fullyQualifiedName: "aws.appstreamStack.AppstreamStackStreamingExperienceSettings")]
        internal sealed class _Proxy : DeputyBase, aws.AppstreamStack.IAppstreamStackStreamingExperienceSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#preferred_protocol AppstreamStack#preferred_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preferredProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreferredProtocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
