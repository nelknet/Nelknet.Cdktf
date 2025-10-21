using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StaticWebApp
{
    [JsiiInterface(nativeType: typeof(IStaticWebAppBasicAuth), fullyQualifiedName: "azurerm.staticWebApp.StaticWebAppBasicAuth")]
    public interface IStaticWebAppBasicAuth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#environments StaticWebApp#environments}.</summary>
        [JsiiProperty(name: "environments", typeJson: "{\"primitive\":\"string\"}")]
        string Environments
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#password StaticWebApp#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStaticWebAppBasicAuth), fullyQualifiedName: "azurerm.staticWebApp.StaticWebAppBasicAuth")]
        internal sealed class _Proxy : DeputyBase, azurerm.StaticWebApp.IStaticWebAppBasicAuth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#environments StaticWebApp#environments}.</summary>
            [JsiiProperty(name: "environments", typeJson: "{\"primitive\":\"string\"}")]
            public string Environments
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app#password StaticWebApp#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
