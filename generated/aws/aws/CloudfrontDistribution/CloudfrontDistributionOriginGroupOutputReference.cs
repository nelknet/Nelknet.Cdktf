using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiClass(nativeType: typeof(aws.CloudfrontDistribution.CloudfrontDistributionOriginGroupOutputReference), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontDistributionOriginGroupOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public CloudfrontDistributionOriginGroupOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected CloudfrontDistributionOriginGroupOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionOriginGroupOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFailoverCriteria", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupFailoverCriteria\"}}]")]
        public virtual void PutFailoverCriteria(aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupFailoverCriteria @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupFailoverCriteria)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMember", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupMember\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMember(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupMember[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupMember).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupMember).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "failoverCriteria", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupFailoverCriteriaOutputReference\"}")]
        public virtual aws.CloudfrontDistribution.CloudfrontDistributionOriginGroupFailoverCriteriaOutputReference FailoverCriteria
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.CloudfrontDistributionOriginGroupFailoverCriteriaOutputReference>()!;
        }

        [JsiiProperty(name: "member", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupMemberList\"}")]
        public virtual aws.CloudfrontDistribution.CloudfrontDistributionOriginGroupMemberList Member
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.CloudfrontDistributionOriginGroupMemberList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "failoverCriteriaInput", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupFailoverCriteria\"}", isOptional: true)]
        public virtual aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupFailoverCriteria? FailoverCriteriaInput
        {
            get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupFailoverCriteria?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memberInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupMember\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MemberInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroup\"}]}}", isOptional: true)]
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
                        case aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroup cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroup).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
