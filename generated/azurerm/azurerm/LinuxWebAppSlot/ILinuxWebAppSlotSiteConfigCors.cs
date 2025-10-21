using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebAppSlot
{
    [JsiiInterface(nativeType: typeof(ILinuxWebAppSlotSiteConfigCors), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigCors")]
    public interface ILinuxWebAppSlotSiteConfigCors
    {
        /// <summary>Specifies a list of origins that should be allowed to make cross-origin calls.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#allowed_origins LinuxWebAppSlot#allowed_origins}
        /// </remarks>
        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedOrigins
        {
            get
            {
                return null;
            }
        }

        /// <summary>Are credentials allowed in CORS requests? Defaults to `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#support_credentials LinuxWebAppSlot#support_credentials}
        /// </remarks>
        [JsiiProperty(name: "supportCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SupportCredentials
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILinuxWebAppSlotSiteConfigCors), fullyQualifiedName: "azurerm.linuxWebAppSlot.LinuxWebAppSlotSiteConfigCors")]
        internal sealed class _Proxy : DeputyBase, azurerm.LinuxWebAppSlot.ILinuxWebAppSlotSiteConfigCors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies a list of origins that should be allowed to make cross-origin calls.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#allowed_origins LinuxWebAppSlot#allowed_origins}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedOrigins
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Are credentials allowed in CORS requests? Defaults to `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_web_app_slot#support_credentials LinuxWebAppSlot#support_credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "supportCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SupportCredentials
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
