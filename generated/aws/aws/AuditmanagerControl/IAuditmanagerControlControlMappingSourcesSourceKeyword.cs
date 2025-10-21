using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerControl
{
    [JsiiInterface(nativeType: typeof(IAuditmanagerControlControlMappingSourcesSourceKeyword), fullyQualifiedName: "aws.auditmanagerControl.AuditmanagerControlControlMappingSourcesSourceKeyword")]
    public interface IAuditmanagerControlControlMappingSourcesSourceKeyword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#keyword_input_type AuditmanagerControl#keyword_input_type}.</summary>
        [JsiiProperty(name: "keywordInputType", typeJson: "{\"primitive\":\"string\"}")]
        string KeywordInputType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#keyword_value AuditmanagerControl#keyword_value}.</summary>
        [JsiiProperty(name: "keywordValue", typeJson: "{\"primitive\":\"string\"}")]
        string KeywordValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAuditmanagerControlControlMappingSourcesSourceKeyword), fullyQualifiedName: "aws.auditmanagerControl.AuditmanagerControlControlMappingSourcesSourceKeyword")]
        internal sealed class _Proxy : DeputyBase, aws.AuditmanagerControl.IAuditmanagerControlControlMappingSourcesSourceKeyword
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#keyword_input_type AuditmanagerControl#keyword_input_type}.</summary>
            [JsiiProperty(name: "keywordInputType", typeJson: "{\"primitive\":\"string\"}")]
            public string KeywordInputType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#keyword_value AuditmanagerControl#keyword_value}.</summary>
            [JsiiProperty(name: "keywordValue", typeJson: "{\"primitive\":\"string\"}")]
            public string KeywordValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
