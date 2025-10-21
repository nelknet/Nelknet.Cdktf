using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxVirtualMachineScaleSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set azurerm_linux_virtual_machine_scale_set}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSet), fullyQualifiedName: "azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetConfig\"}}]")]
    public class LinuxVirtualMachineScaleSet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set azurerm_linux_virtual_machine_scale_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LinuxVirtualMachineScaleSet(Constructs.Construct scope, string id, azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxVirtualMachineScaleSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxVirtualMachineScaleSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a LinuxVirtualMachineScaleSet resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LinuxVirtualMachineScaleSet to import.</param>
        /// <param name="importFromId">The id of the existing LinuxVirtualMachineScaleSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LinuxVirtualMachineScaleSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LinuxVirtualMachineScaleSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/linux_virtual_machine_scale_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LinuxVirtualMachineScaleSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LinuxVirtualMachineScaleSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdditionalCapabilities", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilities\"}}]")]
        public virtual void PutAdditionalCapabilities(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdditionalCapabilities @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdditionalCapabilities)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAdminSshKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdminSshKey\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAdminSshKey(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdminSshKey[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdminSshKey).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdminSshKey).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutomaticInstanceRepair", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticInstanceRepair\"}}]")]
        public virtual void PutAutomaticInstanceRepair(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticInstanceRepair @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticInstanceRepair)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutomaticOsUpgradePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy\"}}]")]
        public virtual void PutAutomaticOsUpgradePolicy(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBootDiagnostics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnostics\"}}]")]
        public virtual void PutBootDiagnostics(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetBootDiagnostics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetBootDiagnostics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetDataDisk\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDataDisk(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetDataDisk[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetDataDisk).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetDataDisk).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtension", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExtension(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetExtension[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetExtension).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetExtension).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGalleryApplication", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetGalleryApplication\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGalleryApplication(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetGalleryApplication[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetGalleryApplication).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetGalleryApplication).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkInterface", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetNetworkInterface\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkInterface(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetNetworkInterface[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetNetworkInterface).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetNetworkInterface).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDisk\"}}]")]
        public virtual void PutOsDisk(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetOsDisk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetOsDisk)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlan\"}}]")]
        public virtual void PutPlan(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetPlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetPlan)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRollingUpgradePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetRollingUpgradePolicy\"}}]")]
        public virtual void PutRollingUpgradePolicy(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetRollingUpgradePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetRollingUpgradePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScaleIn", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetScaleIn\"}}]")]
        public virtual void PutScaleIn(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetScaleIn @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetScaleIn)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecret", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecret\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecret(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSecret).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceImageReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSourceImageReference\"}}]")]
        public virtual void PutSourceImageReference(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSourceImageReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSourceImageReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpotRestore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSpotRestore\"}}]")]
        public virtual void PutSpotRestore(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSpotRestore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSpotRestore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTerminationNotification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTerminationNotification\"}}]")]
        public virtual void PutTerminationNotification(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTerminationNotification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTerminationNotification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalCapabilities")]
        public virtual void ResetAdditionalCapabilities()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdminPassword")]
        public virtual void ResetAdminPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdminSshKey")]
        public virtual void ResetAdminSshKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomaticInstanceRepair")]
        public virtual void ResetAutomaticInstanceRepair()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutomaticOsUpgradePolicy")]
        public virtual void ResetAutomaticOsUpgradePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootDiagnostics")]
        public virtual void ResetBootDiagnostics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityReservationGroupId")]
        public virtual void ResetCapacityReservationGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComputerNamePrefix")]
        public virtual void ResetComputerNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomData")]
        public virtual void ResetCustomData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataDisk")]
        public virtual void ResetDataDisk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisablePasswordAuthentication")]
        public virtual void ResetDisablePasswordAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDoNotRunExtensionsOnOverprovisionedMachines")]
        public virtual void ResetDoNotRunExtensionsOnOverprovisionedMachines()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEdgeZone")]
        public virtual void ResetEdgeZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionAtHostEnabled")]
        public virtual void ResetEncryptionAtHostEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEvictionPolicy")]
        public virtual void ResetEvictionPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtension")]
        public virtual void ResetExtension()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtensionOperationsEnabled")]
        public virtual void ResetExtensionOperationsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtensionsTimeBudget")]
        public virtual void ResetExtensionsTimeBudget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGalleryApplication")]
        public virtual void ResetGalleryApplication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthProbeId")]
        public virtual void ResetHealthProbeId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostGroupId")]
        public virtual void ResetHostGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstances")]
        public virtual void ResetInstances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxBidPrice")]
        public virtual void ResetMaxBidPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverprovision")]
        public virtual void ResetOverprovision()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlan")]
        public virtual void ResetPlan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatformFaultDomainCount")]
        public virtual void ResetPlatformFaultDomainCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProvisionVmAgent")]
        public virtual void ResetProvisionVmAgent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProximityPlacementGroupId")]
        public virtual void ResetProximityPlacementGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRollingUpgradePolicy")]
        public virtual void ResetRollingUpgradePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleIn")]
        public virtual void ResetScaleIn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecret")]
        public virtual void ResetSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecureBootEnabled")]
        public virtual void ResetSecureBootEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSinglePlacementGroup")]
        public virtual void ResetSinglePlacementGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceImageId")]
        public virtual void ResetSourceImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceImageReference")]
        public virtual void ResetSourceImageReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotRestore")]
        public virtual void ResetSpotRestore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminationNotification")]
        public virtual void ResetTerminationNotification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpgradeMode")]
        public virtual void ResetUpgradeMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserData")]
        public virtual void ResetUserData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVtpmEnabled")]
        public virtual void ResetVtpmEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZoneBalance")]
        public virtual void ResetZoneBalance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZones")]
        public virtual void ResetZones()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSet))!;

        [JsiiProperty(name: "additionalCapabilities", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilitiesOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilitiesOutputReference AdditionalCapabilities
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilitiesOutputReference>()!;
        }

        [JsiiProperty(name: "adminSshKey", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdminSshKeyList\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdminSshKeyList AdminSshKey
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdminSshKeyList>()!;
        }

        [JsiiProperty(name: "automaticInstanceRepair", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticInstanceRepairOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticInstanceRepairOutputReference AutomaticInstanceRepair
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticInstanceRepairOutputReference>()!;
        }

        [JsiiProperty(name: "automaticOsUpgradePolicy", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyOutputReference AutomaticOsUpgradePolicy
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticOsUpgradePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnosticsOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnosticsOutputReference BootDiagnostics
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnosticsOutputReference>()!;
        }

        [JsiiProperty(name: "dataDisk", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetDataDiskList\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetDataDiskList DataDisk
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetDataDiskList>()!;
        }

        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetExtensionList\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetExtensionList Extension
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetExtensionList>()!;
        }

        [JsiiProperty(name: "galleryApplication", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetGalleryApplicationList\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetGalleryApplicationList GalleryApplication
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetGalleryApplicationList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetIdentityOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetNetworkInterfaceList\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetNetworkInterfaceList NetworkInterface
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "osDisk", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDiskOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDiskOutputReference OsDisk
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDiskOutputReference>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlanOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlanOutputReference Plan
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlanOutputReference>()!;
        }

        [JsiiProperty(name: "rollingUpgradePolicy", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetRollingUpgradePolicyOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetRollingUpgradePolicyOutputReference RollingUpgradePolicy
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetRollingUpgradePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "scaleIn", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetScaleInOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetScaleInOutputReference ScaleIn
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetScaleInOutputReference>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecretList\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecretList Secret
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecretList>()!;
        }

        [JsiiProperty(name: "sourceImageReference", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSourceImageReferenceOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSourceImageReferenceOutputReference SourceImageReference
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSourceImageReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "spotRestore", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSpotRestoreOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSpotRestoreOutputReference SpotRestore
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSpotRestoreOutputReference>()!;
        }

        [JsiiProperty(name: "terminationNotification", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTerminationNotificationOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTerminationNotificationOutputReference TerminationNotification
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTerminationNotificationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTimeoutsOutputReference\"}")]
        public virtual azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "uniqueId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UniqueId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalCapabilitiesInput", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdditionalCapabilities\"}", isOptional: true)]
        public virtual azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdditionalCapabilities? AdditionalCapabilitiesInput
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAdditionalCapabilities?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminSshKeyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAdminSshKey\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AdminSshKeyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticInstanceRepairInput", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticInstanceRepair\"}", isOptional: true)]
        public virtual azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticInstanceRepair? AutomaticInstanceRepairInput
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticInstanceRepair?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticOsUpgradePolicyInput", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy\"}", isOptional: true)]
        public virtual azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy? AutomaticOsUpgradePolicyInput
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetAutomaticOsUpgradePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootDiagnosticsInput", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetBootDiagnostics\"}", isOptional: true)]
        public virtual azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetBootDiagnostics? BootDiagnosticsInput
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetBootDiagnostics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityReservationGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "computerNamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputerNamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomDataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataDiskInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DataDiskInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disablePasswordAuthenticationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisablePasswordAuthenticationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "doNotRunExtensionsOnOverprovisionedMachinesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DoNotRunExtensionsOnOverprovisionedMachinesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "edgeZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EdgeZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionAtHostEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EncryptionAtHostEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "evictionPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EvictionPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExtensionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionOperationsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ExtensionOperationsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionsTimeBudgetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExtensionsTimeBudgetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "galleryApplicationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetGalleryApplication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GalleryApplicationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthProbeIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HealthProbeIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetIdentity\"}", isOptional: true)]
        public virtual azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instancesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstancesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxBidPriceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxBidPriceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkInterfaceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osDiskInput", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetOsDisk\"}", isOptional: true)]
        public virtual azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetOsDisk? OsDiskInput
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetOsDisk?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overprovisionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OverprovisionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetPlan\"}", isOptional: true)]
        public virtual azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetPlan? PlanInput
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetPlan?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformFaultDomainCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PlatformFaultDomainCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriorityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provisionVmAgentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ProvisionVmAgentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "proximityPlacementGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProximityPlacementGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rollingUpgradePolicyInput", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetRollingUpgradePolicy\"}", isOptional: true)]
        public virtual azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetRollingUpgradePolicy? RollingUpgradePolicyInput
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetRollingUpgradePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInInput", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetScaleIn\"}", isOptional: true)]
        public virtual azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetScaleIn? ScaleInInput
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetScaleIn?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecretInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secureBootEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SecureBootEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singlePlacementGroupInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SinglePlacementGroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceImageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceImageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceImageReferenceInput", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSourceImageReference\"}", isOptional: true)]
        public virtual azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSourceImageReference? SourceImageReferenceInput
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSourceImageReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotRestoreInput", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetSpotRestore\"}", isOptional: true)]
        public virtual azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSpotRestore? SpotRestoreInput
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetSpotRestore?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminationNotificationInput", typeJson: "{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTerminationNotification\"}", isOptional: true)]
        public virtual azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTerminationNotification? TerminationNotificationInput
        {
            get => GetInstanceProperty<azurerm.LinuxVirtualMachineScaleSet.ILinuxVirtualMachineScaleSetTerminationNotification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.linuxVirtualMachineScaleSet.LinuxVirtualMachineScaleSetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradeModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpgradeModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserDataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vtpmEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? VtpmEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneBalanceInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ZoneBalanceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zonesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ZonesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "capacityReservationGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "computerNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputerNamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomData
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "disablePasswordAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DisablePasswordAuthentication
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

        [JsiiProperty(name: "doNotRunExtensionsOnOverprovisionedMachines", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DoNotRunExtensionsOnOverprovisionedMachines
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

        [JsiiProperty(name: "edgeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EdgeZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "encryptionAtHostEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EncryptionAtHostEnabled
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

        [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EvictionPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "extensionOperationsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ExtensionOperationsEnabled
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

        [JsiiProperty(name: "extensionsTimeBudget", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExtensionsTimeBudget
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthProbeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthProbeId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instances", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Instances
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxBidPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBidPrice
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "overprovision", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Overprovision
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

        [JsiiProperty(name: "platformFaultDomainCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PlatformFaultDomainCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Priority
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "provisionVmAgent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ProvisionVmAgent
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

        [JsiiProperty(name: "proximityPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProximityPlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secureBootEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SecureBootEnabled
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

        [JsiiProperty(name: "singlePlacementGroup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SinglePlacementGroup
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

        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sku
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceImageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "upgradeMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradeMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vtpmEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object VtpmEnabled
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

        [JsiiProperty(name: "zoneBalance", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ZoneBalance
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

        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Zones
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
