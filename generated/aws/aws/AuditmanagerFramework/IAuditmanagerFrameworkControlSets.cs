using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerFramework
{
    [JsiiInterface(nativeType: typeof(IAuditmanagerFrameworkControlSets), fullyQualifiedName: "aws.auditmanagerFramework.AuditmanagerFrameworkControlSets")]
    public interface IAuditmanagerFrameworkControlSets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework#name AuditmanagerFramework#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>controls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework#controls AuditmanagerFramework#controls}
        /// </remarks>
        [JsiiProperty(name: "controls", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.auditmanagerFramework.AuditmanagerFrameworkControlSetsControls\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Controls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAuditmanagerFrameworkControlSets), fullyQualifiedName: "aws.auditmanagerFramework.AuditmanagerFrameworkControlSets")]
        internal sealed class _Proxy : DeputyBase, aws.AuditmanagerFramework.IAuditmanagerFrameworkControlSets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework#name AuditmanagerFramework#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>controls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework#controls AuditmanagerFramework#controls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "controls", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.auditmanagerFramework.AuditmanagerFrameworkControlSetsControls\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Controls
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
