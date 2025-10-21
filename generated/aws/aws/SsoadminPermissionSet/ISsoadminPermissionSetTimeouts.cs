using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminPermissionSet
{
    [JsiiInterface(nativeType: typeof(ISsoadminPermissionSetTimeouts), fullyQualifiedName: "aws.ssoadminPermissionSet.SsoadminPermissionSetTimeouts")]
    public interface ISsoadminPermissionSetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set#update SsoadminPermissionSet#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsoadminPermissionSetTimeouts), fullyQualifiedName: "aws.ssoadminPermissionSet.SsoadminPermissionSetTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.SsoadminPermissionSet.ISsoadminPermissionSetTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set#update SsoadminPermissionSet#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
