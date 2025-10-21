using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiInterface(nativeType: typeof(IBatchPoolFixedScale), fullyQualifiedName: "azurerm.batchPool.BatchPoolFixedScale")]
    public interface IBatchPoolFixedScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#node_deallocation_method BatchPool#node_deallocation_method}.</summary>
        [JsiiProperty(name: "nodeDeallocationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeDeallocationMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#resize_timeout BatchPool#resize_timeout}.</summary>
        [JsiiProperty(name: "resizeTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResizeTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#target_dedicated_nodes BatchPool#target_dedicated_nodes}.</summary>
        [JsiiProperty(name: "targetDedicatedNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetDedicatedNodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#target_low_priority_nodes BatchPool#target_low_priority_nodes}.</summary>
        [JsiiProperty(name: "targetLowPriorityNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetLowPriorityNodes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchPoolFixedScale), fullyQualifiedName: "azurerm.batchPool.BatchPoolFixedScale")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchPool.IBatchPoolFixedScale
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#node_deallocation_method BatchPool#node_deallocation_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeDeallocationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeDeallocationMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#resize_timeout BatchPool#resize_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resizeTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResizeTimeout
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#target_dedicated_nodes BatchPool#target_dedicated_nodes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetDedicatedNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetDedicatedNodes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#target_low_priority_nodes BatchPool#target_low_priority_nodes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetLowPriorityNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetLowPriorityNodes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
