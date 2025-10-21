using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerAssessment
{
    [JsiiInterface(nativeType: typeof(IAuditmanagerAssessmentAssessmentReportsDestination), fullyQualifiedName: "aws.auditmanagerAssessment.AuditmanagerAssessmentAssessmentReportsDestination")]
    public interface IAuditmanagerAssessmentAssessmentReportsDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#destination AuditmanagerAssessment#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#destination_type AuditmanagerAssessment#destination_type}.</summary>
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAuditmanagerAssessmentAssessmentReportsDestination), fullyQualifiedName: "aws.auditmanagerAssessment.AuditmanagerAssessmentAssessmentReportsDestination")]
        internal sealed class _Proxy : DeputyBase, aws.AuditmanagerAssessment.IAuditmanagerAssessmentAssessmentReportsDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#destination AuditmanagerAssessment#destination}.</summary>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#destination_type AuditmanagerAssessment#destination_type}.</summary>
            [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
