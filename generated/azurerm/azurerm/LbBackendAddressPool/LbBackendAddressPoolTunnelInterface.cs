using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LbBackendAddressPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.lbBackendAddressPool.LbBackendAddressPoolTunnelInterface")]
    public class LbBackendAddressPoolTunnelInterface : azurerm.LbBackendAddressPool.ILbBackendAddressPoolTunnelInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#identifier LbBackendAddressPool#identifier}.</summary>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"number\"}")]
        public double Identifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#port LbBackendAddressPool#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#protocol LbBackendAddressPool#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_backend_address_pool#type LbBackendAddressPool#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
