using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement")]
    public interface ISagemakerDomainDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement
    {
        /// <summary>idle_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#idle_settings SagemakerDomain#idle_settings}
        /// </remarks>
        [JsiiProperty(name: "idleSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#idle_settings SagemakerDomain#idle_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idleSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings\"}", isOptional: true)]
            public aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings
            {
                get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings?>();
            }
        }
    }
}
