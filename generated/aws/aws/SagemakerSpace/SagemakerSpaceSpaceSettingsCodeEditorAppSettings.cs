using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettings")]
    public class SagemakerSpaceSpaceSettingsCodeEditorAppSettings : aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#default_resource_spec SagemakerSpace#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec\"}")]
        public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettingsDefaultResourceSpec DefaultResourceSpec
        {
            get;
            set;
        }

        /// <summary>app_lifecycle_management block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#app_lifecycle_management SagemakerSpace#app_lifecycle_management}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appLifecycleManagement", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement\"}", isOptional: true)]
        public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement? AppLifecycleManagement
        {
            get;
            set;
        }
    }
}
