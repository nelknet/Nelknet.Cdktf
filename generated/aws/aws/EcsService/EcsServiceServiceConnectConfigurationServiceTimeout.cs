using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiByValue(fqn: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceTimeout")]
    public class EcsServiceServiceConnectConfigurationServiceTimeout : aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTimeout
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#idle_timeout_seconds EcsService#idle_timeout_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idleTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IdleTimeoutSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#per_request_timeout_seconds EcsService#per_request_timeout_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "perRequestTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PerRequestTimeoutSeconds
        {
            get;
            set;
        }
    }
}
