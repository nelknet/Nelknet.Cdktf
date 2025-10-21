using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxWebApp.LinuxWebAppSiteConfigApplicationStackOutputReference), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppSiteConfigApplicationStackOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxWebAppSiteConfigApplicationStackOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxWebAppSiteConfigApplicationStackOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxWebAppSiteConfigApplicationStackOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxWebAppSiteConfigApplicationStackOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDockerImageName")]
        public virtual void ResetDockerImageName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDockerRegistryPassword")]
        public virtual void ResetDockerRegistryPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDockerRegistryUrl")]
        public virtual void ResetDockerRegistryUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDockerRegistryUsername")]
        public virtual void ResetDockerRegistryUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDotnetVersion")]
        public virtual void ResetDotnetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGoVersion")]
        public virtual void ResetGoVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJavaServer")]
        public virtual void ResetJavaServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJavaServerVersion")]
        public virtual void ResetJavaServerVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJavaVersion")]
        public virtual void ResetJavaVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeVersion")]
        public virtual void ResetNodeVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhpVersion")]
        public virtual void ResetPhpVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPythonVersion")]
        public virtual void ResetPythonVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRubyVersion")]
        public virtual void ResetRubyVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dockerImageNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DockerImageNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dockerRegistryPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DockerRegistryPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dockerRegistryUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DockerRegistryUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dockerRegistryUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DockerRegistryUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dotnetVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DotnetVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "goVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GoVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "javaServerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JavaServerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "javaServerVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JavaServerVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "javaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JavaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phpVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhpVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pythonVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PythonVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rubyVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RubyVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dockerImageName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerImageName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dockerRegistryPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerRegistryPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dockerRegistryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerRegistryUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dockerRegistryUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerRegistryUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dotnetVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DotnetVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "goVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GoVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "javaServer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JavaServer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "javaServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JavaServerVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "javaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JavaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "phpVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhpVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pythonVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PythonVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rubyVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RubyVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppSiteConfigApplicationStack\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppSiteConfigApplicationStack? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppSiteConfigApplicationStack?>();
            set => SetInstanceProperty(value);
        }
    }
}
