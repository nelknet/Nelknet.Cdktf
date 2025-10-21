using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Frontdoor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.frontdoor.FrontdoorBackendPool")]
    public class FrontdoorBackendPool : azurerm.Frontdoor.IFrontdoorBackendPool
    {
        private object _backend;

        /// <summary>backend block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend Frontdoor#backend}
        /// </remarks>
        [JsiiProperty(name: "backend", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoor.FrontdoorBackendPoolBackend\"},\"kind\":\"array\"}}]}}")]
        public object Backend
        {
            get => _backend;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Frontdoor.IFrontdoorBackendPoolBackend[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Frontdoor.IFrontdoorBackendPoolBackend).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Frontdoor.IFrontdoorBackendPoolBackend).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _backend = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#health_probe_name Frontdoor#health_probe_name}.</summary>
        [JsiiProperty(name: "healthProbeName", typeJson: "{\"primitive\":\"string\"}")]
        public string HealthProbeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#load_balancing_name Frontdoor#load_balancing_name}.</summary>
        [JsiiProperty(name: "loadBalancingName", typeJson: "{\"primitive\":\"string\"}")]
        public string LoadBalancingName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#name Frontdoor#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
