using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerControl
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.auditmanagerControl.AuditmanagerControlControlMappingSourcesSourceKeyword")]
    public class AuditmanagerControlControlMappingSourcesSourceKeyword : aws.AuditmanagerControl.IAuditmanagerControlControlMappingSourcesSourceKeyword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#keyword_input_type AuditmanagerControl#keyword_input_type}.</summary>
        [JsiiProperty(name: "keywordInputType", typeJson: "{\"primitive\":\"string\"}")]
        public string KeywordInputType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#keyword_value AuditmanagerControl#keyword_value}.</summary>
        [JsiiProperty(name: "keywordValue", typeJson: "{\"primitive\":\"string\"}")]
        public string KeywordValue
        {
            get;
            set;
        }
    }
}
