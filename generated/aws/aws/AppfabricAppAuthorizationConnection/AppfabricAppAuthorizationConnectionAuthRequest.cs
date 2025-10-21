using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricAppAuthorizationConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appfabricAppAuthorizationConnection.AppfabricAppAuthorizationConnectionAuthRequest")]
    public class AppfabricAppAuthorizationConnectionAuthRequest : aws.AppfabricAppAuthorizationConnection.IAppfabricAppAuthorizationConnectionAuthRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection#code AppfabricAppAuthorizationConnection#code}.</summary>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        public string Code
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization_connection#redirect_uri AppfabricAppAuthorizationConnection#redirect_uri}.</summary>
        [JsiiProperty(name: "redirectUri", typeJson: "{\"primitive\":\"string\"}")]
        public string RedirectUri
        {
            get;
            set;
        }
    }
}
