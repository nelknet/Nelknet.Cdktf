using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SignalrServiceNetworkAcl
{
    [JsiiInterface(nativeType: typeof(ISignalrServiceNetworkAclPublicNetwork), fullyQualifiedName: "azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclPublicNetwork")]
    public interface ISignalrServiceNetworkAclPublicNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#allowed_request_types SignalrServiceNetworkAcl#allowed_request_types}.</summary>
        [JsiiProperty(name: "allowedRequestTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedRequestTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#denied_request_types SignalrServiceNetworkAcl#denied_request_types}.</summary>
        [JsiiProperty(name: "deniedRequestTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DeniedRequestTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISignalrServiceNetworkAclPublicNetwork), fullyQualifiedName: "azurerm.signalrServiceNetworkAcl.SignalrServiceNetworkAclPublicNetwork")]
        internal sealed class _Proxy : DeputyBase, azurerm.SignalrServiceNetworkAcl.ISignalrServiceNetworkAclPublicNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#allowed_request_types SignalrServiceNetworkAcl#allowed_request_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedRequestTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedRequestTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/signalr_service_network_acl#denied_request_types SignalrServiceNetworkAcl#denied_request_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deniedRequestTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DeniedRequestTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
