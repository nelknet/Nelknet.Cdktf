using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerAssessment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.auditmanagerAssessment.AuditmanagerAssessmentScopeAwsServices")]
    public class AuditmanagerAssessmentScopeAwsServices : aws.AuditmanagerAssessment.IAuditmanagerAssessmentScopeAwsServices
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#service_name AuditmanagerAssessment#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceName
        {
            get;
            set;
        }
    }
}
