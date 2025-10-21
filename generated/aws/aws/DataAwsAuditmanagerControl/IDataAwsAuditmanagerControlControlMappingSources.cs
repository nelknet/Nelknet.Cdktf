using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAuditmanagerControl
{
    [JsiiInterface(nativeType: typeof(IDataAwsAuditmanagerControlControlMappingSources), fullyQualifiedName: "aws.dataAwsAuditmanagerControl.DataAwsAuditmanagerControlControlMappingSources")]
    public interface IDataAwsAuditmanagerControlControlMappingSources
    {
        /// <summary>source_keyword block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_control#source_keyword DataAwsAuditmanagerControl#source_keyword}
        /// </remarks>
        [JsiiProperty(name: "sourceKeyword", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsAuditmanagerControl.DataAwsAuditmanagerControlControlMappingSourcesSourceKeyword\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceKeyword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsAuditmanagerControlControlMappingSources), fullyQualifiedName: "aws.dataAwsAuditmanagerControl.DataAwsAuditmanagerControlControlMappingSources")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsAuditmanagerControl.IDataAwsAuditmanagerControlControlMappingSources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>source_keyword block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_control#source_keyword DataAwsAuditmanagerControl#source_keyword}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceKeyword", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsAuditmanagerControl.DataAwsAuditmanagerControlControlMappingSourcesSourceKeyword\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceKeyword
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
