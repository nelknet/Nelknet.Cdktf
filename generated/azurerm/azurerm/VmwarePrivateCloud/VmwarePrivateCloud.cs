using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VmwarePrivateCloud
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud azurerm_vmware_private_cloud}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.VmwarePrivateCloud.VmwarePrivateCloud), fullyQualifiedName: "azurerm.vmwarePrivateCloud.VmwarePrivateCloud", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.vmwarePrivateCloud.VmwarePrivateCloudConfig\"}}]")]
    public class VmwarePrivateCloud : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud azurerm_vmware_private_cloud} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VmwarePrivateCloud(Constructs.Construct scope, string id, azurerm.VmwarePrivateCloud.IVmwarePrivateCloudConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.VmwarePrivateCloud.IVmwarePrivateCloudConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VmwarePrivateCloud(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VmwarePrivateCloud(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a VmwarePrivateCloud resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the VmwarePrivateCloud to import.</param>
        /// <param name="importFromId">The id of the existing VmwarePrivateCloud that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the VmwarePrivateCloud to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the VmwarePrivateCloud to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vmware_private_cloud#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing VmwarePrivateCloud that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the VmwarePrivateCloud to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.VmwarePrivateCloud.VmwarePrivateCloud), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putManagementCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.vmwarePrivateCloud.VmwarePrivateCloudManagementCluster\"}}]")]
        public virtual void PutManagementCluster(azurerm.VmwarePrivateCloud.IVmwarePrivateCloudManagementCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VmwarePrivateCloud.IVmwarePrivateCloudManagementCluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.vmwarePrivateCloud.VmwarePrivateCloudTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.VmwarePrivateCloud.IVmwarePrivateCloudTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.VmwarePrivateCloud.IVmwarePrivateCloudTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInternetConnectionEnabled")]
        public virtual void ResetInternetConnectionEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNsxtPassword")]
        public virtual void ResetNsxtPassword()
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

        [JsiiMethod(name: "resetVcenterPassword")]
        public virtual void ResetVcenterPassword()
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
        = GetStaticProperty<string>(typeof(azurerm.VmwarePrivateCloud.VmwarePrivateCloud))!;

        [JsiiProperty(name: "circuit", typeJson: "{\"fqn\":\"azurerm.vmwarePrivateCloud.VmwarePrivateCloudCircuitList\"}")]
        public virtual azurerm.VmwarePrivateCloud.VmwarePrivateCloudCircuitList Circuit
        {
            get => GetInstanceProperty<azurerm.VmwarePrivateCloud.VmwarePrivateCloudCircuitList>()!;
        }

        [JsiiProperty(name: "hcxCloudManagerEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HcxCloudManagerEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managementCluster", typeJson: "{\"fqn\":\"azurerm.vmwarePrivateCloud.VmwarePrivateCloudManagementClusterOutputReference\"}")]
        public virtual azurerm.VmwarePrivateCloud.VmwarePrivateCloudManagementClusterOutputReference ManagementCluster
        {
            get => GetInstanceProperty<azurerm.VmwarePrivateCloud.VmwarePrivateCloudManagementClusterOutputReference>()!;
        }

        [JsiiProperty(name: "managementSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementSubnetCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxtCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxtCertificateThumbprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsxtManagerEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxtManagerEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "provisioningSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProvisioningSubnetCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.vmwarePrivateCloud.VmwarePrivateCloudTimeoutsOutputReference\"}")]
        public virtual azurerm.VmwarePrivateCloud.VmwarePrivateCloudTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.VmwarePrivateCloud.VmwarePrivateCloudTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "vcenterCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcenterCertificateThumbprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vcsaEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcsaEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmotionSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmotionSubnetCidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internetConnectionEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternetConnectionEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managementClusterInput", typeJson: "{\"fqn\":\"azurerm.vmwarePrivateCloud.VmwarePrivateCloudManagementCluster\"}", isOptional: true)]
        public virtual azurerm.VmwarePrivateCloud.IVmwarePrivateCloudManagementCluster? ManagementClusterInput
        {
            get => GetInstanceProperty<azurerm.VmwarePrivateCloud.IVmwarePrivateCloudManagementCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkSubnetCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkSubnetCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nsxtPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NsxtPasswordInput
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
        [JsiiProperty(name: "skuNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.vmwarePrivateCloud.VmwarePrivateCloudTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcenterPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VcenterPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "internetConnectionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object InternetConnectionEnabled
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

        [JsiiProperty(name: "networkSubnetCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkSubnetCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nsxtPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NsxtPassword
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

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
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

        [JsiiProperty(name: "vcenterPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcenterPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
