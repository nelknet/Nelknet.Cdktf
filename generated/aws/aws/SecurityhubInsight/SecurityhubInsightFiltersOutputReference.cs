using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubInsight
{
    [JsiiClass(nativeType: typeof(aws.SecurityhubInsight.SecurityhubInsightFiltersOutputReference), fullyQualifiedName: "aws.securityhubInsight.SecurityhubInsightFiltersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SecurityhubInsightFiltersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SecurityhubInsightFiltersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SecurityhubInsightFiltersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecurityhubInsightFiltersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAwsAccountId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersAwsAccountId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAwsAccountId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersAwsAccountId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersAwsAccountId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersAwsAccountId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCompanyName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCompanyName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCompanyName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersCompanyName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersCompanyName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersCompanyName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComplianceStatus", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersComplianceStatus\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutComplianceStatus(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersComplianceStatus[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersComplianceStatus).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersComplianceStatus).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConfidence", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersConfidence\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutConfidence(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersConfidence[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersConfidence).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersConfidence).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCreatedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCreatedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCreatedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersCreatedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersCreatedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersCreatedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCriticality", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCriticality\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCriticality(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersCriticality[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersCriticality).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersCriticality).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDescription", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersDescription\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDescription(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersDescription[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersDescription).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersDescription).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFindingProviderFieldsConfidence", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsConfidence\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFindingProviderFieldsConfidence(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsConfidence[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsConfidence).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsConfidence).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFindingProviderFieldsCriticality", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsCriticality\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFindingProviderFieldsCriticality(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsCriticality[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsCriticality).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsCriticality).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFindingProviderFieldsRelatedFindingsId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFindingProviderFieldsRelatedFindingsId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFindingProviderFieldsRelatedFindingsProductArn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFindingProviderFieldsRelatedFindingsProductArn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFindingProviderFieldsSeverityLabel", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityLabel\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFindingProviderFieldsSeverityLabel(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsSeverityLabel[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsSeverityLabel).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsSeverityLabel).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFindingProviderFieldsSeverityOriginal", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityOriginal\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFindingProviderFieldsSeverityOriginal(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsSeverityOriginal[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsSeverityOriginal).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsSeverityOriginal).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFindingProviderFieldsTypes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsTypes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFindingProviderFieldsTypes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsTypes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsTypes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFindingProviderFieldsTypes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirstObservedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFirstObservedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFirstObservedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersFirstObservedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFirstObservedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersFirstObservedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeneratorId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersGeneratorId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGeneratorId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersGeneratorId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersGeneratorId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersGeneratorId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyword", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersKeyword\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutKeyword(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersKeyword[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersKeyword).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersKeyword).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLastObservedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersLastObservedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLastObservedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersLastObservedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersLastObservedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersLastObservedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMalwareName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMalwareName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMalwarePath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwarePath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMalwarePath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwarePath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwarePath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwarePath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMalwareState", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareState\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMalwareState(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareState[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareState).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareState).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMalwareType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMalwareType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersMalwareType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkDestinationDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationDomain\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkDestinationDomain(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationDomain[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationDomain).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationDomain).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkDestinationIpv4", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv4\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkDestinationIpv4(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationIpv4[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationIpv4).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationIpv4).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkDestinationIpv6", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv6\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkDestinationIpv6(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationIpv6[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationIpv6).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationIpv6).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkDestinationPort", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationPort\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkDestinationPort(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationPort[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationPort).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDestinationPort).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkDirection", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDirection\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkDirection(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDirection[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDirection).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkDirection).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkProtocol", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkProtocol\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkProtocol(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkProtocol[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkProtocol).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkProtocol).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkSourceDomain", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceDomain\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkSourceDomain(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceDomain[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceDomain).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceDomain).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkSourceIpv4", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv4\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkSourceIpv4(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceIpv4[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceIpv4).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceIpv4).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkSourceIpv6", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv6\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkSourceIpv6(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceIpv6[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceIpv6).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceIpv6).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkSourceMac", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceMac\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkSourceMac(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceMac[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceMac).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourceMac).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkSourcePort", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourcePort\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkSourcePort(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourcePort[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourcePort).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNetworkSourcePort).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNoteText", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteText\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNoteText(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteText[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteText).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteText).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNoteUpdatedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteUpdatedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNoteUpdatedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteUpdatedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteUpdatedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteUpdatedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNoteUpdatedBy", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteUpdatedBy\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNoteUpdatedBy(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteUpdatedBy[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteUpdatedBy).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersNoteUpdatedBy).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessLaunchedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessLaunchedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProcessLaunchedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessLaunchedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessLaunchedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessLaunchedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProcessName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessParentPid", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessParentPid\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProcessParentPid(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessParentPid[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessParentPid).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessParentPid).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessPath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProcessPath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessPath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessPath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessPath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessPid", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessPid\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProcessPid(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessPid[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessPid).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessPid).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProcessTerminatedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessTerminatedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProcessTerminatedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessTerminatedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessTerminatedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProcessTerminatedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProductArn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductArn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProductArn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersProductArn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProductArn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProductArn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProductFields", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductFields\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProductFields(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersProductFields[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProductFields).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProductFields).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProductName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProductName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersProductName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProductName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersProductName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRecommendationText", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRecommendationText\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRecommendationText(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersRecommendationText[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersRecommendationText).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersRecommendationText).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRecordState", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRecordState\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRecordState(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersRecordState[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersRecordState).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersRecordState).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRelatedFindingsId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRelatedFindingsId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRelatedFindingsId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersRelatedFindingsId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersRelatedFindingsId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersRelatedFindingsId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRelatedFindingsProductArn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRelatedFindingsProductArn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersRelatedFindingsProductArn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersRelatedFindingsProductArn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersRelatedFindingsProductArn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsEc2InstanceIamInstanceProfileArn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsEc2InstanceIamInstanceProfileArn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsEc2InstanceImageId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceImageId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsEc2InstanceImageId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceImageId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceImageId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceImageId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsEc2InstanceIpv4Addresses", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsEc2InstanceIpv4Addresses(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsEc2InstanceIpv6Addresses", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsEc2InstanceIpv6Addresses(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsEc2InstanceKeyName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceKeyName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsEc2InstanceKeyName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceKeyName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceKeyName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceKeyName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsEc2InstanceLaunchedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsEc2InstanceLaunchedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsEc2InstanceSubnetId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceSubnetId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsEc2InstanceSubnetId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceSubnetId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceSubnetId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceSubnetId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsEc2InstanceType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsEc2InstanceType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsEc2InstanceVpcId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceVpcId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsEc2InstanceVpcId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceVpcId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceVpcId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsEc2InstanceVpcId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsIamAccessKeyCreatedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsIamAccessKeyCreatedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsIamAccessKeyStatus", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyStatus\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsIamAccessKeyStatus(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyStatus[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyStatus).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyStatus).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsIamAccessKeyUserName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyUserName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsIamAccessKeyUserName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyUserName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyUserName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsIamAccessKeyUserName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsS3BucketOwnerId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsS3BucketOwnerId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsS3BucketOwnerId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsS3BucketOwnerId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsS3BucketOwnerId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceAwsS3BucketOwnerName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceAwsS3BucketOwnerName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsS3BucketOwnerName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsS3BucketOwnerName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceAwsS3BucketOwnerName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceContainerImageId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerImageId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceContainerImageId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerImageId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerImageId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerImageId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceContainerImageName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerImageName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceContainerImageName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerImageName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerImageName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerImageName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceContainerLaunchedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerLaunchedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceContainerLaunchedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerLaunchedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerLaunchedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerLaunchedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceContainerName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceContainerName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceContainerName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceDetailsOther", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceDetailsOther\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceDetailsOther(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceDetailsOther[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceDetailsOther).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceDetailsOther).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourcePartition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourcePartition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourcePartition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourcePartition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourcePartition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourcePartition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceRegion", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceRegion\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceRegion(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceRegion[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceRegion).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceRegion).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersResourceType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSeverityLabel", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersSeverityLabel\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSeverityLabel(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersSeverityLabel[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersSeverityLabel).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersSeverityLabel).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceUrl", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersSourceUrl\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSourceUrl(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersSourceUrl[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersSourceUrl).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersSourceUrl).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThreatIntelIndicatorCategory", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorCategory\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutThreatIntelIndicatorCategory(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorCategory[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorCategory).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorCategory).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThreatIntelIndicatorLastObservedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutThreatIntelIndicatorLastObservedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThreatIntelIndicatorSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSource\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutThreatIntelIndicatorSource(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorSource[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorSource).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorSource).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThreatIntelIndicatorSourceUrl", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSourceUrl\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutThreatIntelIndicatorSourceUrl(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorSourceUrl[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorSourceUrl).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorSourceUrl).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThreatIntelIndicatorType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutThreatIntelIndicatorType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThreatIntelIndicatorValue", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorValue\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutThreatIntelIndicatorValue(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorValue[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorValue).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersThreatIntelIndicatorValue).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTitle", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersTitle\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTitle(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersTitle[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersTitle).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersTitle).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpdatedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersUpdatedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUpdatedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersUpdatedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersUpdatedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersUpdatedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserDefinedValues", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersUserDefinedValues\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUserDefinedValues(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersUserDefinedValues[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersUserDefinedValues).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersUserDefinedValues).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerificationState", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersVerificationState\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVerificationState(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersVerificationState[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersVerificationState).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersVerificationState).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkflowStatus", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersWorkflowStatus\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWorkflowStatus(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SecurityhubInsight.ISecurityhubInsightFiltersWorkflowStatus[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersWorkflowStatus).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SecurityhubInsight.ISecurityhubInsightFiltersWorkflowStatus).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAwsAccountId")]
        public virtual void ResetAwsAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompanyName")]
        public virtual void ResetCompanyName()
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

        [JsiiMethod(name: "resetFindingProviderFieldsConfidence")]
        public virtual void ResetFindingProviderFieldsConfidence()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingProviderFieldsCriticality")]
        public virtual void ResetFindingProviderFieldsCriticality()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingProviderFieldsRelatedFindingsId")]
        public virtual void ResetFindingProviderFieldsRelatedFindingsId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingProviderFieldsRelatedFindingsProductArn")]
        public virtual void ResetFindingProviderFieldsRelatedFindingsProductArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingProviderFieldsSeverityLabel")]
        public virtual void ResetFindingProviderFieldsSeverityLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingProviderFieldsSeverityOriginal")]
        public virtual void ResetFindingProviderFieldsSeverityOriginal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingProviderFieldsTypes")]
        public virtual void ResetFindingProviderFieldsTypes()
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

        [JsiiMethod(name: "resetKeyword")]
        public virtual void ResetKeyword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastObservedAt")]
        public virtual void ResetLastObservedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMalwareName")]
        public virtual void ResetMalwareName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMalwarePath")]
        public virtual void ResetMalwarePath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMalwareState")]
        public virtual void ResetMalwareState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMalwareType")]
        public virtual void ResetMalwareType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkDestinationDomain")]
        public virtual void ResetNetworkDestinationDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkDestinationIpv4")]
        public virtual void ResetNetworkDestinationIpv4()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkDestinationIpv6")]
        public virtual void ResetNetworkDestinationIpv6()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkDestinationPort")]
        public virtual void ResetNetworkDestinationPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkDirection")]
        public virtual void ResetNetworkDirection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkProtocol")]
        public virtual void ResetNetworkProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkSourceDomain")]
        public virtual void ResetNetworkSourceDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkSourceIpv4")]
        public virtual void ResetNetworkSourceIpv4()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkSourceIpv6")]
        public virtual void ResetNetworkSourceIpv6()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkSourceMac")]
        public virtual void ResetNetworkSourceMac()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkSourcePort")]
        public virtual void ResetNetworkSourcePort()
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

        [JsiiMethod(name: "resetProcessLaunchedAt")]
        public virtual void ResetProcessLaunchedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProcessName")]
        public virtual void ResetProcessName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProcessParentPid")]
        public virtual void ResetProcessParentPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProcessPath")]
        public virtual void ResetProcessPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProcessPid")]
        public virtual void ResetProcessPid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProcessTerminatedAt")]
        public virtual void ResetProcessTerminatedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductArn")]
        public virtual void ResetProductArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductFields")]
        public virtual void ResetProductFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductName")]
        public virtual void ResetProductName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecommendationText")]
        public virtual void ResetRecommendationText()
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

        [JsiiMethod(name: "resetResourceAwsEc2InstanceIamInstanceProfileArn")]
        public virtual void ResetResourceAwsEc2InstanceIamInstanceProfileArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsEc2InstanceImageId")]
        public virtual void ResetResourceAwsEc2InstanceImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsEc2InstanceIpv4Addresses")]
        public virtual void ResetResourceAwsEc2InstanceIpv4Addresses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsEc2InstanceIpv6Addresses")]
        public virtual void ResetResourceAwsEc2InstanceIpv6Addresses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsEc2InstanceKeyName")]
        public virtual void ResetResourceAwsEc2InstanceKeyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsEc2InstanceLaunchedAt")]
        public virtual void ResetResourceAwsEc2InstanceLaunchedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsEc2InstanceSubnetId")]
        public virtual void ResetResourceAwsEc2InstanceSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsEc2InstanceType")]
        public virtual void ResetResourceAwsEc2InstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsEc2InstanceVpcId")]
        public virtual void ResetResourceAwsEc2InstanceVpcId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsIamAccessKeyCreatedAt")]
        public virtual void ResetResourceAwsIamAccessKeyCreatedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsIamAccessKeyStatus")]
        public virtual void ResetResourceAwsIamAccessKeyStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsIamAccessKeyUserName")]
        public virtual void ResetResourceAwsIamAccessKeyUserName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsS3BucketOwnerId")]
        public virtual void ResetResourceAwsS3BucketOwnerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceAwsS3BucketOwnerName")]
        public virtual void ResetResourceAwsS3BucketOwnerName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceContainerImageId")]
        public virtual void ResetResourceContainerImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceContainerImageName")]
        public virtual void ResetResourceContainerImageName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceContainerLaunchedAt")]
        public virtual void ResetResourceContainerLaunchedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceContainerName")]
        public virtual void ResetResourceContainerName()
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

        [JsiiMethod(name: "resetThreatIntelIndicatorCategory")]
        public virtual void ResetThreatIntelIndicatorCategory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreatIntelIndicatorLastObservedAt")]
        public virtual void ResetThreatIntelIndicatorLastObservedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreatIntelIndicatorSource")]
        public virtual void ResetThreatIntelIndicatorSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreatIntelIndicatorSourceUrl")]
        public virtual void ResetThreatIntelIndicatorSourceUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreatIntelIndicatorType")]
        public virtual void ResetThreatIntelIndicatorType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThreatIntelIndicatorValue")]
        public virtual void ResetThreatIntelIndicatorValue()
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

        [JsiiMethod(name: "resetUserDefinedValues")]
        public virtual void ResetUserDefinedValues()
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

        [JsiiProperty(name: "awsAccountId", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersAwsAccountIdList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersAwsAccountIdList AwsAccountId
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersAwsAccountIdList>()!;
        }

        [JsiiProperty(name: "companyName", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCompanyNameList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersCompanyNameList CompanyName
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersCompanyNameList>()!;
        }

        [JsiiProperty(name: "complianceStatus", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersComplianceStatusList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersComplianceStatusList ComplianceStatus
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersComplianceStatusList>()!;
        }

        [JsiiProperty(name: "confidence", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersConfidenceList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersConfidenceList Confidence
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersConfidenceList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCreatedAtList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersCreatedAtList CreatedAt
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersCreatedAtList>()!;
        }

        [JsiiProperty(name: "criticality", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCriticalityList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersCriticalityList Criticality
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersCriticalityList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersDescriptionList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersDescriptionList Description
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersDescriptionList>()!;
        }

        [JsiiProperty(name: "findingProviderFieldsConfidence", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsConfidenceList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsConfidenceList FindingProviderFieldsConfidence
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsConfidenceList>()!;
        }

        [JsiiProperty(name: "findingProviderFieldsCriticality", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsCriticalityList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsCriticalityList FindingProviderFieldsCriticality
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsCriticalityList>()!;
        }

        [JsiiProperty(name: "findingProviderFieldsRelatedFindingsId", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsIdList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsIdList FindingProviderFieldsRelatedFindingsId
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsIdList>()!;
        }

        [JsiiProperty(name: "findingProviderFieldsRelatedFindingsProductArn", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArnList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArnList FindingProviderFieldsRelatedFindingsProductArn
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArnList>()!;
        }

        [JsiiProperty(name: "findingProviderFieldsSeverityLabel", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityLabelList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityLabelList FindingProviderFieldsSeverityLabel
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityLabelList>()!;
        }

        [JsiiProperty(name: "findingProviderFieldsSeverityOriginal", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityOriginalList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityOriginalList FindingProviderFieldsSeverityOriginal
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityOriginalList>()!;
        }

        [JsiiProperty(name: "findingProviderFieldsTypes", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsTypesList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsTypesList FindingProviderFieldsTypes
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsTypesList>()!;
        }

        [JsiiProperty(name: "firstObservedAt", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFirstObservedAtList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersFirstObservedAtList FirstObservedAt
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersFirstObservedAtList>()!;
        }

        [JsiiProperty(name: "generatorId", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersGeneratorIdList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersGeneratorIdList GeneratorId
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersGeneratorIdList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersIdList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersIdList Id
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersIdList>()!;
        }

        [JsiiProperty(name: "keyword", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersKeywordList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersKeywordList Keyword
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersKeywordList>()!;
        }

        [JsiiProperty(name: "lastObservedAt", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersLastObservedAtList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersLastObservedAtList LastObservedAt
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersLastObservedAtList>()!;
        }

        [JsiiProperty(name: "malwareName", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareNameList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersMalwareNameList MalwareName
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersMalwareNameList>()!;
        }

        [JsiiProperty(name: "malwarePath", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwarePathList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersMalwarePathList MalwarePath
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersMalwarePathList>()!;
        }

        [JsiiProperty(name: "malwareState", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareStateList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersMalwareStateList MalwareState
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersMalwareStateList>()!;
        }

        [JsiiProperty(name: "malwareType", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareTypeList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersMalwareTypeList MalwareType
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersMalwareTypeList>()!;
        }

        [JsiiProperty(name: "networkDestinationDomain", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationDomainList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkDestinationDomainList NetworkDestinationDomain
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkDestinationDomainList>()!;
        }

        [JsiiProperty(name: "networkDestinationIpv4", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv4List\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv4List NetworkDestinationIpv4
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv4List>()!;
        }

        [JsiiProperty(name: "networkDestinationIpv6", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv6List\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv6List NetworkDestinationIpv6
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv6List>()!;
        }

        [JsiiProperty(name: "networkDestinationPort", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationPortList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkDestinationPortList NetworkDestinationPort
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkDestinationPortList>()!;
        }

        [JsiiProperty(name: "networkDirection", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDirectionList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkDirectionList NetworkDirection
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkDirectionList>()!;
        }

        [JsiiProperty(name: "networkProtocol", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkProtocolList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkProtocolList NetworkProtocol
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkProtocolList>()!;
        }

        [JsiiProperty(name: "networkSourceDomain", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceDomainList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkSourceDomainList NetworkSourceDomain
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkSourceDomainList>()!;
        }

        [JsiiProperty(name: "networkSourceIpv4", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv4List\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv4List NetworkSourceIpv4
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv4List>()!;
        }

        [JsiiProperty(name: "networkSourceIpv6", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv6List\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv6List NetworkSourceIpv6
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv6List>()!;
        }

        [JsiiProperty(name: "networkSourceMac", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceMacList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkSourceMacList NetworkSourceMac
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkSourceMacList>()!;
        }

        [JsiiProperty(name: "networkSourcePort", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourcePortList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkSourcePortList NetworkSourcePort
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNetworkSourcePortList>()!;
        }

        [JsiiProperty(name: "noteText", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteTextList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNoteTextList NoteText
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNoteTextList>()!;
        }

        [JsiiProperty(name: "noteUpdatedAt", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteUpdatedAtList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNoteUpdatedAtList NoteUpdatedAt
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNoteUpdatedAtList>()!;
        }

        [JsiiProperty(name: "noteUpdatedBy", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteUpdatedByList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersNoteUpdatedByList NoteUpdatedBy
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersNoteUpdatedByList>()!;
        }

        [JsiiProperty(name: "processLaunchedAt", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessLaunchedAtList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersProcessLaunchedAtList ProcessLaunchedAt
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersProcessLaunchedAtList>()!;
        }

        [JsiiProperty(name: "processName", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessNameList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersProcessNameList ProcessName
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersProcessNameList>()!;
        }

        [JsiiProperty(name: "processParentPid", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessParentPidList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersProcessParentPidList ProcessParentPid
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersProcessParentPidList>()!;
        }

        [JsiiProperty(name: "processPath", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessPathList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersProcessPathList ProcessPath
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersProcessPathList>()!;
        }

        [JsiiProperty(name: "processPid", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessPidList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersProcessPidList ProcessPid
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersProcessPidList>()!;
        }

        [JsiiProperty(name: "processTerminatedAt", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessTerminatedAtList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersProcessTerminatedAtList ProcessTerminatedAt
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersProcessTerminatedAtList>()!;
        }

        [JsiiProperty(name: "productArn", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductArnList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersProductArnList ProductArn
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersProductArnList>()!;
        }

        [JsiiProperty(name: "productFields", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductFieldsList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersProductFieldsList ProductFields
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersProductFieldsList>()!;
        }

        [JsiiProperty(name: "productName", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductNameList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersProductNameList ProductName
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersProductNameList>()!;
        }

        [JsiiProperty(name: "recommendationText", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRecommendationTextList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersRecommendationTextList RecommendationText
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersRecommendationTextList>()!;
        }

        [JsiiProperty(name: "recordState", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRecordStateList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersRecordStateList RecordState
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersRecordStateList>()!;
        }

        [JsiiProperty(name: "relatedFindingsId", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRelatedFindingsIdList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersRelatedFindingsIdList RelatedFindingsId
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersRelatedFindingsIdList>()!;
        }

        [JsiiProperty(name: "relatedFindingsProductArn", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRelatedFindingsProductArnList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersRelatedFindingsProductArnList RelatedFindingsProductArn
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersRelatedFindingsProductArnList>()!;
        }

        [JsiiProperty(name: "resourceAwsEc2InstanceIamInstanceProfileArn", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArnList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArnList ResourceAwsEc2InstanceIamInstanceProfileArn
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArnList>()!;
        }

        [JsiiProperty(name: "resourceAwsEc2InstanceImageId", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceImageIdList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceImageIdList ResourceAwsEc2InstanceImageId
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceImageIdList>()!;
        }

        [JsiiProperty(name: "resourceAwsEc2InstanceIpv4Addresses", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv4AddressesList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv4AddressesList ResourceAwsEc2InstanceIpv4Addresses
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv4AddressesList>()!;
        }

        [JsiiProperty(name: "resourceAwsEc2InstanceIpv6Addresses", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6AddressesList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6AddressesList ResourceAwsEc2InstanceIpv6Addresses
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6AddressesList>()!;
        }

        [JsiiProperty(name: "resourceAwsEc2InstanceKeyName", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceKeyNameList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceKeyNameList ResourceAwsEc2InstanceKeyName
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceKeyNameList>()!;
        }

        [JsiiProperty(name: "resourceAwsEc2InstanceLaunchedAt", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAtList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAtList ResourceAwsEc2InstanceLaunchedAt
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAtList>()!;
        }

        [JsiiProperty(name: "resourceAwsEc2InstanceSubnetId", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceSubnetIdList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceSubnetIdList ResourceAwsEc2InstanceSubnetId
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceSubnetIdList>()!;
        }

        [JsiiProperty(name: "resourceAwsEc2InstanceType", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceTypeList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceTypeList ResourceAwsEc2InstanceType
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceTypeList>()!;
        }

        [JsiiProperty(name: "resourceAwsEc2InstanceVpcId", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceVpcIdList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceVpcIdList ResourceAwsEc2InstanceVpcId
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceVpcIdList>()!;
        }

        [JsiiProperty(name: "resourceAwsIamAccessKeyCreatedAt", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAtList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAtList ResourceAwsIamAccessKeyCreatedAt
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAtList>()!;
        }

        [JsiiProperty(name: "resourceAwsIamAccessKeyStatus", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyStatusList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyStatusList ResourceAwsIamAccessKeyStatus
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyStatusList>()!;
        }

        [JsiiProperty(name: "resourceAwsIamAccessKeyUserName", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyUserNameList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyUserNameList ResourceAwsIamAccessKeyUserName
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyUserNameList>()!;
        }

        [JsiiProperty(name: "resourceAwsS3BucketOwnerId", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerIdList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerIdList ResourceAwsS3BucketOwnerId
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerIdList>()!;
        }

        [JsiiProperty(name: "resourceAwsS3BucketOwnerName", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerNameList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerNameList ResourceAwsS3BucketOwnerName
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerNameList>()!;
        }

        [JsiiProperty(name: "resourceContainerImageId", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerImageIdList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceContainerImageIdList ResourceContainerImageId
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceContainerImageIdList>()!;
        }

        [JsiiProperty(name: "resourceContainerImageName", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerImageNameList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceContainerImageNameList ResourceContainerImageName
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceContainerImageNameList>()!;
        }

        [JsiiProperty(name: "resourceContainerLaunchedAt", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerLaunchedAtList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceContainerLaunchedAtList ResourceContainerLaunchedAt
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceContainerLaunchedAtList>()!;
        }

        [JsiiProperty(name: "resourceContainerName", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerNameList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceContainerNameList ResourceContainerName
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceContainerNameList>()!;
        }

        [JsiiProperty(name: "resourceDetailsOther", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceDetailsOtherList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceDetailsOtherList ResourceDetailsOther
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceDetailsOtherList>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceIdList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceIdList ResourceId
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceIdList>()!;
        }

        [JsiiProperty(name: "resourcePartition", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourcePartitionList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourcePartitionList ResourcePartition
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourcePartitionList>()!;
        }

        [JsiiProperty(name: "resourceRegion", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceRegionList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceRegionList ResourceRegion
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceRegionList>()!;
        }

        [JsiiProperty(name: "resourceTags", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceTagsList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceTagsList ResourceTags
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceTagsList>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceTypeList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersResourceTypeList ResourceType
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersResourceTypeList>()!;
        }

        [JsiiProperty(name: "severityLabel", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersSeverityLabelList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersSeverityLabelList SeverityLabel
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersSeverityLabelList>()!;
        }

        [JsiiProperty(name: "sourceUrl", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersSourceUrlList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersSourceUrlList SourceUrl
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersSourceUrlList>()!;
        }

        [JsiiProperty(name: "threatIntelIndicatorCategory", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorCategoryList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorCategoryList ThreatIntelIndicatorCategory
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorCategoryList>()!;
        }

        [JsiiProperty(name: "threatIntelIndicatorLastObservedAt", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAtList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAtList ThreatIntelIndicatorLastObservedAt
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAtList>()!;
        }

        [JsiiProperty(name: "threatIntelIndicatorSource", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSourceList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSourceList ThreatIntelIndicatorSource
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSourceList>()!;
        }

        [JsiiProperty(name: "threatIntelIndicatorSourceUrl", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSourceUrlList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSourceUrlList ThreatIntelIndicatorSourceUrl
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSourceUrlList>()!;
        }

        [JsiiProperty(name: "threatIntelIndicatorType", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorTypeList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorTypeList ThreatIntelIndicatorType
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorTypeList>()!;
        }

        [JsiiProperty(name: "threatIntelIndicatorValue", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorValueList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorValueList ThreatIntelIndicatorValue
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorValueList>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersTitleList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersTitleList Title
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersTitleList>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersTypeList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersTypeList Type
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersTypeList>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersUpdatedAtList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersUpdatedAtList UpdatedAt
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersUpdatedAtList>()!;
        }

        [JsiiProperty(name: "userDefinedValues", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersUserDefinedValuesList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersUserDefinedValuesList UserDefinedValues
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersUserDefinedValuesList>()!;
        }

        [JsiiProperty(name: "verificationState", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersVerificationStateList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersVerificationStateList VerificationState
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersVerificationStateList>()!;
        }

        [JsiiProperty(name: "workflowStatus", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersWorkflowStatusList\"}")]
        public virtual aws.SecurityhubInsight.SecurityhubInsightFiltersWorkflowStatusList WorkflowStatus
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.SecurityhubInsightFiltersWorkflowStatusList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsAccountIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersAwsAccountId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AwsAccountIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "companyNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCompanyName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CompanyNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "complianceStatusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersComplianceStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ComplianceStatusInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "confidenceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersConfidence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ConfidenceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createdAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCreatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CreatedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "criticalityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersCriticality\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CriticalityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersDescription\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DescriptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsConfidenceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsConfidence\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FindingProviderFieldsConfidenceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsCriticalityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsCriticality\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FindingProviderFieldsCriticalityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsRelatedFindingsIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FindingProviderFieldsRelatedFindingsIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsRelatedFindingsProductArnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FindingProviderFieldsRelatedFindingsProductArnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsSeverityLabelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FindingProviderFieldsSeverityLabelInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsSeverityOriginalInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsSeverityOriginal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FindingProviderFieldsSeverityOriginalInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingProviderFieldsTypesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFindingProviderFieldsTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FindingProviderFieldsTypesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstObservedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersFirstObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FirstObservedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "generatorIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersGeneratorId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GeneratorIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keywordInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersKeyword\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? KeywordInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastObservedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LastObservedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "malwareNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MalwareNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "malwarePathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwarePath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MalwarePathInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "malwareStateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MalwareStateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "malwareTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersMalwareType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MalwareTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkDestinationDomainInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationDomain\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkDestinationDomainInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkDestinationIpv4Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv4\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkDestinationIpv4Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkDestinationIpv6Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationIpv6\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkDestinationIpv6Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkDestinationPortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDestinationPort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkDestinationPortInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkDirectionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkDirection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkDirectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkProtocolInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkProtocolInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkSourceDomainInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceDomain\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkSourceDomainInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkSourceIpv4Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv4\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkSourceIpv4Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkSourceIpv6Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceIpv6\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkSourceIpv6Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkSourceMacInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourceMac\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkSourceMacInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkSourcePortInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNetworkSourcePort\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkSourcePortInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noteTextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NoteTextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noteUpdatedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NoteUpdatedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noteUpdatedByInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersNoteUpdatedBy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NoteUpdatedByInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processLaunchedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessLaunchedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProcessLaunchedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProcessNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processParentPidInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessParentPid\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProcessParentPidInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processPathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProcessPathInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processPidInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessPid\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProcessPidInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processTerminatedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProcessTerminatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProcessTerminatedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productArnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProductArnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productFieldsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProductFieldsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersProductName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProductNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recommendationTextInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRecommendationText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RecommendationTextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordStateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRecordState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RecordStateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "relatedFindingsIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRelatedFindingsId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RelatedFindingsIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "relatedFindingsProductArnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersRelatedFindingsProductArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RelatedFindingsProductArnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceIamInstanceProfileArnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIamInstanceProfileArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsEc2InstanceIamInstanceProfileArnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceImageIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceImageId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsEc2InstanceImageIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceIpv4AddressesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsEc2InstanceIpv4AddressesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceIpv6AddressesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsEc2InstanceIpv6AddressesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceKeyNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceKeyName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsEc2InstanceKeyNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceLaunchedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsEc2InstanceLaunchedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceSubnetIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceSubnetId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsEc2InstanceSubnetIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsEc2InstanceTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsEc2InstanceVpcIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsEc2InstanceVpcId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsEc2InstanceVpcIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsIamAccessKeyCreatedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyCreatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsIamAccessKeyCreatedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsIamAccessKeyStatusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsIamAccessKeyStatusInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsIamAccessKeyUserNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsIamAccessKeyUserName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsIamAccessKeyUserNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsS3BucketOwnerIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsS3BucketOwnerIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceAwsS3BucketOwnerNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceAwsS3BucketOwnerName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceAwsS3BucketOwnerNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceContainerImageIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerImageId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceContainerImageIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceContainerImageNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerImageName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceContainerImageNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceContainerLaunchedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerLaunchedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceContainerLaunchedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceContainerNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceContainerName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceContainerNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceDetailsOtherInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceDetailsOther\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceDetailsOtherInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcePartitionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourcePartition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourcePartitionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceRegionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceRegion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceRegionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersResourceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "severityLabelInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersSeverityLabel\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SeverityLabelInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceUrlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SourceUrlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorCategoryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorCategory\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ThreatIntelIndicatorCategoryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorLastObservedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ThreatIntelIndicatorLastObservedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorSourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ThreatIntelIndicatorSourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorSourceUrlInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorSourceUrl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ThreatIntelIndicatorSourceUrlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ThreatIntelIndicatorTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "threatIntelIndicatorValueInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersThreatIntelIndicatorValue\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ThreatIntelIndicatorValueInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "titleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersTitle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TitleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updatedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UpdatedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDefinedValuesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersUserDefinedValues\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UserDefinedValuesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verificationStateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersVerificationState\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VerificationStateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workflowStatusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFiltersWorkflowStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WorkflowStatusInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.securityhubInsight.SecurityhubInsightFilters\"}", isOptional: true)]
        public virtual aws.SecurityhubInsight.ISecurityhubInsightFilters? InternalValue
        {
            get => GetInstanceProperty<aws.SecurityhubInsight.ISecurityhubInsightFilters?>();
            set => SetInstanceProperty(value);
        }
    }
}
