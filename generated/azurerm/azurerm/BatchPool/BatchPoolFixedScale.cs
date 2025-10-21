using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolFixedScale")]
    public class BatchPoolFixedScale : azurerm.BatchPool.IBatchPoolFixedScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#node_deallocation_method BatchPool#node_deallocation_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeDeallocationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeDeallocationMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#resize_timeout BatchPool#resize_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resizeTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResizeTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#target_dedicated_nodes BatchPool#target_dedicated_nodes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetDedicatedNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetDedicatedNodes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#target_low_priority_nodes BatchPool#target_low_priority_nodes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetLowPriorityNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetLowPriorityNodes
        {
            get;
            set;
        }
    }
}
