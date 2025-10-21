using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAlias")]
    public class EcsServiceServiceConnectConfigurationServiceClientAlias : aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAlias
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#port EcsService#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#dns_name EcsService#dns_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsName
        {
            get;
            set;
        }
    }
}
