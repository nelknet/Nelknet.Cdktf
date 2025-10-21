using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DxHostedTransitVirtualInterface
{
    [JsiiInterface(nativeType: typeof(IDxHostedTransitVirtualInterfaceTimeouts), fullyQualifiedName: "aws.dxHostedTransitVirtualInterface.DxHostedTransitVirtualInterfaceTimeouts")]
    public interface IDxHostedTransitVirtualInterfaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#create DxHostedTransitVirtualInterface#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#delete DxHostedTransitVirtualInterface#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDxHostedTransitVirtualInterfaceTimeouts), fullyQualifiedName: "aws.dxHostedTransitVirtualInterface.DxHostedTransitVirtualInterfaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DxHostedTransitVirtualInterface.IDxHostedTransitVirtualInterfaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#create DxHostedTransitVirtualInterface#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_hosted_transit_virtual_interface#delete DxHostedTransitVirtualInterface#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
