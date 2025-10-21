using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsAccessPoint
{
    [JsiiByValue(fqn: "aws.efsAccessPoint.EfsAccessPointRootDirectory")]
    public class EfsAccessPointRootDirectory : aws.EfsAccessPoint.IEfsAccessPointRootDirectory
    {
        /// <summary>creation_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#creation_info EfsAccessPoint#creation_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "creationInfo", typeJson: "{\"fqn\":\"aws.efsAccessPoint.EfsAccessPointRootDirectoryCreationInfo\"}", isOptional: true)]
        public aws.EfsAccessPoint.IEfsAccessPointRootDirectoryCreationInfo? CreationInfo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#path EfsAccessPoint#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}
