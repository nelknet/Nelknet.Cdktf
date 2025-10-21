using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerSpace
{
    [JsiiInterface(nativeType: typeof(ISagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement")]
    public interface ISagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement
    {
        /// <summary>idle_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#idle_settings SagemakerSpace#idle_settings}
        /// </remarks>
        [JsiiProperty(name: "idleSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement), fullyQualifiedName: "aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_space#idle_settings SagemakerSpace#idle_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idleSettings", typeJson: "{\"fqn\":\"aws.sagemakerSpace.SagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings\"}", isOptional: true)]
            public aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings
            {
                get => GetInstanceProperty<aws.SagemakerSpace.ISagemakerSpaceSpaceSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings?>();
            }
        }
    }
}
