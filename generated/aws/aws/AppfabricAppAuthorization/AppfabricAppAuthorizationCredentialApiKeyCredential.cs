using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricAppAuthorization
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appfabricAppAuthorization.AppfabricAppAuthorizationCredentialApiKeyCredential")]
    public class AppfabricAppAuthorizationCredentialApiKeyCredential : aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationCredentialApiKeyCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#api_key AppfabricAppAuthorization#api_key}.</summary>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiKey
        {
            get;
            set;
        }
    }
}
