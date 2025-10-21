using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerAssessment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.auditmanagerAssessment.AuditmanagerAssessmentRoles")]
    public class AuditmanagerAssessmentRoles : aws.AuditmanagerAssessment.IAuditmanagerAssessmentRoles
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#role_arn AuditmanagerAssessment#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#role_type AuditmanagerAssessment#role_type}.</summary>
        [JsiiProperty(name: "roleType", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleType
        {
            get;
            set;
        }
    }
}
