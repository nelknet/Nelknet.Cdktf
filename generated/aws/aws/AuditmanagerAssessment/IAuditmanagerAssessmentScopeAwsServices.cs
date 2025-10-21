using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerAssessment
{
    [JsiiInterface(nativeType: typeof(IAuditmanagerAssessmentScopeAwsServices), fullyQualifiedName: "aws.auditmanagerAssessment.AuditmanagerAssessmentScopeAwsServices")]
    public interface IAuditmanagerAssessmentScopeAwsServices
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#service_name AuditmanagerAssessment#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAuditmanagerAssessmentScopeAwsServices), fullyQualifiedName: "aws.auditmanagerAssessment.AuditmanagerAssessmentScopeAwsServices")]
        internal sealed class _Proxy : DeputyBase, aws.AuditmanagerAssessment.IAuditmanagerAssessmentScopeAwsServices
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#service_name AuditmanagerAssessment#service_name}.</summary>
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
