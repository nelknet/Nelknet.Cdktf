using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsCluster
{
    [JsiiInterface(nativeType: typeof(IEcsClusterServiceConnectDefaults), fullyQualifiedName: "aws.ecsCluster.EcsClusterServiceConnectDefaults")]
    public interface IEcsClusterServiceConnectDefaults
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#namespace EcsCluster#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEcsClusterServiceConnectDefaults), fullyQualifiedName: "aws.ecsCluster.EcsClusterServiceConnectDefaults")]
        internal sealed class _Proxy : DeputyBase, aws.EcsCluster.IEcsClusterServiceConnectDefaults
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_cluster#namespace EcsCluster#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
