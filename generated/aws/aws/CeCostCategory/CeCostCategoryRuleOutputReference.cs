using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CeCostCategory
{
    [JsiiClass(nativeType: typeof(aws.CeCostCategory.CeCostCategoryRuleOutputReference), fullyQualifiedName: "aws.ceCostCategory.CeCostCategoryRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CeCostCategoryRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CeCostCategoryRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CeCostCategoryRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CeCostCategoryRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInheritedValue", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleInheritedValue\"}}]")]
        public virtual void PutInheritedValue(aws.CeCostCategory.ICeCostCategoryRuleInheritedValue @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleInheritedValue)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRule\"}}]")]
        public virtual void PutRule(aws.CeCostCategory.ICeCostCategoryRuleRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CeCostCategory.ICeCostCategoryRuleRule)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInheritedValue")]
        public virtual void ResetInheritedValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRule")]
        public virtual void ResetRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValue")]
        public virtual void ResetValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "inheritedValue", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleInheritedValueOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleInheritedValueOutputReference InheritedValue
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleInheritedValueOutputReference>()!;
        }

        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRuleOutputReference\"}")]
        public virtual aws.CeCostCategory.CeCostCategoryRuleRuleOutputReference Rule
        {
            get => GetInstanceProperty<aws.CeCostCategory.CeCostCategoryRuleRuleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "inheritedValueInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleInheritedValue\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleInheritedValue? InheritedValueInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleInheritedValue?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleInput", typeJson: "{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRuleRule\"}", isOptional: true)]
        public virtual aws.CeCostCategory.ICeCostCategoryRuleRule? RuleInput
        {
            get => GetInstanceProperty<aws.CeCostCategory.ICeCostCategoryRuleRule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.ceCostCategory.CeCostCategoryRule\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CeCostCategory.ICeCostCategoryRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CeCostCategory.ICeCostCategoryRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
