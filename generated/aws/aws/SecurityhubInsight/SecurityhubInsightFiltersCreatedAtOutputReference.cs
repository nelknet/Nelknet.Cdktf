using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubInsight
{
    [JsiiClass(nativeType: typeof(aws.SecurityhubInsight.SecurityhubInsightFiltersCreatedAtOutputReference), fullyQualifiedName: "aws.securityhubInsight.SecurityhubInsightFiltersCreatedAtOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SecurityhubInsightFiltersCreatedAtOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SecurityhubInsightFiltersCreatedAtOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected SecurityhubInsightFiltersCreatedAtOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecurityhubInsightFiltersCreatedAtOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDateRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCreatedAtDateRange\"}}]")]
        public virtual void PutDateRange(aws.SecurityhubInsight.ISecurityhubInsightFiltersCreatedAtDateRange @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersCreatedAtDateRange)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDateRange")]
        public virtual void ResetDateRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnd")]
        public virtual void ResetEnd()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStart")]
        public virtual void ResetStart()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCreatedAtDateRangeOutputReference\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersCreatedAtDateRangeOutputReference DateRange
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersCreatedAtDateRangeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dateRangeInput", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCreatedAtDateRange\"}", isOptional: true)]
        public virtual aws.SecurityhubInsight.ISecurityhubInsightFiltersCreatedAtDateRange? DateRangeInput
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.ISecurityhubInsightFiltersCreatedAtDateRange?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string End
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Start
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCreatedAt\"}]}}", isOptional: true)]
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
                        case aws.SecurityhubInsight.ISecurityhubInsightFiltersCreatedAt cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersCreatedAt).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
