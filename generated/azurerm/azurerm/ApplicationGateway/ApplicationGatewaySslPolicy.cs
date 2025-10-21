using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewaySslPolicy")]
    public class ApplicationGatewaySslPolicy : azurerm.ApplicationGateway.IApplicationGatewaySslPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#cipher_suites ApplicationGateway#cipher_suites}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cipherSuites", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CipherSuites
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#disabled_protocols ApplicationGateway#disabled_protocols}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disabledProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DisabledProtocols
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#min_protocol_version ApplicationGateway#min_protocol_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minProtocolVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinProtocolVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#policy_name ApplicationGateway#policy_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#policy_type ApplicationGateway#policy_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PolicyType
        {
            get;
            set;
        }
    }
}
