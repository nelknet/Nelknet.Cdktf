using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachine
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine azurerm_virtual_machine}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.VirtualMachine.VirtualMachine), fullyQualifiedName: "azurerm.virtualMachine.VirtualMachine", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineConfig\"}}]")]
    public class VirtualMachine : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine azurerm_virtual_machine} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VirtualMachine(Constructs.Construct scope, string id, azurerm.VirtualMachine.IVirtualMachineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.VirtualMachine.IVirtualMachineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualMachine(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VirtualMachine(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a VirtualMachine resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VirtualMachine to import.</param>
        /// <param name="importFromId">The id of the existing VirtualMachine that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VirtualMachine to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VirtualMachine to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_machine#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VirtualMachine that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VirtualMachine to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.VirtualMachine.VirtualMachine), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdditionalCapabilities", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineAdditionalCapabilities\"}}]")]
        public virtual void PutAdditionalCapabilities(azurerm.VirtualMachine.IVirtualMachineAdditionalCapabilities @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachine.IVirtualMachineAdditionalCapabilities)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBootDiagnostics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineBootDiagnostics\"}}]")]
        public virtual void PutBootDiagnostics(azurerm.VirtualMachine.IVirtualMachineBootDiagnostics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachine.IVirtualMachineBootDiagnostics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.VirtualMachine.IVirtualMachineIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachine.IVirtualMachineIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfile\"}}]")]
        public virtual void PutOsProfile(azurerm.VirtualMachine.IVirtualMachineOsProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachine.IVirtualMachineOsProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfileLinuxConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileLinuxConfig\"}}]")]
        public virtual void PutOsProfileLinuxConfig(azurerm.VirtualMachine.IVirtualMachineOsProfileLinuxConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachine.IVirtualMachineOsProfileLinuxConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfileSecrets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileSecrets\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOsProfileSecrets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VirtualMachine.IVirtualMachineOsProfileSecrets[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachine.IVirtualMachineOsProfileSecrets).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachine.IVirtualMachineOsProfileSecrets).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOsProfileWindowsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileWindowsConfig\"}}]")]
        public virtual void PutOsProfileWindowsConfig(azurerm.VirtualMachine.IVirtualMachineOsProfileWindowsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachine.IVirtualMachineOsProfileWindowsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachinePlan\"}}]")]
        public virtual void PutPlan(azurerm.VirtualMachine.IVirtualMachinePlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachine.IVirtualMachinePlan)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageDataDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineStorageDataDisk\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStorageDataDisk(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.VirtualMachine.IVirtualMachineStorageDataDisk[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachine.IVirtualMachineStorageDataDisk).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.VirtualMachine.IVirtualMachineStorageDataDisk).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageImageReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineStorageImageReference\"}}]")]
        public virtual void PutStorageImageReference(azurerm.VirtualMachine.IVirtualMachineStorageImageReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachine.IVirtualMachineStorageImageReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageOsDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineStorageOsDisk\"}}]")]
        public virtual void PutStorageOsDisk(azurerm.VirtualMachine.IVirtualMachineStorageOsDisk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachine.IVirtualMachineStorageOsDisk)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.VirtualMachine.IVirtualMachineTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VirtualMachine.IVirtualMachineTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalCapabilities")]
        public virtual void ResetAdditionalCapabilities()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAvailabilitySetId")]
        public virtual void ResetAvailabilitySetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootDiagnostics")]
        public virtual void ResetBootDiagnostics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteDataDisksOnTermination")]
        public virtual void ResetDeleteDataDisksOnTermination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeleteOsDiskOnTermination")]
        public virtual void ResetDeleteOsDiskOnTermination()
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

        [JsiiMethod(name: "resetOsProfile")]
        public virtual void ResetOsProfile()
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

        [JsiiMethod(name: "resetPlan")]
        public virtual void ResetPlan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryNetworkInterfaceId")]
        public virtual void ResetPrimaryNetworkInterfaceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProximityPlacementGroupId")]
        public virtual void ResetProximityPlacementGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageDataDisk")]
        public virtual void ResetStorageDataDisk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageImageReference")]
        public virtual void ResetStorageImageReference()
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
        = GetStaticProperty<string>(typeof(azurerm.VirtualMachine.VirtualMachine))!;

        [JsiiProperty(name: "additionalCapabilities", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineAdditionalCapabilitiesOutputReference\"}")]
        public virtual azurerm.VirtualMachine.VirtualMachineAdditionalCapabilitiesOutputReference AdditionalCapabilities
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.VirtualMachineAdditionalCapabilitiesOutputReference>()!;
        }

        [JsiiProperty(name: "bootDiagnostics", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineBootDiagnosticsOutputReference\"}")]
        public virtual azurerm.VirtualMachine.VirtualMachineBootDiagnosticsOutputReference BootDiagnostics
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.VirtualMachineBootDiagnosticsOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineIdentityOutputReference\"}")]
        public virtual azurerm.VirtualMachine.VirtualMachineIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.VirtualMachineIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "osProfile", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileOutputReference\"}")]
        public virtual azurerm.VirtualMachine.VirtualMachineOsProfileOutputReference OsProfile
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.VirtualMachineOsProfileOutputReference>()!;
        }

        [JsiiProperty(name: "osProfileLinuxConfig", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileLinuxConfigOutputReference\"}")]
        public virtual azurerm.VirtualMachine.VirtualMachineOsProfileLinuxConfigOutputReference OsProfileLinuxConfig
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.VirtualMachineOsProfileLinuxConfigOutputReference>()!;
        }

        [JsiiProperty(name: "osProfileSecrets", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileSecretsList\"}")]
        public virtual azurerm.VirtualMachine.VirtualMachineOsProfileSecretsList OsProfileSecrets
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.VirtualMachineOsProfileSecretsList>()!;
        }

        [JsiiProperty(name: "osProfileWindowsConfig", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileWindowsConfigOutputReference\"}")]
        public virtual azurerm.VirtualMachine.VirtualMachineOsProfileWindowsConfigOutputReference OsProfileWindowsConfig
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.VirtualMachineOsProfileWindowsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachinePlanOutputReference\"}")]
        public virtual azurerm.VirtualMachine.VirtualMachinePlanOutputReference Plan
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.VirtualMachinePlanOutputReference>()!;
        }

        [JsiiProperty(name: "storageDataDisk", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineStorageDataDiskList\"}")]
        public virtual azurerm.VirtualMachine.VirtualMachineStorageDataDiskList StorageDataDisk
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.VirtualMachineStorageDataDiskList>()!;
        }

        [JsiiProperty(name: "storageImageReference", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineStorageImageReferenceOutputReference\"}")]
        public virtual azurerm.VirtualMachine.VirtualMachineStorageImageReferenceOutputReference StorageImageReference
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.VirtualMachineStorageImageReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "storageOsDisk", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineStorageOsDiskOutputReference\"}")]
        public virtual azurerm.VirtualMachine.VirtualMachineStorageOsDiskOutputReference StorageOsDisk
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.VirtualMachineStorageOsDiskOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineTimeoutsOutputReference\"}")]
        public virtual azurerm.VirtualMachine.VirtualMachineTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.VirtualMachineTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalCapabilitiesInput", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineAdditionalCapabilities\"}", isOptional: true)]
        public virtual azurerm.VirtualMachine.IVirtualMachineAdditionalCapabilities? AdditionalCapabilitiesInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.IVirtualMachineAdditionalCapabilities?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilitySetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilitySetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootDiagnosticsInput", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineBootDiagnostics\"}", isOptional: true)]
        public virtual azurerm.VirtualMachine.IVirtualMachineBootDiagnostics? BootDiagnosticsInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.IVirtualMachineBootDiagnostics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteDataDisksOnTerminationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteDataDisksOnTerminationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteOsDiskOnTerminationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeleteOsDiskOnTerminationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineIdentity\"}", isOptional: true)]
        public virtual azurerm.VirtualMachine.IVirtualMachineIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.IVirtualMachineIdentity?>();
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
        [JsiiProperty(name: "networkInterfaceIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NetworkInterfaceIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileInput", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfile\"}", isOptional: true)]
        public virtual azurerm.VirtualMachine.IVirtualMachineOsProfile? OsProfileInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.IVirtualMachineOsProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileLinuxConfigInput", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileLinuxConfig\"}", isOptional: true)]
        public virtual azurerm.VirtualMachine.IVirtualMachineOsProfileLinuxConfig? OsProfileLinuxConfigInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.IVirtualMachineOsProfileLinuxConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileSecretsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OsProfileSecretsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osProfileWindowsConfigInput", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineOsProfileWindowsConfig\"}", isOptional: true)]
        public virtual azurerm.VirtualMachine.IVirtualMachineOsProfileWindowsConfig? OsProfileWindowsConfigInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.IVirtualMachineOsProfileWindowsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachinePlan\"}", isOptional: true)]
        public virtual azurerm.VirtualMachine.IVirtualMachinePlan? PlanInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.IVirtualMachinePlan?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryNetworkInterfaceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryNetworkInterfaceIdInput
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
        [JsiiProperty(name: "storageDataDiskInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachine.VirtualMachineStorageDataDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StorageDataDiskInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageImageReferenceInput", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineStorageImageReference\"}", isOptional: true)]
        public virtual azurerm.VirtualMachine.IVirtualMachineStorageImageReference? StorageImageReferenceInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.IVirtualMachineStorageImageReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageOsDiskInput", typeJson: "{\"fqn\":\"azurerm.virtualMachine.VirtualMachineStorageOsDisk\"}", isOptional: true)]
        public virtual azurerm.VirtualMachine.IVirtualMachineStorageOsDisk? StorageOsDiskInput
        {
            get => GetInstanceProperty<azurerm.VirtualMachine.IVirtualMachineStorageOsDisk?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.virtualMachine.VirtualMachineTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmSizeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmSizeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zonesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ZonesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "availabilitySetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilitySetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deleteDataDisksOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DeleteDataDisksOnTermination
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

        [JsiiProperty(name: "deleteOsDiskOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DeleteOsDiskOnTermination
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

        [JsiiProperty(name: "networkInterfaceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkInterfaceIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primaryNetworkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryNetworkInterfaceId
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmSize
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
