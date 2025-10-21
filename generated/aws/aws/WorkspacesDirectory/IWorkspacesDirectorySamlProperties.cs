using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesDirectory
{
    [JsiiInterface(nativeType: typeof(IWorkspacesDirectorySamlProperties), fullyQualifiedName: "aws.workspacesDirectory.WorkspacesDirectorySamlProperties")]
    public interface IWorkspacesDirectorySamlProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#relay_state_parameter_name WorkspacesDirectory#relay_state_parameter_name}.</summary>
        [JsiiProperty(name: "relayStateParameterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RelayStateParameterName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#status WorkspacesDirectory#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#user_access_url WorkspacesDirectory#user_access_url}.</summary>
        [JsiiProperty(name: "userAccessUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserAccessUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspacesDirectorySamlProperties), fullyQualifiedName: "aws.workspacesDirectory.WorkspacesDirectorySamlProperties")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspacesDirectory.IWorkspacesDirectorySamlProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#relay_state_parameter_name WorkspacesDirectory#relay_state_parameter_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "relayStateParameterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RelayStateParameterName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#status WorkspacesDirectory#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspaces_directory#user_access_url WorkspacesDirectory#user_access_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userAccessUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserAccessUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
