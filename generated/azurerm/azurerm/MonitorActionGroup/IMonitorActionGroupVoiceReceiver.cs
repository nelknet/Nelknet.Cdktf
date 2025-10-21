using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActionGroup
{
    [JsiiInterface(nativeType: typeof(IMonitorActionGroupVoiceReceiver), fullyQualifiedName: "azurerm.monitorActionGroup.MonitorActionGroupVoiceReceiver")]
    public interface IMonitorActionGroupVoiceReceiver
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#country_code MonitorActionGroup#country_code}.</summary>
        [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
        string CountryCode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#name MonitorActionGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#phone_number MonitorActionGroup#phone_number}.</summary>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        string PhoneNumber
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMonitorActionGroupVoiceReceiver), fullyQualifiedName: "azurerm.monitorActionGroup.MonitorActionGroupVoiceReceiver")]
        internal sealed class _Proxy : DeputyBase, azurerm.MonitorActionGroup.IMonitorActionGroupVoiceReceiver
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#country_code MonitorActionGroup#country_code}.</summary>
            [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
            public string CountryCode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#name MonitorActionGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#phone_number MonitorActionGroup#phone_number}.</summary>
            [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string PhoneNumber
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
