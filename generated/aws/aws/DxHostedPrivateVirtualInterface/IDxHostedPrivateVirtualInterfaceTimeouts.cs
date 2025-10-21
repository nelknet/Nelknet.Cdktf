using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DxHostedPrivateVirtualInterface
{
    [JsiiInterface(nativeType: typeof(IDxHostedPrivateVirtualInterfaceTimeouts), fullyQualifiedName: "aws.dxHostedPrivateVirtualInterface.DxHostedPrivateVirtualInterfaceTimeouts")]
    public interface IDxHostedPrivateVirtualInterfaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#create DxHostedPrivateVirtualInterface#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#delete DxHostedPrivateVirtualInterface#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDxHostedPrivateVirtualInterfaceTimeouts), fullyQualifiedName: "aws.dxHostedPrivateVirtualInterface.DxHostedPrivateVirtualInterfaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DxHostedPrivateVirtualInterface.IDxHostedPrivateVirtualInterfaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#create DxHostedPrivateVirtualInterface#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_private_virtual_interface#delete DxHostedPrivateVirtualInterface#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
