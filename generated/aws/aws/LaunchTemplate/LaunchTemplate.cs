using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template aws_launch_template}.</summary>
    [JsiiClass(nativeType: typeof(aws.LaunchTemplate.LaunchTemplate), fullyQualifiedName: "aws.launchTemplate.LaunchTemplate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateConfig\"}}]")]
    public class LaunchTemplate : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template aws_launch_template} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LaunchTemplate(Constructs.Construct scope, string id, aws.LaunchTemplate.ILaunchTemplateConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.LaunchTemplate.ILaunchTemplateConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplate(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a LaunchTemplate resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LaunchTemplate to import.</param>
        /// <param name="importFromId">The id of the existing LaunchTemplate that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LaunchTemplate to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LaunchTemplate to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LaunchTemplate that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LaunchTemplate to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.LaunchTemplate.LaunchTemplate), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBlockDeviceMappings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateBlockDeviceMappings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutBlockDeviceMappings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LaunchTemplate.ILaunchTemplateBlockDeviceMappings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LaunchTemplate.ILaunchTemplateBlockDeviceMappings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LaunchTemplate.ILaunchTemplateBlockDeviceMappings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCapacityReservationSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateCapacityReservationSpecification\"}}]")]
        public virtual void PutCapacityReservationSpecification(aws.LaunchTemplate.ILaunchTemplateCapacityReservationSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateCapacityReservationSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCpuOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateCpuOptions\"}}]")]
        public virtual void PutCpuOptions(aws.LaunchTemplate.ILaunchTemplateCpuOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateCpuOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCreditSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateCreditSpecification\"}}]")]
        public virtual void PutCreditSpecification(aws.LaunchTemplate.ILaunchTemplateCreditSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateCreditSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putElasticGpuSpecifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateElasticGpuSpecifications\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutElasticGpuSpecifications(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LaunchTemplate.ILaunchTemplateElasticGpuSpecifications[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LaunchTemplate.ILaunchTemplateElasticGpuSpecifications).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LaunchTemplate.ILaunchTemplateElasticGpuSpecifications).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putElasticInferenceAccelerator", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateElasticInferenceAccelerator\"}}]")]
        public virtual void PutElasticInferenceAccelerator(aws.LaunchTemplate.ILaunchTemplateElasticInferenceAccelerator @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateElasticInferenceAccelerator)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnclaveOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateEnclaveOptions\"}}]")]
        public virtual void PutEnclaveOptions(aws.LaunchTemplate.ILaunchTemplateEnclaveOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateEnclaveOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHibernationOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateHibernationOptions\"}}]")]
        public virtual void PutHibernationOptions(aws.LaunchTemplate.ILaunchTemplateHibernationOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateHibernationOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIamInstanceProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateIamInstanceProfile\"}}]")]
        public virtual void PutIamInstanceProfile(aws.LaunchTemplate.ILaunchTemplateIamInstanceProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateIamInstanceProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstanceMarketOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceMarketOptions\"}}]")]
        public virtual void PutInstanceMarketOptions(aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstanceRequirements", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirements\"}}]")]
        public virtual void PutInstanceRequirements(aws.LaunchTemplate.ILaunchTemplateInstanceRequirements @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateInstanceRequirements)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLicenseSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateLicenseSpecification\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLicenseSpecification(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LaunchTemplate.ILaunchTemplateLicenseSpecification[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LaunchTemplate.ILaunchTemplateLicenseSpecification).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LaunchTemplate.ILaunchTemplateLicenseSpecification).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenanceOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateMaintenanceOptions\"}}]")]
        public virtual void PutMaintenanceOptions(aws.LaunchTemplate.ILaunchTemplateMaintenanceOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateMaintenanceOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetadataOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateMetadataOptions\"}}]")]
        public virtual void PutMetadataOptions(aws.LaunchTemplate.ILaunchTemplateMetadataOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateMetadataOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitoring", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateMonitoring\"}}]")]
        public virtual void PutMonitoring(aws.LaunchTemplate.ILaunchTemplateMonitoring @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateMonitoring)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkInterfaces", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateNetworkInterfaces\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkInterfaces(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LaunchTemplate.ILaunchTemplateNetworkInterfaces[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LaunchTemplate.ILaunchTemplateNetworkInterfaces).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LaunchTemplate.ILaunchTemplateNetworkInterfaces).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplatePlacement\"}}]")]
        public virtual void PutPlacement(aws.LaunchTemplate.ILaunchTemplatePlacement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplatePlacement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrivateDnsNameOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplatePrivateDnsNameOptions\"}}]")]
        public virtual void PutPrivateDnsNameOptions(aws.LaunchTemplate.ILaunchTemplatePrivateDnsNameOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplatePrivateDnsNameOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTagSpecifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateTagSpecifications\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTagSpecifications(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LaunchTemplate.ILaunchTemplateTagSpecifications[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LaunchTemplate.ILaunchTemplateTagSpecifications).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LaunchTemplate.ILaunchTemplateTagSpecifications).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBlockDeviceMappings")]
        public virtual void ResetBlockDeviceMappings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCapacityReservationSpecification")]
        public virtual void ResetCapacityReservationSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCpuOptions")]
        public virtual void ResetCpuOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreditSpecification")]
        public virtual void ResetCreditSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultVersion")]
        public virtual void ResetDefaultVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableApiStop")]
        public virtual void ResetDisableApiStop()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableApiTermination")]
        public virtual void ResetDisableApiTermination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsOptimized")]
        public virtual void ResetEbsOptimized()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticGpuSpecifications")]
        public virtual void ResetElasticGpuSpecifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticInferenceAccelerator")]
        public virtual void ResetElasticInferenceAccelerator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnclaveOptions")]
        public virtual void ResetEnclaveOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHibernationOptions")]
        public virtual void ResetHibernationOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIamInstanceProfile")]
        public virtual void ResetIamInstanceProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageId")]
        public virtual void ResetImageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceInitiatedShutdownBehavior")]
        public virtual void ResetInstanceInitiatedShutdownBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceMarketOptions")]
        public virtual void ResetInstanceMarketOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceRequirements")]
        public virtual void ResetInstanceRequirements()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceType")]
        public virtual void ResetInstanceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKernelId")]
        public virtual void ResetKernelId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyName")]
        public virtual void ResetKeyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicenseSpecification")]
        public virtual void ResetLicenseSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceOptions")]
        public virtual void ResetMaintenanceOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadataOptions")]
        public virtual void ResetMetadataOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitoring")]
        public virtual void ResetMonitoring()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamePrefix")]
        public virtual void ResetNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkInterfaces")]
        public virtual void ResetNetworkInterfaces()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacement")]
        public virtual void ResetPlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateDnsNameOptions")]
        public virtual void ResetPrivateDnsNameOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRamDiskId")]
        public virtual void ResetRamDiskId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupNames")]
        public virtual void ResetSecurityGroupNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagSpecifications")]
        public virtual void ResetTagSpecifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUpdateDefaultVersion")]
        public virtual void ResetUpdateDefaultVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserData")]
        public virtual void ResetUserData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpcSecurityGroupIds")]
        public virtual void ResetVpcSecurityGroupIds()
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
        = GetStaticProperty<string>(typeof(aws.LaunchTemplate.LaunchTemplate))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockDeviceMappings", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateBlockDeviceMappingsList\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateBlockDeviceMappingsList BlockDeviceMappings
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateBlockDeviceMappingsList>()!;
        }

        [JsiiProperty(name: "capacityReservationSpecification", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateCapacityReservationSpecificationOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateCapacityReservationSpecificationOutputReference CapacityReservationSpecification
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateCapacityReservationSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "cpuOptions", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateCpuOptionsOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateCpuOptionsOutputReference CpuOptions
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateCpuOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "creditSpecification", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateCreditSpecificationOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateCreditSpecificationOutputReference CreditSpecification
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateCreditSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "elasticGpuSpecifications", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateElasticGpuSpecificationsList\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateElasticGpuSpecificationsList ElasticGpuSpecifications
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateElasticGpuSpecificationsList>()!;
        }

        [JsiiProperty(name: "elasticInferenceAccelerator", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateElasticInferenceAcceleratorOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateElasticInferenceAcceleratorOutputReference ElasticInferenceAccelerator
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateElasticInferenceAcceleratorOutputReference>()!;
        }

        [JsiiProperty(name: "enclaveOptions", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateEnclaveOptionsOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateEnclaveOptionsOutputReference EnclaveOptions
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateEnclaveOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "hibernationOptions", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateHibernationOptionsOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateHibernationOptionsOutputReference HibernationOptions
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateHibernationOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateIamInstanceProfileOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateIamInstanceProfileOutputReference IamInstanceProfile
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateIamInstanceProfileOutputReference>()!;
        }

        [JsiiProperty(name: "instanceMarketOptions", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceMarketOptionsOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateInstanceMarketOptionsOutputReference InstanceMarketOptions
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateInstanceMarketOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "instanceRequirements", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirementsOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateInstanceRequirementsOutputReference InstanceRequirements
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateInstanceRequirementsOutputReference>()!;
        }

        [JsiiProperty(name: "latestVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LatestVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "licenseSpecification", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateLicenseSpecificationList\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateLicenseSpecificationList LicenseSpecification
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateLicenseSpecificationList>()!;
        }

        [JsiiProperty(name: "maintenanceOptions", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateMaintenanceOptionsOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateMaintenanceOptionsOutputReference MaintenanceOptions
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateMaintenanceOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "metadataOptions", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateMetadataOptionsOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateMetadataOptionsOutputReference MetadataOptions
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateMetadataOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "monitoring", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateMonitoringOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateMonitoringOutputReference Monitoring
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateMonitoringOutputReference>()!;
        }

        [JsiiProperty(name: "networkInterfaces", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateNetworkInterfacesList\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateNetworkInterfacesList NetworkInterfaces
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateNetworkInterfacesList>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplatePlacementOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplatePlacementOutputReference Placement
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplatePlacementOutputReference>()!;
        }

        [JsiiProperty(name: "privateDnsNameOptions", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplatePrivateDnsNameOptionsOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplatePrivateDnsNameOptionsOutputReference PrivateDnsNameOptions
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplatePrivateDnsNameOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "tagSpecifications", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateTagSpecificationsList\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateTagSpecificationsList TagSpecifications
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateTagSpecificationsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockDeviceMappingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateBlockDeviceMappings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? BlockDeviceMappingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationSpecificationInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateCapacityReservationSpecification\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateCapacityReservationSpecification? CapacityReservationSpecificationInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateCapacityReservationSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuOptionsInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateCpuOptions\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateCpuOptions? CpuOptionsInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateCpuOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "creditSpecificationInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateCreditSpecification\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateCreditSpecification? CreditSpecificationInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateCreditSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableApiStopInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisableApiStopInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableApiTerminationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisableApiTerminationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimizedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EbsOptimizedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticGpuSpecificationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateElasticGpuSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ElasticGpuSpecificationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticInferenceAcceleratorInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateElasticInferenceAccelerator\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateElasticInferenceAccelerator? ElasticInferenceAcceleratorInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateElasticInferenceAccelerator?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enclaveOptionsInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateEnclaveOptions\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateEnclaveOptions? EnclaveOptionsInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateEnclaveOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hibernationOptionsInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateHibernationOptions\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateHibernationOptions? HibernationOptionsInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateHibernationOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamInstanceProfileInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateIamInstanceProfile\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateIamInstanceProfile? IamInstanceProfileInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateIamInstanceProfile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInitiatedShutdownBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceInitiatedShutdownBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceMarketOptionsInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceMarketOptions\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptions? InstanceMarketOptionsInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceMarketOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceRequirementsInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateInstanceRequirements\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateInstanceRequirements? InstanceRequirementsInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateInstanceRequirements?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KernelIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseSpecificationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateLicenseSpecification\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LicenseSpecificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceOptionsInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateMaintenanceOptions\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateMaintenanceOptions? MaintenanceOptionsInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateMaintenanceOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataOptionsInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateMetadataOptions\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateMetadataOptions? MetadataOptionsInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateMetadataOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateMonitoring\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateMonitoring? MonitoringInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateMonitoring?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfacesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateNetworkInterfaces\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkInterfacesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplatePlacement\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplatePlacement? PlacementInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplatePlacement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateDnsNameOptionsInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplatePrivateDnsNameOptions\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplatePrivateDnsNameOptions? PrivateDnsNameOptionsInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplatePrivateDnsNameOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ramDiskIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RamDiskIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagSpecificationsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateTagSpecifications\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagSpecificationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "updateDefaultVersionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UpdateDefaultVersionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDataInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserDataInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VpcSecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "disableApiStop", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DisableApiStop
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

        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DisableApiTermination
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

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsOptimized
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

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceInitiatedShutdownBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KernelId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyName
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

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RamDiskId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "updateDefaultVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object UpdateDefaultVersion
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

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
