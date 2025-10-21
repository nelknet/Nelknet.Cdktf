using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkService
{
    [JsiiClass(nativeType: typeof(azurerm.MobileNetworkService.MobileNetworkServicePccRuleOutputReference), fullyQualifiedName: "azurerm.mobileNetworkService.MobileNetworkServicePccRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MobileNetworkServicePccRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MobileNetworkServicePccRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected MobileNetworkServicePccRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MobileNetworkServicePccRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putQosPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicy\"}}]")]
        public virtual void PutQosPolicy(azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceDataFlowTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleServiceDataFlowTemplate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutServiceDataFlowTemplate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MobileNetworkService.IMobileNetworkServicePccRuleServiceDataFlowTemplate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MobileNetworkService.IMobileNetworkServicePccRuleServiceDataFlowTemplate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MobileNetworkService.IMobileNetworkServicePccRuleServiceDataFlowTemplate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetQosPolicy")]
        public virtual void ResetQosPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrafficControlEnabled")]
        public virtual void ResetTrafficControlEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "qosPolicy", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicyOutputReference\"}")]
        public virtual azurerm.MobileNetworkService.MobileNetworkServicePccRuleQosPolicyOutputReference QosPolicy
        {
            get => GetInstanceProperty<azurerm.MobileNetworkService.MobileNetworkServicePccRuleQosPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "serviceDataFlowTemplate", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleServiceDataFlowTemplateList\"}")]
        public virtual azurerm.MobileNetworkService.MobileNetworkServicePccRuleServiceDataFlowTemplateList ServiceDataFlowTemplate
        {
            get => GetInstanceProperty<azurerm.MobileNetworkService.MobileNetworkServicePccRuleServiceDataFlowTemplateList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "precedenceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PrecedenceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "qosPolicyInput", typeJson: "{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleQosPolicy\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicy? QosPolicyInput
        {
            get => GetInstanceProperty<azurerm.MobileNetworkService.IMobileNetworkServicePccRuleQosPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceDataFlowTemplateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRuleServiceDataFlowTemplate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ServiceDataFlowTemplateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficControlEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TrafficControlEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "precedence", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Precedence
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trafficControlEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TrafficControlEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.mobileNetworkService.MobileNetworkServicePccRule\"}]}}", isOptional: true)]
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
                        case azurerm.MobileNetworkService.IMobileNetworkServicePccRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MobileNetworkService.IMobileNetworkServicePccRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
