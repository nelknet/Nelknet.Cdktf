using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codebuildProject.CodebuildProjectBuildBatchConfig")]
    public class CodebuildProjectBuildBatchConfig : aws.CodebuildProject.ICodebuildProjectBuildBatchConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#service_role CodebuildProject#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceRole
        {
            get;
            set;
        }

        private object? _combineArtifacts;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#combine_artifacts CodebuildProject#combine_artifacts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "combineArtifacts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CombineArtifacts
        {
            get => _combineArtifacts;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _combineArtifacts = value;
            }
        }

        /// <summary>restrictions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#restrictions CodebuildProject#restrictions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"aws.codebuildProject.CodebuildProjectBuildBatchConfigRestrictions\"}", isOptional: true)]
        public aws.CodebuildProject.ICodebuildProjectBuildBatchConfigRestrictions? Restrictions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#timeout_in_mins CodebuildProject#timeout_in_mins}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInMins", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutInMins
        {
            get;
            set;
        }
    }
}
