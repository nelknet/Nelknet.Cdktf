using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueTrigger
{
    [JsiiInterface(nativeType: typeof(IGlueTriggerEventBatchingCondition), fullyQualifiedName: "aws.glueTrigger.GlueTriggerEventBatchingCondition")]
    public interface IGlueTriggerEventBatchingCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#batch_size GlueTrigger#batch_size}.</summary>
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}")]
        double BatchSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#batch_window GlueTrigger#batch_window}.</summary>
        [JsiiProperty(name: "batchWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchWindow
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueTriggerEventBatchingCondition), fullyQualifiedName: "aws.glueTrigger.GlueTriggerEventBatchingCondition")]
        internal sealed class _Proxy : DeputyBase, aws.GlueTrigger.IGlueTriggerEventBatchingCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#batch_size GlueTrigger#batch_size}.</summary>
            [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}")]
            public double BatchSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#batch_window GlueTrigger#batch_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchWindow
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
