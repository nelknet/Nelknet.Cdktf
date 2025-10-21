using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VoiceServicesCommunicationsGatewayTestLine
{
    [JsiiInterface(nativeType: typeof(IVoiceServicesCommunicationsGatewayTestLineTimeouts), fullyQualifiedName: "azurerm.voiceServicesCommunicationsGatewayTestLine.VoiceServicesCommunicationsGatewayTestLineTimeouts")]
    public interface IVoiceServicesCommunicationsGatewayTestLineTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#create VoiceServicesCommunicationsGatewayTestLine#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#delete VoiceServicesCommunicationsGatewayTestLine#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#read VoiceServicesCommunicationsGatewayTestLine#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#update VoiceServicesCommunicationsGatewayTestLine#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVoiceServicesCommunicationsGatewayTestLineTimeouts), fullyQualifiedName: "azurerm.voiceServicesCommunicationsGatewayTestLine.VoiceServicesCommunicationsGatewayTestLineTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.VoiceServicesCommunicationsGatewayTestLine.IVoiceServicesCommunicationsGatewayTestLineTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#create VoiceServicesCommunicationsGatewayTestLine#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#delete VoiceServicesCommunicationsGatewayTestLine#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#read VoiceServicesCommunicationsGatewayTestLine#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/voice_services_communications_gateway_test_line#update VoiceServicesCommunicationsGatewayTestLine#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
