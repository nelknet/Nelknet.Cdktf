using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.batchPool.BatchPoolAutoScale")]
    public class BatchPoolAutoScale : azurerm.BatchPool.IBatchPoolAutoScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#formula BatchPool#formula}.</summary>
        [JsiiProperty(name: "formula", typeJson: "{\"primitive\":\"string\"}")]
        public string Formula
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#evaluation_interval BatchPool#evaluation_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "evaluationInterval", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EvaluationInterval
        {
            get;
            set;
        }
    }
}
