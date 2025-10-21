using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppSiteConfigAutoHealSettingTriggerRequests), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerRequests")]
    public interface ILinuxWebAppSiteConfigAutoHealSettingTriggerRequests
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#count LinuxWebApp#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        double Count
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#interval LinuxWebApp#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        string Interval
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppSiteConfigAutoHealSettingTriggerRequests), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerRequests")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerRequests
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#count LinuxWebApp#count}.</summary>
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
            public double Count
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app#interval LinuxWebApp#interval}.</summary>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
            public string Interval
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
