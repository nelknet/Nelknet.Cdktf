using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerControl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.auditmanagerControl.AuditmanagerControlControlMappingSources")]
    public class AuditmanagerControlControlMappingSources : aws.AuditmanagerControl.IAuditmanagerControlControlMappingSources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_name AuditmanagerControl#source_name}.</summary>
        [JsiiProperty(name: "sourceName", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_set_up_option AuditmanagerControl#source_set_up_option}.</summary>
        [JsiiProperty(name: "sourceSetUpOption", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceSetUpOption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_type AuditmanagerControl#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_description AuditmanagerControl#source_description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_frequency AuditmanagerControl#source_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceFrequency
        {
            get;
            set;
        }

        private object? _sourceKeyword;

        /// <summary>source_keyword block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#source_keyword AuditmanagerControl#source_keyword}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceKeyword", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.auditmanagerControl.AuditmanagerControlControlMappingSourcesSourceKeyword\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SourceKeyword
        {
            get => _sourceKeyword;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AuditmanagerControl.IAuditmanagerControlControlMappingSourcesSourceKeyword[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AuditmanagerControl.IAuditmanagerControlControlMappingSourcesSourceKeyword).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sourceKeyword = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#troubleshooting_text AuditmanagerControl#troubleshooting_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "troubleshootingText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TroubleshootingText
        {
            get;
            set;
        }
    }
}
