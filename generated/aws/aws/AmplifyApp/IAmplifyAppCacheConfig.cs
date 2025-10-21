using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AmplifyApp
{
    [JsiiInterface(nativeType: typeof(IAmplifyAppCacheConfig), fullyQualifiedName: "aws.amplifyApp.AmplifyAppCacheConfig")]
    public interface IAmplifyAppCacheConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#type AmplifyApp#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAmplifyAppCacheConfig), fullyQualifiedName: "aws.amplifyApp.AmplifyAppCacheConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AmplifyApp.IAmplifyAppCacheConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/amplify_app#type AmplifyApp#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
