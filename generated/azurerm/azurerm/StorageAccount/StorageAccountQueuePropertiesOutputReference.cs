using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.StorageAccount
{
    [JsiiClass(nativeType: typeof(azurerm.StorageAccount.StorageAccountQueuePropertiesOutputReference), fullyQualifiedName: "azurerm.storageAccount.StorageAccountQueuePropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StorageAccountQueuePropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StorageAccountQueuePropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StorageAccountQueuePropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageAccountQueuePropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCorsRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesCorsRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCorsRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.StorageAccount.IStorageAccountQueuePropertiesCorsRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageAccount.IStorageAccountQueuePropertiesCorsRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.StorageAccount.IStorageAccountQueuePropertiesCorsRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHourMetrics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesHourMetrics\"}}]")]
        public virtual void PutHourMetrics(azurerm.StorageAccount.IStorageAccountQueuePropertiesHourMetrics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountQueuePropertiesHourMetrics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogging", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesLogging\"}}]")]
        public virtual void PutLogging(azurerm.StorageAccount.IStorageAccountQueuePropertiesLogging @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountQueuePropertiesLogging)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMinuteMetrics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesMinuteMetrics\"}}]")]
        public virtual void PutMinuteMetrics(azurerm.StorageAccount.IStorageAccountQueuePropertiesMinuteMetrics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.StorageAccount.IStorageAccountQueuePropertiesMinuteMetrics)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCorsRule")]
        public virtual void ResetCorsRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHourMetrics")]
        public virtual void ResetHourMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogging")]
        public virtual void ResetLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinuteMetrics")]
        public virtual void ResetMinuteMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "corsRule", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesCorsRuleList\"}")]
        public virtual azurerm.StorageAccount.StorageAccountQueuePropertiesCorsRuleList CorsRule
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountQueuePropertiesCorsRuleList>()!;
        }

        [JsiiProperty(name: "hourMetrics", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesHourMetricsOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountQueuePropertiesHourMetricsOutputReference HourMetrics
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountQueuePropertiesHourMetricsOutputReference>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesLoggingOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountQueuePropertiesLoggingOutputReference Logging
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountQueuePropertiesLoggingOutputReference>()!;
        }

        [JsiiProperty(name: "minuteMetrics", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesMinuteMetricsOutputReference\"}")]
        public virtual azurerm.StorageAccount.StorageAccountQueuePropertiesMinuteMetricsOutputReference MinuteMetrics
        {
            get => GetInstanceProperty<azurerm.StorageAccount.StorageAccountQueuePropertiesMinuteMetricsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CorsRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hourMetricsInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesHourMetrics\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountQueuePropertiesHourMetrics? HourMetricsInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountQueuePropertiesHourMetrics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesLogging\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountQueuePropertiesLogging? LoggingInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountQueuePropertiesLogging?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minuteMetricsInput", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueuePropertiesMinuteMetrics\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountQueuePropertiesMinuteMetrics? MinuteMetricsInput
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountQueuePropertiesMinuteMetrics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.storageAccount.StorageAccountQueueProperties\"}", isOptional: true)]
        public virtual azurerm.StorageAccount.IStorageAccountQueueProperties? InternalValue
        {
            get => GetInstanceProperty<azurerm.StorageAccount.IStorageAccountQueueProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
