using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueTrigger.GlueTriggerPredicate")]
    public class GlueTriggerPredicate : aws.GlueTrigger.IGlueTriggerPredicate
    {
        private object _conditions;

        /// <summary>conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#conditions GlueTrigger#conditions}
        /// </remarks>
        [JsiiProperty(name: "conditions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueTrigger.GlueTriggerPredicateConditions\"},\"kind\":\"array\"}}]}}")]
        public object Conditions
        {
            get => _conditions;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.GlueTrigger.IGlueTriggerPredicateConditions[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueTrigger.IGlueTriggerPredicateConditions).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueTrigger.IGlueTriggerPredicateConditions).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _conditions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#logical GlueTrigger#logical}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logical", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Logical
        {
            get;
            set;
        }
    }
}
