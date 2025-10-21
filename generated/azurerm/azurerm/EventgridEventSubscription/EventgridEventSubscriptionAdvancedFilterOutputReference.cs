using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.EventgridEventSubscription
{
    [JsiiClass(nativeType: typeof(azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterOutputReference), fullyQualifiedName: "azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EventgridEventSubscriptionAdvancedFilterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EventgridEventSubscriptionAdvancedFilterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EventgridEventSubscriptionAdvancedFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EventgridEventSubscriptionAdvancedFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBoolEquals", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterBoolEquals\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBoolEquals(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterBoolEquals[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterBoolEquals).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterBoolEquals).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIsNotNull", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNotNull\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIsNotNull(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterIsNotNull[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterIsNotNull).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterIsNotNull).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIsNullOrUndefined", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNullOrUndefined\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIsNullOrUndefined(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterIsNullOrUndefined[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterIsNullOrUndefined).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterIsNullOrUndefined).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNumberGreaterThan", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThan\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNumberGreaterThan(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberGreaterThan[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberGreaterThan).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberGreaterThan).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNumberGreaterThanOrEquals", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNumberGreaterThanOrEquals(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNumberIn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberIn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNumberIn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberIn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberIn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberIn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNumberInRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberInRange\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNumberInRange(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberInRange[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberInRange).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberInRange).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNumberLessThan", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThan\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNumberLessThan(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberLessThan[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberLessThan).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberLessThan).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNumberLessThanOrEquals", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThanOrEquals\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNumberLessThanOrEquals(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberLessThanOrEquals[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberLessThanOrEquals).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberLessThanOrEquals).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNumberNotIn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotIn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNumberNotIn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberNotIn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberNotIn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberNotIn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNumberNotInRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInRange\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNumberNotInRange(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberNotInRange[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberNotInRange).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterNumberNotInRange).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStringBeginsWith", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringBeginsWith\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStringBeginsWith(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringBeginsWith[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringBeginsWith).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringBeginsWith).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStringContains", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringContains\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStringContains(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringContains[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringContains).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringContains).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStringEndsWith", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringEndsWith\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStringEndsWith(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringEndsWith[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringEndsWith).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringEndsWith).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStringIn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringIn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStringIn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringIn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringIn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringIn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStringNotBeginsWith", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotBeginsWith\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStringNotBeginsWith(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotBeginsWith[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotBeginsWith).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotBeginsWith).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStringNotContains", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotContains\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStringNotContains(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotContains[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotContains).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotContains).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStringNotEndsWith", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotEndsWith\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStringNotEndsWith(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotEndsWith[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotEndsWith).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotEndsWith).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStringNotIn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotIn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStringNotIn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotIn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotIn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilterStringNotIn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBoolEquals")]
        public virtual void ResetBoolEquals()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsNotNull")]
        public virtual void ResetIsNotNull()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsNullOrUndefined")]
        public virtual void ResetIsNullOrUndefined()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberGreaterThan")]
        public virtual void ResetNumberGreaterThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberGreaterThanOrEquals")]
        public virtual void ResetNumberGreaterThanOrEquals()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberIn")]
        public virtual void ResetNumberIn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberInRange")]
        public virtual void ResetNumberInRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberLessThan")]
        public virtual void ResetNumberLessThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberLessThanOrEquals")]
        public virtual void ResetNumberLessThanOrEquals()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberNotIn")]
        public virtual void ResetNumberNotIn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberNotInRange")]
        public virtual void ResetNumberNotInRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStringBeginsWith")]
        public virtual void ResetStringBeginsWith()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStringContains")]
        public virtual void ResetStringContains()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStringEndsWith")]
        public virtual void ResetStringEndsWith()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStringIn")]
        public virtual void ResetStringIn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStringNotBeginsWith")]
        public virtual void ResetStringNotBeginsWith()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStringNotContains")]
        public virtual void ResetStringNotContains()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStringNotEndsWith")]
        public virtual void ResetStringNotEndsWith()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStringNotIn")]
        public virtual void ResetStringNotIn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "boolEquals", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterBoolEqualsList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterBoolEqualsList BoolEquals
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterBoolEqualsList>()!;
        }

        [JsiiProperty(name: "isNotNull", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNotNullList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNotNullList IsNotNull
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNotNullList>()!;
        }

        [JsiiProperty(name: "isNullOrUndefined", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNullOrUndefinedList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNullOrUndefinedList IsNullOrUndefined
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNullOrUndefinedList>()!;
        }

        [JsiiProperty(name: "numberGreaterThan", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThanList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThanList NumberGreaterThan
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThanList>()!;
        }

        [JsiiProperty(name: "numberGreaterThanOrEquals", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEqualsList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEqualsList NumberGreaterThanOrEquals
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEqualsList>()!;
        }

        [JsiiProperty(name: "numberIn", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberInList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberInList NumberIn
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberInList>()!;
        }

        [JsiiProperty(name: "numberInRange", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberInRangeList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberInRangeList NumberInRange
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberInRangeList>()!;
        }

        [JsiiProperty(name: "numberLessThan", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThanList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThanList NumberLessThan
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThanList>()!;
        }

        [JsiiProperty(name: "numberLessThanOrEquals", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThanOrEqualsList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThanOrEqualsList NumberLessThanOrEquals
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThanOrEqualsList>()!;
        }

        [JsiiProperty(name: "numberNotIn", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInList NumberNotIn
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInList>()!;
        }

        [JsiiProperty(name: "numberNotInRange", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInRangeList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInRangeList NumberNotInRange
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInRangeList>()!;
        }

        [JsiiProperty(name: "stringBeginsWith", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringBeginsWithList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringBeginsWithList StringBeginsWith
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringBeginsWithList>()!;
        }

        [JsiiProperty(name: "stringContains", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringContainsList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringContainsList StringContains
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringContainsList>()!;
        }

        [JsiiProperty(name: "stringEndsWith", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringEndsWithList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringEndsWithList StringEndsWith
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringEndsWithList>()!;
        }

        [JsiiProperty(name: "stringIn", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringInList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringInList StringIn
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringInList>()!;
        }

        [JsiiProperty(name: "stringNotBeginsWith", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotBeginsWithList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotBeginsWithList StringNotBeginsWith
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotBeginsWithList>()!;
        }

        [JsiiProperty(name: "stringNotContains", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotContainsList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotContainsList StringNotContains
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotContainsList>()!;
        }

        [JsiiProperty(name: "stringNotEndsWith", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotEndsWithList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotEndsWithList StringNotEndsWith
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotEndsWithList>()!;
        }

        [JsiiProperty(name: "stringNotIn", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotInList\"}")]
        public virtual azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotInList StringNotIn
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotInList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "boolEqualsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterBoolEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BoolEqualsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isNotNullInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNotNull\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IsNotNullInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isNullOrUndefinedInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterIsNullOrUndefined\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IsNullOrUndefinedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberGreaterThanInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThan\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NumberGreaterThanInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberGreaterThanOrEqualsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberGreaterThanOrEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NumberGreaterThanOrEqualsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberInInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NumberInInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberInRangeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberInRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NumberInRangeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberLessThanInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThan\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NumberLessThanInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberLessThanOrEqualsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberLessThanOrEquals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NumberLessThanOrEqualsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberNotInInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NumberNotInInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberNotInRangeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterNumberNotInRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NumberNotInRangeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringBeginsWithInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringBeginsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StringBeginsWithInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringContainsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringContains\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StringContainsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringEndsWithInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringEndsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StringEndsWithInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringInInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StringInInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringNotBeginsWithInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotBeginsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StringNotBeginsWithInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringNotContainsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotContains\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StringNotContainsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringNotEndsWithInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotEndsWith\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StringNotEndsWithInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringNotInInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilterStringNotIn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StringNotInInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.eventgridEventSubscription.EventgridEventSubscriptionAdvancedFilter\"}", isOptional: true)]
        public virtual azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilter? InternalValue
        {
            get => GetInstanceProperty<azurerm.EventgridEventSubscription.IEventgridEventSubscriptionAdvancedFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}
