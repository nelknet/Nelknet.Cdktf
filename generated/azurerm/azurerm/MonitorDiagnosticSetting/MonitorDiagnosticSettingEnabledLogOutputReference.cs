using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDiagnosticSetting
{
    [JsiiClass(nativeType: typeof(azurerm.MonitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLogOutputReference), fullyQualifiedName: "azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLogOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MonitorDiagnosticSettingEnabledLogOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MonitorDiagnosticSettingEnabledLogOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected MonitorDiagnosticSettingEnabledLogOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorDiagnosticSettingEnabledLogOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRetentionPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLogRetentionPolicy\"}}]")]
        public virtual void PutRetentionPolicy(azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingEnabledLogRetentionPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingEnabledLogRetentionPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCategory")]
        public virtual void ResetCategory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCategoryGroup")]
        public virtual void ResetCategoryGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionPolicy")]
        public virtual void ResetRetentionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLogRetentionPolicyOutputReference\"}")]
        public virtual azurerm.MonitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLogRetentionPolicyOutputReference RetentionPolicy
        {
            get => GetInstanceProperty<azurerm.MonitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLogRetentionPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "categoryGroupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CategoryGroupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "categoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CategoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPolicyInput", typeJson: "{\"fqn\":\"azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLogRetentionPolicy\"}", isOptional: true)]
        public virtual azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingEnabledLogRetentionPolicy? RetentionPolicyInput
        {
            get => GetInstanceProperty<azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingEnabledLogRetentionPolicy?>();
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "categoryGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CategoryGroup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.monitorDiagnosticSetting.MonitorDiagnosticSettingEnabledLog\"}]}}", isOptional: true)]
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
                        case azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingEnabledLog cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDiagnosticSetting.IMonitorDiagnosticSettingEnabledLog).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
