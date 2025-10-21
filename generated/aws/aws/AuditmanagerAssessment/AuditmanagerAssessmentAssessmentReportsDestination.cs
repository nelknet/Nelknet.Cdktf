using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerAssessment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.auditmanagerAssessment.AuditmanagerAssessmentAssessmentReportsDestination")]
    public class AuditmanagerAssessmentAssessmentReportsDestination : aws.AuditmanagerAssessment.IAuditmanagerAssessmentAssessmentReportsDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#destination AuditmanagerAssessment#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public string Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#destination_type AuditmanagerAssessment#destination_type}.</summary>
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationType
        {
            get;
            set;
        }
    }
}
