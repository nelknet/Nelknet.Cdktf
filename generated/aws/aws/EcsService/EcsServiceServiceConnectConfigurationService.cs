using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsService.EcsServiceServiceConnectConfigurationService")]
    public class EcsServiceServiceConnectConfigurationService : aws.EcsService.IEcsServiceServiceConnectConfigurationService
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#port_name EcsService#port_name}.</summary>
        [JsiiProperty(name: "portName", typeJson: "{\"primitive\":\"string\"}")]
        public string PortName
        {
            get;
            set;
        }

        /// <summary>client_alias block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#client_alias EcsService#client_alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientAlias", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceClientAlias\"}", isOptional: true)]
        public aws.EcsService.IEcsServiceServiceConnectConfigurationServiceClientAlias? ClientAlias
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#discovery_name EcsService#discovery_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "discoveryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiscoveryName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#ingress_port_override EcsService#ingress_port_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ingressPortOverride", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IngressPortOverride
        {
            get;
            set;
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#timeout EcsService#timeout}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTimeout\"}", isOptional: true)]
        public aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTimeout? Timeout
        {
            get;
            set;
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#tls EcsService#tls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTls\"}", isOptional: true)]
        public aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTls? Tls
        {
            get;
            set;
        }
    }
}
