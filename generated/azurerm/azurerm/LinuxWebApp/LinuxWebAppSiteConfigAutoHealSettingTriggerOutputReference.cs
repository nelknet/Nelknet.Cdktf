using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerOutputReference), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxWebAppSiteConfigAutoHealSettingTriggerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxWebAppSiteConfigAutoHealSettingTriggerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxWebAppSiteConfigAutoHealSettingTriggerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxWebAppSiteConfigAutoHealSettingTriggerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRequests", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerRequests\"}}]")]
        public virtual void PutRequests(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerRequests @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerRequests)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlowRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest\"}}]")]
        public virtual void PutSlowRequest(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSlowRequestWithPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSlowRequestWithPath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStatusCode", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStatusCode(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
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

        [JsiiProperty(name: "requests", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerRequestsOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerRequestsOutputReference Requests
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerRequestsOutputReference>()!;
        }

        [JsiiProperty(name: "slowRequest", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestOutputReference SlowRequest
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestOutputReference>()!;
        }

        [JsiiProperty(name: "slowRequestWithPath", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPathList\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPathList SlowRequestWithPath
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPathList>()!;
        }

        [JsiiProperty(name: "statusCode", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerStatusCodeList\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerStatusCodeList StatusCode
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerStatusCodeList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "requestsInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerRequests\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerRequests? RequestsInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerRequests?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slowRequestInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest? SlowRequestInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slowRequestWithPathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerSlowRequestWithPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SlowRequestWithPathInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusCodeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTriggerStatusCode\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StatusCodeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigAutoHealSettingTrigger\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTrigger? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppSiteConfigAutoHealSettingTrigger?>();
            set => SetInstanceProperty(value);
        }
    }
}
