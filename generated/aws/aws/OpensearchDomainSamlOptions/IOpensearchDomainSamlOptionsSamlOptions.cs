using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomainSamlOptions
{
    [JsiiInterface(nativeType: typeof(IOpensearchDomainSamlOptionsSamlOptions), fullyQualifiedName: "aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptions")]
    public interface IOpensearchDomainSamlOptionsSamlOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#enabled OpensearchDomainSamlOptions#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>idp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#idp OpensearchDomainSamlOptions#idp}
        /// </remarks>
        [JsiiProperty(name: "idp", typeJson: "{\"fqn\":\"aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsIdp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptionsIdp? Idp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#master_backend_role OpensearchDomainSamlOptions#master_backend_role}.</summary>
        [JsiiProperty(name: "masterBackendRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterBackendRole
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#master_user_name OpensearchDomainSamlOptions#master_user_name}.</summary>
        [JsiiProperty(name: "masterUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterUserName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#roles_key OpensearchDomainSamlOptions#roles_key}.</summary>
        [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RolesKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#session_timeout_minutes OpensearchDomainSamlOptions#session_timeout_minutes}.</summary>
        [JsiiProperty(name: "sessionTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SessionTimeoutMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#subject_key OpensearchDomainSamlOptions#subject_key}.</summary>
        [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubjectKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDomainSamlOptionsSamlOptions), fullyQualifiedName: "aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#enabled OpensearchDomainSamlOptions#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>idp block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#idp OpensearchDomainSamlOptions#idp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idp", typeJson: "{\"fqn\":\"aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsIdp\"}", isOptional: true)]
            public aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptionsIdp? Idp
            {
                get => GetInstanceProperty<aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptionsIdp?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#master_backend_role OpensearchDomainSamlOptions#master_backend_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "masterBackendRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterBackendRole
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#master_user_name OpensearchDomainSamlOptions#master_user_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "masterUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterUserName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#roles_key OpensearchDomainSamlOptions#roles_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RolesKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#session_timeout_minutes OpensearchDomainSamlOptions#session_timeout_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sessionTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SessionTimeoutMinutes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#subject_key OpensearchDomainSamlOptions#subject_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubjectKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
