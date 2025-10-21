using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Frontdoor
{
    [JsiiInterface(nativeType: typeof(IFrontdoorBackendPool), fullyQualifiedName: "azurerm.frontdoor.FrontdoorBackendPool")]
    public interface IFrontdoorBackendPool
    {
        /// <summary>backend block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend Frontdoor#backend}
        /// </remarks>
        [JsiiProperty(name: "backend", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoor.FrontdoorBackendPoolBackend\"},\"kind\":\"array\"}}]}}")]
        object Backend
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#health_probe_name Frontdoor#health_probe_name}.</summary>
        [JsiiProperty(name: "healthProbeName", typeJson: "{\"primitive\":\"string\"}")]
        string HealthProbeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#load_balancing_name Frontdoor#load_balancing_name}.</summary>
        [JsiiProperty(name: "loadBalancingName", typeJson: "{\"primitive\":\"string\"}")]
        string LoadBalancingName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#name Frontdoor#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFrontdoorBackendPool), fullyQualifiedName: "azurerm.frontdoor.FrontdoorBackendPool")]
        internal sealed class _Proxy : DeputyBase, azurerm.Frontdoor.IFrontdoorBackendPool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>backend block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend Frontdoor#backend}
            /// </remarks>
            [JsiiProperty(name: "backend", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.frontdoor.FrontdoorBackendPoolBackend\"},\"kind\":\"array\"}}]}}")]
            public object Backend
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#health_probe_name Frontdoor#health_probe_name}.</summary>
            [JsiiProperty(name: "healthProbeName", typeJson: "{\"primitive\":\"string\"}")]
            public string HealthProbeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#load_balancing_name Frontdoor#load_balancing_name}.</summary>
            [JsiiProperty(name: "loadBalancingName", typeJson: "{\"primitive\":\"string\"}")]
            public string LoadBalancingName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#name Frontdoor#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
