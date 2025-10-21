using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster azurerm_service_fabric_cluster}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ServiceFabricCluster.ServiceFabricCluster), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterConfig\"}}]")]
    public class ServiceFabricCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster azurerm_service_fabric_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceFabricCluster(Constructs.Construct scope, string id, azurerm.ServiceFabricCluster.IServiceFabricClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ServiceFabricCluster.IServiceFabricClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceFabricCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceFabricCluster(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ServiceFabricCluster resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServiceFabricCluster to import.</param>
        /// <param name="importFromId">The id of the existing ServiceFabricCluster that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServiceFabricCluster to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServiceFabricCluster to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServiceFabricCluster that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServiceFabricCluster to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ServiceFabricCluster.ServiceFabricCluster), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAzureActiveDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterAzureActiveDirectory\"}}]")]
        public virtual void PutAzureActiveDirectory(azurerm.ServiceFabricCluster.IServiceFabricClusterAzureActiveDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterAzureActiveDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificate\"}}]")]
        public virtual void PutCertificate(azurerm.ServiceFabricCluster.IServiceFabricClusterCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificateCommonNames", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNames\"}}]")]
        public virtual void PutCertificateCommonNames(azurerm.ServiceFabricCluster.IServiceFabricClusterCertificateCommonNames @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterCertificateCommonNames)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientCertificateCommonName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateCommonName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClientCertificateCommonName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateCommonName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateCommonName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateCommonName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClientCertificateThumbprint", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateThumbprint\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutClientCertificateThumbprint(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateThumbprint[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateThumbprint).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterClientCertificateThumbprint).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDiagnosticsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterDiagnosticsConfig\"}}]")]
        public virtual void PutDiagnosticsConfig(azurerm.ServiceFabricCluster.IServiceFabricClusterDiagnosticsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterDiagnosticsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFabricSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterFabricSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFabricSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ServiceFabricCluster.IServiceFabricClusterFabricSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterFabricSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterFabricSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterNodeType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNodeType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ServiceFabricCluster.IServiceFabricClusterNodeType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterNodeType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterNodeType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReverseProxyCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificate\"}}]")]
        public virtual void PutReverseProxyCertificate(azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReverseProxyCertificateCommonNames", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificateCommonNames\"}}]")]
        public virtual void PutReverseProxyCertificateCommonNames(azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificateCommonNames @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificateCommonNames)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ServiceFabricCluster.IServiceFabricClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpgradePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicy\"}}]")]
        public virtual void PutUpgradePolicy(azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddOnFeatures")]
        public virtual void ResetAddOnFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureActiveDirectory")]
        public virtual void ResetAzureActiveDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificate")]
        public virtual void ResetCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateCommonNames")]
        public virtual void ResetCertificateCommonNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateCommonName")]
        public virtual void ResetClientCertificateCommonName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientCertificateThumbprint")]
        public virtual void ResetClientCertificateThumbprint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterCodeVersion")]
        public virtual void ResetClusterCodeVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiagnosticsConfig")]
        public virtual void ResetDiagnosticsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFabricSettings")]
        public virtual void ResetFabricSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReverseProxyCertificate")]
        public virtual void ResetReverseProxyCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReverseProxyCertificateCommonNames")]
        public virtual void ResetReverseProxyCertificateCommonNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceFabricZonalUpgradeMode")]
        public virtual void ResetServiceFabricZonalUpgradeMode()
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

        [JsiiMethod(name: "resetUpgradePolicy")]
        public virtual void ResetUpgradePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVmssZonalUpgradeMode")]
        public virtual void ResetVmssZonalUpgradeMode()
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
        = GetStaticProperty<string>(typeof(azurerm.ServiceFabricCluster.ServiceFabricCluster))!;

        [JsiiProperty(name: "azureActiveDirectory", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterAzureActiveDirectoryOutputReference\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterAzureActiveDirectoryOutputReference AzureActiveDirectory
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterAzureActiveDirectoryOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificateOutputReference\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterCertificateOutputReference Certificate
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "certificateCommonNames", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNamesOutputReference\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterCertificateCommonNamesOutputReference CertificateCommonNames
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterCertificateCommonNamesOutputReference>()!;
        }

        [JsiiProperty(name: "clientCertificateCommonName", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateCommonNameList\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterClientCertificateCommonNameList ClientCertificateCommonName
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterClientCertificateCommonNameList>()!;
        }

        [JsiiProperty(name: "clientCertificateThumbprint", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateThumbprintList\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterClientCertificateThumbprintList ClientCertificateThumbprint
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterClientCertificateThumbprintList>()!;
        }

        [JsiiProperty(name: "clusterEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "diagnosticsConfig", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterDiagnosticsConfigOutputReference\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterDiagnosticsConfigOutputReference DiagnosticsConfig
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterDiagnosticsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "fabricSettings", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterFabricSettingsList\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterFabricSettingsList FabricSettings
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterFabricSettingsList>()!;
        }

        [JsiiProperty(name: "nodeType", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterNodeTypeList\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterNodeTypeList NodeType
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterNodeTypeList>()!;
        }

        [JsiiProperty(name: "reverseProxyCertificate", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificateOutputReference\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterReverseProxyCertificateOutputReference ReverseProxyCertificate
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterReverseProxyCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "reverseProxyCertificateCommonNames", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificateCommonNamesOutputReference\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterReverseProxyCertificateCommonNamesOutputReference ReverseProxyCertificateCommonNames
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterReverseProxyCertificateCommonNamesOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterTimeoutsOutputReference\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "upgradePolicy", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicyOutputReference\"}")]
        public virtual azurerm.ServiceFabricCluster.ServiceFabricClusterUpgradePolicyOutputReference UpgradePolicy
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.ServiceFabricClusterUpgradePolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addOnFeaturesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AddOnFeaturesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureActiveDirectoryInput", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterAzureActiveDirectory\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterAzureActiveDirectory? AzureActiveDirectoryInput
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterAzureActiveDirectory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateCommonNamesInput", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificateCommonNames\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterCertificateCommonNames? CertificateCommonNamesInput
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterCertificateCommonNames?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterCertificate\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterCertificate? CertificateInput
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterCertificate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateCommonNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateCommonName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClientCertificateCommonNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateThumbprintInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterClientCertificateThumbprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ClientCertificateThumbprintInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterCodeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterCodeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diagnosticsConfigInput", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterDiagnosticsConfig\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterDiagnosticsConfig? DiagnosticsConfigInput
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterDiagnosticsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fabricSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterFabricSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FabricSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
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
        [JsiiProperty(name: "managementEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagementEndpointInput
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
        [JsiiProperty(name: "nodeTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterNodeType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NodeTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reliabilityLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReliabilityLevelInput
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
        [JsiiProperty(name: "reverseProxyCertificateCommonNamesInput", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificateCommonNames\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificateCommonNames? ReverseProxyCertificateCommonNamesInput
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificateCommonNames?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "reverseProxyCertificateInput", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterReverseProxyCertificate\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificate? ReverseProxyCertificateInput
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterReverseProxyCertificate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceFabricZonalUpgradeModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceFabricZonalUpgradeModeInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterTimeouts\"}]}}", isOptional: true)]
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
        [JsiiProperty(name: "upgradePolicyInput", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterUpgradePolicy\"}", isOptional: true)]
        public virtual azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicy? UpgradePolicyInput
        {
            get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterUpgradePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmImageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vmssZonalUpgradeModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VmssZonalUpgradeModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "addOnFeatures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AddOnFeatures
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterCodeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterCodeVersion
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

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managementEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementEndpoint
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

        [JsiiProperty(name: "reliabilityLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReliabilityLevel
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

        [JsiiProperty(name: "serviceFabricZonalUpgradeMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceFabricZonalUpgradeMode
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

        [JsiiProperty(name: "vmImage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmImage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmssZonalUpgradeMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmssZonalUpgradeMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
