using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MaintenanceConfiguration
{
    [JsiiClass(nativeType: typeof(azurerm.MaintenanceConfiguration.MaintenanceConfigurationInstallPatchesOutputReference), fullyQualifiedName: "azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MaintenanceConfigurationInstallPatchesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MaintenanceConfigurationInstallPatchesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MaintenanceConfigurationInstallPatchesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MaintenanceConfigurationInstallPatchesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLinux", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesLinux\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLinux(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatchesLinux[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatchesLinux).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatchesLinux).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWindows", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesWindows\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWindows(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatchesWindows[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatchesWindows).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatchesWindows).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLinux")]
        public virtual void ResetLinux()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReboot")]
        public virtual void ResetReboot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWindows")]
        public virtual void ResetWindows()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "linux", typeJson: "{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesLinuxList\"}")]
        public virtual azurerm.MaintenanceConfiguration.MaintenanceConfigurationInstallPatchesLinuxList Linux
        {
            get => GetInstanceProperty<azurerm.MaintenanceConfiguration.MaintenanceConfigurationInstallPatchesLinuxList>()!;
        }

        [JsiiProperty(name: "windows", typeJson: "{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesWindowsList\"}")]
        public virtual azurerm.MaintenanceConfiguration.MaintenanceConfigurationInstallPatchesWindowsList Windows
        {
            get => GetInstanceProperty<azurerm.MaintenanceConfiguration.MaintenanceConfigurationInstallPatchesWindowsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "linuxInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesLinux\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LinuxInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rebootInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RebootInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "windowsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatchesWindows\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WindowsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "reboot", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reboot
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.maintenanceConfiguration.MaintenanceConfigurationInstallPatches\"}", isOptional: true)]
        public virtual azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatches? InternalValue
        {
            get => GetInstanceProperty<azurerm.MaintenanceConfiguration.IMaintenanceConfigurationInstallPatches?>();
            set => SetInstanceProperty(value);
        }
    }
}
