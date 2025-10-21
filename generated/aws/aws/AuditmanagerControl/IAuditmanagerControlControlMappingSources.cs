using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerControl
{
    [JsiiInterface(nativeType: typeof(IAuditmanagerControlControlMappingSources), fullyQualifiedName: "aws.auditmanagerControl.AuditmanagerControlControlMappingSources")]
    public interface IAuditmanagerControlControlMappingSources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_name AuditmanagerControl#source_name}.</summary>
        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}")]
        string SourceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_set_up_option AuditmanagerControl#source_set_up_option}.</summary>
        [JsiiProperty(name: "sourceSetUpOption", typeJson: "{\"primitive\":\"string\"}")]
        string SourceSetUpOption
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_type AuditmanagerControl#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        string SourceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_description AuditmanagerControl#source_description}.</summary>
        [JsiiProperty(name: "sourceDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_frequency AuditmanagerControl#source_frequency}.</summary>
        [JsiiProperty(name: "sourceFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_keyword block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_keyword AuditmanagerControl#source_keyword}
        /// </remarks>
        [JsiiProperty(name: "sourceKeyword", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.auditmanagerControl.AuditmanagerControlControlMappingSourcesSourceKeyword\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceKeyword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#troubleshooting_text AuditmanagerControl#troubleshooting_text}.</summary>
        [JsiiProperty(name: "troubleshootingText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TroubleshootingText
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAuditmanagerControlControlMappingSources), fullyQualifiedName: "aws.auditmanagerControl.AuditmanagerControlControlMappingSources")]
        internal sealed class _Proxy : DeputyBase, aws.AuditmanagerControl.IAuditmanagerControlControlMappingSources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_name AuditmanagerControl#source_name}.</summary>
            [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_set_up_option AuditmanagerControl#source_set_up_option}.</summary>
            [JsiiProperty(name: "sourceSetUpOption", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceSetUpOption
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_type AuditmanagerControl#source_type}.</summary>
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_description AuditmanagerControl#source_description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_frequency AuditmanagerControl#source_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceFrequency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>source_keyword block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_keyword AuditmanagerControl#source_keyword}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceKeyword", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.auditmanagerControl.AuditmanagerControlControlMappingSourcesSourceKeyword\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceKeyword
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#troubleshooting_text AuditmanagerControl#troubleshooting_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "troubleshootingText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TroubleshootingText
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
