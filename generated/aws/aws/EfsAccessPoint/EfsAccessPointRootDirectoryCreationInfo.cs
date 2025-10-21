using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsAccessPoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.efsAccessPoint.EfsAccessPointRootDirectoryCreationInfo")]
    public class EfsAccessPointRootDirectoryCreationInfo : aws.EfsAccessPoint.IEfsAccessPointRootDirectoryCreationInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#owner_gid EfsAccessPoint#owner_gid}.</summary>
        [JsiiProperty(name: "ownerGid", typeJson: "{\"primitive\":\"number\"}")]
        public double OwnerGid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#owner_uid EfsAccessPoint#owner_uid}.</summary>
        [JsiiProperty(name: "ownerUid", typeJson: "{\"primitive\":\"number\"}")]
        public double OwnerUid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#permissions EfsAccessPoint#permissions}.</summary>
        [JsiiProperty(name: "permissions", typeJson: "{\"primitive\":\"string\"}")]
        public string Permissions
        {
            get;
            set;
        }
    }
}
