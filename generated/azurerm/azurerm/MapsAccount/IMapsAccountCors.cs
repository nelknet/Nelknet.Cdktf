using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MapsAccount
{
    [JsiiInterface(nativeType: typeof(IMapsAccountCors), fullyQualifiedName: "azurerm.mapsAccount.MapsAccountCors")]
    public interface IMapsAccountCors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#allowed_origins MapsAccount#allowed_origins}.</summary>
        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedOrigins
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMapsAccountCors), fullyQualifiedName: "azurerm.mapsAccount.MapsAccountCors")]
        internal sealed class _Proxy : DeputyBase, azurerm.MapsAccount.IMapsAccountCors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#allowed_origins MapsAccount#allowed_origins}.</summary>
            [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedOrigins
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
