using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomainSamlOptions
{
    [JsiiByValue(fqn: "aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptions")]
    public class OpensearchDomainSamlOptionsSamlOptions : aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptions
    {
        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#enabled OpensearchDomainSamlOptions#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }

        /// <summary>idp block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#idp OpensearchDomainSamlOptions#idp}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idp", typeJson: "{\"fqn\":\"aws.opensearchDomainSamlOptions.OpensearchDomainSamlOptionsSamlOptionsIdp\"}", isOptional: true)]
        public aws.OpensearchDomainSamlOptions.IOpensearchDomainSamlOptionsSamlOptionsIdp? Idp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#master_backend_role OpensearchDomainSamlOptions#master_backend_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterBackendRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MasterBackendRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#master_user_name OpensearchDomainSamlOptions#master_user_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MasterUserName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#roles_key OpensearchDomainSamlOptions#roles_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RolesKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#session_timeout_minutes OpensearchDomainSamlOptions#session_timeout_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SessionTimeoutMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_domain_saml_options#subject_key OpensearchDomainSamlOptions#subject_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubjectKey
        {
            get;
            set;
        }
    }
}
