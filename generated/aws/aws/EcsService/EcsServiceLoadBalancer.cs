using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ecsService.EcsServiceLoadBalancer")]
    public class EcsServiceLoadBalancer : aws.EcsService.IEcsServiceLoadBalancer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#container_name EcsService#container_name}.</summary>
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}")]
        public string ContainerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#container_port EcsService#container_port}.</summary>
        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}")]
        public double ContainerPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#elb_name EcsService#elb_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ElbName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#target_group_arn EcsService#target_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetGroupArn
        {
            get;
            set;
        }
    }
}
