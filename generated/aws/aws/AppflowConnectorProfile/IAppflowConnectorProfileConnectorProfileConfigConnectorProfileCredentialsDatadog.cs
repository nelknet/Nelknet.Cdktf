using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    [JsiiInterface(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDatadog), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDatadog")]
    public interface IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDatadog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#api_key AppflowConnectorProfile#api_key}.</summary>
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
        string ApiKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#application_key AppflowConnectorProfile#application_key}.</summary>
        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}")]
        string ApplicationKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDatadog), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDatadog")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsDatadog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#api_key AppflowConnectorProfile#api_key}.</summary>
            [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#application_key AppflowConnectorProfile#application_key}.</summary>
            [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplicationKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
