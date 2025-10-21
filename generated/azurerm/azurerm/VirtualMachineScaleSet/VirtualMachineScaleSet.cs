using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set azurerm_virtual_machine_scale_set}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.VirtualMachineScaleSet.VirtualMachineScaleSet), fullyQualifiedName: "azurerm.virtualMachineScaleSet.VirtualMachineScaleSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetConfig\"}}]")]
    public class VirtualMachineScaleSet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set azurerm_virtual_machine_scale_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VirtualMachineScaleSet(Constructs.Construct scope, string id, azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualMachineScaleSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualMachineScaleSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a VirtualMachineScaleSet resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VirtualMachineScaleSet to import.</param>
        /// <param name="importFromId">The id of the existing VirtualMachineScaleSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VirtualMachineScaleSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VirtualMachineScaleSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine_scale_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VirtualMachineScaleSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VirtualMachineScaleSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.VirtualMachineScaleSet.VirtualMachineScaleSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBootDiagnostics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetBootDiagnostics\"}}]")]
        public virtual void PutBootDiagnostics(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtension", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExtension(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetExtension[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetExtension).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetExtension).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfile\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkProfile(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfile[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfile).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetNetworkProfile).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfile\"}}]")]
        public virtual void PutOsProfile(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfileLinuxConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfig\"}}]")]
        public virtual void PutOsProfileLinuxConfig(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfileSecrets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecrets\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOsProfileSecrets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileSecrets).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfileWindowsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfig\"}}]")]
        public virtual void PutOsProfileWindowsConfig(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetPlan\"}}]")]
        public virtual void PutPlan(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRollingUpgradePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicy\"}}]")]
        public virtual void PutRollingUpgradePolicy(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSku", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetSku\"}}]")]
        public virtual void PutSku(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetSku @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetSku)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageProfileDataDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDisk\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageProfileDataDisk(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileDataDisk[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileDataDisk).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileDataDisk).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageProfileImageReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReference\"}}]")]
        public virtual void PutStorageProfileImageReference(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageProfileOsDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDisk\"}}]")]
        public virtual void PutStorageProfileOsDisk(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutomaticOsUpgrade")]
        public virtual void ResetAutomaticOsUpgrade()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootDiagnostics")]
        public virtual void ResetBootDiagnostics()
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

        [JsiiMethod(name: "resetHealthProbeId")]
        public virtual void ResetHealthProbeId()
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

        [JsiiMethod(name: "resetLicenseType")]
        public virtual void ResetLicenseType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsProfileLinuxConfig")]
        public virtual void ResetOsProfileLinuxConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsProfileSecrets")]
        public virtual void ResetOsProfileSecrets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsProfileWindowsConfig")]
        public virtual void ResetOsProfileWindowsConfig()
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

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
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

        [JsiiMethod(name: "resetSinglePlacementGroup")]
        public virtual void ResetSinglePlacementGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageProfileDataDisk")]
        public virtual void ResetStorageProfileDataDisk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageProfileImageReference")]
        public virtual void ResetStorageProfileImageReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(azurerm.VirtualMachineScaleSet.VirtualMachineScaleSet))!;

        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetBootDiagnosticsOutputReference\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetBootDiagnosticsOutputReference BootDiagnostics
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetBootDiagnosticsOutputReference>()!;
        }

        [JsiiProperty(name: "extension", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetExtensionList\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetExtensionList Extension
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetExtensionList>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetIdentityOutputReference\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "networkProfile", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfileList\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetNetworkProfileList NetworkProfile
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetNetworkProfileList>()!;
        }

        [JsiiProperty(name: "osProfile", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileOutputReference\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileOutputReference OsProfile
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileOutputReference>()!;
        }

        [JsiiProperty(name: "osProfileLinuxConfig", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfigOutputReference\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfigOutputReference OsProfileLinuxConfig
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfigOutputReference>()!;
        }

        [JsiiProperty(name: "osProfileSecrets", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecretsList\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecretsList OsProfileSecrets
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecretsList>()!;
        }

        [JsiiProperty(name: "osProfileWindowsConfig", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfigOutputReference\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfigOutputReference OsProfileWindowsConfig
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetPlanOutputReference\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetPlanOutputReference Plan
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetPlanOutputReference>()!;
        }

        [JsiiProperty(name: "rollingUpgradePolicy", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicyOutputReference\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicyOutputReference RollingUpgradePolicy
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "sku", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetSkuOutputReference\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetSkuOutputReference Sku
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetSkuOutputReference>()!;
        }

        [JsiiProperty(name: "storageProfileDataDisk", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDiskList\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDiskList StorageProfileDataDisk
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDiskList>()!;
        }

        [JsiiProperty(name: "storageProfileImageReference", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReferenceOutputReference\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReferenceOutputReference StorageProfileImageReference
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "storageProfileOsDisk", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDiskOutputReference\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDiskOutputReference StorageProfileOsDisk
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDiskOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetTimeoutsOutputReference\"}")]
        public virtual azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.VirtualMachineScaleSetTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automaticOsUpgradeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutomaticOsUpgradeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootDiagnosticsInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetBootDiagnostics\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics? BootDiagnosticsInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetBootDiagnostics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "evictionPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EvictionPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetExtension\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExtensionInput
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
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetIdentity\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LicenseTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkProfileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetNetworkProfile\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkProfileInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfile\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile? OsProfileInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileLinuxConfigInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileLinuxConfig\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig? OsProfileLinuxConfigInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileLinuxConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileSecretsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OsProfileSecretsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileWindowsConfigInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetOsProfileWindowsConfig\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig? OsProfileWindowsConfigInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetOsProfileWindowsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overprovisionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OverprovisionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetPlan\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan? PlanInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetPlan?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriorityInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "rollingUpgradePolicyInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetRollingUpgradePolicy\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy? RollingUpgradePolicyInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetRollingUpgradePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singlePlacementGroupInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SinglePlacementGroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetSku\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetSku? SkuInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetSku?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageProfileDataDiskInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageProfileDataDiskInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageProfileImageReferenceInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileImageReference\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference? StorageProfileImageReferenceInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileImageReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageProfileOsDiskInput", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetStorageProfileOsDisk\"}", isOptional: true)]
        public virtual azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk? StorageProfileOsDiskInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachineScaleSet.IVirtualMachineScaleSetStorageProfileOsDisk?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.virtualMachineScaleSet.VirtualMachineScaleSetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "upgradePolicyModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UpgradePolicyModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zonesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ZonesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "automaticOsUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutomaticOsUpgrade
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

        [JsiiProperty(name: "healthProbeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthProbeId
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

        [JsiiProperty(name: "licenseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Priority
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "upgradePolicyMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpgradePolicyMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Zones
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
