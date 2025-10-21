using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    [JsiiInterface(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDynatrace), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDynatrace")]
    public interface IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDynatrace
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#api_token AppflowConnectorProfile#api_token}.</summary>
        [JsiiProperty(name: "apiToken", typeJson: "{\"primitive\":\"string\"}")]
        string ApiToken
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDynatrace), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDynatrace")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDynatrace
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#api_token AppflowConnectorProfile#api_token}.</summary>
            [JsiiProperty(name: "apiToken", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiToken
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
