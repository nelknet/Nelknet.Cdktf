using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WindowsWebAppSlot
{
    [JsiiClass(nativeType: typeof(azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsOutputReference), fullyQualifiedName: "azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WindowsWebAppSlotAuthSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WindowsWebAppSlotAuthSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WindowsWebAppSlotAuthSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WindowsWebAppSlotAuthSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActiveDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsActiveDirectory\"}}]")]
        public virtual void PutActiveDirectory(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsActiveDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsActiveDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFacebook", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsFacebook\"}}]")]
        public virtual void PutFacebook(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsFacebook @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsFacebook)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithub", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsGithub\"}}]")]
        public virtual void PutGithub(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsGithub @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsGithub)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGoogle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsGoogle\"}}]")]
        public virtual void PutGoogle(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsGoogle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsGoogle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMicrosoft", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsMicrosoft\"}}]")]
        public virtual void PutMicrosoft(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsMicrosoft @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsMicrosoft)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTwitter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsTwitter\"}}]")]
        public virtual void PutTwitter(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsTwitter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsTwitter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActiveDirectory")]
        public virtual void ResetActiveDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdditionalLoginParameters")]
        public virtual void ResetAdditionalLoginParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedExternalRedirectUrls")]
        public virtual void ResetAllowedExternalRedirectUrls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultProvider")]
        public virtual void ResetDefaultProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFacebook")]
        public virtual void ResetFacebook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGithub")]
        public virtual void ResetGithub()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGoogle")]
        public virtual void ResetGoogle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIssuer")]
        public virtual void ResetIssuer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMicrosoft")]
        public virtual void ResetMicrosoft()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntimeVersion")]
        public virtual void ResetRuntimeVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTokenRefreshExtensionHours")]
        public virtual void ResetTokenRefreshExtensionHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTokenStoreEnabled")]
        public virtual void ResetTokenStoreEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTwitter")]
        public virtual void ResetTwitter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnauthenticatedClientAction")]
        public virtual void ResetUnauthenticatedClientAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsActiveDirectoryOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsActiveDirectoryOutputReference ActiveDirectory
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsActiveDirectoryOutputReference>()!;
        }

        [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsFacebookOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsFacebookOutputReference Facebook
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsFacebookOutputReference>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsGithubOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsGithubOutputReference Github
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsGithubOutputReference>()!;
        }

        [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsGoogleOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsGoogleOutputReference Google
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsGoogleOutputReference>()!;
        }

        [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsMicrosoftOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsMicrosoftOutputReference Microsoft
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsMicrosoftOutputReference>()!;
        }

        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsTwitterOutputReference\"}")]
        public virtual azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsTwitterOutputReference Twitter
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.WindowsWebAppSlotAuthSettingsTwitterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsActiveDirectory\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsActiveDirectory? ActiveDirectoryInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsActiveDirectory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalLoginParametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AdditionalLoginParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedExternalRedirectUrlsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedExternalRedirectUrlsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultProviderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultProviderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "facebookInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsFacebook\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsFacebook? FacebookInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsFacebook?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsGithub\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsGithub? GithubInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsGithub?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "googleInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsGoogle\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsGoogle? GoogleInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsGoogle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IssuerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "microsoftInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsMicrosoft\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsMicrosoft? MicrosoftInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsMicrosoft?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuntimeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenRefreshExtensionHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TokenRefreshExtensionHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenStoreEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TokenStoreEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "twitterInput", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettingsTwitter\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsTwitter? TwitterInput
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettingsTwitter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unauthenticatedClientActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UnauthenticatedClientActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "additionalLoginParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalLoginParameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedExternalRedirectUrls
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultProvider
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tokenRefreshExtensionHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TokenRefreshExtensionHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tokenStoreEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TokenStoreEnabled
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

        [JsiiProperty(name: "unauthenticatedClientAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnauthenticatedClientAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.windowsWebAppSlot.WindowsWebAppSlotAuthSettings\"}", isOptional: true)]
        public virtual azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.WindowsWebAppSlot.IWindowsWebAppSlotAuthSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
