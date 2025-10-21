using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    [JsiiInterface(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsCustomConnectorCustom), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsCustomConnectorCustom")]
    public interface IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsCustomConnectorCustom
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#custom_authentication_type AppflowConnectorProfile#custom_authentication_type}.</summary>
        [JsiiProperty(name: "customAuthenticationType", typeJson: "{\"primitive\":\"string\"}")]
        string CustomAuthenticationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#credentials_map AppflowConnectorProfile#credentials_map}.</summary>
        [JsiiProperty(name: "credentialsMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CredentialsMap
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsCustomConnectorCustom), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsCustomConnectorCustom")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfileCredentialsCustomConnectorCustom
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#custom_authentication_type AppflowConnectorProfile#custom_authentication_type}.</summary>
            [JsiiProperty(name: "customAuthenticationType", typeJson: "{\"primitive\":\"string\"}")]
            public string CustomAuthenticationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#credentials_map AppflowConnectorProfile#credentials_map}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentialsMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CredentialsMap
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
