using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorAutoscaleSetting
{
    [JsiiClass(nativeType: typeof(azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileOutputReference), fullyQualifiedName: "azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MonitorAutoscaleSettingProfileOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MonitorAutoscaleSettingProfileOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected MonitorAutoscaleSettingProfileOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorAutoscaleSettingProfileOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCapacity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileCapacity\"}}]")]
        public virtual void PutCapacity(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileCapacity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileCapacity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFixedDate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileFixedDate\"}}]")]
        public virtual void PutFixedDate(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileFixedDate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileFixedDate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRecurrence", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRecurrence\"}}]")]
        public virtual void PutRecurrence(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRecurrence @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRecurrence)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFixedDate")]
        public virtual void ResetFixedDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecurrence")]
        public virtual void ResetRecurrence()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRule")]
        public virtual void ResetRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "capacity", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileCapacityOutputReference\"}")]
        public virtual azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileCapacityOutputReference Capacity
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileCapacityOutputReference>()!;
        }

        [JsiiProperty(name: "fixedDate", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileFixedDateOutputReference\"}")]
        public virtual azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileFixedDateOutputReference FixedDate
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileFixedDateOutputReference>()!;
        }

        [JsiiProperty(name: "recurrence", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRecurrenceOutputReference\"}")]
        public virtual azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileRecurrenceOutputReference Recurrence
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileRecurrenceOutputReference>()!;
        }

        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleList\"}")]
        public virtual azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleList Rule
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.MonitorAutoscaleSettingProfileRuleList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityInput", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileCapacity\"}", isOptional: true)]
        public virtual azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileCapacity? CapacityInput
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileCapacity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedDateInput", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileFixedDate\"}", isOptional: true)]
        public virtual azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileFixedDate? FixedDateInput
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileFixedDate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recurrenceInput", typeJson: "{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRecurrence\"}", isOptional: true)]
        public virtual azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRecurrence? RecurrenceInput
        {
            get => GetInstanceProperty<azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfileRecurrence?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfileRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.monitorAutoscaleSetting.MonitorAutoscaleSettingProfile\"}]}}", isOptional: true)]
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
                        case azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfile cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorAutoscaleSetting.IMonitorAutoscaleSettingProfile).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
