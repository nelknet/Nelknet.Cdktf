using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VmwareExpressRouteAuthorization
{
    [JsiiByValue(fqn: "azurerm.vmwareExpressRouteAuthorization.VmwareExpressRouteAuthorizationTimeouts")]
    public class VmwareExpressRouteAuthorizationTimeouts : azurerm.VmwareExpressRouteAuthorization.IVmwareExpressRouteAuthorizationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_express_route_authorization#create VmwareExpressRouteAuthorization#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_express_route_authorization#delete VmwareExpressRouteAuthorization#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_express_route_authorization#read VmwareExpressRouteAuthorization#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
