using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2OutputReference), fullyQualifiedName: "azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WindowsWebAppAuthSettingsV2OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WindowsWebAppAuthSettingsV2OutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WindowsWebAppAuthSettingsV2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsWebAppAuthSettingsV2OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActiveDirectoryV2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2ActiveDirectoryV2\"}}]")]
        public virtual void PutActiveDirectoryV2(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2ActiveDirectoryV2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2ActiveDirectoryV2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAppleV2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2AppleV2\"}}]")]
        public virtual void PutAppleV2(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AppleV2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AppleV2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureStaticWebAppV2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2AzureStaticWebAppV2\"}}]")]
        public virtual void PutAzureStaticWebAppV2(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AzureStaticWebAppV2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AzureStaticWebAppV2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomOidcV2", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2CustomOidcV2\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomOidcV2(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2CustomOidcV2[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2CustomOidcV2).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2CustomOidcV2).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFacebookV2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2FacebookV2\"}}]")]
        public virtual void PutFacebookV2(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2FacebookV2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2FacebookV2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithubV2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2GithubV2\"}}]")]
        public virtual void PutGithubV2(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GithubV2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GithubV2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGoogleV2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2GoogleV2\"}}]")]
        public virtual void PutGoogleV2(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GoogleV2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GoogleV2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogin", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2Login\"}}]")]
        public virtual void PutLogin(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2Login @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2Login)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMicrosoftV2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2MicrosoftV2\"}}]")]
        public virtual void PutMicrosoftV2(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2MicrosoftV2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2MicrosoftV2)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTwitterV2", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2TwitterV2\"}}]")]
        public virtual void PutTwitterV2(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2TwitterV2 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2TwitterV2)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActiveDirectoryV2")]
        public virtual void ResetActiveDirectoryV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppleV2")]
        public virtual void ResetAppleV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthEnabled")]
        public virtual void ResetAuthEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureStaticWebAppV2")]
        public virtual void ResetAzureStaticWebAppV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigFilePath")]
        public virtual void ResetConfigFilePath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomOidcV2")]
        public virtual void ResetCustomOidcV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultProvider")]
        public virtual void ResetDefaultProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcludedPaths")]
        public virtual void ResetExcludedPaths()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFacebookV2")]
        public virtual void ResetFacebookV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForwardProxyConvention")]
        public virtual void ResetForwardProxyConvention()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForwardProxyCustomHostHeaderName")]
        public virtual void ResetForwardProxyCustomHostHeaderName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForwardProxyCustomSchemeHeaderName")]
        public virtual void ResetForwardProxyCustomSchemeHeaderName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGithubV2")]
        public virtual void ResetGithubV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGoogleV2")]
        public virtual void ResetGoogleV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpRouteApiPrefix")]
        public virtual void ResetHttpRouteApiPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMicrosoftV2")]
        public virtual void ResetMicrosoftV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireAuthentication")]
        public virtual void ResetRequireAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequireHttps")]
        public virtual void ResetRequireHttps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntimeVersion")]
        public virtual void ResetRuntimeVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTwitterV2")]
        public virtual void ResetTwitterV2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnauthenticatedAction")]
        public virtual void ResetUnauthenticatedAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "activeDirectoryV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2ActiveDirectoryV2OutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2ActiveDirectoryV2OutputReference ActiveDirectoryV2
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2ActiveDirectoryV2OutputReference>()!;
        }

        [JsiiProperty(name: "appleV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2AppleV2OutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2AppleV2OutputReference AppleV2
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2AppleV2OutputReference>()!;
        }

        [JsiiProperty(name: "azureStaticWebAppV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2AzureStaticWebAppV2OutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2AzureStaticWebAppV2OutputReference AzureStaticWebAppV2
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2AzureStaticWebAppV2OutputReference>()!;
        }

        [JsiiProperty(name: "customOidcV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2CustomOidcV2List\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2CustomOidcV2List CustomOidcV2
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2CustomOidcV2List>()!;
        }

        [JsiiProperty(name: "facebookV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2FacebookV2OutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2FacebookV2OutputReference FacebookV2
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2FacebookV2OutputReference>()!;
        }

        [JsiiProperty(name: "githubV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2GithubV2OutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2GithubV2OutputReference GithubV2
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2GithubV2OutputReference>()!;
        }

        [JsiiProperty(name: "googleV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2GoogleV2OutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2GoogleV2OutputReference GoogleV2
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2GoogleV2OutputReference>()!;
        }

        [JsiiProperty(name: "login", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2LoginOutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2LoginOutputReference Login
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2LoginOutputReference>()!;
        }

        [JsiiProperty(name: "microsoftV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2MicrosoftV2OutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2MicrosoftV2OutputReference MicrosoftV2
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2MicrosoftV2OutputReference>()!;
        }

        [JsiiProperty(name: "twitterV2", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2TwitterV2OutputReference\"}")]
        public virtual azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2TwitterV2OutputReference TwitterV2
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.WindowsWebAppAuthSettingsV2TwitterV2OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryV2Input", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2ActiveDirectoryV2\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2ActiveDirectoryV2? ActiveDirectoryV2Input
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2ActiveDirectoryV2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appleV2Input", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2AppleV2\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AppleV2? AppleV2Input
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AppleV2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AuthEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureStaticWebAppV2Input", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2AzureStaticWebAppV2\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AzureStaticWebAppV2? AzureStaticWebAppV2Input
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2AzureStaticWebAppV2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configFilePathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigFilePathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customOidcV2Input", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2CustomOidcV2\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomOidcV2Input
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultProviderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultProviderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludedPathsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ExcludedPathsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "facebookV2Input", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2FacebookV2\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2FacebookV2? FacebookV2Input
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2FacebookV2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardProxyConventionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ForwardProxyConventionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardProxyCustomHostHeaderNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ForwardProxyCustomHostHeaderNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardProxyCustomSchemeHeaderNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ForwardProxyCustomSchemeHeaderNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubV2Input", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2GithubV2\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GithubV2? GithubV2Input
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GithubV2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "googleV2Input", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2GoogleV2\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GoogleV2? GoogleV2Input
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2GoogleV2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRouteApiPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpRouteApiPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginInput", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2Login\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2Login? LoginInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2Login?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "microsoftV2Input", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2MicrosoftV2\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2MicrosoftV2? MicrosoftV2Input
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2MicrosoftV2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireAuthenticationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequireAuthenticationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requireHttpsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RequireHttpsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuntimeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "twitterV2Input", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2TwitterV2\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2TwitterV2? TwitterV2Input
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2TwitterV2?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unauthenticatedActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UnauthenticatedActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "authEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AuthEnabled
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

        [JsiiProperty(name: "configFilePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigFilePath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultProvider
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "excludedPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludedPaths
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forwardProxyConvention", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForwardProxyConvention
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forwardProxyCustomHostHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForwardProxyCustomHostHeaderName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forwardProxyCustomSchemeHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForwardProxyCustomSchemeHeaderName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpRouteApiPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpRouteApiPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requireAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RequireAuthentication
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

        [JsiiProperty(name: "requireHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RequireHttps
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

        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "unauthenticatedAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnauthenticatedAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.windowsWebApp.WindowsWebAppAuthSettingsV2\"}", isOptional: true)]
        public virtual azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2? InternalValue
        {
            get => GetInstanceProperty<azurerm.WindowsWebApp.IWindowsWebAppAuthSettingsV2?>();
            set => SetInstanceProperty(value);
        }
    }
}
