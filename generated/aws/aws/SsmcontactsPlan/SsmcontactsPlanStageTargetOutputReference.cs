using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsPlan
{
    [JsiiClass(nativeType: typeof(aws.SsmcontactsPlan.SsmcontactsPlanStageTargetOutputReference), fullyQualifiedName: "aws.ssmcontactsPlan.SsmcontactsPlanStageTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SsmcontactsPlanStageTargetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SsmcontactsPlanStageTargetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected SsmcontactsPlanStageTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmcontactsPlanStageTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putChannelTargetInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTargetChannelTargetInfo\"}}]")]
        public virtual void PutChannelTargetInfo(aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetChannelTargetInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetChannelTargetInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContactTargetInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTargetContactTargetInfo\"}}]")]
        public virtual void PutContactTargetInfo(aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetContactTargetInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetContactTargetInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetChannelTargetInfo")]
        public virtual void ResetChannelTargetInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContactTargetInfo")]
        public virtual void ResetContactTargetInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "channelTargetInfo", typeJson: "{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTargetChannelTargetInfoOutputReference\"}")]
        public virtual aws.SsmcontactsPlan.SsmcontactsPlanStageTargetChannelTargetInfoOutputReference ChannelTargetInfo
        {
            get => GetInstanceProperty<aws.SsmcontactsPlan.SsmcontactsPlanStageTargetChannelTargetInfoOutputReference>()!;
        }

        [JsiiProperty(name: "contactTargetInfo", typeJson: "{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTargetContactTargetInfoOutputReference\"}")]
        public virtual aws.SsmcontactsPlan.SsmcontactsPlanStageTargetContactTargetInfoOutputReference ContactTargetInfo
        {
            get => GetInstanceProperty<aws.SsmcontactsPlan.SsmcontactsPlanStageTargetContactTargetInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "channelTargetInfoInput", typeJson: "{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTargetChannelTargetInfo\"}", isOptional: true)]
        public virtual aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetChannelTargetInfo? ChannelTargetInfoInput
        {
            get => GetInstanceProperty<aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetChannelTargetInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contactTargetInfoInput", typeJson: "{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTargetContactTargetInfo\"}", isOptional: true)]
        public virtual aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetContactTargetInfo? ContactTargetInfoInput
        {
            get => GetInstanceProperty<aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetContactTargetInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTarget\"}]}}", isOptional: true)]
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
                        case aws.SsmcontactsPlan.ISsmcontactsPlanStageTarget cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsPlan.ISsmcontactsPlanStageTarget).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
