using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    [JsiiClass(nativeType: typeof(aws.Inspector2Filter.Inspector2FilterFilterCriteriaOutputReference), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Inspector2FilterFilterCriteriaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public Inspector2FilterFilterCriteriaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected Inspector2FilterFilterCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Inspector2FilterFilterCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAwsAccountId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaAwsAccountId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAwsAccountId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaAwsAccountId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaAwsAccountId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaAwsAccountId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCodeVulnerabilityDetectorName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCodeVulnerabilityDetectorName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityDetectorName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityDetectorName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityDetectorName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCodeVulnerabilityDetectorTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCodeVulnerabilityDetectorTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityDetectorTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityDetectorTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityDetectorTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCodeVulnerabilityFilePath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityFilePath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCodeVulnerabilityFilePath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityFilePath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityFilePath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityFilePath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComponentId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaComponentId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutComponentId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaComponentId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaComponentId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaComponentId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putComponentType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaComponentType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutComponentType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaComponentType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaComponentType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaComponentType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEc2InstanceImageId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceImageId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEc2InstanceImageId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceImageId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceImageId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceImageId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEc2InstanceSubnetId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceSubnetId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEc2InstanceSubnetId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceSubnetId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceSubnetId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceSubnetId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEc2InstanceVpcId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceVpcId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEc2InstanceVpcId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceVpcId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceVpcId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceVpcId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcrImageArchitecture", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageArchitecture\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEcrImageArchitecture(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageArchitecture[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageArchitecture).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageArchitecture).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcrImageHash", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageHash\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEcrImageHash(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageHash[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageHash).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageHash).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcrImagePushedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImagePushedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEcrImagePushedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImagePushedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImagePushedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImagePushedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcrImageRegistry", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRegistry\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEcrImageRegistry(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageRegistry[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageRegistry).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageRegistry).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcrImageRepositoryName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRepositoryName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEcrImageRepositoryName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageRepositoryName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageRepositoryName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageRepositoryName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcrImageTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEcrImageTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEpssScore", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEpssScore\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEpssScore(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEpssScore[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEpssScore).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEpssScore).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExploitAvailable", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaExploitAvailable\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExploitAvailable(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaExploitAvailable[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaExploitAvailable).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaExploitAvailable).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFindingArn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingArn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFindingArn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingArn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingArn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingArn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFindingStatus", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingStatus\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFindingStatus(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingStatus[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingStatus).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingStatus).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFindingType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFindingType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirstObservedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFirstObservedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFirstObservedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaFirstObservedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFirstObservedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFirstObservedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFixAvailable", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFixAvailable\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFixAvailable(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaFixAvailable[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFixAvailable).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFixAvailable).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInspectorScore", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaInspectorScore\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutInspectorScore(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaInspectorScore[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaInspectorScore).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaInspectorScore).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaFunctionExecutionRoleArn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLambdaFunctionExecutionRoleArn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaFunctionLastModifiedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLambdaFunctionLastModifiedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaFunctionLayers", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLayers\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLambdaFunctionLayers(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionLayers[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionLayers).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionLayers).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaFunctionName", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionName\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLambdaFunctionName(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionName[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionName).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionName).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaFunctionRuntime", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionRuntime\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLambdaFunctionRuntime(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionRuntime[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionRuntime).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionRuntime).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLastObservedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLastObservedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLastObservedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaLastObservedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLastObservedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLastObservedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkProtocol", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaNetworkProtocol\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkProtocol(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaNetworkProtocol[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaNetworkProtocol).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaNetworkProtocol).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPortRange", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaPortRange\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPortRange(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaPortRange[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaPortRange).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaPortRange).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRelatedVulnerabilities", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaRelatedVulnerabilities\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRelatedVulnerabilities(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaRelatedVulnerabilities[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaRelatedVulnerabilities).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaRelatedVulnerabilities).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceType", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceType\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutResourceType(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceType[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceType).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceType).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSeverity", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaSeverity\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSeverity(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaSeverity[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaSeverity).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaSeverity).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTitle", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaTitle\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTitle(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaTitle[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaTitle).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaTitle).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUpdatedAt", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaUpdatedAt\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUpdatedAt(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaUpdatedAt[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaUpdatedAt).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaUpdatedAt).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVendorSeverity", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVendorSeverity\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVendorSeverity(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVendorSeverity[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVendorSeverity).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVendorSeverity).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVulnerabilityId", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilityId\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVulnerabilityId(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerabilityId[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerabilityId).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerabilityId).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVulnerabilitySource", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilitySource\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVulnerabilitySource(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerabilitySource[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerabilitySource).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerabilitySource).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVulnerablePackages", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackages\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVulnerablePackages(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackages[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackages).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackages).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAwsAccountId")]
        public virtual void ResetAwsAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeVulnerabilityDetectorName")]
        public virtual void ResetCodeVulnerabilityDetectorName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeVulnerabilityDetectorTags")]
        public virtual void ResetCodeVulnerabilityDetectorTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeVulnerabilityFilePath")]
        public virtual void ResetCodeVulnerabilityFilePath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComponentId")]
        public virtual void ResetComponentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComponentType")]
        public virtual void ResetComponentType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2InstanceImageId")]
        public virtual void ResetEc2InstanceImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2InstanceSubnetId")]
        public virtual void ResetEc2InstanceSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2InstanceVpcId")]
        public virtual void ResetEc2InstanceVpcId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcrImageArchitecture")]
        public virtual void ResetEcrImageArchitecture()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcrImageHash")]
        public virtual void ResetEcrImageHash()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcrImagePushedAt")]
        public virtual void ResetEcrImagePushedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcrImageRegistry")]
        public virtual void ResetEcrImageRegistry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcrImageRepositoryName")]
        public virtual void ResetEcrImageRepositoryName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcrImageTags")]
        public virtual void ResetEcrImageTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEpssScore")]
        public virtual void ResetEpssScore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExploitAvailable")]
        public virtual void ResetExploitAvailable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingArn")]
        public virtual void ResetFindingArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingStatus")]
        public virtual void ResetFindingStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFindingType")]
        public virtual void ResetFindingType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirstObservedAt")]
        public virtual void ResetFirstObservedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFixAvailable")]
        public virtual void ResetFixAvailable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInspectorScore")]
        public virtual void ResetInspectorScore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaFunctionExecutionRoleArn")]
        public virtual void ResetLambdaFunctionExecutionRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaFunctionLastModifiedAt")]
        public virtual void ResetLambdaFunctionLastModifiedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaFunctionLayers")]
        public virtual void ResetLambdaFunctionLayers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaFunctionName")]
        public virtual void ResetLambdaFunctionName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaFunctionRuntime")]
        public virtual void ResetLambdaFunctionRuntime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastObservedAt")]
        public virtual void ResetLastObservedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkProtocol")]
        public virtual void ResetNetworkProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPortRange")]
        public virtual void ResetPortRange()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRelatedVulnerabilities")]
        public virtual void ResetRelatedVulnerabilities()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceId")]
        public virtual void ResetResourceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTags")]
        public virtual void ResetResourceTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceType")]
        public virtual void ResetResourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSeverity")]
        public virtual void ResetSeverity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTitle")]
        public virtual void ResetTitle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdatedAt")]
        public virtual void ResetUpdatedAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVendorSeverity")]
        public virtual void ResetVendorSeverity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVulnerabilityId")]
        public virtual void ResetVulnerabilityId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVulnerabilitySource")]
        public virtual void ResetVulnerabilitySource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVulnerablePackages")]
        public virtual void ResetVulnerablePackages()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "awsAccountId", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaAwsAccountIdList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaAwsAccountIdList AwsAccountId
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaAwsAccountIdList>()!;
        }

        [JsiiProperty(name: "codeVulnerabilityDetectorName", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorNameList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorNameList CodeVulnerabilityDetectorName
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorNameList>()!;
        }

        [JsiiProperty(name: "codeVulnerabilityDetectorTags", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorTagsList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorTagsList CodeVulnerabilityDetectorTags
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorTagsList>()!;
        }

        [JsiiProperty(name: "codeVulnerabilityFilePath", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityFilePathList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityFilePathList CodeVulnerabilityFilePath
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityFilePathList>()!;
        }

        [JsiiProperty(name: "componentId", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaComponentIdList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaComponentIdList ComponentId
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaComponentIdList>()!;
        }

        [JsiiProperty(name: "componentType", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaComponentTypeList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaComponentTypeList ComponentType
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaComponentTypeList>()!;
        }

        [JsiiProperty(name: "ec2InstanceImageId", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceImageIdList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceImageIdList Ec2InstanceImageId
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceImageIdList>()!;
        }

        [JsiiProperty(name: "ec2InstanceSubnetId", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceSubnetIdList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceSubnetIdList Ec2InstanceSubnetId
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceSubnetIdList>()!;
        }

        [JsiiProperty(name: "ec2InstanceVpcId", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceVpcIdList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceVpcIdList Ec2InstanceVpcId
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceVpcIdList>()!;
        }

        [JsiiProperty(name: "ecrImageArchitecture", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageArchitectureList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaEcrImageArchitectureList EcrImageArchitecture
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaEcrImageArchitectureList>()!;
        }

        [JsiiProperty(name: "ecrImageHash", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageHashList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaEcrImageHashList EcrImageHash
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaEcrImageHashList>()!;
        }

        [JsiiProperty(name: "ecrImagePushedAt", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImagePushedAtList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaEcrImagePushedAtList EcrImagePushedAt
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaEcrImagePushedAtList>()!;
        }

        [JsiiProperty(name: "ecrImageRegistry", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRegistryList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRegistryList EcrImageRegistry
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRegistryList>()!;
        }

        [JsiiProperty(name: "ecrImageRepositoryName", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRepositoryNameList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRepositoryNameList EcrImageRepositoryName
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRepositoryNameList>()!;
        }

        [JsiiProperty(name: "ecrImageTags", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageTagsList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaEcrImageTagsList EcrImageTags
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaEcrImageTagsList>()!;
        }

        [JsiiProperty(name: "epssScore", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEpssScoreList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaEpssScoreList EpssScore
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaEpssScoreList>()!;
        }

        [JsiiProperty(name: "exploitAvailable", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaExploitAvailableList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaExploitAvailableList ExploitAvailable
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaExploitAvailableList>()!;
        }

        [JsiiProperty(name: "findingArn", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingArnList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaFindingArnList FindingArn
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaFindingArnList>()!;
        }

        [JsiiProperty(name: "findingStatus", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingStatusList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaFindingStatusList FindingStatus
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaFindingStatusList>()!;
        }

        [JsiiProperty(name: "findingType", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingTypeList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaFindingTypeList FindingType
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaFindingTypeList>()!;
        }

        [JsiiProperty(name: "firstObservedAt", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFirstObservedAtList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaFirstObservedAtList FirstObservedAt
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaFirstObservedAtList>()!;
        }

        [JsiiProperty(name: "fixAvailable", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFixAvailableList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaFixAvailableList FixAvailable
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaFixAvailableList>()!;
        }

        [JsiiProperty(name: "inspectorScore", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaInspectorScoreList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaInspectorScoreList InspectorScore
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaInspectorScoreList>()!;
        }

        [JsiiProperty(name: "lambdaFunctionExecutionRoleArn", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArnList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArnList LambdaFunctionExecutionRoleArn
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArnList>()!;
        }

        [JsiiProperty(name: "lambdaFunctionLastModifiedAt", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLastModifiedAtList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLastModifiedAtList LambdaFunctionLastModifiedAt
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLastModifiedAtList>()!;
        }

        [JsiiProperty(name: "lambdaFunctionLayers", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLayersList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLayersList LambdaFunctionLayers
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLayersList>()!;
        }

        [JsiiProperty(name: "lambdaFunctionName", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionNameList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionNameList LambdaFunctionName
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionNameList>()!;
        }

        [JsiiProperty(name: "lambdaFunctionRuntime", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionRuntimeList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionRuntimeList LambdaFunctionRuntime
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionRuntimeList>()!;
        }

        [JsiiProperty(name: "lastObservedAt", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLastObservedAtList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaLastObservedAtList LastObservedAt
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaLastObservedAtList>()!;
        }

        [JsiiProperty(name: "networkProtocol", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaNetworkProtocolList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaNetworkProtocolList NetworkProtocol
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaNetworkProtocolList>()!;
        }

        [JsiiProperty(name: "portRange", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaPortRangeList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaPortRangeList PortRange
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaPortRangeList>()!;
        }

        [JsiiProperty(name: "relatedVulnerabilities", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaRelatedVulnerabilitiesList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaRelatedVulnerabilitiesList RelatedVulnerabilities
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaRelatedVulnerabilitiesList>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceIdList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaResourceIdList ResourceId
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaResourceIdList>()!;
        }

        [JsiiProperty(name: "resourceTags", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceTagsList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaResourceTagsList ResourceTags
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaResourceTagsList>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceTypeList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaResourceTypeList ResourceType
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaResourceTypeList>()!;
        }

        [JsiiProperty(name: "severity", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaSeverityList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaSeverityList Severity
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaSeverityList>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaTitleList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaTitleList Title
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaTitleList>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaUpdatedAtList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaUpdatedAtList UpdatedAt
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaUpdatedAtList>()!;
        }

        [JsiiProperty(name: "vendorSeverity", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVendorSeverityList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaVendorSeverityList VendorSeverity
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaVendorSeverityList>()!;
        }

        [JsiiProperty(name: "vulnerabilityId", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilityIdList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilityIdList VulnerabilityId
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilityIdList>()!;
        }

        [JsiiProperty(name: "vulnerabilitySource", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilitySourceList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilitySourceList VulnerabilitySource
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilitySourceList>()!;
        }

        [JsiiProperty(name: "vulnerablePackages", typeJson: "{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesList\"}")]
        public virtual aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesList VulnerablePackages
        {
            get => GetInstanceProperty<aws.Inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsAccountIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaAwsAccountId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AwsAccountIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeVulnerabilityDetectorNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CodeVulnerabilityDetectorNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeVulnerabilityDetectorTagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CodeVulnerabilityDetectorTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeVulnerabilityFilePathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityFilePath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CodeVulnerabilityFilePathInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaComponentId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ComponentIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaComponentType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ComponentTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2InstanceImageIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceImageId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ec2InstanceImageIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2InstanceSubnetIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceSubnetId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ec2InstanceSubnetIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2InstanceVpcIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceVpcId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ec2InstanceVpcIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecrImageArchitectureInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageArchitecture\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EcrImageArchitectureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecrImageHashInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageHash\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EcrImageHashInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecrImagePushedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImagePushedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EcrImagePushedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecrImageRegistryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRegistry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EcrImageRegistryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecrImageRepositoryNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRepositoryName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EcrImageRepositoryNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecrImageTagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EcrImageTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "epssScoreInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEpssScore\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EpssScoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "exploitAvailableInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaExploitAvailable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExploitAvailableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingArnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FindingArnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingStatusInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FindingStatusInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "findingTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FindingTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstObservedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFirstObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FirstObservedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixAvailableInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFixAvailable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FixAvailableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inspectorScoreInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaInspectorScore\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? InspectorScoreInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionExecutionRoleArnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LambdaFunctionExecutionRoleArnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionLastModifiedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LambdaFunctionLastModifiedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionLayersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLayers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LambdaFunctionLayersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionNameInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LambdaFunctionNameInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionRuntimeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionRuntime\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LambdaFunctionRuntimeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastObservedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LastObservedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkProtocolInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaNetworkProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkProtocolInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portRangeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaPortRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PortRangeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "relatedVulnerabilitiesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaRelatedVulnerabilities\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RelatedVulnerabilitiesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ResourceTypeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "severityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaSeverity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SeverityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "titleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaTitle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TitleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updatedAtInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UpdatedAtInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vendorSeverityInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVendorSeverity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VendorSeverityInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vulnerabilityIdInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilityId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VulnerabilityIdInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vulnerabilitySourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilitySource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VulnerabilitySourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vulnerablePackagesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VulnerablePackagesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteria\"}]}}", isOptional: true)]
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
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteria cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteria).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
