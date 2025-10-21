using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersVirtualCluster
{
    [JsiiInterface(nativeType: typeof(IEmrcontainersVirtualClusterTimeouts), fullyQualifiedName: "aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterTimeouts")]
    public interface IEmrcontainersVirtualClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster#delete EmrcontainersVirtualCluster#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrcontainersVirtualClusterTimeouts), fullyQualifiedName: "aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster#delete EmrcontainersVirtualCluster#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
