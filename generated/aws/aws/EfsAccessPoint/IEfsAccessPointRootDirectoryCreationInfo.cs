using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsAccessPoint
{
    [JsiiInterface(nativeType: typeof(IEfsAccessPointRootDirectoryCreationInfo), fullyQualifiedName: "aws.efsAccessPoint.EfsAccessPointRootDirectoryCreationInfo")]
    public interface IEfsAccessPointRootDirectoryCreationInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#owner_gid EfsAccessPoint#owner_gid}.</summary>
        [JsiiProperty(name: "ownerGid", typeJson: "{\"primitive\":\"number\"}")]
        double OwnerGid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#owner_uid EfsAccessPoint#owner_uid}.</summary>
        [JsiiProperty(name: "ownerUid", typeJson: "{\"primitive\":\"number\"}")]
        double OwnerUid
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#permissions EfsAccessPoint#permissions}.</summary>
        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        string Permissions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsAccessPointRootDirectoryCreationInfo), fullyQualifiedName: "aws.efsAccessPoint.EfsAccessPointRootDirectoryCreationInfo")]
        internal sealed class _Proxy : DeputyBase, aws.EfsAccessPoint.IEfsAccessPointRootDirectoryCreationInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#owner_gid EfsAccessPoint#owner_gid}.</summary>
            [JsiiProperty(name: "ownerGid", typeJson: "{\"primitive\":\"number\"}")]
            public double OwnerGid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#owner_uid EfsAccessPoint#owner_uid}.</summary>
            [JsiiProperty(name: "ownerUid", typeJson: "{\"primitive\":\"number\"}")]
            public double OwnerUid
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#permissions EfsAccessPoint#permissions}.</summary>
            [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
            public string Permissions
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
