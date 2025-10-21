using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceVpcLatticeConfigurations), fullyQualifiedName: "aws.ecsService.EcsServiceVpcLatticeConfigurations")]
    public interface IEcsServiceVpcLatticeConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#port_name EcsService#port_name}.</summary>
        [JsiiProperty(name: "portName", typeJson: "{\"primitive\":\"string\"}")]
        string PortName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#role_arn EcsService#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#target_group_arn EcsService#target_group_arn}.</summary>
        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        string TargetGroupArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceVpcLatticeConfigurations), fullyQualifiedName: "aws.ecsService.EcsServiceVpcLatticeConfigurations")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceVpcLatticeConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#port_name EcsService#port_name}.</summary>
            [JsiiProperty(name: "portName", typeJson: "{\"primitive\":\"string\"}")]
            public string PortName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#role_arn EcsService#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#target_group_arn EcsService#target_group_arn}.</summary>
            [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetGroupArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
