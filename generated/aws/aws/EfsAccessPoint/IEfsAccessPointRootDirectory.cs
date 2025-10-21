using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsAccessPoint
{
    [JsiiInterface(nativeType: typeof(IEfsAccessPointRootDirectory), fullyQualifiedName: "aws.efsAccessPoint.EfsAccessPointRootDirectory")]
    public interface IEfsAccessPointRootDirectory
    {
        /// <summary>creation_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#creation_info EfsAccessPoint#creation_info}
        /// </remarks>
        [JsiiProperty(name: "creationInfo", typeJson: "{\"fqn\":\"aws.efsAccessPoint.EfsAccessPointRootDirectoryCreationInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EfsAccessPoint.IEfsAccessPointRootDirectoryCreationInfo? CreationInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#path EfsAccessPoint#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsAccessPointRootDirectory), fullyQualifiedName: "aws.efsAccessPoint.EfsAccessPointRootDirectory")]
        internal sealed class _Proxy : DeputyBase, aws.EfsAccessPoint.IEfsAccessPointRootDirectory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>creation_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#creation_info EfsAccessPoint#creation_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "creationInfo", typeJson: "{\"fqn\":\"aws.efsAccessPoint.EfsAccessPointRootDirectoryCreationInfo\"}", isOptional: true)]
            public aws.EfsAccessPoint.IEfsAccessPointRootDirectoryCreationInfo? CreationInfo
            {
                get => GetInstanceProperty<aws.EfsAccessPoint.IEfsAccessPointRootDirectoryCreationInfo?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_access_point#path EfsAccessPoint#path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
