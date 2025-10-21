using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueTrigger.GlueTriggerEventBatchingCondition")]
    public class GlueTriggerEventBatchingCondition : aws.GlueTrigger.IGlueTriggerEventBatchingCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#batch_size GlueTrigger#batch_size}.</summary>
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}")]
        public double BatchSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#batch_window GlueTrigger#batch_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchWindow
        {
            get;
            set;
        }
    }
}
