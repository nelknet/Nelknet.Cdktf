using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NginxDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.nginxDeployment.NginxDeploymentFrontendPrivate")]
    public class NginxDeploymentFrontendPrivate : azurerm.NginxDeployment.INginxDeploymentFrontendPrivate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#allocation_method NginxDeployment#allocation_method}.</summary>
        [JsiiProperty(name: "allocationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string AllocationMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#ip_address NginxDeployment#ip_address}.</summary>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string IpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#subnet_id NginxDeployment#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }
    }
}
