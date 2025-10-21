using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NewRelicMonitor
{
    [JsiiInterface(nativeType: typeof(INewRelicMonitorUser), fullyQualifiedName: "azurerm.newRelicMonitor.NewRelicMonitorUser")]
    public interface INewRelicMonitorUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#email NewRelicMonitor#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        string Email
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#first_name NewRelicMonitor#first_name}.</summary>
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        string FirstName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#last_name NewRelicMonitor#last_name}.</summary>
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        string LastName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#phone_number NewRelicMonitor#phone_number}.</summary>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        string PhoneNumber
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INewRelicMonitorUser), fullyQualifiedName: "azurerm.newRelicMonitor.NewRelicMonitorUser")]
        internal sealed class _Proxy : DeputyBase, azurerm.NewRelicMonitor.INewRelicMonitorUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#email NewRelicMonitor#email}.</summary>
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
            public string Email
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#first_name NewRelicMonitor#first_name}.</summary>
            [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
            public string FirstName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#last_name NewRelicMonitor#last_name}.</summary>
            [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
            public string LastName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#phone_number NewRelicMonitor#phone_number}.</summary>
            [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
            public string PhoneNumber
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
