using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSlot
{
    [JsiiClass(nativeType: typeof(azurerm.AppServiceSlot.AppServiceSlotLogsOutputReference), fullyQualifiedName: "azurerm.appServiceSlot.AppServiceSlotLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppServiceSlotLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppServiceSlotLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppServiceSlotLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppServiceSlotLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplicationLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsApplicationLogs\"}}]")]
        public virtual void PutApplicationLogs(azurerm.AppServiceSlot.IAppServiceSlotLogsApplicationLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AppServiceSlot.IAppServiceSlotLogsApplicationLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogs\"}}]")]
        public virtual void PutHttpLogs(azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplicationLogs")]
        public virtual void ResetApplicationLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDetailedErrorMessagesEnabled")]
        public virtual void ResetDetailedErrorMessagesEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailedRequestTracingEnabled")]
        public virtual void ResetFailedRequestTracingEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpLogs")]
        public virtual void ResetHttpLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsApplicationLogsOutputReference\"}")]
        public virtual azurerm.AppServiceSlot.AppServiceSlotLogsApplicationLogsOutputReference ApplicationLogs
        {
            get => GetInstanceProperty<azurerm.AppServiceSlot.AppServiceSlotLogsApplicationLogsOutputReference>()!;
        }

        [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogsOutputReference\"}")]
        public virtual azurerm.AppServiceSlot.AppServiceSlotLogsHttpLogsOutputReference HttpLogs
        {
            get => GetInstanceProperty<azurerm.AppServiceSlot.AppServiceSlotLogsHttpLogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationLogsInput", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsApplicationLogs\"}", isOptional: true)]
        public virtual azurerm.AppServiceSlot.IAppServiceSlotLogsApplicationLogs? ApplicationLogsInput
        {
            get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotLogsApplicationLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detailedErrorMessagesEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DetailedErrorMessagesEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failedRequestTracingEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FailedRequestTracingEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpLogsInput", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogsHttpLogs\"}", isOptional: true)]
        public virtual azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogs? HttpLogsInput
        {
            get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotLogsHttpLogs?>();
        }

        [JsiiProperty(name: "detailedErrorMessagesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DetailedErrorMessagesEnabled
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

        [JsiiProperty(name: "failedRequestTracingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object FailedRequestTracingEnabled
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.appServiceSlot.AppServiceSlotLogs\"}", isOptional: true)]
        public virtual azurerm.AppServiceSlot.IAppServiceSlotLogs? InternalValue
        {
            get => GetInstanceProperty<azurerm.AppServiceSlot.IAppServiceSlotLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
