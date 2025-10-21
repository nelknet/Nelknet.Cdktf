using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiInterface(nativeType: typeof(IEcsServiceServiceConnectConfigurationLogConfigurationSecretOption), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationLogConfigurationSecretOption")]
    public interface IEcsServiceServiceConnectConfigurationLogConfigurationSecretOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#name EcsService#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#value_from EcsService#value_from}.</summary>
        [JsiiProperty(name: "valueFrom", typeJson: "{\"primitive\":\"string\"}")]
        string ValueFrom
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsServiceServiceConnectConfigurationLogConfigurationSecretOption), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationLogConfigurationSecretOption")]
        internal sealed class _Proxy : DeputyBase, aws.EcsService.IEcsServiceServiceConnectConfigurationLogConfigurationSecretOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#name EcsService#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#value_from EcsService#value_from}.</summary>
            [JsiiProperty(name: "valueFrom", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueFrom
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
