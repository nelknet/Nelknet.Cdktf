using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExpressRoutePort
{
    [JsiiInterface(nativeType: typeof(IExpressRoutePortLink1), fullyQualifiedName: "azurerm.expressRoutePort.ExpressRoutePortLink1")]
    public interface IExpressRoutePortLink1
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#admin_enabled ExpressRoutePort#admin_enabled}.</summary>
        [JsiiProperty(name: "adminEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdminEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#macsec_cak_keyvault_secret_id ExpressRoutePort#macsec_cak_keyvault_secret_id}.</summary>
        [JsiiProperty(name: "macsecCakKeyvaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MacsecCakKeyvaultSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#macsec_cipher ExpressRoutePort#macsec_cipher}.</summary>
        [JsiiProperty(name: "macsecCipher", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MacsecCipher
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#macsec_ckn_keyvault_secret_id ExpressRoutePort#macsec_ckn_keyvault_secret_id}.</summary>
        [JsiiProperty(name: "macsecCknKeyvaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MacsecCknKeyvaultSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#macsec_sci_enabled ExpressRoutePort#macsec_sci_enabled}.</summary>
        [JsiiProperty(name: "macsecSciEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MacsecSciEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IExpressRoutePortLink1), fullyQualifiedName: "azurerm.expressRoutePort.ExpressRoutePortLink1")]
        internal sealed class _Proxy : DeputyBase, azurerm.ExpressRoutePort.IExpressRoutePortLink1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#admin_enabled ExpressRoutePort#admin_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adminEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AdminEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#macsec_cak_keyvault_secret_id ExpressRoutePort#macsec_cak_keyvault_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "macsecCakKeyvaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MacsecCakKeyvaultSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#macsec_cipher ExpressRoutePort#macsec_cipher}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "macsecCipher", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MacsecCipher
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#macsec_ckn_keyvault_secret_id ExpressRoutePort#macsec_ckn_keyvault_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "macsecCknKeyvaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MacsecCknKeyvaultSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#macsec_sci_enabled ExpressRoutePort#macsec_sci_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "macsecSciEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? MacsecSciEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
