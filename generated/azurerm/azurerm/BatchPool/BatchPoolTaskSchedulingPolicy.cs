using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolTaskSchedulingPolicy")]
    public class BatchPoolTaskSchedulingPolicy : azurerm.BatchPool.IBatchPoolTaskSchedulingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#node_fill_type BatchPool#node_fill_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeFillType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeFillType
        {
            get;
            set;
        }
    }
}
