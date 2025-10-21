using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolWindows), fullyQualifiedName: "azurerm.batchPool.BatchPoolWindows")]
    public interface IBatchPoolWindows
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#enable_automatic_updates BatchPool#enable_automatic_updates}.</summary>
        [JsiiProperty(name: "enableAutomaticUpdates", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableAutomaticUpdates
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolWindows), fullyQualifiedName: "azurerm.batchPool.BatchPoolWindows")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolWindows
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#enable_automatic_updates BatchPool#enable_automatic_updates}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableAutomaticUpdates", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableAutomaticUpdates
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
