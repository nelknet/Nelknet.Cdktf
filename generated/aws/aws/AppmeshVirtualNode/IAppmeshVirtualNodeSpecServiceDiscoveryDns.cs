using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshVirtualNode
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscoveryDns), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecServiceDiscoveryDns")]
    public interface IAppmeshVirtualNodeSpecServiceDiscoveryDns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#hostname AppmeshVirtualNode#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#ip_preference AppmeshVirtualNode#ip_preference}.</summary>
        [JsiiProperty(name: "ipPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#response_type AppmeshVirtualNode#response_type}.</summary>
        [JsiiProperty(name: "responseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecServiceDiscoveryDns), fullyQualifiedName: "aws.appmeshVirtualNode.AppmeshVirtualNodeSpecServiceDiscoveryDns")]
        internal sealed class _Proxy : DeputyBase, aws.AppmeshVirtualNode.IAppmeshVirtualNodeSpecServiceDiscoveryDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#hostname AppmeshVirtualNode#hostname}.</summary>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#ip_preference AppmeshVirtualNode#ip_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpPreference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appmesh_virtual_node#response_type AppmeshVirtualNode#response_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
