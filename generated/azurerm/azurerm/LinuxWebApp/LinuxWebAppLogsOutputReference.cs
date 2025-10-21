using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxWebApp.LinuxWebAppLogsOutputReference), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxWebAppLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxWebAppLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxWebAppLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxWebAppLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplicationLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogs\"}}]")]
        public virtual void PutApplicationLogs(azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogs\"}}]")]
        public virtual void PutHttpLogs(azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplicationLogs")]
        public virtual void ResetApplicationLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDetailedErrorMessages")]
        public virtual void ResetDetailedErrorMessages()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailedRequestTracing")]
        public virtual void ResetFailedRequestTracing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpLogs")]
        public virtual void ResetHttpLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "applicationLogs", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogsOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppLogsApplicationLogsOutputReference ApplicationLogs
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppLogsApplicationLogsOutputReference>()!;
        }

        [JsiiProperty(name: "httpLogs", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogsOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppLogsHttpLogsOutputReference HttpLogs
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppLogsHttpLogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationLogsInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsApplicationLogs\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogs? ApplicationLogsInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppLogsApplicationLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detailedErrorMessagesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DetailedErrorMessagesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failedRequestTracingInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FailedRequestTracingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpLogsInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogsHttpLogs\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogs? HttpLogsInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppLogsHttpLogs?>();
        }

        [JsiiProperty(name: "detailedErrorMessages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DetailedErrorMessages
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

        [JsiiProperty(name: "failedRequestTracing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object FailedRequestTracing
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppLogs\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppLogs? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
