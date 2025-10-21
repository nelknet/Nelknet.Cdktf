using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EfsBackupPolicy
{
    [JsiiInterface(nativeType: typeof(IEfsBackupPolicyBackupPolicy), fullyQualifiedName: "aws.efsBackupPolicy.EfsBackupPolicyBackupPolicy")]
    public interface IEfsBackupPolicyBackupPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_backup_policy#status EfsBackupPolicy#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsBackupPolicyBackupPolicy), fullyQualifiedName: "aws.efsBackupPolicy.EfsBackupPolicyBackupPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.EfsBackupPolicy.IEfsBackupPolicyBackupPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/efs_backup_policy#status EfsBackupPolicy#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
