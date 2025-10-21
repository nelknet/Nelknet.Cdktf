using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HpcCache
{
    [JsiiClass(nativeType: typeof(azurerm.HpcCache.HpcCacheDirectoryLdapOutputReference), fullyQualifiedName: "azurerm.hpcCache.HpcCacheDirectoryLdapOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HpcCacheDirectoryLdapOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HpcCacheDirectoryLdapOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HpcCacheDirectoryLdapOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HpcCacheDirectoryLdapOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBind", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryLdapBind\"}}]")]
        public virtual void PutBind(azurerm.HpcCache.IHpcCacheDirectoryLdapBind @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.HpcCache.IHpcCacheDirectoryLdapBind)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBind")]
        public virtual void ResetBind()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateValidationUri")]
        public virtual void ResetCertificateValidationUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDownloadCertificateAutomatically")]
        public virtual void ResetDownloadCertificateAutomatically()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncrypted")]
        public virtual void ResetEncrypted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bind", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryLdapBindOutputReference\"}")]
        public virtual azurerm.HpcCache.HpcCacheDirectoryLdapBindOutputReference Bind
        {
            get => GetInstanceProperty<azurerm.HpcCache.HpcCacheDirectoryLdapBindOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "baseDnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BaseDnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bindInput", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryLdapBind\"}", isOptional: true)]
        public virtual azurerm.HpcCache.IHpcCacheDirectoryLdapBind? BindInput
        {
            get => GetInstanceProperty<azurerm.HpcCache.IHpcCacheDirectoryLdapBind?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateValidationUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateValidationUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "downloadCertificateAutomaticallyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DownloadCertificateAutomaticallyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EncryptedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "baseDn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseDn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateValidationUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateValidationUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "downloadCertificateAutomatically", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DownloadCertificateAutomatically
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

        [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Encrypted
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

        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Server
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.hpcCache.HpcCacheDirectoryLdap\"}", isOptional: true)]
        public virtual azurerm.HpcCache.IHpcCacheDirectoryLdap? InternalValue
        {
            get => GetInstanceProperty<azurerm.HpcCache.IHpcCacheDirectoryLdap?>();
            set => SetInstanceProperty(value);
        }
    }
}
