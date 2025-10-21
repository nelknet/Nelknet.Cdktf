using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VoiceServicesCommunicationsGateway
{
    [JsiiInterface(nativeType: typeof(IVoiceServicesCommunicationsGatewayServiceLocation), fullyQualifiedName: "azurerm.voiceServicesCommunicationsGateway.VoiceServicesCommunicationsGatewayServiceLocation")]
    public interface IVoiceServicesCommunicationsGatewayServiceLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#location VoiceServicesCommunicationsGateway#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#operator_addresses VoiceServicesCommunicationsGateway#operator_addresses}.</summary>
        [JsiiProperty(name: "operatorAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] OperatorAddresses
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#allowed_media_source_address_prefixes VoiceServicesCommunicationsGateway#allowed_media_source_address_prefixes}.</summary>
        [JsiiProperty(name: "allowedMediaSourceAddressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedMediaSourceAddressPrefixes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#allowed_signaling_source_address_prefixes VoiceServicesCommunicationsGateway#allowed_signaling_source_address_prefixes}.</summary>
        [JsiiProperty(name: "allowedSignalingSourceAddressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedSignalingSourceAddressPrefixes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#esrp_addresses VoiceServicesCommunicationsGateway#esrp_addresses}.</summary>
        [JsiiProperty(name: "esrpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EsrpAddresses
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVoiceServicesCommunicationsGatewayServiceLocation), fullyQualifiedName: "azurerm.voiceServicesCommunicationsGateway.VoiceServicesCommunicationsGatewayServiceLocation")]
        internal sealed class _Proxy : DeputyBase, azurerm.VoiceServicesCommunicationsGateway.IVoiceServicesCommunicationsGatewayServiceLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#location VoiceServicesCommunicationsGateway#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#operator_addresses VoiceServicesCommunicationsGateway#operator_addresses}.</summary>
            [JsiiProperty(name: "operatorAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] OperatorAddresses
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#allowed_media_source_address_prefixes VoiceServicesCommunicationsGateway#allowed_media_source_address_prefixes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedMediaSourceAddressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedMediaSourceAddressPrefixes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#allowed_signaling_source_address_prefixes VoiceServicesCommunicationsGateway#allowed_signaling_source_address_prefixes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedSignalingSourceAddressPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedSignalingSourceAddressPrefixes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway#esrp_addresses VoiceServicesCommunicationsGateway#esrp_addresses}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "esrpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EsrpAddresses
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
