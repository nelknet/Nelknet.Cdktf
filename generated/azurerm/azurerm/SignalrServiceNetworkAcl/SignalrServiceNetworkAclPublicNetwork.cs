using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SignalrServiceNetworkAcl
{
    [JsiiByValue(fqn: "azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclPublicNetwork")]
    public class SignalrServiceNetworkAclPublicNetwork : azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclPublicNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#allowed_request_types SignalrServiceNetworkAcl#allowed_request_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedRequestTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedRequestTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#denied_request_types SignalrServiceNetworkAcl#denied_request_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deniedRequestTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DeniedRequestTypes
        {
            get;
            set;
        }
    }
}
