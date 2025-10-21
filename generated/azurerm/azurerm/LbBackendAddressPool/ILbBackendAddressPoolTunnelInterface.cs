using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LbBackendAddressPool
{
    [JsiiInterface(nativeType: typeof(ILbBackendAddressPoolTunnelInterface), fullyQualifiedName: "azurerm.lbBackendAddressPool.LbBackendAddressPoolTunnelInterface")]
    public interface ILbBackendAddressPoolTunnelInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#identifier LbBackendAddressPool#identifier}.</summary>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"number\"}")]
        double Identifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#port LbBackendAddressPool#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#protocol LbBackendAddressPool#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#type LbBackendAddressPool#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbBackendAddressPoolTunnelInterface), fullyQualifiedName: "azurerm.lbBackendAddressPool.LbBackendAddressPoolTunnelInterface")]
        internal sealed class _Proxy : DeputyBase, azurerm.LbBackendAddressPool.ILbBackendAddressPoolTunnelInterface
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#identifier LbBackendAddressPool#identifier}.</summary>
            [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"number\"}")]
            public double Identifier
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#port LbBackendAddressPool#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#protocol LbBackendAddressPool#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#type LbBackendAddressPool#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
