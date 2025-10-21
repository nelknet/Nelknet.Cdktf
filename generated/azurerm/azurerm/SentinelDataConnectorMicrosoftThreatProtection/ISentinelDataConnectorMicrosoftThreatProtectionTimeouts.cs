using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelDataConnectorMicrosoftThreatProtection
{
    [JsiiInterface(nativeType: typeof(ISentinelDataConnectorMicrosoftThreatProtectionTimeouts), fullyQualifiedName: "azurerm.sentinelDataConnectorMicrosoftThreatProtection.SentinelDataConnectorMicrosoftThreatProtectionTimeouts")]
    public interface ISentinelDataConnectorMicrosoftThreatProtectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_protection#create SentinelDataConnectorMicrosoftThreatProtection#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_protection#delete SentinelDataConnectorMicrosoftThreatProtection#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_protection#read SentinelDataConnectorMicrosoftThreatProtection#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISentinelDataConnectorMicrosoftThreatProtectionTimeouts), fullyQualifiedName: "azurerm.sentinelDataConnectorMicrosoftThreatProtection.SentinelDataConnectorMicrosoftThreatProtectionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.SentinelDataConnectorMicrosoftThreatProtection.ISentinelDataConnectorMicrosoftThreatProtectionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_protection#create SentinelDataConnectorMicrosoftThreatProtection#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_protection#delete SentinelDataConnectorMicrosoftThreatProtection#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/sentinel_data_connector_microsoft_threat_protection#read SentinelDataConnectorMicrosoftThreatProtection#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
