using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPoolTcp), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolTcp")]
    public interface IAppmeshVirtualNodeSpecListenerConnectionPoolTcp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#max_connections AppmeshVirtualNode#max_connections}.</summary>
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
        double MaxConnections
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerConnectionPoolTcp), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecListenerConnectionPoolTcp")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecListenerConnectionPoolTcp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#max_connections AppmeshVirtualNode#max_connections}.</summary>
            [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxConnections
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
