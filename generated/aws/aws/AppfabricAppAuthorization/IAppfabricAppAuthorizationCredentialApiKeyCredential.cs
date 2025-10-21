using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricAppAuthorization
{
    [JsiiInterface(nativeType: typeof(IAppfabricAppAuthorizationCredentialApiKeyCredential), fullyQualifiedName: "aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialApiKeyCredential")]
    public interface IAppfabricAppAuthorizationCredentialApiKeyCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#api_key AppfabricAppAuthorization#api_key}.</summary>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        string ApiKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppfabricAppAuthorizationCredentialApiKeyCredential), fullyQualifiedName: "aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialApiKeyCredential")]
        internal sealed class _Proxy : DeputyBase, aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialApiKeyCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#api_key AppfabricAppAuthorization#api_key}.</summary>
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
