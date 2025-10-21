using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionAppSlot
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsOutputReference), fullyQualifiedName: "azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxFunctionAppSlotAuthSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxFunctionAppSlotAuthSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxFunctionAppSlotAuthSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxFunctionAppSlotAuthSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActiveDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsActiveDirectory\"}}]")]
        public virtual void PutActiveDirectory(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsActiveDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsActiveDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFacebook", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsFacebook\"}}]")]
        public virtual void PutFacebook(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsFacebook @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsFacebook)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithub", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsGithub\"}}]")]
        public virtual void PutGithub(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsGithub @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsGithub)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGoogle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsGoogle\"}}]")]
        public virtual void PutGoogle(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsGoogle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsGoogle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMicrosoft", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsMicrosoft\"}}]")]
        public virtual void PutMicrosoft(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsMicrosoft @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsMicrosoft)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTwitter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsTwitter\"}}]")]
        public virtual void PutTwitter(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsTwitter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsTwitter)}, new object[]{@value});
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

        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsActiveDirectoryOutputReference\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsActiveDirectoryOutputReference ActiveDirectory
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsActiveDirectoryOutputReference>()!;
        }

        [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsFacebookOutputReference\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsFacebookOutputReference Facebook
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsFacebookOutputReference>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsGithubOutputReference\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsGithubOutputReference Github
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsGithubOutputReference>()!;
        }

        [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsGoogleOutputReference\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsGoogleOutputReference Google
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsGoogleOutputReference>()!;
        }

        [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsMicrosoftOutputReference\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsMicrosoftOutputReference Microsoft
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsMicrosoftOutputReference>()!;
        }

        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsTwitterOutputReference\"}")]
        public virtual azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsTwitterOutputReference Twitter
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsTwitterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsActiveDirectory\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsActiveDirectory? ActiveDirectoryInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsActiveDirectory?>();
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
        [JsiiProperty(name: "facebookInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsFacebook\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsFacebook? FacebookInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsFacebook?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsGithub\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsGithub? GithubInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsGithub?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "googleInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsGoogle\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsGoogle? GoogleInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsGoogle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IssuerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "microsoftInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsMicrosoft\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsMicrosoft? MicrosoftInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsMicrosoft?>();
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
        [JsiiProperty(name: "twitterInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettingsTwitter\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsTwitter? TwitterInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettingsTwitter?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxFunctionAppSlot.LinuxFunctionAppSlotAuthSettings\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionAppSlot.ILinuxFunctionAppSlotAuthSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
