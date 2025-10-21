using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolTaskSchedulingPolicy), fullyQualifiedName: "azurerm.batchPool.BatchPoolTaskSchedulingPolicy")]
    public interface IBatchPoolTaskSchedulingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#node_fill_type BatchPool#node_fill_type}.</summary>
        [JsiiProperty(name: "nodeFillType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeFillType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolTaskSchedulingPolicy), fullyQualifiedName: "azurerm.batchPool.BatchPoolTaskSchedulingPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolTaskSchedulingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#node_fill_type BatchPool#node_fill_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeFillType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeFillType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
