using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsSchema
{
    [JsiiInterface(nativeType: typeof(IVerifiedpermissionsSchemaDefinition), fullyQualifiedName: "aws.verifiedpermissionsSchema.VerifiedpermissionsSchemaDefinition")]
    public interface IVerifiedpermissionsSchemaDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_schema#value VerifiedpermissionsSchema#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVerifiedpermissionsSchemaDefinition), fullyQualifiedName: "aws.verifiedpermissionsSchema.VerifiedpermissionsSchemaDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.VerifiedpermissionsSchema.IVerifiedpermissionsSchemaDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_schema#value VerifiedpermissionsSchema#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
