using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueTrigger
{
    [JsiiInterface(nativeType: typeof(IGlueTriggerPredicate), fullyQualifiedName: "aws.glueTrigger.GlueTriggerPredicate")]
    public interface IGlueTriggerPredicate
    {
        /// <summary>conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#conditions GlueTrigger#conditions}
        /// </remarks>
        [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueTrigger.GlueTriggerPredicateConditions\"},\"kind\":\"array\"}}]}}")]
        object Conditions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#logical GlueTrigger#logical}.</summary>
        [JsiiProperty(name: "logical", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Logical
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueTriggerPredicate), fullyQualifiedName: "aws.glueTrigger.GlueTriggerPredicate")]
        internal sealed class _Proxy : DeputyBase, aws.GlueTrigger.IGlueTriggerPredicate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>conditions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#conditions GlueTrigger#conditions}
            /// </remarks>
            [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueTrigger.GlueTriggerPredicateConditions\"},\"kind\":\"array\"}}]}}")]
            public object Conditions
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#logical GlueTrigger#logical}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logical", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Logical
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
