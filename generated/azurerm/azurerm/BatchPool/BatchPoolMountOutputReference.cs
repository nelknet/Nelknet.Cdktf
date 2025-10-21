using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchPool
{
    [JsiiClass(nativeType: typeof(azurerm.BatchPool.BatchPoolMountOutputReference), fullyQualifiedName: "azurerm.batchPool.BatchPoolMountOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BatchPoolMountOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public BatchPoolMountOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchPoolMountOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchPoolMountOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAzureBlobFileSystem", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountAzureBlobFileSystem\"}}]")]
        public virtual void PutAzureBlobFileSystem(azurerm.BatchPool.IBatchPoolMountAzureBlobFileSystem @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.BatchPool.IBatchPoolMountAzureBlobFileSystem)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureFileShare", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountAzureFileShare\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAzureFileShare(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolMountAzureFileShare[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMountAzureFileShare).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMountAzureFileShare).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCifsMount", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountCifsMount\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCifsMount(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolMountCifsMount[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMountCifsMount).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMountCifsMount).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNfsMount", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountNfsMount\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNfsMount(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.BatchPool.IBatchPoolMountNfsMount[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMountNfsMount).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMountNfsMount).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAzureBlobFileSystem")]
        public virtual void ResetAzureBlobFileSystem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureFileShare")]
        public virtual void ResetAzureFileShare()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCifsMount")]
        public virtual void ResetCifsMount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNfsMount")]
        public virtual void ResetNfsMount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "azureBlobFileSystem", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolMountAzureBlobFileSystemOutputReference\"}")]
        public virtual azurerm.BatchPool.BatchPoolMountAzureBlobFileSystemOutputReference AzureBlobFileSystem
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolMountAzureBlobFileSystemOutputReference>()!;
        }

        [JsiiProperty(name: "azureFileShare", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolMountAzureFileShareList\"}")]
        public virtual azurerm.BatchPool.BatchPoolMountAzureFileShareList AzureFileShare
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolMountAzureFileShareList>()!;
        }

        [JsiiProperty(name: "cifsMount", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolMountCifsMountList\"}")]
        public virtual azurerm.BatchPool.BatchPoolMountCifsMountList CifsMount
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolMountCifsMountList>()!;
        }

        [JsiiProperty(name: "nfsMount", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolMountNfsMountList\"}")]
        public virtual azurerm.BatchPool.BatchPoolMountNfsMountList NfsMount
        {
            get => GetInstanceProperty<azurerm.BatchPool.BatchPoolMountNfsMountList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureBlobFileSystemInput", typeJson: "{\"fqn\":\"azurerm.batchPool.BatchPoolMountAzureBlobFileSystem\"}", isOptional: true)]
        public virtual azurerm.BatchPool.IBatchPoolMountAzureBlobFileSystem? AzureBlobFileSystemInput
        {
            get => GetInstanceProperty<azurerm.BatchPool.IBatchPoolMountAzureBlobFileSystem?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureFileShareInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountAzureFileShare\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AzureFileShareInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cifsMountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountCifsMount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CifsMountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nfsMountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.batchPool.BatchPoolMountNfsMount\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NfsMountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.batchPool.BatchPoolMount\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.BatchPool.IBatchPoolMount cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.BatchPool.IBatchPoolMount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
