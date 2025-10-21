using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAuditmanagerFramework
{
    [JsiiInterface(nativeType: typeof(IDataAwsAuditmanagerFrameworkControlSets), fullyQualifiedName: "aws.dataAwsAuditmanagerFramework.DataAwsAuditmanagerFrameworkControlSets")]
    public interface IDataAwsAuditmanagerFrameworkControlSets
    {
        /// <summary>controls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_framework#controls DataAwsAuditmanagerFramework#controls}
        /// </remarks>
        [JsiiProperty(name: "controls", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsAuditmanagerFramework.DataAwsAuditmanagerFrameworkControlSetsControls\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Controls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsAuditmanagerFrameworkControlSets), fullyQualifiedName: "aws.dataAwsAuditmanagerFramework.DataAwsAuditmanagerFrameworkControlSets")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsAuditmanagerFramework.IDataAwsAuditmanagerFrameworkControlSets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>controls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/auditmanager_framework#controls DataAwsAuditmanagerFramework#controls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "controls", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsAuditmanagerFramework.DataAwsAuditmanagerFrameworkControlSetsControls\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Controls
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
