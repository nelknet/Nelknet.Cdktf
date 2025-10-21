using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLaunchTemplate
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_template aws_launch_template}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsLaunchTemplate.DataAwsLaunchTemplate), fullyQualifiedName: "aws.dataAwsLaunchTemplate.DataAwsLaunchTemplate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateConfig\"}}]")]
    public class DataAwsLaunchTemplate : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_template aws_launch_template} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsLaunchTemplate(Constructs.Construct scope, string id, aws.DataAwsLaunchTemplate.IDataAwsLaunchTemplateConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsLaunchTemplate.IDataAwsLaunchTemplateConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchTemplate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchTemplate(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsLaunchTemplate resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsLaunchTemplate to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsLaunchTemplate that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsLaunchTemplate to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsLaunchTemplate to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_template#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsLaunchTemplate that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsLaunchTemplate to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsLaunchTemplate.DataAwsLaunchTemplate), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateFilter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.DataAwsLaunchTemplate.IDataAwsLaunchTemplateFilter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsLaunchTemplate.IDataAwsLaunchTemplateFilter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsLaunchTemplate.IDataAwsLaunchTemplateFilter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.DataAwsLaunchTemplate.IDataAwsLaunchTemplateTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsLaunchTemplate.IDataAwsLaunchTemplateTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsLaunchTemplate.DataAwsLaunchTemplate))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockDeviceMappings", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateBlockDeviceMappingsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateBlockDeviceMappingsList BlockDeviceMappings
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateBlockDeviceMappingsList>()!;
        }

        [JsiiProperty(name: "capacityReservationSpecification", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateCapacityReservationSpecificationList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateCapacityReservationSpecificationList CapacityReservationSpecification
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateCapacityReservationSpecificationList>()!;
        }

        [JsiiProperty(name: "cpuOptions", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateCpuOptionsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateCpuOptionsList CpuOptions
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateCpuOptionsList>()!;
        }

        [JsiiProperty(name: "creditSpecification", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateCreditSpecificationList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateCreditSpecificationList CreditSpecification
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateCreditSpecificationList>()!;
        }

        [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disableApiStop", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DisableApiStop
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DisableApiTermination
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsOptimized
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "elasticGpuSpecifications", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateElasticGpuSpecificationsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateElasticGpuSpecificationsList ElasticGpuSpecifications
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateElasticGpuSpecificationsList>()!;
        }

        [JsiiProperty(name: "elasticInferenceAccelerator", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateElasticInferenceAcceleratorList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateElasticInferenceAcceleratorList ElasticInferenceAccelerator
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateElasticInferenceAcceleratorList>()!;
        }

        [JsiiProperty(name: "enclaveOptions", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateEnclaveOptionsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateEnclaveOptionsList EnclaveOptions
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateEnclaveOptionsList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateFilterList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateFilterList Filter
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateFilterList>()!;
        }

        [JsiiProperty(name: "hibernationOptions", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateHibernationOptionsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateHibernationOptionsList HibernationOptions
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateHibernationOptionsList>()!;
        }

        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateIamInstanceProfileList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateIamInstanceProfileList IamInstanceProfile
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateIamInstanceProfileList>()!;
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceInitiatedShutdownBehavior
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceMarketOptions", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceMarketOptionsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceMarketOptionsList InstanceMarketOptions
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceMarketOptionsList>()!;
        }

        [JsiiProperty(name: "instanceRequirements", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsList InstanceRequirements
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateInstanceRequirementsList>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KernelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LatestVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "licenseSpecification", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateLicenseSpecificationList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateLicenseSpecificationList LicenseSpecification
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateLicenseSpecificationList>()!;
        }

        [JsiiProperty(name: "maintenanceOptions", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateMaintenanceOptionsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateMaintenanceOptionsList MaintenanceOptions
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateMaintenanceOptionsList>()!;
        }

        [JsiiProperty(name: "metadataOptions", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateMetadataOptionsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateMetadataOptionsList MetadataOptions
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateMetadataOptionsList>()!;
        }

        [JsiiProperty(name: "monitoring", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateMonitoringList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateMonitoringList Monitoring
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateMonitoringList>()!;
        }

        [JsiiProperty(name: "networkInterfaces", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateNetworkInterfacesList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateNetworkInterfacesList NetworkInterfaces
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateNetworkInterfacesList>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplatePlacementList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplatePlacementList Placement
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplatePlacementList>()!;
        }

        [JsiiProperty(name: "privateDnsNameOptions", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplatePrivateDnsNameOptionsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplatePrivateDnsNameOptionsList PrivateDnsNameOptions
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplatePrivateDnsNameOptionsList>()!;
        }

        [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RamDiskId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tagSpecifications", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateTagSpecificationsList\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateTagSpecificationsList TagSpecifications
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateTagSpecificationsList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateTimeoutsOutputReference\"}")]
        public virtual aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.DataAwsLaunchTemplate.DataAwsLaunchTemplateTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilterInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.dataAwsLaunchTemplate.DataAwsLaunchTemplateTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
