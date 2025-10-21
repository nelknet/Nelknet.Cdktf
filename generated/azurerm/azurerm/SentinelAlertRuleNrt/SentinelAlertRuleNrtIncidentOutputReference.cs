using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SentinelAlertRuleNrt
{
    [JsiiClass(nativeType: typeof(azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrtIncidentOutputReference), fullyQualifiedName: "azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtIncidentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SentinelAlertRuleNrtIncidentOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SentinelAlertRuleNrtIncidentOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SentinelAlertRuleNrtIncidentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SentinelAlertRuleNrtIncidentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrouping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtIncidentGrouping\"}}]")]
        public virtual void PutGrouping(azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtIncidentGrouping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtIncidentGrouping)}, new object[]{@value});
        }

        [JsiiProperty(name: "grouping", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtIncidentGroupingOutputReference\"}")]
        public virtual azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrtIncidentGroupingOutputReference Grouping
        {
            get => GetInstanceProperty<azurerm.SentinelAlertRuleNrt.SentinelAlertRuleNrtIncidentGroupingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "createIncidentEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CreateIncidentEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupingInput", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtIncidentGrouping\"}", isOptional: true)]
        public virtual azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtIncidentGrouping? GroupingInput
        {
            get => GetInstanceProperty<azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtIncidentGrouping?>();
        }

        [JsiiProperty(name: "createIncidentEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CreateIncidentEnabled
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.sentinelAlertRuleNrt.SentinelAlertRuleNrtIncident\"}", isOptional: true)]
        public virtual azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtIncident? InternalValue
        {
            get => GetInstanceProperty<azurerm.SentinelAlertRuleNrt.ISentinelAlertRuleNrtIncident?>();
            set => SetInstanceProperty(value);
        }
    }
}
