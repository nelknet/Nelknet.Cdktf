using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    [JsiiInterface(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsMarketoOauthRequest), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsMarketoOauthRequest")]
    public interface IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsMarketoOauthRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#auth_code AppflowConnectorProfile#auth_code}.</summary>
        [JsiiProperty(name: "authCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#redirect_uri AppflowConnectorProfile#redirect_uri}.</summary>
        [JsiiProperty(name: "redirectUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RedirectUri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsMarketoOauthRequest), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsMarketoOauthRequest")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsMarketoOauthRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#auth_code AppflowConnectorProfile#auth_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#redirect_uri AppflowConnectorProfile#redirect_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirectUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RedirectUri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
