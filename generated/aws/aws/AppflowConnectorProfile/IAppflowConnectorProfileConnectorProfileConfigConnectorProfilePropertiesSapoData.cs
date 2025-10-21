using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowConnectorProfile
{
    [JsiiInterface(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData")]
    public interface IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#application_host_url AppflowConnectorProfile#application_host_url}.</summary>
        [JsiiProperty(name: "applicationHostUrl", typeJson: "{\"primitive\":\"string\"}")]
        string ApplicationHostUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#application_service_path AppflowConnectorProfile#application_service_path}.</summary>
        [JsiiProperty(name: "applicationServicePath", typeJson: "{\"primitive\":\"string\"}")]
        string ApplicationServicePath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#client_number AppflowConnectorProfile#client_number}.</summary>
        [JsiiProperty(name: "clientNumber", typeJson: "{\"primitive\":\"string\"}")]
        string ClientNumber
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#port_number AppflowConnectorProfile#port_number}.</summary>
        [JsiiProperty(name: "portNumber", typeJson: "{\"primitive\":\"number\"}")]
        double PortNumber
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#logon_language AppflowConnectorProfile#logon_language}.</summary>
        [JsiiProperty(name: "logonLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogonLanguage
        {
            get
            {
                return null;
            }
        }

        /// <summary>oauth_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#oauth_properties AppflowConnectorProfile#oauth_properties}
        /// </remarks>
        [JsiiProperty(name: "oauthProperties", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties? OauthProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#private_link_service_name AppflowConnectorProfile#private_link_service_name}.</summary>
        [JsiiProperty(name: "privateLinkServiceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateLinkServiceName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData), fullyQualifiedName: "aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData")]
        internal sealed class _Proxy : DeputyBase, aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#application_host_url AppflowConnectorProfile#application_host_url}.</summary>
            [JsiiProperty(name: "applicationHostUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplicationHostUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#application_service_path AppflowConnectorProfile#application_service_path}.</summary>
            [JsiiProperty(name: "applicationServicePath", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplicationServicePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#client_number AppflowConnectorProfile#client_number}.</summary>
            [JsiiProperty(name: "clientNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientNumber
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#port_number AppflowConnectorProfile#port_number}.</summary>
            [JsiiProperty(name: "portNumber", typeJson: "{\"primitive\":\"number\"}")]
            public double PortNumber
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#logon_language AppflowConnectorProfile#logon_language}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logonLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogonLanguage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>oauth_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#oauth_properties AppflowConnectorProfile#oauth_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauthProperties", typeJson: "{\"fqn\":\"aws.appflowConnectorProfile.AppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties\"}", isOptional: true)]
            public aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties? OauthProperties
            {
                get => GetInstanceProperty<aws.AppflowConnectorProfile.IAppflowConnectorProfileConnectorProfileConfigConnectorProfilePropertiesSapoDataOauthProperties?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appflow_connector_profile#private_link_service_name AppflowConnectorProfile#private_link_service_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateLinkServiceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateLinkServiceName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
