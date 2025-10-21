using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.WindowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerOutputReference), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WindowsWebAppSiteConfigAutoHealSettingTriggerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WindowsWebAppSiteConfigAutoHealSettingTriggerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WindowsWebAppSiteConfigAutoHealSettingTriggerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsWebAppSiteConfigAutoHealSettingTriggerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRequests", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerRequests\"}}]")]
        public virtual void PutRequests(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerRequests @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerRequests)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlowRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest\"}}]")]
        public virtual void PutSlowRequest(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlowRequestWithPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSlowRequestWithPath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStatusCode", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStatusCode(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerStatusCode[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerStatusCode).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerStatusCode).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPrivateMemoryKb")]
        public virtual void ResetPrivateMemoryKb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequests")]
        public virtual void ResetRequests()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlowRequest")]
        public virtual void ResetSlowRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlowRequestWithPath")]
        public virtual void ResetSlowRequestWithPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatusCode")]
        public virtual void ResetStatusCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "requests", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerRequestsOutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerRequestsOutputReference Requests
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerRequestsOutputReference>()!;
        }

        [JsiiProperty(name: "slowRequest", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestOutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestOutputReference SlowRequest
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestOutputReference>()!;
        }

        [JsiiProperty(name: "slowRequestWithPath", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPathList\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPathList SlowRequestWithPath
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPathList>()!;
        }

        [JsiiProperty(name: "statusCode", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerStatusCodeList\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerStatusCodeList StatusCode
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerStatusCodeList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateMemoryKbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PrivateMemoryKbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestsInput", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerRequests\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerRequests? RequestsInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerRequests?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slowRequestInput", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequestInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slowRequestWithPathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SlowRequestWithPathInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusCodeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StatusCodeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "privateMemoryKb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PrivateMemoryKb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppSiteConfigAutoHealSettingTrigger\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTrigger? InternalValue
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppSiteConfigAutoHealSettingTrigger?>();
            set => SetInstanceProperty(value);
        }
    }
}
