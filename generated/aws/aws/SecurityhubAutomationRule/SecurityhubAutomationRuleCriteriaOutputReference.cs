using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubAutomationRule
{
    [JsiiClass(nativeType: typeof(aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaOutputReference), fullyQualifiedName: "aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SecurityhubAutomationRuleCriteriaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SecurityhubAutomationRuleCriteriaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected SecurityhubAutomationRuleCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecurityhubAutomationRuleCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAwsAccountId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAwsAccountId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaAwsAccountId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaAwsAccountId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaAwsAccountId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAwsAccountName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAwsAccountName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaAwsAccountName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaAwsAccountName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaAwsAccountName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCompanyName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCompanyName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCompanyName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCompanyName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCompanyName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCompanyName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComplianceAssociatedStandardsId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceAssociatedStandardsId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutComplianceAssociatedStandardsId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceAssociatedStandardsId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceAssociatedStandardsId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceAssociatedStandardsId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComplianceSecurityControlId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceSecurityControlId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutComplianceSecurityControlId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceSecurityControlId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceSecurityControlId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceSecurityControlId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComplianceStatus", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceStatus\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutComplianceStatus(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceStatus[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceStatus).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaComplianceStatus).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConfidence", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaConfidence\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConfidence(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaConfidence[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaConfidence).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaConfidence).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCreatedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCreatedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCreatedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCreatedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCreatedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCreatedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCriticality", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCriticality\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCriticality(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCriticality[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCriticality).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaCriticality).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDescription", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaDescription\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDescription(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaDescription[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaDescription).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaDescription).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirstObservedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaFirstObservedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFirstObservedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaFirstObservedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaFirstObservedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaFirstObservedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeneratorId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaGeneratorId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGeneratorId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaGeneratorId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaGeneratorId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaGeneratorId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLastObservedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaLastObservedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLastObservedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaLastObservedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaLastObservedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaLastObservedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNoteText", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteText\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNoteText(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteText[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteText).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteText).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNoteUpdatedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNoteUpdatedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteUpdatedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteUpdatedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteUpdatedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNoteUpdatedBy", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedBy\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNoteUpdatedBy(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteUpdatedBy[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteUpdatedBy).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaNoteUpdatedBy).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProductArn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductArn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProductArn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaProductArn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaProductArn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaProductArn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProductName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProductName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaProductName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaProductName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaProductName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRecordState", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRecordState\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRecordState(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRecordState[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRecordState).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRecordState).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRelatedFindingsId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRelatedFindingsId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRelatedFindingsId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRelatedFindingsId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRelatedFindingsId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRelatedFindingsProductArn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRelatedFindingsProductArn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRelatedFindingsProductArn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRelatedFindingsProductArn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaRelatedFindingsProductArn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceApplicationArn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationArn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceApplicationArn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceApplicationArn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceApplicationArn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceApplicationArn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceApplicationName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceApplicationName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceApplicationName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceApplicationName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceApplicationName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceDetailsOther", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceDetailsOther\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceDetailsOther(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceDetailsOther[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceDetailsOther).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceDetailsOther).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourcePartition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourcePartition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourcePartition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourcePartition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourcePartition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourcePartition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceRegion", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceRegion\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceRegion(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceRegion[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceRegion).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceRegion).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaResourceType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSeverityLabel", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaSeverityLabel\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSeverityLabel(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaSeverityLabel[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaSeverityLabel).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaSeverityLabel).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceUrl", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaSourceUrl\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSourceUrl(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaSourceUrl[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaSourceUrl).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaSourceUrl).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTitle", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaTitle\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTitle(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaTitle[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaTitle).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaTitle).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpdatedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaUpdatedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUpdatedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaUpdatedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaUpdatedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaUpdatedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserDefinedFields", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaUserDefinedFields\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUserDefinedFields(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaUserDefinedFields[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaUserDefinedFields).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaUserDefinedFields).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerificationState", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaVerificationState\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVerificationState(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaVerificationState[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaVerificationState).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaVerificationState).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkflowStatus", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaWorkflowStatus\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWorkflowStatus(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaWorkflowStatus[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaWorkflowStatus).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteriaWorkflowStatus).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAwsAccountId")]
        public virtual void ResetAwsAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAwsAccountName")]
        public virtual void ResetAwsAccountName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompanyName")]
        public virtual void ResetCompanyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComplianceAssociatedStandardsId")]
        public virtual void ResetComplianceAssociatedStandardsId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComplianceSecurityControlId")]
        public virtual void ResetComplianceSecurityControlId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComplianceStatus")]
        public virtual void ResetComplianceStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfidence")]
        public virtual void ResetConfidence()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreatedAt")]
        public virtual void ResetCreatedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCriticality")]
        public virtual void ResetCriticality()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirstObservedAt")]
        public virtual void ResetFirstObservedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeneratorId")]
        public virtual void ResetGeneratorId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastObservedAt")]
        public virtual void ResetLastObservedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNoteText")]
        public virtual void ResetNoteText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNoteUpdatedAt")]
        public virtual void ResetNoteUpdatedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNoteUpdatedBy")]
        public virtual void ResetNoteUpdatedBy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductArn")]
        public virtual void ResetProductArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductName")]
        public virtual void ResetProductName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecordState")]
        public virtual void ResetRecordState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRelatedFindingsId")]
        public virtual void ResetRelatedFindingsId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRelatedFindingsProductArn")]
        public virtual void ResetRelatedFindingsProductArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceApplicationArn")]
        public virtual void ResetResourceApplicationArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceApplicationName")]
        public virtual void ResetResourceApplicationName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceDetailsOther")]
        public virtual void ResetResourceDetailsOther()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceId")]
        public virtual void ResetResourceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourcePartition")]
        public virtual void ResetResourcePartition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceRegion")]
        public virtual void ResetResourceRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTags")]
        public virtual void ResetResourceTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceType")]
        public virtual void ResetResourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSeverityLabel")]
        public virtual void ResetSeverityLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceUrl")]
        public virtual void ResetSourceUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTitle")]
        public virtual void ResetTitle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdatedAt")]
        public virtual void ResetUpdatedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserDefinedFields")]
        public virtual void ResetUserDefinedFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerificationState")]
        public virtual void ResetVerificationState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkflowStatus")]
        public virtual void ResetWorkflowStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "awsAccountId", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountIdList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountIdList AwsAccountId
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountIdList>()!;
        }

        [JsiiProperty(name: "awsAccountName", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountNameList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountNameList AwsAccountName
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountNameList>()!;
        }

        [JsiiProperty(name: "companyName", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCompanyNameList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaCompanyNameList CompanyName
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaCompanyNameList>()!;
        }

        [JsiiProperty(name: "complianceAssociatedStandardsId", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceAssociatedStandardsIdList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceAssociatedStandardsIdList ComplianceAssociatedStandardsId
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceAssociatedStandardsIdList>()!;
        }

        [JsiiProperty(name: "complianceSecurityControlId", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceSecurityControlIdList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceSecurityControlIdList ComplianceSecurityControlId
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceSecurityControlIdList>()!;
        }

        [JsiiProperty(name: "complianceStatus", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceStatusList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceStatusList ComplianceStatus
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceStatusList>()!;
        }

        [JsiiProperty(name: "confidence", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaConfidenceList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaConfidenceList Confidence
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaConfidenceList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCreatedAtList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaCreatedAtList CreatedAt
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaCreatedAtList>()!;
        }

        [JsiiProperty(name: "criticality", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCriticalityList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaCriticalityList Criticality
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaCriticalityList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaDescriptionList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaDescriptionList Description
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaDescriptionList>()!;
        }

        [JsiiProperty(name: "firstObservedAt", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaFirstObservedAtList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaFirstObservedAtList FirstObservedAt
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaFirstObservedAtList>()!;
        }

        [JsiiProperty(name: "generatorId", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaGeneratorIdList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaGeneratorIdList GeneratorId
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaGeneratorIdList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaIdList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaIdList Id
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaIdList>()!;
        }

        [JsiiProperty(name: "lastObservedAt", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaLastObservedAtList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaLastObservedAtList LastObservedAt
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaLastObservedAtList>()!;
        }

        [JsiiProperty(name: "noteText", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteTextList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteTextList NoteText
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteTextList>()!;
        }

        [JsiiProperty(name: "noteUpdatedAt", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedAtList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedAtList NoteUpdatedAt
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedAtList>()!;
        }

        [JsiiProperty(name: "noteUpdatedBy", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedByList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedByList NoteUpdatedBy
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedByList>()!;
        }

        [JsiiProperty(name: "productArn", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductArnList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductArnList ProductArn
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductArnList>()!;
        }

        [JsiiProperty(name: "productName", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductNameList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductNameList ProductName
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductNameList>()!;
        }

        [JsiiProperty(name: "recordState", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRecordStateList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaRecordStateList RecordState
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaRecordStateList>()!;
        }

        [JsiiProperty(name: "relatedFindingsId", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsIdList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsIdList RelatedFindingsId
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsIdList>()!;
        }

        [JsiiProperty(name: "relatedFindingsProductArn", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsProductArnList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsProductArnList RelatedFindingsProductArn
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsProductArnList>()!;
        }

        [JsiiProperty(name: "resourceApplicationArn", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationArnList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationArnList ResourceApplicationArn
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationArnList>()!;
        }

        [JsiiProperty(name: "resourceApplicationName", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationNameList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationNameList ResourceApplicationName
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationNameList>()!;
        }

        [JsiiProperty(name: "resourceDetailsOther", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceDetailsOtherList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceDetailsOtherList ResourceDetailsOther
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceDetailsOtherList>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceIdList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceIdList ResourceId
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceIdList>()!;
        }

        [JsiiProperty(name: "resourcePartition", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourcePartitionList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourcePartitionList ResourcePartition
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourcePartitionList>()!;
        }

        [JsiiProperty(name: "resourceRegion", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceRegionList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceRegionList ResourceRegion
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceRegionList>()!;
        }

        [JsiiProperty(name: "resourceTags", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceTagsList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceTagsList ResourceTags
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceTagsList>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceTypeList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceTypeList ResourceType
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceTypeList>()!;
        }

        [JsiiProperty(name: "severityLabel", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaSeverityLabelList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaSeverityLabelList SeverityLabel
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaSeverityLabelList>()!;
        }

        [JsiiProperty(name: "sourceUrl", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaSourceUrlList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaSourceUrlList SourceUrl
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaSourceUrlList>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaTitleList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaTitleList Title
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaTitleList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaTypeList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaTypeList Type
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaTypeList>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaUpdatedAtList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaUpdatedAtList UpdatedAt
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaUpdatedAtList>()!;
        }

        [JsiiProperty(name: "userDefinedFields", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaUserDefinedFieldsList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaUserDefinedFieldsList UserDefinedFields
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaUserDefinedFieldsList>()!;
        }

        [JsiiProperty(name: "verificationState", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaVerificationStateList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaVerificationStateList VerificationState
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaVerificationStateList>()!;
        }

        [JsiiProperty(name: "workflowStatus", typeJson: "{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaWorkflowStatusList\"}")]
        public virtual aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaWorkflowStatusList WorkflowStatus
        {
            get => GetInstanceProperty<aws.SecurityhubAutomationRule.SecurityhubAutomationRuleCriteriaWorkflowStatusList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsAccountIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AwsAccountIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsAccountNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaAwsAccountName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AwsAccountNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "companyNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCompanyName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CompanyNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "complianceAssociatedStandardsIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceAssociatedStandardsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ComplianceAssociatedStandardsIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "complianceSecurityControlIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceSecurityControlId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ComplianceSecurityControlIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "complianceStatusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaComplianceStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ComplianceStatusInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "confidenceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaConfidence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConfidenceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createdAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCreatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CreatedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "criticalityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaCriticality\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CriticalityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaDescription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DescriptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstObservedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaFirstObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FirstObservedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "generatorIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaGeneratorId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GeneratorIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastObservedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LastObservedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noteTextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NoteTextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noteUpdatedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NoteUpdatedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noteUpdatedByInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaNoteUpdatedBy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NoteUpdatedByInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productArnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProductArnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaProductName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProductNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordStateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRecordState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RecordStateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "relatedFindingsIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RelatedFindingsIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "relatedFindingsProductArnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RelatedFindingsProductArnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceApplicationArnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceApplicationArnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceApplicationNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceApplicationName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceApplicationNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceDetailsOtherInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceDetailsOther\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceDetailsOtherInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcePartitionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourcePartition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourcePartitionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceRegionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceRegionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaResourceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "severityLabelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaSeverityLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SeverityLabelInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceUrlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SourceUrlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "titleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaTitle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TitleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updatedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UpdatedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDefinedFieldsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaUserDefinedFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UserDefinedFieldsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verificationStateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaVerificationState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VerificationStateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workflowStatusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteriaWorkflowStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WorkflowStatusInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.securityhubAutomationRule.SecurityhubAutomationRuleCriteria\"}]}}", isOptional: true)]
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
                        case aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteria cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubAutomationRule.ISecurityhubAutomationRuleCriteria).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
