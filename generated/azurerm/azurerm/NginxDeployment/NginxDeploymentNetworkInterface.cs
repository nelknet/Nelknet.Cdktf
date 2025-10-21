using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NginxDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.nginxDeployment.NginxDeploymentNetworkInterface")]
    public class NginxDeploymentNetworkInterface : azurerm.NginxDeployment.INginxDeploymentNetworkInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#subnet_id NginxDeployment#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }
    }
}
