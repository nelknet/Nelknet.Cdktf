using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricAppAuthorization
{
    [JsiiInterface(nativeType: typeof(IAppfabricAppAuthorizationCredentialOauth2Credential), fullyQualifiedName: "aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialOauth2Credential")]
    public interface IAppfabricAppAuthorizationCredentialOauth2Credential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#client_id AppfabricAppAuthorization#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        string ClientId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#client_secret AppfabricAppAuthorization#client_secret}.</summary>
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        string ClientSecret
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppfabricAppAuthorizationCredentialOauth2Credential), fullyQualifiedName: "aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialOauth2Credential")]
        internal sealed class _Proxy : DeputyBase, aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialOauth2Credential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#client_id AppfabricAppAuthorization#client_id}.</summary>
            [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#client_secret AppfabricAppAuthorization#client_secret}.</summary>
            [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientSecret
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
