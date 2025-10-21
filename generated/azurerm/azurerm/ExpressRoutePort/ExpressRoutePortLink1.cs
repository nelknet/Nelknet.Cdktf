using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ExpressRoutePort
{
    [JsiiByValue(fqn: "azurerm.expressRoutePort.ExpressRoutePortLink1")]
    public class ExpressRoutePortLink1 : azurerm.ExpressRoutePort.IExpressRoutePortLink1
    {
        private object? _adminEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#admin_enabled ExpressRoutePort#admin_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AdminEnabled
        {
            get => _adminEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _adminEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#macsec_cak_keyvault_secret_id ExpressRoutePort#macsec_cak_keyvault_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "macsecCakKeyvaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MacsecCakKeyvaultSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#macsec_cipher ExpressRoutePort#macsec_cipher}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "macsecCipher", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MacsecCipher
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#macsec_ckn_keyvault_secret_id ExpressRoutePort#macsec_ckn_keyvault_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "macsecCknKeyvaultSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MacsecCknKeyvaultSecretId
        {
            get;
            set;
        }

        private object? _macsecSciEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/express_route_port#macsec_sci_enabled ExpressRoutePort#macsec_sci_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "macsecSciEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? MacsecSciEnabled
        {
            get => _macsecSciEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _macsecSciEnabled = value;
            }
        }
    }
}
