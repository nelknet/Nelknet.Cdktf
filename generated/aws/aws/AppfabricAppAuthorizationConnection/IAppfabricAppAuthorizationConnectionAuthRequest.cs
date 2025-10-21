using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricAppAuthorizationConnection
{
    [JsiiInterface(nativeType: typeof(IAppfabricAppAuthorizationConnectionAuthRequest), fullyQualifiedName: "aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionAuthRequest")]
    public interface IAppfabricAppAuthorizationConnectionAuthRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection#code AppfabricAppAuthorizationConnection#code}.</summary>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        string Code
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection#redirect_uri AppfabricAppAuthorizationConnection#redirect_uri}.</summary>
        [JsiiProperty(name: "redirectUri", typeJson: "{\"primitive\":\"string\"}")]
        string RedirectUri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppfabricAppAuthorizationConnectionAuthRequest), fullyQualifiedName: "aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionAuthRequest")]
        internal sealed class _Proxy : DeputyBase, aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionAuthRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection#code AppfabricAppAuthorizationConnection#code}.</summary>
            [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
            public string Code
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection#redirect_uri AppfabricAppAuthorizationConnection#redirect_uri}.</summary>
            [JsiiProperty(name: "redirectUri", typeJson: "{\"primitive\":\"string\"}")]
            public string RedirectUri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
