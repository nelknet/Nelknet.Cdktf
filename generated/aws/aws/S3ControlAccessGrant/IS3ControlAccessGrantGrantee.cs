using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlAccessGrant
{
    [JsiiInterface(nativeType: typeof(IS3ControlAccessGrantGrantee), fullyQualifiedName: "aws.s3ControlAccessGrant.S3ControlAccessGrantGrantee")]
    public interface IS3ControlAccessGrantGrantee
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#grantee_identifier S3ControlAccessGrant#grantee_identifier}.</summary>
        [JsiiProperty(name: "granteeIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string GranteeIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#grantee_type S3ControlAccessGrant#grantee_type}.</summary>
        [JsiiProperty(name: "granteeType", typeJson: "{\"primitive\":\"string\"}")]
        string GranteeType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlAccessGrantGrantee), fullyQualifiedName: "aws.s3ControlAccessGrant.S3ControlAccessGrantGrantee")]
        internal sealed class _Proxy : DeputyBase, aws.S3ControlAccessGrant.IS3ControlAccessGrantGrantee
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#grantee_identifier S3ControlAccessGrant#grantee_identifier}.</summary>
            [JsiiProperty(name: "granteeIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string GranteeIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_access_grant#grantee_type S3ControlAccessGrant#grantee_type}.</summary>
            [JsiiProperty(name: "granteeType", typeJson: "{\"primitive\":\"string\"}")]
            public string GranteeType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
