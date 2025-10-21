using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettings")]
    public class SagemakerSpaceSpaceSettingsJupyterLabAppSettings : aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#default_resource_spec SagemakerSpace#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec\"}")]
        public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsDefaultResourceSpec DefaultResourceSpec
        {
            get;
            set;
        }

        /// <summary>app_lifecycle_management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#app_lifecycle_management SagemakerSpace#app_lifecycle_management}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appLifecycleManagement", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement\"}", isOptional: true)]
        public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagement
        {
            get;
            set;
        }

        private object? _codeRepository;

        /// <summary>code_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#code_repository SagemakerSpace#code_repository}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeRepository", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsJupyterLabAppSettingsCodeRepository\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CodeRepository
        {
            get => _codeRepository;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsCodeRepository[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsJupyterLabAppSettingsCodeRepository).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _codeRepository = value;
            }
        }
    }
}
