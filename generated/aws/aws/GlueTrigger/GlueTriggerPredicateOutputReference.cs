using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueTrigger
{
    [JsiiClass(nativeType: typeof(aws.GlueTrigger.GlueTriggerPredicateOutputReference), fullyQualifiedName: "aws.glueTrigger.GlueTriggerPredicateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueTriggerPredicateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueTriggerPredicateOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueTriggerPredicateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueTriggerPredicateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConditions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueTrigger.GlueTriggerPredicateConditions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConditions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.GlueTrigger.IGlueTriggerPredicateConditions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueTrigger.IGlueTriggerPredicateConditions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.GlueTrigger.IGlueTriggerPredicateConditions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLogical")]
        public virtual void ResetLogical()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"aws.glueTrigger.GlueTriggerPredicateConditionsList\"}")]
        public virtual aws.GlueTrigger.GlueTriggerPredicateConditionsList Conditions
        {
            get => GetInstanceProperty<aws.GlueTrigger.GlueTriggerPredicateConditionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueTrigger.GlueTriggerPredicateConditions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConditionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logicalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogicalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "logical", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Logical
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueTrigger.GlueTriggerPredicate\"}", isOptional: true)]
        public virtual aws.GlueTrigger.IGlueTriggerPredicate? InternalValue
        {
            get => GetInstanceProperty<aws.GlueTrigger.IGlueTriggerPredicate?>();
            set => SetInstanceProperty(value);
        }
    }
}
