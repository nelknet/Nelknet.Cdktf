using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorDataCollectionRule
{
    [JsiiClass(nativeType: typeof(azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsOutputReference), fullyQualifiedName: "azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MonitorDataCollectionRuleDestinationsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MonitorDataCollectionRuleDestinationsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MonitorDataCollectionRuleDestinationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MonitorDataCollectionRuleDestinationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAzureMonitorMetrics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsAzureMonitorMetrics\"}}]")]
        public virtual void PutAzureMonitorMetrics(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsAzureMonitorMetrics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsAzureMonitorMetrics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEventHub", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHub\"}}]")]
        public virtual void PutEventHub(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHub @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHub)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEventHubDirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHubDirect\"}}]")]
        public virtual void PutEventHubDirect(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHubDirect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHubDirect)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogAnalytics", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsLogAnalytics\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogAnalytics(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsLogAnalytics[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsLogAnalytics).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsLogAnalytics).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitorAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsMonitorAccount\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMonitorAccount(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsMonitorAccount[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsMonitorAccount).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsMonitorAccount).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageBlob", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlob\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageBlob(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageBlob[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageBlob).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageBlob).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageBlobDirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlobDirect\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageBlobDirect(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageBlobDirect[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageBlobDirect).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageBlobDirect).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageTableDirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageTableDirect\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageTableDirect(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageTableDirect[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageTableDirect).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsStorageTableDirect).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAzureMonitorMetrics")]
        public virtual void ResetAzureMonitorMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventHub")]
        public virtual void ResetEventHub()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventHubDirect")]
        public virtual void ResetEventHubDirect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogAnalytics")]
        public virtual void ResetLogAnalytics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitorAccount")]
        public virtual void ResetMonitorAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageBlob")]
        public virtual void ResetStorageBlob()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageBlobDirect")]
        public virtual void ResetStorageBlobDirect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageTableDirect")]
        public virtual void ResetStorageTableDirect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "azureMonitorMetrics", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsAzureMonitorMetricsOutputReference\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsAzureMonitorMetricsOutputReference AzureMonitorMetrics
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsAzureMonitorMetricsOutputReference>()!;
        }

        [JsiiProperty(name: "eventHub", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHubOutputReference\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHubOutputReference EventHub
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHubOutputReference>()!;
        }

        [JsiiProperty(name: "eventHubDirect", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHubDirectOutputReference\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHubDirectOutputReference EventHubDirect
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHubDirectOutputReference>()!;
        }

        [JsiiProperty(name: "logAnalytics", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsLogAnalyticsList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsLogAnalyticsList LogAnalytics
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsLogAnalyticsList>()!;
        }

        [JsiiProperty(name: "monitorAccount", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsMonitorAccountList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsMonitorAccountList MonitorAccount
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsMonitorAccountList>()!;
        }

        [JsiiProperty(name: "storageBlob", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlobList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlobList StorageBlob
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlobList>()!;
        }

        [JsiiProperty(name: "storageBlobDirect", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlobDirectList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlobDirectList StorageBlobDirect
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlobDirectList>()!;
        }

        [JsiiProperty(name: "storageTableDirect", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageTableDirectList\"}")]
        public virtual azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageTableDirectList StorageTableDirect
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageTableDirectList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureMonitorMetricsInput", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsAzureMonitorMetrics\"}", isOptional: true)]
        public virtual azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsAzureMonitorMetrics? AzureMonitorMetricsInput
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsAzureMonitorMetrics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventHubDirectInput", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHubDirect\"}", isOptional: true)]
        public virtual azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHubDirect? EventHubDirectInput
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHubDirect?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventHubInput", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsEventHub\"}", isOptional: true)]
        public virtual azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHub? EventHubInput
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinationsEventHub?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logAnalyticsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsLogAnalytics\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogAnalyticsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitorAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsMonitorAccount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MonitorAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageBlobDirectInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlobDirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageBlobDirectInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageBlobInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageBlob\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageBlobInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageTableDirectInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinationsStorageTableDirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageTableDirectInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.monitorDataCollectionRule.MonitorDataCollectionRuleDestinations\"}", isOptional: true)]
        public virtual azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinations? InternalValue
        {
            get => GetInstanceProperty<azurerm.MonitorDataCollectionRule.IMonitorDataCollectionRuleDestinations?>();
            set => SetInstanceProperty(value);
        }
    }
}
