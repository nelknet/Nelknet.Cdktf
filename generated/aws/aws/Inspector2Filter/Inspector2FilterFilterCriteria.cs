using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    [JsiiByValue(fqn: "aws.inspector2Filter.Inspector2FilterFilterCriteria")]
    public class Inspector2FilterFilterCriteria : aws.Inspector2Filter.IInspector2FilterFilterCriteria
    {
        private object? _awsAccountId;

        /// <summary>aws_account_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#aws_account_id Inspector2Filter#aws_account_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsAccountId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaAwsAccountId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AwsAccountId
        {
            get => _awsAccountId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaAwsAccountId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaAwsAccountId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _awsAccountId = value;
            }
        }

        private object? _codeVulnerabilityDetectorName;

        /// <summary>code_vulnerability_detector_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#code_vulnerability_detector_name Inspector2Filter#code_vulnerability_detector_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeVulnerabilityDetectorName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CodeVulnerabilityDetectorName
        {
            get => _codeVulnerabilityDetectorName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityDetectorName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityDetectorName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _codeVulnerabilityDetectorName = value;
            }
        }

        private object? _codeVulnerabilityDetectorTags;

        /// <summary>code_vulnerability_detector_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#code_vulnerability_detector_tags Inspector2Filter#code_vulnerability_detector_tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeVulnerabilityDetectorTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CodeVulnerabilityDetectorTags
        {
            get => _codeVulnerabilityDetectorTags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityDetectorTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityDetectorTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _codeVulnerabilityDetectorTags = value;
            }
        }

        private object? _codeVulnerabilityFilePath;

        /// <summary>code_vulnerability_file_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#code_vulnerability_file_path Inspector2Filter#code_vulnerability_file_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeVulnerabilityFilePath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityFilePath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CodeVulnerabilityFilePath
        {
            get => _codeVulnerabilityFilePath;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityFilePath[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaCodeVulnerabilityFilePath).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _codeVulnerabilityFilePath = value;
            }
        }

        private object? _componentId;

        /// <summary>component_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#component_id Inspector2Filter#component_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "componentId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaComponentId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ComponentId
        {
            get => _componentId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaComponentId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaComponentId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _componentId = value;
            }
        }

        private object? _componentType;

        /// <summary>component_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#component_type Inspector2Filter#component_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "componentType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaComponentType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ComponentType
        {
            get => _componentType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaComponentType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaComponentType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _componentType = value;
            }
        }

        private object? _ec2InstanceImageId;

        /// <summary>ec2_instance_image_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ec2_instance_image_id Inspector2Filter#ec2_instance_image_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ec2InstanceImageId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceImageId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ec2InstanceImageId
        {
            get => _ec2InstanceImageId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceImageId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceImageId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ec2InstanceImageId = value;
            }
        }

        private object? _ec2InstanceSubnetId;

        /// <summary>ec2_instance_subnet_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ec2_instance_subnet_id Inspector2Filter#ec2_instance_subnet_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ec2InstanceSubnetId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceSubnetId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ec2InstanceSubnetId
        {
            get => _ec2InstanceSubnetId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceSubnetId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceSubnetId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ec2InstanceSubnetId = value;
            }
        }

        private object? _ec2InstanceVpcId;

        /// <summary>ec2_instance_vpc_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ec2_instance_vpc_id Inspector2Filter#ec2_instance_vpc_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ec2InstanceVpcId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceVpcId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Ec2InstanceVpcId
        {
            get => _ec2InstanceVpcId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceVpcId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEc2InstanceVpcId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ec2InstanceVpcId = value;
            }
        }

        private object? _ecrImageArchitecture;

        /// <summary>ecr_image_architecture block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_architecture Inspector2Filter#ecr_image_architecture}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecrImageArchitecture", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageArchitecture\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EcrImageArchitecture
        {
            get => _ecrImageArchitecture;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageArchitecture[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageArchitecture).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ecrImageArchitecture = value;
            }
        }

        private object? _ecrImageHash;

        /// <summary>ecr_image_hash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_hash Inspector2Filter#ecr_image_hash}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecrImageHash", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageHash\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EcrImageHash
        {
            get => _ecrImageHash;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageHash[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageHash).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ecrImageHash = value;
            }
        }

        private object? _ecrImagePushedAt;

        /// <summary>ecr_image_pushed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_pushed_at Inspector2Filter#ecr_image_pushed_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecrImagePushedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImagePushedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EcrImagePushedAt
        {
            get => _ecrImagePushedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImagePushedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImagePushedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ecrImagePushedAt = value;
            }
        }

        private object? _ecrImageRegistry;

        /// <summary>ecr_image_registry block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_registry Inspector2Filter#ecr_image_registry}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecrImageRegistry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRegistry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EcrImageRegistry
        {
            get => _ecrImageRegistry;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageRegistry[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageRegistry).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ecrImageRegistry = value;
            }
        }

        private object? _ecrImageRepositoryName;

        /// <summary>ecr_image_repository_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_repository_name Inspector2Filter#ecr_image_repository_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecrImageRepositoryName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRepositoryName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EcrImageRepositoryName
        {
            get => _ecrImageRepositoryName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageRepositoryName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageRepositoryName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ecrImageRepositoryName = value;
            }
        }

        private object? _ecrImageTags;

        /// <summary>ecr_image_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_tags Inspector2Filter#ecr_image_tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecrImageTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EcrImageTags
        {
            get => _ecrImageTags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ecrImageTags = value;
            }
        }

        private object? _epssScore;

        /// <summary>epss_score block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#epss_score Inspector2Filter#epss_score}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "epssScore", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEpssScore\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EpssScore
        {
            get => _epssScore;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaEpssScore[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaEpssScore).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _epssScore = value;
            }
        }

        private object? _exploitAvailable;

        /// <summary>exploit_available block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#exploit_available Inspector2Filter#exploit_available}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exploitAvailable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaExploitAvailable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExploitAvailable
        {
            get => _exploitAvailable;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaExploitAvailable[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaExploitAvailable).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exploitAvailable = value;
            }
        }

        private object? _findingArn;

        /// <summary>finding_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#finding_arn Inspector2Filter#finding_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FindingArn
        {
            get => _findingArn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingArn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingArn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _findingArn = value;
            }
        }

        private object? _findingStatus;

        /// <summary>finding_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#finding_status Inspector2Filter#finding_status}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FindingStatus
        {
            get => _findingStatus;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingStatus[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingStatus).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _findingStatus = value;
            }
        }

        private object? _findingType;

        /// <summary>finding_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#finding_type Inspector2Filter#finding_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "findingType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FindingType
        {
            get => _findingType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFindingType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _findingType = value;
            }
        }

        private object? _firstObservedAt;

        /// <summary>first_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#first_observed_at Inspector2Filter#first_observed_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firstObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFirstObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FirstObservedAt
        {
            get => _firstObservedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaFirstObservedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFirstObservedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _firstObservedAt = value;
            }
        }

        private object? _fixAvailable;

        /// <summary>fix_available block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#fix_available Inspector2Filter#fix_available}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixAvailable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFixAvailable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FixAvailable
        {
            get => _fixAvailable;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaFixAvailable[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaFixAvailable).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fixAvailable = value;
            }
        }

        private object? _inspectorScore;

        /// <summary>inspector_score block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#inspector_score Inspector2Filter#inspector_score}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inspectorScore", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaInspectorScore\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? InspectorScore
        {
            get => _inspectorScore;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaInspectorScore[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaInspectorScore).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _inspectorScore = value;
            }
        }

        private object? _lambdaFunctionExecutionRoleArn;

        /// <summary>lambda_function_execution_role_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_execution_role_arn Inspector2Filter#lambda_function_execution_role_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionExecutionRoleArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LambdaFunctionExecutionRoleArn
        {
            get => _lambdaFunctionExecutionRoleArn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lambdaFunctionExecutionRoleArn = value;
            }
        }

        private object? _lambdaFunctionLastModifiedAt;

        /// <summary>lambda_function_last_modified_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_last_modified_at Inspector2Filter#lambda_function_last_modified_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionLastModifiedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LambdaFunctionLastModifiedAt
        {
            get => _lambdaFunctionLastModifiedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lambdaFunctionLastModifiedAt = value;
            }
        }

        private object? _lambdaFunctionLayers;

        /// <summary>lambda_function_layers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_layers Inspector2Filter#lambda_function_layers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionLayers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLayers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LambdaFunctionLayers
        {
            get => _lambdaFunctionLayers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionLayers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionLayers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lambdaFunctionLayers = value;
            }
        }

        private object? _lambdaFunctionName;

        /// <summary>lambda_function_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_name Inspector2Filter#lambda_function_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LambdaFunctionName
        {
            get => _lambdaFunctionName;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lambdaFunctionName = value;
            }
        }

        private object? _lambdaFunctionRuntime;

        /// <summary>lambda_function_runtime block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_runtime Inspector2Filter#lambda_function_runtime}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionRuntime", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionRuntime\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LambdaFunctionRuntime
        {
            get => _lambdaFunctionRuntime;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionRuntime[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLambdaFunctionRuntime).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lambdaFunctionRuntime = value;
            }
        }

        private object? _lastObservedAt;

        /// <summary>last_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#last_observed_at Inspector2Filter#last_observed_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lastObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LastObservedAt
        {
            get => _lastObservedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaLastObservedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaLastObservedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lastObservedAt = value;
            }
        }

        private object? _networkProtocol;

        /// <summary>network_protocol block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#network_protocol Inspector2Filter#network_protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkProtocol", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaNetworkProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkProtocol
        {
            get => _networkProtocol;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaNetworkProtocol[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaNetworkProtocol).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkProtocol = value;
            }
        }

        private object? _portRange;

        /// <summary>port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#port_range Inspector2Filter#port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaPortRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PortRange
        {
            get => _portRange;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaPortRange[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaPortRange).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _portRange = value;
            }
        }

        private object? _relatedVulnerabilities;

        /// <summary>related_vulnerabilities block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#related_vulnerabilities Inspector2Filter#related_vulnerabilities}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "relatedVulnerabilities", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaRelatedVulnerabilities\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RelatedVulnerabilities
        {
            get => _relatedVulnerabilities;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaRelatedVulnerabilities[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaRelatedVulnerabilities).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _relatedVulnerabilities = value;
            }
        }

        private object? _resourceId;

        /// <summary>resource_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#resource_id Inspector2Filter#resource_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceId
        {
            get => _resourceId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceId = value;
            }
        }

        private object? _resourceTags;

        /// <summary>resource_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#resource_tags Inspector2Filter#resource_tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceTags
        {
            get => _resourceTags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceTags = value;
            }
        }

        private object? _resourceType;

        /// <summary>resource_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#resource_type Inspector2Filter#resource_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceType
        {
            get => _resourceType;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceType[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaResourceType).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceType = value;
            }
        }

        private object? _severity;

        /// <summary>severity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#severity Inspector2Filter#severity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "severity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaSeverity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Severity
        {
            get => _severity;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaSeverity[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaSeverity).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _severity = value;
            }
        }

        private object? _title;

        /// <summary>title block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#title Inspector2Filter#title}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "title", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaTitle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Title
        {
            get => _title;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaTitle[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaTitle).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _title = value;
            }
        }

        private object? _updatedAt;

        /// <summary>updated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#updated_at Inspector2Filter#updated_at}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "updatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? UpdatedAt
        {
            get => _updatedAt;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaUpdatedAt[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaUpdatedAt).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _updatedAt = value;
            }
        }

        private object? _vendorSeverity;

        /// <summary>vendor_severity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#vendor_severity Inspector2Filter#vendor_severity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vendorSeverity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVendorSeverity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VendorSeverity
        {
            get => _vendorSeverity;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVendorSeverity[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVendorSeverity).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vendorSeverity = value;
            }
        }

        private object? _vulnerabilityId;

        /// <summary>vulnerability_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#vulnerability_id Inspector2Filter#vulnerability_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vulnerabilityId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilityId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VulnerabilityId
        {
            get => _vulnerabilityId;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerabilityId[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerabilityId).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vulnerabilityId = value;
            }
        }

        private object? _vulnerabilitySource;

        /// <summary>vulnerability_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#vulnerability_source Inspector2Filter#vulnerability_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vulnerabilitySource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilitySource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VulnerabilitySource
        {
            get => _vulnerabilitySource;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerabilitySource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerabilitySource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vulnerabilitySource = value;
            }
        }

        private object? _vulnerablePackages;

        /// <summary>vulnerable_packages block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#vulnerable_packages Inspector2Filter#vulnerable_packages}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vulnerablePackages", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VulnerablePackages
        {
            get => _vulnerablePackages;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackages[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackages).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vulnerablePackages = value;
            }
        }
    }
}
