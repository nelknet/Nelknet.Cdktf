using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerAssessment
{
    [JsiiInterface(nativeType: typeof(IAuditmanagerAssessmentRoles), fullyQualifiedName: "aws.auditmanagerAssessment.AuditmanagerAssessmentRoles")]
    public interface IAuditmanagerAssessmentRoles
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#role_arn AuditmanagerAssessment#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#role_type AuditmanagerAssessment#role_type}.</summary>
        [JsiiProperty(name: "roleType", typeJson: "{\"primitive\":\"string\"}")]
        string RoleType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAuditmanagerAssessmentRoles), fullyQualifiedName: "aws.auditmanagerAssessment.AuditmanagerAssessmentRoles")]
        internal sealed class _Proxy : DeputyBase, aws.AuditmanagerAssessment.IAuditmanagerAssessmentRoles
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#role_arn AuditmanagerAssessment#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#role_type AuditmanagerAssessment#role_type}.</summary>
            [JsiiProperty(name: "roleType", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
