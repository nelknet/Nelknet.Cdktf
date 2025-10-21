using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    [JsiiInterface(nativeType: typeof(IInspector2FilterFilterCriteria), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteria")]
    public interface IInspector2FilterFilterCriteria
    {
        /// <summary>aws_account_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#aws_account_id Inspector2Filter#aws_account_id}
        /// </remarks>
        [JsiiProperty(name: "awsAccountId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaAwsAccountId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AwsAccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>code_vulnerability_detector_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#code_vulnerability_detector_name Inspector2Filter#code_vulnerability_detector_name}
        /// </remarks>
        [JsiiProperty(name: "codeVulnerabilityDetectorName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CodeVulnerabilityDetectorName
        {
            get
            {
                return null;
            }
        }

        /// <summary>code_vulnerability_detector_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#code_vulnerability_detector_tags Inspector2Filter#code_vulnerability_detector_tags}
        /// </remarks>
        [JsiiProperty(name: "codeVulnerabilityDetectorTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CodeVulnerabilityDetectorTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>code_vulnerability_file_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#code_vulnerability_file_path Inspector2Filter#code_vulnerability_file_path}
        /// </remarks>
        [JsiiProperty(name: "codeVulnerabilityFilePath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityFilePath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CodeVulnerabilityFilePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>component_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#component_id Inspector2Filter#component_id}
        /// </remarks>
        [JsiiProperty(name: "componentId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaComponentId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ComponentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>component_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#component_type Inspector2Filter#component_type}
        /// </remarks>
        [JsiiProperty(name: "componentType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaComponentType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ComponentType
        {
            get
            {
                return null;
            }
        }

        /// <summary>ec2_instance_image_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ec2_instance_image_id Inspector2Filter#ec2_instance_image_id}
        /// </remarks>
        [JsiiProperty(name: "ec2InstanceImageId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceImageId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ec2InstanceImageId
        {
            get
            {
                return null;
            }
        }

        /// <summary>ec2_instance_subnet_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ec2_instance_subnet_id Inspector2Filter#ec2_instance_subnet_id}
        /// </remarks>
        [JsiiProperty(name: "ec2InstanceSubnetId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceSubnetId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ec2InstanceSubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>ec2_instance_vpc_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ec2_instance_vpc_id Inspector2Filter#ec2_instance_vpc_id}
        /// </remarks>
        [JsiiProperty(name: "ec2InstanceVpcId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceVpcId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ec2InstanceVpcId
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecr_image_architecture block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_architecture Inspector2Filter#ecr_image_architecture}
        /// </remarks>
        [JsiiProperty(name: "ecrImageArchitecture", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageArchitecture\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EcrImageArchitecture
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecr_image_hash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_hash Inspector2Filter#ecr_image_hash}
        /// </remarks>
        [JsiiProperty(name: "ecrImageHash", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageHash\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EcrImageHash
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecr_image_pushed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_pushed_at Inspector2Filter#ecr_image_pushed_at}
        /// </remarks>
        [JsiiProperty(name: "ecrImagePushedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImagePushedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EcrImagePushedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecr_image_registry block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_registry Inspector2Filter#ecr_image_registry}
        /// </remarks>
        [JsiiProperty(name: "ecrImageRegistry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRegistry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EcrImageRegistry
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecr_image_repository_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_repository_name Inspector2Filter#ecr_image_repository_name}
        /// </remarks>
        [JsiiProperty(name: "ecrImageRepositoryName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRepositoryName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EcrImageRepositoryName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecr_image_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_tags Inspector2Filter#ecr_image_tags}
        /// </remarks>
        [JsiiProperty(name: "ecrImageTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EcrImageTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>epss_score block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#epss_score Inspector2Filter#epss_score}
        /// </remarks>
        [JsiiProperty(name: "epssScore", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEpssScore\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EpssScore
        {
            get
            {
                return null;
            }
        }

        /// <summary>exploit_available block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#exploit_available Inspector2Filter#exploit_available}
        /// </remarks>
        [JsiiProperty(name: "exploitAvailable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaExploitAvailable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExploitAvailable
        {
            get
            {
                return null;
            }
        }

        /// <summary>finding_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#finding_arn Inspector2Filter#finding_arn}
        /// </remarks>
        [JsiiProperty(name: "findingArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FindingArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>finding_status block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#finding_status Inspector2Filter#finding_status}
        /// </remarks>
        [JsiiProperty(name: "findingStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FindingStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>finding_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#finding_type Inspector2Filter#finding_type}
        /// </remarks>
        [JsiiProperty(name: "findingType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FindingType
        {
            get
            {
                return null;
            }
        }

        /// <summary>first_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#first_observed_at Inspector2Filter#first_observed_at}
        /// </remarks>
        [JsiiProperty(name: "firstObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFirstObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FirstObservedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>fix_available block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#fix_available Inspector2Filter#fix_available}
        /// </remarks>
        [JsiiProperty(name: "fixAvailable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFixAvailable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FixAvailable
        {
            get
            {
                return null;
            }
        }

        /// <summary>inspector_score block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#inspector_score Inspector2Filter#inspector_score}
        /// </remarks>
        [JsiiProperty(name: "inspectorScore", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaInspectorScore\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InspectorScore
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_function_execution_role_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_execution_role_arn Inspector2Filter#lambda_function_execution_role_arn}
        /// </remarks>
        [JsiiProperty(name: "lambdaFunctionExecutionRoleArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaFunctionExecutionRoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_function_last_modified_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_last_modified_at Inspector2Filter#lambda_function_last_modified_at}
        /// </remarks>
        [JsiiProperty(name: "lambdaFunctionLastModifiedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaFunctionLastModifiedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_function_layers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_layers Inspector2Filter#lambda_function_layers}
        /// </remarks>
        [JsiiProperty(name: "lambdaFunctionLayers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLayers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaFunctionLayers
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_function_name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_name Inspector2Filter#lambda_function_name}
        /// </remarks>
        [JsiiProperty(name: "lambdaFunctionName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaFunctionName
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_function_runtime block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_runtime Inspector2Filter#lambda_function_runtime}
        /// </remarks>
        [JsiiProperty(name: "lambdaFunctionRuntime", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionRuntime\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaFunctionRuntime
        {
            get
            {
                return null;
            }
        }

        /// <summary>last_observed_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#last_observed_at Inspector2Filter#last_observed_at}
        /// </remarks>
        [JsiiProperty(name: "lastObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LastObservedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_protocol block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#network_protocol Inspector2Filter#network_protocol}
        /// </remarks>
        [JsiiProperty(name: "networkProtocol", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaNetworkProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkProtocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#port_range Inspector2Filter#port_range}
        /// </remarks>
        [JsiiProperty(name: "portRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaPortRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PortRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>related_vulnerabilities block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#related_vulnerabilities Inspector2Filter#related_vulnerabilities}
        /// </remarks>
        [JsiiProperty(name: "relatedVulnerabilities", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaRelatedVulnerabilities\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RelatedVulnerabilities
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#resource_id Inspector2Filter#resource_id}
        /// </remarks>
        [JsiiProperty(name: "resourceId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#resource_tags Inspector2Filter#resource_tags}
        /// </remarks>
        [JsiiProperty(name: "resourceTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#resource_type Inspector2Filter#resource_type}
        /// </remarks>
        [JsiiProperty(name: "resourceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResourceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>severity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#severity Inspector2Filter#severity}
        /// </remarks>
        [JsiiProperty(name: "severity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaSeverity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Severity
        {
            get
            {
                return null;
            }
        }

        /// <summary>title block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#title Inspector2Filter#title}
        /// </remarks>
        [JsiiProperty(name: "title", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaTitle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Title
        {
            get
            {
                return null;
            }
        }

        /// <summary>updated_at block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#updated_at Inspector2Filter#updated_at}
        /// </remarks>
        [JsiiProperty(name: "updatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UpdatedAt
        {
            get
            {
                return null;
            }
        }

        /// <summary>vendor_severity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#vendor_severity Inspector2Filter#vendor_severity}
        /// </remarks>
        [JsiiProperty(name: "vendorSeverity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVendorSeverity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VendorSeverity
        {
            get
            {
                return null;
            }
        }

        /// <summary>vulnerability_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#vulnerability_id Inspector2Filter#vulnerability_id}
        /// </remarks>
        [JsiiProperty(name: "vulnerabilityId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilityId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VulnerabilityId
        {
            get
            {
                return null;
            }
        }

        /// <summary>vulnerability_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#vulnerability_source Inspector2Filter#vulnerability_source}
        /// </remarks>
        [JsiiProperty(name: "vulnerabilitySource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilitySource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VulnerabilitySource
        {
            get
            {
                return null;
            }
        }

        /// <summary>vulnerable_packages block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#vulnerable_packages Inspector2Filter#vulnerable_packages}
        /// </remarks>
        [JsiiProperty(name: "vulnerablePackages", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VulnerablePackages
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInspector2FilterFilterCriteria), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.Inspector2Filter.IInspector2FilterFilterCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_account_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#aws_account_id Inspector2Filter#aws_account_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsAccountId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaAwsAccountId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AwsAccountId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>code_vulnerability_detector_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#code_vulnerability_detector_name Inspector2Filter#code_vulnerability_detector_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeVulnerabilityDetectorName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CodeVulnerabilityDetectorName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>code_vulnerability_detector_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#code_vulnerability_detector_tags Inspector2Filter#code_vulnerability_detector_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeVulnerabilityDetectorTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityDetectorTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CodeVulnerabilityDetectorTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>code_vulnerability_file_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#code_vulnerability_file_path Inspector2Filter#code_vulnerability_file_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeVulnerabilityFilePath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaCodeVulnerabilityFilePath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CodeVulnerabilityFilePath
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>component_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#component_id Inspector2Filter#component_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "componentId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaComponentId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ComponentId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>component_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#component_type Inspector2Filter#component_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "componentType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaComponentType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ComponentType
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ec2_instance_image_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ec2_instance_image_id Inspector2Filter#ec2_instance_image_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ec2InstanceImageId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceImageId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ec2InstanceImageId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ec2_instance_subnet_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ec2_instance_subnet_id Inspector2Filter#ec2_instance_subnet_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ec2InstanceSubnetId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceSubnetId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ec2InstanceSubnetId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ec2_instance_vpc_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ec2_instance_vpc_id Inspector2Filter#ec2_instance_vpc_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ec2InstanceVpcId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEc2InstanceVpcId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ec2InstanceVpcId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ecr_image_architecture block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_architecture Inspector2Filter#ecr_image_architecture}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecrImageArchitecture", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageArchitecture\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EcrImageArchitecture
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ecr_image_hash block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_hash Inspector2Filter#ecr_image_hash}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecrImageHash", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageHash\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EcrImageHash
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ecr_image_pushed_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_pushed_at Inspector2Filter#ecr_image_pushed_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecrImagePushedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImagePushedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EcrImagePushedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ecr_image_registry block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_registry Inspector2Filter#ecr_image_registry}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecrImageRegistry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRegistry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EcrImageRegistry
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ecr_image_repository_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_repository_name Inspector2Filter#ecr_image_repository_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecrImageRepositoryName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageRepositoryName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EcrImageRepositoryName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ecr_image_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#ecr_image_tags Inspector2Filter#ecr_image_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecrImageTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EcrImageTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>epss_score block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#epss_score Inspector2Filter#epss_score}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "epssScore", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaEpssScore\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EpssScore
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>exploit_available block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#exploit_available Inspector2Filter#exploit_available}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exploitAvailable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaExploitAvailable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExploitAvailable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>finding_arn block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#finding_arn Inspector2Filter#finding_arn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "findingArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FindingArn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>finding_status block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#finding_status Inspector2Filter#finding_status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "findingStatus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingStatus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FindingStatus
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>finding_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#finding_type Inspector2Filter#finding_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "findingType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFindingType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FindingType
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>first_observed_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#first_observed_at Inspector2Filter#first_observed_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firstObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFirstObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FirstObservedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>fix_available block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#fix_available Inspector2Filter#fix_available}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixAvailable", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaFixAvailable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FixAvailable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>inspector_score block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#inspector_score Inspector2Filter#inspector_score}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inspectorScore", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaInspectorScore\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InspectorScore
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lambda_function_execution_role_arn block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_execution_role_arn Inspector2Filter#lambda_function_execution_role_arn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunctionExecutionRoleArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionExecutionRoleArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LambdaFunctionExecutionRoleArn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lambda_function_last_modified_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_last_modified_at Inspector2Filter#lambda_function_last_modified_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunctionLastModifiedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLastModifiedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LambdaFunctionLastModifiedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lambda_function_layers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_layers Inspector2Filter#lambda_function_layers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunctionLayers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionLayers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LambdaFunctionLayers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lambda_function_name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_name Inspector2Filter#lambda_function_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunctionName", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LambdaFunctionName
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lambda_function_runtime block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#lambda_function_runtime Inspector2Filter#lambda_function_runtime}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunctionRuntime", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLambdaFunctionRuntime\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LambdaFunctionRuntime
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>last_observed_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#last_observed_at Inspector2Filter#last_observed_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lastObservedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaLastObservedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LastObservedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>network_protocol block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#network_protocol Inspector2Filter#network_protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkProtocol", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaNetworkProtocol\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkProtocol
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#port_range Inspector2Filter#port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaPortRange\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PortRange
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>related_vulnerabilities block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#related_vulnerabilities Inspector2Filter#related_vulnerabilities}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "relatedVulnerabilities", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaRelatedVulnerabilities\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RelatedVulnerabilities
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#resource_id Inspector2Filter#resource_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_tags block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#resource_tags Inspector2Filter#resource_tags}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>resource_type block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#resource_type Inspector2Filter#resource_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceType", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaResourceType\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResourceType
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>severity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#severity Inspector2Filter#severity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "severity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaSeverity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Severity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>title block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#title Inspector2Filter#title}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "title", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaTitle\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Title
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>updated_at block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#updated_at Inspector2Filter#updated_at}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "updatedAt", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaUpdatedAt\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UpdatedAt
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>vendor_severity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#vendor_severity Inspector2Filter#vendor_severity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vendorSeverity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVendorSeverity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VendorSeverity
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>vulnerability_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#vulnerability_id Inspector2Filter#vulnerability_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vulnerabilityId", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilityId\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VulnerabilityId
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>vulnerability_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#vulnerability_source Inspector2Filter#vulnerability_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vulnerabilitySource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerabilitySource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VulnerabilitySource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>vulnerable_packages block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#vulnerable_packages Inspector2Filter#vulnerable_packages}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vulnerablePackages", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VulnerablePackages
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
