using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool azurerm_batch_pool}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.BatchPool.BatchPool), fullyQualifiedName: "azurerm.batchPool.BatchPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.batchPool.BatchPoolConfig\"}}]")]
    public class BatchPool : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool azurerm_batch_pool} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BatchPool(Constructs.Construct scope, string id, azurerm.BatchPool.IBatchPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.BatchPool.IBatchPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a BatchPool resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BatchPool to import.</param>
        /// <param name="importFromId">The id of the existing BatchPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BatchPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BatchPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BatchPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BatchPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.BatchPool.BatchPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutoScale", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchPool.BatchPoolAutoScale\"}}]")]
        public virtual void PutAutoScale(azurerm.BatchPool.IBatchPoolAutoScale @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchPool.IBatchPoolAutoScale)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolCertificate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCertificate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolCertificate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolCertificate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolCertificate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContainerConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchPool.BatchPoolContainerConfiguration\"}}]")]
        public virtual void PutContainerConfiguration(azurerm.BatchPool.IBatchPoolContainerConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchPool.IBatchPoolContainerConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataDisks", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolDataDisks\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDataDisks(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolDataDisks[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolDataDisks).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolDataDisks).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDiskEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolDiskEncryption\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDiskEncryption(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolDiskEncryption[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolDiskEncryption).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolDiskEncryption).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExtensions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolExtensions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExtensions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolExtensions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolExtensions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolExtensions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFixedScale", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchPool.BatchPoolFixedScale\"}}]")]
        public virtual void PutFixedScale(azurerm.BatchPool.IBatchPoolFixedScale @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchPool.IBatchPoolFixedScale)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchPool.BatchPoolIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.BatchPool.IBatchPoolIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchPool.IBatchPoolIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMount", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMount\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMount(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolMount[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMount).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMount).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchPool.BatchPoolNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(azurerm.BatchPool.IBatchPoolNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchPool.IBatchPoolNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodePlacement", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolNodePlacement\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNodePlacement(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolNodePlacement[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolNodePlacement).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolNodePlacement).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStartTask", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchPool.BatchPoolStartTask\"}}]")]
        public virtual void PutStartTask(azurerm.BatchPool.IBatchPoolStartTask @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchPool.IBatchPoolStartTask)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageImageReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchPool.BatchPoolStorageImageReference\"}}]")]
        public virtual void PutStorageImageReference(azurerm.BatchPool.IBatchPoolStorageImageReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchPool.IBatchPoolStorageImageReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTaskSchedulingPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolTaskSchedulingPolicy\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTaskSchedulingPolicy(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolTaskSchedulingPolicy[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolTaskSchedulingPolicy).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolTaskSchedulingPolicy).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchPool.BatchPoolTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.BatchPool.IBatchPoolTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchPool.IBatchPoolTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserAccounts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolUserAccounts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUserAccounts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolUserAccounts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolUserAccounts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolUserAccounts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWindows", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolWindows\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutWindows(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolWindows[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolWindows).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolWindows).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoScale")]
        public virtual void ResetAutoScale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificate")]
        public virtual void ResetCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerConfiguration")]
        public virtual void ResetContainerConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataDisks")]
        public virtual void ResetDataDisks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiskEncryption")]
        public virtual void ResetDiskEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExtensions")]
        public virtual void ResetExtensions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFixedScale")]
        public virtual void ResetFixedScale()
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

        [JsiiMethod(name: "resetInterNodeCommunication")]
        public virtual void ResetInterNodeCommunication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicenseType")]
        public virtual void ResetLicenseType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxTasksPerNode")]
        public virtual void ResetMaxTasksPerNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMount")]
        public virtual void ResetMount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkConfiguration")]
        public virtual void ResetNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodePlacement")]
        public virtual void ResetNodePlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsDiskPlacement")]
        public virtual void ResetOsDiskPlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartTask")]
        public virtual void ResetStartTask()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStopPendingResizeOperation")]
        public virtual void ResetStopPendingResizeOperation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetNodeCommunicationMode")]
        public virtual void ResetTargetNodeCommunicationMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskSchedulingPolicy")]
        public virtual void ResetTaskSchedulingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserAccounts")]
        public virtual void ResetUserAccounts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWindows")]
        public virtual void ResetWindows()
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
        = GetStaticProperty<string>(typeof(azurerm.BatchPool.BatchPool))!;

        [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolAutoScaleOutputReference\"}")]
        public virtual azurerm.BatchPool.BatchPoolAutoScaleOutputReference AutoScale
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolAutoScaleOutputReference>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolCertificateList\"}")]
        public virtual azurerm.BatchPool.BatchPoolCertificateList Certificate
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolCertificateList>()!;
        }

        [JsiiProperty(name: "containerConfiguration", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolContainerConfigurationOutputReference\"}")]
        public virtual azurerm.BatchPool.BatchPoolContainerConfigurationOutputReference ContainerConfiguration
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolContainerConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "dataDisks", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolDataDisksList\"}")]
        public virtual azurerm.BatchPool.BatchPoolDataDisksList DataDisks
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolDataDisksList>()!;
        }

        [JsiiProperty(name: "diskEncryption", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolDiskEncryptionList\"}")]
        public virtual azurerm.BatchPool.BatchPoolDiskEncryptionList DiskEncryption
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolDiskEncryptionList>()!;
        }

        [JsiiProperty(name: "extensions", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolExtensionsList\"}")]
        public virtual azurerm.BatchPool.BatchPoolExtensionsList Extensions
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolExtensionsList>()!;
        }

        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolFixedScaleOutputReference\"}")]
        public virtual azurerm.BatchPool.BatchPoolFixedScaleOutputReference FixedScale
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolFixedScaleOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolIdentityOutputReference\"}")]
        public virtual azurerm.BatchPool.BatchPoolIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "mount", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolMountList\"}")]
        public virtual azurerm.BatchPool.BatchPoolMountList Mount
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolMountList>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolNetworkConfigurationOutputReference\"}")]
        public virtual azurerm.BatchPool.BatchPoolNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "nodePlacement", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolNodePlacementList\"}")]
        public virtual azurerm.BatchPool.BatchPoolNodePlacementList NodePlacement
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolNodePlacementList>()!;
        }

        [JsiiProperty(name: "startTask", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTaskOutputReference\"}")]
        public virtual azurerm.BatchPool.BatchPoolStartTaskOutputReference StartTask
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolStartTaskOutputReference>()!;
        }

        [JsiiProperty(name: "storageImageReference", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStorageImageReferenceOutputReference\"}")]
        public virtual azurerm.BatchPool.BatchPoolStorageImageReferenceOutputReference StorageImageReference
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolStorageImageReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "taskSchedulingPolicy", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolTaskSchedulingPolicyList\"}")]
        public virtual azurerm.BatchPool.BatchPoolTaskSchedulingPolicyList TaskSchedulingPolicy
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolTaskSchedulingPolicyList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolTimeoutsOutputReference\"}")]
        public virtual azurerm.BatchPool.BatchPoolTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "userAccounts", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolUserAccountsList\"}")]
        public virtual azurerm.BatchPool.BatchPoolUserAccountsList UserAccounts
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolUserAccountsList>()!;
        }

        [JsiiProperty(name: "windows", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolWindowsList\"}")]
        public virtual azurerm.BatchPool.BatchPoolWindowsList Windows
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolWindowsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScaleInput", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolAutoScale\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolAutoScale? AutoScaleInput
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolAutoScale?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerConfigurationInput", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolContainerConfiguration\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolContainerConfiguration? ContainerConfigurationInput
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolContainerConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataDisksInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolDataDisks\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DataDisksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskEncryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolDiskEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DiskEncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "extensionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolExtensions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExtensionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedScaleInput", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolFixedScale\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolFixedScale? FixedScaleInput
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolFixedScale?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolIdentity\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "interNodeCommunicationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InterNodeCommunicationInput
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
        [JsiiProperty(name: "maxTasksPerNodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxTasksPerNodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolNetworkConfiguration\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeAgentSkuIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeAgentSkuIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodePlacementInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolNodePlacement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NodePlacementInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osDiskPlacementInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OsDiskPlacementInput
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
        [JsiiProperty(name: "startTaskInput", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStartTask\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolStartTask? StartTaskInput
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolStartTask?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stopPendingResizeOperationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StopPendingResizeOperationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageImageReferenceInput", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolStorageImageReference\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolStorageImageReference? StorageImageReferenceInput
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolStorageImageReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetNodeCommunicationModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetNodeCommunicationModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskSchedulingPolicyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolTaskSchedulingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TaskSchedulingPolicyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.batchPool.BatchPoolTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userAccountsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolUserAccounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UserAccountsInput
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
        [JsiiProperty(name: "windowsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolWindows\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? WindowsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "interNodeCommunication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InterNodeCommunication
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

        [JsiiProperty(name: "maxTasksPerNode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTasksPerNode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeAgentSkuId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeAgentSkuId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "osDiskPlacement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsDiskPlacement
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

        [JsiiProperty(name: "stopPendingResizeOperation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object StopPendingResizeOperation
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

        [JsiiProperty(name: "targetNodeCommunicationMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetNodeCommunicationMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vmSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmSize
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
