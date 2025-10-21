using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NginxDeployment
{
    [JsiiByValue(fqn: "azurerm.nginxDeployment.NginxDeploymentFrontendPublic")]
    public class NginxDeploymentFrontendPublic : azurerm.NginxDeployment.INginxDeploymentFrontendPublic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#ip_address NginxDeployment#ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddress", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpAddress
        {
            get;
            set;
        }
    }
}
